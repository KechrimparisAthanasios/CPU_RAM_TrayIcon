using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Threading;

namespace CPU_RAM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private double GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.AvailableFreeSpace;
                }
            }
            return -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Ram
            float ramUsage = ramCounter.NextValue();
            ramProgress.Value = (int)ramUsage;
            RAMCirc.Value = (int)ramUsage;
            ramLbl.Text = String.Format("{0: 0.00}%", ramUsage);
            RAMCirc.Text = String.Format("{0: 0.00}%", ramUsage);

            //CPU
            float cpuUsage = cpuCounter.NextValue();
            cpuProgress.Value = (int)cpuUsage;
            CpuCirc.Value = (int)cpuUsage;
            cpuLbl.Text = String.Format("{0: 0.00} %", cpuUsage);
            CpuCirc.Text = String.Format("{0: 0.00} %", cpuUsage);

            //Temperature
            float temperature = TemparatureCounter.NextValue();
            int newValue = (int)temperature;
            double convertValue = (newValue - 273.15);
            TempCirc.Value = (int)convertValue;
            TempCirc.Text = String.Format("{0: 0.00} °C", convertValue);

            //Hard Disk
            double hardDisk = (double)GetTotalFreeSpace("C:\\");
            double roundValue = hardDisk / (1024 * 1024);
            double roundValue1 = roundValue / 1000;
            //hardDiskSpace.Value = (int)roundValue1;
            //SpaceLbl.Text = String.Format("{0: 0.00}  GB available space", roundValue1);

            //Core0
            float cpu0Usage = core0Conter.NextValue();
            core0Circ.Value = (int)cpu0Usage;
            core0Circ.Text = String.Format("{0: 0.00} %", cpu0Usage);

            //Core1
            float cpu1Usage = core1Counter.NextValue();
            core1Circ.Value = (int)cpu1Usage;
            core1Circ.Text = String.Format("{0: 0.00} %", cpu1Usage);

            //Core2
            float cpu2Usage = core2Counter.NextValue();
            core2Circ.Value = (int)cpu2Usage;
            core2Circ.Text = String.Format("{0: 0.00} %", cpu2Usage);

            //Core3
            float cpu3Usage = core3Counter.NextValue();
            core3Circ.Value = (int)cpu3Usage;
            core3Circ.Text = String.Format("{0: 0.00} %", cpu3Usage);


            //DateTime dateTime = DateTime.Now;
            //timeLbl.Text = DateTime.Now.ToLongTimeString();
            //dateLbl.Text = DateTime.Now.ToLongDateString();


            //greekTimeLbl.Text = dateTime.AddHours(-1).ToLongTimeString();
            //greekDateLbl.Text = DateTime.Now.ToLongDateString();

            //englishTimeLbl.Text = dateTime.AddHours(-2).ToLongTimeString();
            //englishDateLbl.Text = DateTime.Now.ToLongDateString();


            chart1.Series["CPU"].Points.AddY(cpuUsage);
            ramChart.Series["RAM"].Points.AddY(ramUsage);
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           this.Show();            
        }

        private void Form1_MouseLeave_1(object sender, EventArgs e)
        {
           // this.Hide();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Commit
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
