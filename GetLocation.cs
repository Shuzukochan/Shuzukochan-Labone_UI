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
    public partial class GetLocation : BaseForm
    {
        public GetLocation()
        {
            InitializeComponent();
        }

        private void getAButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationA(), groundPanel);
        }

        private void getBButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationB(), groundPanel);
        }

        private void getHButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationH(), groundPanel);
        }

        private void getCButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationC(), groundPanel);
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
