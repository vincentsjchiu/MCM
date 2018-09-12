namespace SeeSharpExample.JY.JYUSB62405
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            SeeSharpTools.JY.GUI.EasyChartSeries easyChartSeries3 = new SeeSharpTools.JY.GUI.EasyChartSeries();
            SeeSharpTools.JY.GUI.EasyChartSeries easyChartSeries4 = new SeeSharpTools.JY.GUI.EasyChartSeries();
            this.easyChartTime = new SeeSharpTools.JY.GUI.EasyChart();
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.label_RangeLow = new System.Windows.Forms.Label();
            this.label_RangeHigh = new System.Windows.Forms.Label();
            this.numericUpDown_SampleRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ch0_Threshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RangeHigh = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_boardNum = new System.Windows.Forms.ComboBox();
            this.groupBox_GenParam = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectChannel = new System.Windows.Forms.ComboBox();
            this.easyChartFFT = new SeeSharpTools.JY.GUI.EasyChart();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Ch1_Threshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ch2_Threshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ch3_Threshold = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCH0 = new System.Windows.Forms.RadioButton();
            this.radioButtonCH1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCH2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCH3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_CH0_Sensivity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CH1_Sensivity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CH2_Sensivity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CH3_Sensivity = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch0_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeHigh)).BeginInit();
            this.groupBox_GenParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch1_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch2_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch3_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH0_Sensivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH1_Sensivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH2_Sensivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH3_Sensivity)).BeginInit();
            this.SuspendLayout();
            // 
            // easyChartTime
            // 
            this.easyChartTime.AxisX.AutoScale = true;
            this.easyChartTime.AxisX.InitWithScaleView = false;
            this.easyChartTime.AxisX.LabelEnabled = true;
            this.easyChartTime.AxisX.LabelFormat = "";
            this.easyChartTime.AxisX.Maximum = 1001D;
            this.easyChartTime.AxisX.Minimum = 0D;
            this.easyChartTime.AxisX.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartTime.AxisX.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartTime.AxisX.Title = "Samples";
            this.easyChartTime.AxisX.ViewMaximum = 1001D;
            this.easyChartTime.AxisX.ViewMinimum = 0D;
            this.easyChartTime.AxisY.AutoScale = true;
            this.easyChartTime.AxisY.InitWithScaleView = false;
            this.easyChartTime.AxisY.LabelEnabled = true;
            this.easyChartTime.AxisY.LabelFormat = "";
            this.easyChartTime.AxisY.Maximum = 3.5D;
            this.easyChartTime.AxisY.Minimum = 0D;
            this.easyChartTime.AxisY.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartTime.AxisY.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartTime.AxisY.Title = "g";
            this.easyChartTime.AxisY.ViewMaximum = 3.5D;
            this.easyChartTime.AxisY.ViewMinimum = 0D;
            this.easyChartTime.AxisYMax = 3.5D;
            this.easyChartTime.AxisYMin = 0D;
            this.easyChartTime.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartTime.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartTime.GradientStyle = SeeSharpTools.JY.GUI.EasyChart.EasyChartGradientStyle.None;
            this.easyChartTime.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartTime.LegendVisible = true;
            easyChartSeries3.InterpolationStyle = SeeSharpTools.JY.GUI.EasyChartSeries.Interpolation.FastLine;
            easyChartSeries3.MarkerType = SeeSharpTools.JY.GUI.EasyChartSeries.PointStyle.None;
            easyChartSeries3.Width = SeeSharpTools.JY.GUI.EasyChartSeries.LineWidth.Thin;
            this.easyChartTime.LineSeries.Add(easyChartSeries3);
            this.easyChartTime.Location = new System.Drawing.Point(63, 69);
            this.easyChartTime.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartTime.MajorGridEnabled = true;
            this.easyChartTime.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartTime.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartTime.MinorGridEnabled = false;
            this.easyChartTime.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartTime.Name = "easyChartTime";
            this.easyChartTime.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartTime.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChartTime.Size = new System.Drawing.Size(559, 198);
            this.easyChartTime.TabIndex = 0;
            this.easyChartTime.XAxisLogarithmic = false;
            this.easyChartTime.XAxisTitle = "Samples";
            this.easyChartTime.XCursor.AutoInterval = true;
            this.easyChartTime.XCursor.Color = System.Drawing.Color.Red;
            this.easyChartTime.XCursor.Interval = 1D;
            this.easyChartTime.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Zoom;
            this.easyChartTime.XCursor.Value = double.NaN;
            this.easyChartTime.XTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartTime.XTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartTime.YAutoEnable = true;
            this.easyChartTime.YAxisLogarithmic = false;
            this.easyChartTime.YAxisTitle = "g";
            this.easyChartTime.YCursor.AutoInterval = true;
            this.easyChartTime.YCursor.Color = System.Drawing.Color.Red;
            this.easyChartTime.YCursor.Interval = 0.001D;
            this.easyChartTime.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Disabled;
            this.easyChartTime.YCursor.Value = double.NaN;
            this.easyChartTime.YTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartTime.YTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(6, 87);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(98, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "采样率(Sa/s) ";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Channel.Location = new System.Drawing.Point(6, 56);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(49, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "通道数";
            // 
            // label_RangeLow
            // 
            this.label_RangeLow.AutoSize = true;
            this.label_RangeLow.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RangeLow.Location = new System.Drawing.Point(682, 351);
            this.label_RangeLow.Name = "label_RangeLow";
            this.label_RangeLow.Size = new System.Drawing.Size(84, 14);
            this.label_RangeLow.TabIndex = 3;
            this.label_RangeLow.Text = "CH0報警閥值";
            // 
            // label_RangeHigh
            // 
            this.label_RangeHigh.AutoSize = true;
            this.label_RangeHigh.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RangeHigh.Location = new System.Drawing.Point(682, 320);
            this.label_RangeHigh.Name = "label_RangeHigh";
            this.label_RangeHigh.Size = new System.Drawing.Size(63, 14);
            this.label_RangeHigh.TabIndex = 4;
            this.label_RangeHigh.Text = "平均次數";
            // 
            // numericUpDown_SampleRate
            // 
            this.numericUpDown_SampleRate.Location = new System.Drawing.Point(150, 84);
            this.numericUpDown_SampleRate.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_SampleRate.Name = "numericUpDown_SampleRate";
            this.numericUpDown_SampleRate.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_SampleRate.TabIndex = 5;
            this.numericUpDown_SampleRate.Tag = "ParaConfig";
            this.numericUpDown_SampleRate.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // numericUpDown_Ch0_Threshold
            // 
            this.numericUpDown_Ch0_Threshold.DecimalPlaces = 1;
            this.numericUpDown_Ch0_Threshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Ch0_Threshold.Location = new System.Drawing.Point(809, 348);
            this.numericUpDown_Ch0_Threshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Ch0_Threshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_Ch0_Threshold.Name = "numericUpDown_Ch0_Threshold";
            this.numericUpDown_Ch0_Threshold.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_Ch0_Threshold.TabIndex = 7;
            this.numericUpDown_Ch0_Threshold.Tag = "ParaConfig";
            this.numericUpDown_Ch0_Threshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown_RangeHigh
            // 
            this.numericUpDown_RangeHigh.DecimalPlaces = 1;
            this.numericUpDown_RangeHigh.Location = new System.Drawing.Point(809, 317);
            this.numericUpDown_RangeHigh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_RangeHigh.Name = "numericUpDown_RangeHigh";
            this.numericUpDown_RangeHigh.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_RangeHigh.TabIndex = 8;
            this.numericUpDown_RangeHigh.Tag = "ParaConfig";
            this.numericUpDown_RangeHigh.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(685, 495);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(66, 30);
            this.Start.TabIndex = 9;
            this.Start.Tag = "ParaConfig";
            this.Start.Text = "启动";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(833, 496);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(66, 30);
            this.Stop.TabIndex = 10;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "MCM-100多通道连续采集";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "板卡号 ";
            // 
            // comboBox_boardNum
            // 
            this.comboBox_boardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardNum.FormattingEnabled = true;
            this.comboBox_boardNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_boardNum.Location = new System.Drawing.Point(149, 21);
            this.comboBox_boardNum.Name = "comboBox_boardNum";
            this.comboBox_boardNum.Size = new System.Drawing.Size(90, 20);
            this.comboBox_boardNum.TabIndex = 63;
            this.comboBox_boardNum.Tag = "ParaConfig";
            this.comboBox_boardNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_boardNum_SelectedIndexChanged);
            // 
            // groupBox_GenParam
            // 
            this.groupBox_GenParam.Controls.Add(this.numericUpDown_CH3_Sensivity);
            this.groupBox_GenParam.Controls.Add(this.numericUpDown_CH2_Sensivity);
            this.groupBox_GenParam.Controls.Add(this.numericUpDown_CH1_Sensivity);
            this.groupBox_GenParam.Controls.Add(this.numericUpDown_CH0_Sensivity);
            this.groupBox_GenParam.Controls.Add(this.label10);
            this.groupBox_GenParam.Controls.Add(this.label9);
            this.groupBox_GenParam.Controls.Add(this.label8);
            this.groupBox_GenParam.Controls.Add(this.label6);
            this.groupBox_GenParam.Controls.Add(this.comboBoxSelectChannel);
            this.groupBox_GenParam.Controls.Add(this.comboBox_boardNum);
            this.groupBox_GenParam.Controls.Add(this.label7);
            this.groupBox_GenParam.Controls.Add(this.label_SampleRate);
            this.groupBox_GenParam.Controls.Add(this.label_Channel);
            this.groupBox_GenParam.Controls.Add(this.numericUpDown_SampleRate);
            this.groupBox_GenParam.Location = new System.Drawing.Point(685, 55);
            this.groupBox_GenParam.Name = "groupBox_GenParam";
            this.groupBox_GenParam.Size = new System.Drawing.Size(269, 225);
            this.groupBox_GenParam.TabIndex = 65;
            this.groupBox_GenParam.TabStop = false;
            this.groupBox_GenParam.Text = "基本参数配置";
            // 
            // comboBoxSelectChannel
            // 
            this.comboBoxSelectChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectChannel.FormattingEnabled = true;
            this.comboBoxSelectChannel.Items.AddRange(new object[] {
            "CH0",
            "CH0~CH1",
            "CH0~CH2",
            "CH0~CH3"});
            this.comboBoxSelectChannel.Location = new System.Drawing.Point(149, 53);
            this.comboBoxSelectChannel.Name = "comboBoxSelectChannel";
            this.comboBoxSelectChannel.Size = new System.Drawing.Size(90, 20);
            this.comboBoxSelectChannel.TabIndex = 65;
            this.comboBoxSelectChannel.Tag = "ParaConfig";
            // 
            // easyChartFFT
            // 
            this.easyChartFFT.AxisX.AutoScale = true;
            this.easyChartFFT.AxisX.InitWithScaleView = false;
            this.easyChartFFT.AxisX.LabelEnabled = true;
            this.easyChartFFT.AxisX.LabelFormat = "";
            this.easyChartFFT.AxisX.Maximum = 1001D;
            this.easyChartFFT.AxisX.Minimum = 0D;
            this.easyChartFFT.AxisX.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartFFT.AxisX.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartFFT.AxisX.Title = "Hz";
            this.easyChartFFT.AxisX.ViewMaximum = 1001D;
            this.easyChartFFT.AxisX.ViewMinimum = 0D;
            this.easyChartFFT.AxisY.AutoScale = true;
            this.easyChartFFT.AxisY.InitWithScaleView = false;
            this.easyChartFFT.AxisY.LabelEnabled = true;
            this.easyChartFFT.AxisY.LabelFormat = "";
            this.easyChartFFT.AxisY.Maximum = 3.5D;
            this.easyChartFFT.AxisY.Minimum = 0D;
            this.easyChartFFT.AxisY.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartFFT.AxisY.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartFFT.AxisY.Title = "g rms";
            this.easyChartFFT.AxisY.ViewMaximum = 3.5D;
            this.easyChartFFT.AxisY.ViewMinimum = 0D;
            this.easyChartFFT.AxisYMax = 3.5D;
            this.easyChartFFT.AxisYMin = 0D;
            this.easyChartFFT.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartFFT.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChartFFT.GradientStyle = SeeSharpTools.JY.GUI.EasyChart.EasyChartGradientStyle.None;
            this.easyChartFFT.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartFFT.LegendVisible = true;
            easyChartSeries4.InterpolationStyle = SeeSharpTools.JY.GUI.EasyChartSeries.Interpolation.FastLine;
            easyChartSeries4.MarkerType = SeeSharpTools.JY.GUI.EasyChartSeries.PointStyle.None;
            easyChartSeries4.Width = SeeSharpTools.JY.GUI.EasyChartSeries.LineWidth.Thin;
            this.easyChartFFT.LineSeries.Add(easyChartSeries4);
            this.easyChartFFT.Location = new System.Drawing.Point(63, 315);
            this.easyChartFFT.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartFFT.MajorGridEnabled = true;
            this.easyChartFFT.Margin = new System.Windows.Forms.Padding(2);
            this.easyChartFFT.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartFFT.MinorGridEnabled = false;
            this.easyChartFFT.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChartFFT.Name = "easyChartFFT";
            this.easyChartFFT.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChartFFT.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChartFFT.Size = new System.Drawing.Size(559, 211);
            this.easyChartFFT.TabIndex = 66;
            this.easyChartFFT.XAxisLogarithmic = false;
            this.easyChartFFT.XAxisTitle = "Hz";
            this.easyChartFFT.XCursor.AutoInterval = true;
            this.easyChartFFT.XCursor.Color = System.Drawing.Color.Red;
            this.easyChartFFT.XCursor.Interval = 1D;
            this.easyChartFFT.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Zoom;
            this.easyChartFFT.XCursor.Value = double.NaN;
            this.easyChartFFT.XTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartFFT.XTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChartFFT.YAutoEnable = true;
            this.easyChartFFT.YAxisLogarithmic = false;
            this.easyChartFFT.YAxisTitle = "g rms";
            this.easyChartFFT.YCursor.AutoInterval = true;
            this.easyChartFFT.YCursor.Color = System.Drawing.Color.Red;
            this.easyChartFFT.YCursor.Interval = 0.001D;
            this.easyChartFFT.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Disabled;
            this.easyChartFFT.YCursor.Value = double.NaN;
            this.easyChartFFT.YTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChartFFT.YTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(809, 466);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(87, 22);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(90, 22);
            this.ipAddressControl1.TabIndex = 67;
            this.ipAddressControl1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(682, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 68;
            this.label2.Text = "MQTT　Borker IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(682, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 69;
            this.label3.Text = "CH1報警閥值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(682, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "CH2報警閥值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(682, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 71;
            this.label5.Text = "CH3報警閥值";
            // 
            // numericUpDown_Ch1_Threshold
            // 
            this.numericUpDown_Ch1_Threshold.DecimalPlaces = 1;
            this.numericUpDown_Ch1_Threshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Ch1_Threshold.Location = new System.Drawing.Point(809, 379);
            this.numericUpDown_Ch1_Threshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Ch1_Threshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_Ch1_Threshold.Name = "numericUpDown_Ch1_Threshold";
            this.numericUpDown_Ch1_Threshold.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_Ch1_Threshold.TabIndex = 72;
            this.numericUpDown_Ch1_Threshold.Tag = "ParaConfig";
            this.numericUpDown_Ch1_Threshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown_Ch2_Threshold
            // 
            this.numericUpDown_Ch2_Threshold.DecimalPlaces = 1;
            this.numericUpDown_Ch2_Threshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Ch2_Threshold.Location = new System.Drawing.Point(809, 409);
            this.numericUpDown_Ch2_Threshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Ch2_Threshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_Ch2_Threshold.Name = "numericUpDown_Ch2_Threshold";
            this.numericUpDown_Ch2_Threshold.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_Ch2_Threshold.TabIndex = 73;
            this.numericUpDown_Ch2_Threshold.Tag = "ParaConfig";
            this.numericUpDown_Ch2_Threshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown_Ch3_Threshold
            // 
            this.numericUpDown_Ch3_Threshold.DecimalPlaces = 1;
            this.numericUpDown_Ch3_Threshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Ch3_Threshold.Location = new System.Drawing.Point(809, 437);
            this.numericUpDown_Ch3_Threshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Ch3_Threshold.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_Ch3_Threshold.Name = "numericUpDown_Ch3_Threshold";
            this.numericUpDown_Ch3_Threshold.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_Ch3_Threshold.TabIndex = 74;
            this.numericUpDown_Ch3_Threshold.Tag = "ParaConfig";
            this.numericUpDown_Ch3_Threshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // radioButtonCH0
            // 
            this.radioButtonCH0.AutoSize = true;
            this.radioButtonCH0.Location = new System.Drawing.Point(12, 73);
            this.radioButtonCH0.Name = "radioButtonCH0";
            this.radioButtonCH0.Size = new System.Drawing.Size(45, 16);
            this.radioButtonCH0.TabIndex = 75;
            this.radioButtonCH0.TabStop = true;
            this.radioButtonCH0.Text = "CH0";
            this.radioButtonCH0.UseVisualStyleBackColor = true;
            // 
            // radioButtonCH1
            // 
            this.radioButtonCH1.AutoSize = true;
            this.radioButtonCH1.Location = new System.Drawing.Point(12, 116);
            this.radioButtonCH1.Name = "radioButtonCH1";
            this.radioButtonCH1.Size = new System.Drawing.Size(45, 16);
            this.radioButtonCH1.TabIndex = 76;
            this.radioButtonCH1.TabStop = true;
            this.radioButtonCH1.Text = "CH1";
            this.radioButtonCH1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCH2
            // 
            this.radioButtonCH2.AutoSize = true;
            this.radioButtonCH2.Location = new System.Drawing.Point(12, 159);
            this.radioButtonCH2.Name = "radioButtonCH2";
            this.radioButtonCH2.Size = new System.Drawing.Size(45, 16);
            this.radioButtonCH2.TabIndex = 77;
            this.radioButtonCH2.TabStop = true;
            this.radioButtonCH2.Text = "CH2";
            this.radioButtonCH2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCH3
            // 
            this.radioButtonCH3.AutoSize = true;
            this.radioButtonCH3.Location = new System.Drawing.Point(12, 205);
            this.radioButtonCH3.Name = "radioButtonCH3";
            this.radioButtonCH3.Size = new System.Drawing.Size(45, 16);
            this.radioButtonCH3.TabIndex = 78;
            this.radioButtonCH3.TabStop = true;
            this.radioButtonCH3.Text = "CH3";
            this.radioButtonCH3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 14);
            this.label6.TabIndex = 66;
            this.label6.Text = "CH0 Sensivity(mv/g)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 14);
            this.label8.TabIndex = 67;
            this.label8.Text = "CH1 Sensivity(mv/g)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 14);
            this.label9.TabIndex = 68;
            this.label9.Text = "CH2 Sensivity(mv/g)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 14);
            this.label10.TabIndex = 69;
            this.label10.Text = "CH3 Sensivity(mv/g)";
            // 
            // numericUpDown_CH0_Sensivity
            // 
            this.numericUpDown_CH0_Sensivity.DecimalPlaces = 1;
            this.numericUpDown_CH0_Sensivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_CH0_Sensivity.Location = new System.Drawing.Point(149, 114);
            this.numericUpDown_CH0_Sensivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CH0_Sensivity.Name = "numericUpDown_CH0_Sensivity";
            this.numericUpDown_CH0_Sensivity.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_CH0_Sensivity.TabIndex = 70;
            this.numericUpDown_CH0_Sensivity.Tag = "ParaConfig";
            this.numericUpDown_CH0_Sensivity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_CH1_Sensivity
            // 
            this.numericUpDown_CH1_Sensivity.DecimalPlaces = 1;
            this.numericUpDown_CH1_Sensivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_CH1_Sensivity.Location = new System.Drawing.Point(149, 144);
            this.numericUpDown_CH1_Sensivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CH1_Sensivity.Name = "numericUpDown_CH1_Sensivity";
            this.numericUpDown_CH1_Sensivity.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_CH1_Sensivity.TabIndex = 71;
            this.numericUpDown_CH1_Sensivity.Tag = "ParaConfig";
            this.numericUpDown_CH1_Sensivity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_CH2_Sensivity
            // 
            this.numericUpDown_CH2_Sensivity.DecimalPlaces = 1;
            this.numericUpDown_CH2_Sensivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_CH2_Sensivity.Location = new System.Drawing.Point(149, 172);
            this.numericUpDown_CH2_Sensivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CH2_Sensivity.Name = "numericUpDown_CH2_Sensivity";
            this.numericUpDown_CH2_Sensivity.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_CH2_Sensivity.TabIndex = 72;
            this.numericUpDown_CH2_Sensivity.Tag = "ParaConfig";
            this.numericUpDown_CH2_Sensivity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_CH3_Sensivity
            // 
            this.numericUpDown_CH3_Sensivity.DecimalPlaces = 1;
            this.numericUpDown_CH3_Sensivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_CH3_Sensivity.Location = new System.Drawing.Point(150, 199);
            this.numericUpDown_CH3_Sensivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CH3_Sensivity.Name = "numericUpDown_CH3_Sensivity";
            this.numericUpDown_CH3_Sensivity.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown_CH3_Sensivity.TabIndex = 73;
            this.numericUpDown_CH3_Sensivity.Tag = "ParaConfig";
            this.numericUpDown_CH3_Sensivity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 74;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 537);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonCH3);
            this.Controls.Add(this.radioButtonCH2);
            this.Controls.Add(this.radioButtonCH1);
            this.Controls.Add(this.radioButtonCH0);
            this.Controls.Add(this.numericUpDown_Ch3_Threshold);
            this.Controls.Add(this.numericUpDown_Ch2_Threshold);
            this.Controls.Add(this.numericUpDown_Ch1_Threshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddressControl1);
            this.Controls.Add(this.easyChartFFT);
            this.Controls.Add(this.groupBox_GenParam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_RangeLow);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.numericUpDown_Ch0_Threshold);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.easyChartTime);
            this.Controls.Add(this.numericUpDown_RangeHigh);
            this.Controls.Add(this.label_RangeHigh);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 602);
            this.MinimumSize = new System.Drawing.Size(638, 382);
            this.Name = "MainForm";
            this.Text = "MCM-100多通道连续采集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch0_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RangeHigh)).EndInit();
            this.groupBox_GenParam.ResumeLayout(false);
            this.groupBox_GenParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch1_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch2_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ch3_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH0_Sensivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH1_Sensivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH2_Sensivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CH3_Sensivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart easyChartTime;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.Label label_RangeLow;
        private System.Windows.Forms.Label label_RangeHigh;
        private System.Windows.Forms.NumericUpDown numericUpDown_SampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ch0_Threshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_RangeHigh;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_boardNum;
        private System.Windows.Forms.GroupBox groupBox_GenParam;
        private SeeSharpTools.JY.GUI.EasyChart easyChartFFT;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ch1_Threshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ch2_Threshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ch3_Threshold;
        private System.Windows.Forms.RadioButton radioButtonCH0;
        private System.Windows.Forms.RadioButton radioButtonCH1;
        private System.Windows.Forms.RadioButton radioButtonCH2;
        private System.Windows.Forms.RadioButton radioButtonCH3;
        private System.Windows.Forms.NumericUpDown numericUpDown_CH3_Sensivity;
        private System.Windows.Forms.NumericUpDown numericUpDown_CH2_Sensivity;
        private System.Windows.Forms.NumericUpDown numericUpDown_CH1_Sensivity;
        private System.Windows.Forms.NumericUpDown numericUpDown_CH0_Sensivity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

