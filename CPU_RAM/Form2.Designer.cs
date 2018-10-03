namespace CPU_RAM
{
    partial class Form2
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
            this.TempCounter = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPUCounter = new System.Diagnostics.PerformanceCounter();
            this.core3Counter = new System.Diagnostics.PerformanceCounter();
            this.core1Counter = new System.Diagnostics.PerformanceCounter();
            this.core0Counter = new System.Diagnostics.PerformanceCounter();
            this.RamCounter = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.TempCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core3Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core1Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.core0Counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // TempCounter
            // 
            this.TempCounter.CategoryName = "Thermal Zone Information";
            this.TempCounter.CounterName = "Temperature";
            this.TempCounter.InstanceName = "\\_TZ.TSZ0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // CPUCounter
            // 
            this.CPUCounter.CategoryName = "Processor";
            this.CPUCounter.CounterName = "% Processor Time";
            this.CPUCounter.InstanceName = "_Total";
            // 
            // core3Counter
            // 
            this.core3Counter.CategoryName = "Processor";
            this.core3Counter.CounterName = "% Processor Time";
            this.core3Counter.InstanceName = "3";
            // 
            // core1Counter
            // 
            this.core1Counter.CategoryName = "Processor";
            this.core1Counter.CounterName = "% Processor Time";
            this.core1Counter.InstanceName = "1";
            // 
            // core0Counter
            // 
            this.core0Counter.CategoryName = "Processor";
            this.core0Counter.CounterName = "% Processor Time";
            this.core0Counter.InstanceName = "0";
            // 
            // RamCounter
            // 
            this.RamCounter.CategoryName = "Memory";
            this.RamCounter.CounterName = "% Committed Bytes In Use";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1303, 711);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.TempCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core3Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core1Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.core0Counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter TempCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPUCounter;
        private System.Diagnostics.PerformanceCounter core3Counter;
        private System.Diagnostics.PerformanceCounter core1Counter;
        private System.Diagnostics.PerformanceCounter core0Counter;
        private System.Diagnostics.PerformanceCounter RamCounter;
    }
}