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
            // Mở form cài đặt
            OpenChildForm(new Setting(), groundPanel);

            // Ẩn các panel
            leftPanel.Visible = false;
            midPanel.Visible = false;
            rightPanel.Visible = false;
        }

        private async void StartClock()
        {
            while (true)
            {
                this.Update();
                GlobalVariables.TimeString = DateTime.Now.ToString("HH:mm:ss");
                timeLabel.Text = GlobalVariables.TimeString;
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
            timeLabel.Text = GlobalVariables.TimeString;
            dayLabel.Text = GlobalVariables.DayString;
            programNameLabel.Text = GlobalVariables.ProgramName;
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

