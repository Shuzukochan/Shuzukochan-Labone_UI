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
    public partial class CelibrationAction : BaseForm
    {
        public CelibrationAction(string programName)
        {
            InitializeComponent();
            programNameLabel.Text = programName;
            if (programName == "Program 10")
            {
                programNameLabel.Location = new Point(425, 6);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProgramParameter_1(GlobalVariables.ProgramName), groundPanel);
        }
    }
}
