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
    public partial class GetLocationA : BaseForm
    {
        public GetLocationA()
        {
            InitializeComponent();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetLocation(), groundPanel);
        }
    }
}
