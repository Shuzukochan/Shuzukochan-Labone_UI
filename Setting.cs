using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labone_UI
{
    public partial class Setting : BaseForm
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void setupButton_Click(object sender, EventArgs e)
        {
            // Mở form cài đặt
            OpenChildForm(new SelectProgram(false), groundPanel);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting_1(), groundPanel);
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

        private void Setting_Load(object sender, EventArgs e)
        {
            StartClock();
            timeLabel.Text = GlobalVariables.TimeString;
            dayLabel.Text = GlobalVariables.DayString;
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new goToLocation(), groundPanel);
        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectProgram(true), groundPanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }
    }
}
