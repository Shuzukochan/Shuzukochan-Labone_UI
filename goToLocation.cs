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
    public partial class goToLocation : BaseForm
    {
        public goToLocation()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting(), groundPanel);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }

        private void goToLocation_Load(object sender, EventArgs e)
        {
            programNameLabel.Text = GlobalVariables.ProgramName;
        }
    }
}
