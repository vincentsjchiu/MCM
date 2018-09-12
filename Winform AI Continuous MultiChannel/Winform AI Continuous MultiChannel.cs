using System;
using System.Windows.Forms;
using JYUSB62405;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;
using System.Threading;
using System.Collections.Generic;
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
        Thread AI, DataQueue;
        Queue<Queuedata> myqueue = new Queue<Queuedata>();
        Queuedata qdata = new Queuedata();
        bool start = false;
        int Chcount;
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
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            comboBoxSelectChannel.SelectedIndex = 0;
            radioButtonCH0.Checked = true;
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
            qdata.RawData = new double[(int)aitask.SampleRate, aitask.Channels.Count];
            displyValue = new double[aitask.Channels.Count, (int)aitask.SampleRate];
            ch0RawValue = new double[(int)aitask.SampleRate];
            ch1RawValue = new double[(int)aitask.SampleRate];
            ch2RawValue = new double[(int)aitask.SampleRate];
            ch3RawValue = new double[(int)aitask.SampleRate];
            ch0sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch1sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch2sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch3sprectrumValue = new double[(int)aitask.SampleRate/2];
            ch0sensivity =1000/ Convert.ToDouble(numericUpDown_CH0_Sensivity.Value);
            ch1sensivity =1000/ Convert.ToDouble(numericUpDown_CH1_Sensivity.Value);
            ch2sensivity =1000/ Convert.ToDouble(numericUpDown_CH2_Sensivity.Value);
            ch3sensivity =1000/ Convert.ToDouble(numericUpDown_CH3_Sensivity.Value);
        }
        private void ProcessQueue()
        {
            while (start)
            {
                Thread.Sleep(1);
                if (myqueue.Count > 0)
                {
                    qdata = myqueue.Dequeue();

                    //显示波形需要做一次转置

                    if (Chcount == 1)
                    {
                        ArrayManipulation.GetArraySubset(qdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                    }
                    else if (Chcount == 2)
                    {
                        ArrayManipulation.GetArraySubset(qdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                    }
                    else if (Chcount == 3)
                    {
                        ArrayManipulation.GetArraySubset(qdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 2, ref ch2RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch2RawValue, ch2sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch2RawValue, aitask.SampleRate, ref ch2sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                    }
                    else
                    {
                        ArrayManipulation.GetArraySubset(qdata.RawData, 0, ref ch0RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch0RawValue, ch0sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 1, ref ch1RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch1RawValue, ch1sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 2, ref ch2RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch2RawValue, ch2sensivity);
                        ArrayManipulation.GetArraySubset(qdata.RawData, 3, ref ch3RawValue, ArrayManipulation.IndexType.column);
                        ArrayCalculation.MultiplyScale(ref ch3RawValue, ch3sensivity);
                        Spectrum.PowerSpectrum(ch0RawValue, aitask.SampleRate, ref ch0sprectrumValue, out df, SpectrumUnits.V, WindowType.None);
                        Spectrum.PowerSpectrum(ch1RawValue, aitask.SampleRate, ref ch1sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch2RawValue, aitask.SampleRate, ref ch2sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
                        Spectrum.PowerSpectrum(ch3RawValue, aitask.SampleRate, ref ch3sprectrumValue, out df, SpectrumUnits.V, WindowType.Hanning);
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
                aitask.AddChannel(i, (double)numericUpDown_Ch0_Threshold.Value, (double)numericUpDown_RangeHigh.Value, Coupling.AC, AITerminal.Differential, true);
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
                    qdata = new Queuedata();
                    aitask.ReadData(ref readValue, (int)aitask.SampleRate, -1);
                    qdata.logtime = DateTime.Now;
                    qdata.RawData = MVAFW.TestItemColls.GenericCopier<double[,]>.DeepCopy(readValue);
                    myqueue.Enqueue(qdata);
                }
                
            }
        }

        #endregion=

        #region Methods
        #endregion

    }
}

