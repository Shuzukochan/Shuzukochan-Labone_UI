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
    public partial class ProgramParameter_1 : BaseForm
    {
        public ProgramParameter_1(string programName)
        {
            InitializeComponent();
            programNameLabel.Text = programName;
            if (programName == "Program 10")
            {
                programNameLabel.Location = new Point(548, 9);
            }
        }

        private void calibDisButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CelibrationAction(programNameLabel.Text), groundPanel);
        }

        private void calibPosButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalibPosition(), groundPanel);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
            leftPanel.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectProgram(1), groundPanel);
            leftPanel.Visible = false;
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting(), groundPanel);
        }
    }
}
