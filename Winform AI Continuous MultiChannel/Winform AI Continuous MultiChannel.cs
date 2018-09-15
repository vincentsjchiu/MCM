using System;
using System.Windows.Forms;
using JYUSB62405;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.File;
using SeeSharpTools.JY.DSP.Fundamental;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/// <summary>
/// JYUSB62405多通道连续采集
/// 作者：简仪科技 
/// 驱动版本：USB-62405 Driver 1.0.2
/// 安裝套件；SeeSharpTools.JY.GUI 1.0.3
/// 使用環境；.NET 4.0 以上版本
/// 说明：
///         1. 输入板卡号以及信道号
///         2. 输入采样率以及输入电压最大、最小值
///         3. 按下启动开始进行多通道数据撷取
/// </summary>
namespace SeeSharpExample.JY.JYUSB62405
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// AI任务
        /// </summary>
        private JYUSB62405AITask aitask;

        /// <summary>
        /// 存放AI采集到的数据，容量为100ms样点数
        /// </summary>
        double[,] readValue;
        double df;
        double ch0sensivity, ch1sensivity, ch2sensivity, ch3sensivity;
        double[] ch0sprectrumValue, ch1sprectrumValue, ch2sprectrumValue, ch3sprectrumValue;
        double[] ch0RawValue, ch1RawValue, ch2RawValue, ch3RawValue;
        double[] FFTdf;
        Thread AI, DataQueue;
        Queue<Queuedata> myqueue = new Queue<Queuedata>();
        Queuedata qindata = new Queuedata();
        Queuedata qoutdata = new Queuedata();
        bool start = false;
        int Chcount;
        int averagetimes;
        string filepath;
        string csvfilename;
        /// <summary>
        /// 存放readValue转置后的数据，容量与readValue一样
        /// </summary>
        double[,] displyValue;

        /// <summary>
        /// 板卡号
        /// </summary>
        private int boardNum;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            comboBox_boardNum.SelectedIndex = 0;
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// 设置comboBox的默认索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public class Queuedata
        {
            public DateTime logtime;
            public double[,] RawData;
            public int averageindex;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            comboBoxSelectChannel.SelectedIndex = 0;
            radioButtonCH0.Checked = true;
            CreateIfFolderMissing("c:\\MCMCSOT\\FFT");
            CreateIfFolderMissing("c:\\MCMCSOT\\FFTALARM");
            filepath = "c:\\MCMCSOT\\FFT\\";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (start)
            {
                start = false;
                
                if (DataQueue.IsAlive)
                {
                    if (false == DataQueue.Join(5000))
                    {
                        DataQueue.Abort();
                    }
                }
                if (AI.IsAlive)
                {
                    if (false == AI.Join(5000))
                    {
                        AI.Abort();
                    }
                }
                aitask.Stop();
                aitask.Channels.Clear();//把上次启动添加的通道清掉
            }

        }

        /// <summary>
        /// 根据选择的板卡号创建任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_boardNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                boardNum = comboBox_boardNum.SelectedIndex;
                aitask = new JYUSB62405AITask(boardNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("板卡初始化失败");
                return;
            }
        }


        /// <summary>
        /// 启动采集 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {

            //添加通道
            groupBox_GenParam.Enabled = false;
            Start.Enabled = false;
            ConfigDAQ();
            Inital();
            aitask.Start();
            start = true;
            AI = new Thread(GetData);
            AI.Start();
            DataQueue = new Thread(ProcessQueue);
            DataQueue.Start();
            //启用定时器，禁用参数配置按钮

        }

        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
            start = false;
            if (DataQueue.IsAlive)
            {
                if (false == DataQueue.Join(5000))
                {
                    DataQueue.Abort();
                }
            }
            if (AI.IsAlive)
            {
                if (false == AI.Join(5000))
                {
                    AI.Abort();
                }
            }
            aitask.Stop();
            aitask.Channels.Clear();//把上次启动添加的通道清掉
            //禁用定时器，重新启动参数配置按钮
            groupBox_GenParam.Enabled = true;
            Start.Enabled = true;

        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aitask.Stop();
        }

        /// <summary>
        /// 定时器，每秒钟刷新一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Inital()
        {
            readValue = new double[(int)aitask.SampleRate, aitask.Channels.Count];
            qindata.RawData = new double[(int)aitask.SampleRate, aitask.Channels.Count];
            displyValue = new double[aitask.Channels.Count, (int)aitask.SampleRate];
            ch0RawValue = new double[(int)aitask.SampleRate];
            ch1RawValue = new double[(int)aitask.SampleRate];
            ch2RawValue = new double[(int)aitask.SampleRate];
            ch3RawValue = new double[(int)aitask.SampleRate];
            ch0sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch1sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch2sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch3sprectrumValue = new double[(int)aitask.SampleRate/2];
            FFTdf = new double[(int)aitask.SampleRate / 2];
            ch0sensivity =1000/ Convert.ToDouble(numericUpDown_CH0_Sensivity.Value);
            ch1sensivity =1000/ Convert.ToDouble(numericUpDown_CH1_Sensivity.Value);
            ch2sensivity =1000/ Convert.ToDouble(numericUpDown_CH2_Sensivity.Value);
            ch3sensivity =1000/ Convert.ToDouble(numericUpDown_CH3_Sensivity.Value);
            for(int i=0;i< ch0sprectrumValue.GetLongLength(0);i++)
            {
                FFTdf[i] = i;
            }
            averagetimes = Convert.ToInt16(numericUpDown_averagetimes);
            qindata.averageindex = 0;
        }
        private void ProcessQueue()
        {
            while (start)
            {
                Thread.Sleep(1);
                if (myqueue.Count > 0)
                {
                    qoutdata = myqueue.Dequeue();
                    if(qoutdata.averageindex==1)
                    {
                        csvfilename = DateTime.Now.ToString("yyy_MM_dd_HH_mm_ss_ffff");
                    }
                    //显示波形需要做一次转置

                    if (Chcount == 1)
                    {
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        ///File.AppendAllLines(filepath+"1.csv", ch0sprectrumValue.Select(d => d.ToString()).ToArray());
                        CsvData(filepath, "CH0", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch0sprectrumValue);

                    }
                    else if (Chcount == 2)
                    {
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        CsvData(filepath, "CH0", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch0sprectrumValue);
                        CsvData(filepath, "CH1", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch1sprectrumValue);
                    }
                    else if (Chcount == 3)
                    {
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 2, ref ch2RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch2RawValue, ch2sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch2RawValue, aitask.SampleRate, ref ch2sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        CsvData(filepath, "CH0", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch0sprectrumValue);
                        CsvData(filepath, "CH1", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch1sprectrumValue);
                        CsvData(filepath, "CH2", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch2sprectrumValue);
                    }
                    else
                    {
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 2, ref ch2RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch2RawValue, ch2sensivity);
                        ArrayManipulation.GetArraySubset(qoutdata.RawData, 3, ref ch3RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch3RawValue, ch3sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch2RawValue, aitask.SampleRate, ref ch2sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch3RawValue, aitask.SampleRate, ref ch3sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        CsvData(filepath, "CH0", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch0sprectrumValue);
                        CsvData(filepath, "CH1", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch1sprectrumValue);
                        CsvData(filepath, "CH2", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch2sprectrumValue);
                        CsvData(filepath, "CH3", csvfilename, qoutdata.averageindex, qoutdata.logtime, FFTdf, ch3sprectrumValue);
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (radioButtonCH0.Checked == true)
                        {
                            easyChartTime.Plot(ch0RawValue);
                            easyChartFFT.Plot(ch0sprectrumValue);
                        }
                        if (radioButtonCH1.Checked == true)
                        {
                            easyChartTime.Plot(ch1RawValue);
                            easyChartFFT.Plot(ch1sprectrumValue);
                        }
                        if (radioButtonCH2.Checked == true)
                        {
                            easyChartTime.Plot(ch2RawValue);
                            easyChartFFT.Plot(ch2sprectrumValue);
                        }
                        if (radioButtonCH3.Checked == true)
                        {
                            easyChartTime.Plot(ch3RawValue);
                            easyChartFFT.Plot(ch3sprectrumValue);
                        }
                        textBox1.Text = myqueue.Count.ToString();
                    });
                    
                }
            }
        }
        private void ConfigDAQ()
        {
            Chcount = comboBoxSelectChannel.SelectedIndex + 1;
            for (int i = 0; i < Chcount; i++)
            {
                aitask.AddChannel(i, (double)numericUpDown_Ch0_Threshold.Value, (double)numericUpDown_averagetimes.Value, Coupling.AC, AITerminal.Differential, true);
            }

            //基本参数配置
            aitask.Mode = AIMode.Continuous;
            aitask.SampleRate = (double)numericUpDown_SampleRate.Value;
        }
        private void GetData()
        {
            while (start)
            {
                Thread.Sleep(1);
                if (aitask.AvailableSamples >= (int)aitask.SampleRate)
                {
                    qindata = new Queuedata();
                    aitask.ReadData(ref readValue, (int)aitask.SampleRate, -1);
                    qindata.averageindex++;
                    if (qindata.averageindex>averagetimes)
                    {
                        qindata.averageindex = 0;
                    }
                    qindata.logtime = DateTime.Now;
                    qindata.RawData = MVAFW.TestItemColls.GenericCopier<double[,]>.DeepCopy(readValue);
                    myqueue.Enqueue(qindata);
                }
                
            }
        }
        private void CreateIfFolderMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
        private void CsvData(string filepath, string channel, string filename, int index, DateTime time, double[] indexf, double[] FFTData)
        {
            if (index == 1)
            {
                File.AppendAllText(filepath + channel + filename + ".csv", "Hz," + string.Join(",", indexf) + "\n");
                File.AppendAllText(filepath + channel + filename + ".csv", time.ToString("yyy_MM_dd_HH_mm_ss_ffff") + string.Join(",", FFTData) + "\n");
            }
            else
            {
                File.AppendAllText(filepath + channel + filename + ".csv", time.ToString("yyy_MM_dd_HH_mm_ss_ffff") + string.Join(",", FFTData) + "\n");
            }
        }

        #endregion=

        #region Methods
        #endregion

    }
}

