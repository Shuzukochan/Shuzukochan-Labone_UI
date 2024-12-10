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
    public partial class CalibPosition : BaseForm
    {
        public CalibPosition()
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

        private void getCButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationC(), groundPanel);
        }

        private void getHButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocationH(), groundPanel);
        }
    }
}
