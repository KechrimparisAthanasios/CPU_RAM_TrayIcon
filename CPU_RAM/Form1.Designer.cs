namespace CPU_RAM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ramCounter = new System.Diagnostics.PerformanceCounter();
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.core0Conter = new System.Diagnostics.PerformanceCounter();
            this.core1Counter = new System.Diagnostics.PerformanceCounter();
            this.core2Counter = new System.Diagnostics.PerformanceCounter();
            this.core3Counter = new System.Diagnostics.PerformanceCounter();
            this.TemparatureCounter = new System.Diagnostics.PerformanceCounter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.core3Circ = new CircularProgressBar.CircularProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.core2Circ = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.core1Circ = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.core0Circ = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TempCirc = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CpuCirc = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.RAMCirc = new CircularProgressBar.CircularProgressBar();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuProgress = new MetroFramework.Controls.MetroProgressBar();
            this.ramLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ramProgress = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ramCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core0Conter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core1Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core2Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core3Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemparatureCounter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ramCounter
            // 
            this.ramCounter.CategoryName = "Memory";
            this.ramCounter.CounterName = "% Committed Bytes In Use";
            // 
            // cpuCounter
            // 
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
            // 
            // core0Conter
            // 
            this.core0Conter.CategoryName = "Processor";
            this.core0Conter.CounterName = "% Processor Time";
            this.core0Conter.InstanceName = "0";
            // 
            // core1Counter
            // 
            this.core1Counter.CategoryName = "Processor";
            this.core1Counter.CounterName = "% Processor Time";
            this.core1Counter.InstanceName = "1";
            // 
            // core2Counter
            // 
            this.core2Counter.CategoryName = "Processor";
            this.core2Counter.CounterName = "% Processor Time";
            this.core2Counter.InstanceName = "2";
            // 
            // core3Counter
            // 
            this.core3Counter.CategoryName = "Processor";
            this.core3Counter.CounterName = "% Processor Time";
            this.core3Counter.InstanceName = "3";
            // 
            // TemparatureCounter
            // 
            this.TemparatureCounter.CategoryName = "Thermal Zone Information";
            this.TemparatureCounter.CounterName = "Temperature";
            this.TemparatureCounter.InstanceName = "\\_TZ.TSZ0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CPU_RAM";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ramChart);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.core3Circ);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.core2Circ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.core1Circ);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.core0Circ);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TempCirc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CpuCirc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RAMCirc);
            this.panel1.Controls.Add(this.cpuLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cpuProgress);
            this.panel1.Controls.Add(this.ramLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ramProgress);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 298);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // ramChart
            // 
            this.ramChart.BackColor = System.Drawing.Color.Transparent;
            this.ramChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ramChart.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.ramChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.ramChart.Legends.Add(legend1);
            this.ramChart.Location = new System.Drawing.Point(11, 232);
            this.ramChart.Name = "ramChart";
            this.ramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackImageTransparentColor = System.Drawing.Color.Maroon;
            series1.BackSecondaryColor = System.Drawing.Color.DarkViolet;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.Color = System.Drawing.Color.Black;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "RAM";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ShadowColor = System.Drawing.Color.Tomato;
            this.ramChart.Series.Add(series1);
            this.ramChart.Size = new System.Drawing.Size(252, 68);
            this.ramChart.TabIndex = 91;
            this.ramChart.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MaximumAutoSize = 100F;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 5;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 169);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackImageTransparentColor = System.Drawing.Color.Maroon;
            series2.BackSecondaryColor = System.Drawing.Color.DarkViolet;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Color = System.Drawing.Color.Black;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "CPU";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ShadowColor = System.Drawing.Color.Tomato;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(252, 68);
            this.chart1.TabIndex = 90;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(271, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 89;
            this.label10.Text = "Core 3";
            // 
            // core3Circ
            // 
            this.core3Circ.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.core3Circ.AnimationSpeed = 500;
            this.core3Circ.BackColor = System.Drawing.Color.Transparent;
            this.core3Circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core3Circ.ForeColor = System.Drawing.Color.White;
            this.core3Circ.InnerColor = System.Drawing.Color.Transparent;
            this.core3Circ.InnerMargin = 2;
            this.core3Circ.InnerWidth = -1;
            this.core3Circ.Location = new System.Drawing.Point(264, 184);
            this.core3Circ.MarqueeAnimationSpeed = 2000;
            this.core3Circ.Name = "core3Circ";
            this.core3Circ.OuterColor = System.Drawing.Color.PeachPuff;
            this.core3Circ.OuterMargin = -25;
            this.core3Circ.OuterWidth = 6;
            this.core3Circ.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.core3Circ.ProgressWidth = 9;
            this.core3Circ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core3Circ.Size = new System.Drawing.Size(50, 38);
            this.core3Circ.StartAngle = 270;
            this.core3Circ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.core3Circ.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.core3Circ.SubscriptText = "";
            this.core3Circ.SuperscriptColor = System.Drawing.Color.White;
            this.core3Circ.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.core3Circ.SuperscriptText = "";
            this.core3Circ.TabIndex = 88;
            this.core3Circ.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.core3Circ.Value = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 87;
            this.label8.Text = "Core 2";
            // 
            // core2Circ
            // 
            this.core2Circ.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.core2Circ.AnimationSpeed = 500;
            this.core2Circ.BackColor = System.Drawing.Color.Transparent;
            this.core2Circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core2Circ.ForeColor = System.Drawing.Color.White;
            this.core2Circ.InnerColor = System.Drawing.Color.Transparent;
            this.core2Circ.InnerMargin = 2;
            this.core2Circ.InnerWidth = -1;
            this.core2Circ.Location = new System.Drawing.Point(264, 128);
            this.core2Circ.MarqueeAnimationSpeed = 2000;
            this.core2Circ.Name = "core2Circ";
            this.core2Circ.OuterColor = System.Drawing.Color.PeachPuff;
            this.core2Circ.OuterMargin = -25;
            this.core2Circ.OuterWidth = 6;
            this.core2Circ.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.core2Circ.ProgressWidth = 9;
            this.core2Circ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core2Circ.Size = new System.Drawing.Size(50, 38);
            this.core2Circ.StartAngle = 270;
            this.core2Circ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.core2Circ.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.core2Circ.SubscriptText = "";
            this.core2Circ.SuperscriptColor = System.Drawing.Color.White;
            this.core2Circ.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.core2Circ.SuperscriptText = "";
            this.core2Circ.TabIndex = 86;
            this.core2Circ.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.core2Circ.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(271, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 85;
            this.label4.Text = "Core 1";
            // 
            // core1Circ
            // 
            this.core1Circ.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.core1Circ.AnimationSpeed = 500;
            this.core1Circ.BackColor = System.Drawing.Color.Transparent;
            this.core1Circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core1Circ.ForeColor = System.Drawing.Color.White;
            this.core1Circ.InnerColor = System.Drawing.Color.Transparent;
            this.core1Circ.InnerMargin = 2;
            this.core1Circ.InnerWidth = -1;
            this.core1Circ.Location = new System.Drawing.Point(264, 72);
            this.core1Circ.MarqueeAnimationSpeed = 2000;
            this.core1Circ.Name = "core1Circ";
            this.core1Circ.OuterColor = System.Drawing.Color.PeachPuff;
            this.core1Circ.OuterMargin = -25;
            this.core1Circ.OuterWidth = 6;
            this.core1Circ.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.core1Circ.ProgressWidth = 9;
            this.core1Circ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core1Circ.Size = new System.Drawing.Size(50, 38);
            this.core1Circ.StartAngle = 270;
            this.core1Circ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.core1Circ.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.core1Circ.SubscriptText = "";
            this.core1Circ.SuperscriptColor = System.Drawing.Color.White;
            this.core1Circ.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.core1Circ.SuperscriptText = "";
            this.core1Circ.TabIndex = 84;
            this.core1Circ.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.core1Circ.Value = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 83;
            this.label7.Text = "Core 0";
            // 
            // core0Circ
            // 
            this.core0Circ.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.core0Circ.AnimationSpeed = 500;
            this.core0Circ.BackColor = System.Drawing.Color.Transparent;
            this.core0Circ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core0Circ.ForeColor = System.Drawing.Color.White;
            this.core0Circ.InnerColor = System.Drawing.Color.Transparent;
            this.core0Circ.InnerMargin = 2;
            this.core0Circ.InnerWidth = -1;
            this.core0Circ.Location = new System.Drawing.Point(264, 14);
            this.core0Circ.MarqueeAnimationSpeed = 2000;
            this.core0Circ.Name = "core0Circ";
            this.core0Circ.OuterColor = System.Drawing.Color.PeachPuff;
            this.core0Circ.OuterMargin = -25;
            this.core0Circ.OuterWidth = 6;
            this.core0Circ.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.core0Circ.ProgressWidth = 9;
            this.core0Circ.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core0Circ.Size = new System.Drawing.Size(50, 38);
            this.core0Circ.StartAngle = 270;
            this.core0Circ.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.core0Circ.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.core0Circ.SubscriptText = "";
            this.core0Circ.SuperscriptColor = System.Drawing.Color.Transparent;
            this.core0Circ.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.core0Circ.SuperscriptText = "";
            this.core0Circ.TabIndex = 82;
            this.core0Circ.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.core0Circ.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 81;
            this.label3.Text = "TEMPERATURE";
            // 
            // TempCirc
            // 
            this.TempCirc.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.TempCirc.AnimationSpeed = 500;
            this.TempCirc.BackColor = System.Drawing.Color.Transparent;
            this.TempCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempCirc.ForeColor = System.Drawing.Color.White;
            this.TempCirc.InnerColor = System.Drawing.Color.Transparent;
            this.TempCirc.InnerMargin = 2;
            this.TempCirc.InnerWidth = -1;
            this.TempCirc.Location = new System.Drawing.Point(161, 72);
            this.TempCirc.MarqueeAnimationSpeed = 2000;
            this.TempCirc.Name = "TempCirc";
            this.TempCirc.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.TempCirc.OuterMargin = -25;
            this.TempCirc.OuterWidth = 6;
            this.TempCirc.ProgressColor = System.Drawing.Color.DarkViolet;
            this.TempCirc.ProgressWidth = 10;
            this.TempCirc.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempCirc.Size = new System.Drawing.Size(60, 58);
            this.TempCirc.StartAngle = 270;
            this.TempCirc.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.TempCirc.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.TempCirc.SubscriptText = "";
            this.TempCirc.SuperscriptColor = System.Drawing.Color.White;
            this.TempCirc.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.TempCirc.SuperscriptText = "";
            this.TempCirc.TabIndex = 80;
            this.TempCirc.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.TempCirc.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 79;
            this.label2.Text = "CPU";
            // 
            // CpuCirc
            // 
            this.CpuCirc.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuCirc.AnimationSpeed = 500;
            this.CpuCirc.BackColor = System.Drawing.Color.Transparent;
            this.CpuCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuCirc.ForeColor = System.Drawing.Color.White;
            this.CpuCirc.InnerColor = System.Drawing.Color.Transparent;
            this.CpuCirc.InnerMargin = 2;
            this.CpuCirc.InnerWidth = -1;
            this.CpuCirc.Location = new System.Drawing.Point(101, 72);
            this.CpuCirc.MarqueeAnimationSpeed = 2000;
            this.CpuCirc.Name = "CpuCirc";
            this.CpuCirc.OuterColor = System.Drawing.Color.PeachPuff;
            this.CpuCirc.OuterMargin = -25;
            this.CpuCirc.OuterWidth = 6;
            this.CpuCirc.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.CpuCirc.ProgressWidth = 10;
            this.CpuCirc.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuCirc.Size = new System.Drawing.Size(60, 58);
            this.CpuCirc.StartAngle = 270;
            this.CpuCirc.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CpuCirc.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CpuCirc.SubscriptText = "";
            this.CpuCirc.SuperscriptColor = System.Drawing.Color.White;
            this.CpuCirc.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpuCirc.SuperscriptText = "";
            this.CpuCirc.TabIndex = 78;
            this.CpuCirc.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CpuCirc.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 77;
            this.label1.Text = "RAM";
            // 
            // RAMCirc
            // 
            this.RAMCirc.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RAMCirc.AnimationSpeed = 500;
            this.RAMCirc.BackColor = System.Drawing.Color.Transparent;
            this.RAMCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMCirc.ForeColor = System.Drawing.Color.White;
            this.RAMCirc.InnerColor = System.Drawing.Color.Transparent;
            this.RAMCirc.InnerMargin = 2;
            this.RAMCirc.InnerWidth = -1;
            this.RAMCirc.Location = new System.Drawing.Point(41, 72);
            this.RAMCirc.MarqueeAnimationSpeed = 2000;
            this.RAMCirc.Name = "RAMCirc";
            this.RAMCirc.OuterColor = System.Drawing.Color.SeaShell;
            this.RAMCirc.OuterMargin = -25;
            this.RAMCirc.OuterWidth = 6;
            this.RAMCirc.ProgressColor = System.Drawing.Color.DarkMagenta;
            this.RAMCirc.ProgressWidth = 10;
            this.RAMCirc.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMCirc.Size = new System.Drawing.Size(60, 58);
            this.RAMCirc.StartAngle = 270;
            this.RAMCirc.SubscriptColor = System.Drawing.Color.White;
            this.RAMCirc.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RAMCirc.SubscriptText = "";
            this.RAMCirc.SuperscriptColor = System.Drawing.Color.White;
            this.RAMCirc.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RAMCirc.SuperscriptText = "";
            this.RAMCirc.TabIndex = 76;
            this.RAMCirc.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RAMCirc.Value = 68;
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpuLbl.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLbl.ForeColor = System.Drawing.Color.White;
            this.cpuLbl.Location = new System.Drawing.Point(214, 35);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(0, 12);
            this.cpuLbl.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 74;
            this.label6.Text = "CPU";
            // 
            // cpuProgress
            // 
            this.cpuProgress.Location = new System.Drawing.Point(54, 36);
            this.cpuProgress.Name = "cpuProgress";
            this.cpuProgress.Size = new System.Drawing.Size(154, 16);
            this.cpuProgress.Style = MetroFramework.MetroColorStyle.Pink;
            this.cpuProgress.TabIndex = 73;
            this.cpuProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ramLbl
            // 
            this.ramLbl.AutoSize = true;
            this.ramLbl.BackColor = System.Drawing.Color.Transparent;
            this.ramLbl.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLbl.ForeColor = System.Drawing.Color.White;
            this.ramLbl.Location = new System.Drawing.Point(215, 14);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(0, 12);
            this.ramLbl.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "RAM";
            // 
            // ramProgress
            // 
            this.ramProgress.Location = new System.Drawing.Point(54, 14);
            this.ramProgress.Name = "ramProgress";
            this.ramProgress.Size = new System.Drawing.Size(155, 15);
            this.ramProgress.Style = MetroFramework.MetroColorStyle.Pink;
            this.ramProgress.TabIndex = 70;
            this.ramProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 343);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Location = new System.Drawing.Point(1050, 370);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CPU && RAM";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave_1);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ramCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core0Conter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core1Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core2Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core3Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemparatureCounter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter ramCounter;
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter core0Conter;
        private System.Diagnostics.PerformanceCounter core1Counter;
        private System.Diagnostics.PerformanceCounter core2Counter;
        private System.Diagnostics.PerformanceCounter core3Counter;
        private System.Diagnostics.PerformanceCounter TemparatureCounter;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private CircularProgressBar.CircularProgressBar core3Circ;
        private System.Windows.Forms.Label label8;
        private CircularProgressBar.CircularProgressBar core2Circ;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar core1Circ;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar core0Circ;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar TempCirc;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar CpuCirc;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar RAMCirc;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroProgressBar cpuProgress;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroProgressBar ramProgress;
    }
}

