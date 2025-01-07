using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using Labone_UI.Resources;
using System.IO.Ports;


namespace Labone_UI
{
    public partial class Begin : BaseForm
    {
        public Begin()
        {
            InitializeComponent();

        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting(), groundPanel);
            leftPanel.Visible = false;
            midPanel.Visible = false;
            rightPanel.Visible = false;
            underLeftPanel.BringToFront();
        }

        private async void StartClock()
        {
            while (true)
            {
                this.Update();
                timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                await Task.Delay(1000);
            }
        }

        private void Begin_Load(object sender, EventArgs e)
        {
            StartClock();
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();

            });
            dayLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            programNameLabel.Text = GlobalVariables.ProgramName;
            quanityRxLabel.Text = GlobalVariables.Quanity;
            volumeRxLabel.Text = GlobalVariables.Volume;
            pumpSpeedRxLabel.Text = GlobalVariables.PumpSpeed;
            tubeIDRxLabel.Text = GlobalVariables.TubeID;
            speedXYRxLabel.Text = GlobalVariables.SpeedXY;
            antidropRxLabel.Text = GlobalVariables.Antidrop;

            
            UartManager.Instance.SerialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = UartManager.Instance.Receive();

                this.BeginInvoke((MethodInvoker)delegate
                {
                    GlobalVariables.Quanity = data[0].ToString() + data[1].ToString();
                    GlobalVariables.Volume = data[3].ToString() + data[4].ToString();
                    GlobalVariables.PumpSpeed = data[6].ToString() + data[7].ToString();
                    GlobalVariables.TubeID = data[9].ToString() + data[10].ToString();
                    GlobalVariables.SpeedXY = data[12].ToString() + data[13].ToString();
                    GlobalVariables.Antidrop = data[15].ToString() + data[16].ToString() + data[17].ToString();

   
                    quanityRxLabel.Text = GlobalVariables.Quanity;
                    volumeRxLabel.Text = GlobalVariables.Volume;
                    pumpSpeedRxLabel.Text = GlobalVariables.PumpSpeed;
                    tubeIDRxLabel.Text = GlobalVariables.TubeID;
                    speedXYRxLabel.Text = GlobalVariables.SpeedXY;
                    antidropRxLabel.Text = GlobalVariables.Antidrop;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data from UART: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void area1Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectProgram(3), groundPanel);
            leftPanel.Visible = false;
            rightPanel.Visible = false;
            midPanel.Visible = false;
            GlobalVariables.AreaState = false;
        }

        private void area2Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectProgram(3), groundPanel);
            leftPanel.Visible = false;
            rightPanel.Visible = false;
            midPanel.Visible = false;
            GlobalVariables.AreaState = true;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Information(), groundPanel);
            leftPanel.Visible = false;
            rightPanel.Visible = false;
            midPanel.Visible = false;
        }
    }
}

