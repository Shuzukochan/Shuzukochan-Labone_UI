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
            OpenChildForm(new SelectProgram(0), groundPanel);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting_1(), groundPanel);
        }


        private void configButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new goToLocation(), groundPanel);
        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectProgram(1), groundPanel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
            mainPanel.Visible = false;
        }
    }
}
