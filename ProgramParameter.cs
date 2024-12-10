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
    public partial class ProgramParameter : BaseForm
    {
        public ProgramParameter(string programName)
        {
            InitializeComponent();
            programNameLabel.Text = programName;
            if (programName == "Program 10")
            {
                programNameLabel.Location = new Point(548, 9);
            }
        }
        private void ProgramParameter_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }

        private void modDistributionButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DistributionLocation(), groundPanel);
        }

        private void modPositionButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocation(), groundPanel);
        }
    }
}
