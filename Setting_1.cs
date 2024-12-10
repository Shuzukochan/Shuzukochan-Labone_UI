using Labone_UI.Resources;
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
    public partial class Setting_1 : BaseForm
    {
        public Setting_1()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting(), groundPanel);
        }

        private void Setting_1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
        }

        private void otaButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OTAUpdate(), groundPanel);
        }

        private void in4Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About(), groundPanel);
        }
    }
}
