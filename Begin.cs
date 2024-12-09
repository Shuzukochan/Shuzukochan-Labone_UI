using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Labone_UI
{
    public partial class Begin : BaseForm
    {
        public Begin()
        {
            InitializeComponent();

        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            // Mở form cài đặt
            OpenChildForm(new Setting(), groundPanel);

            // Ẩn các panel
            leftPanel.Visible = false;
            midPanel.Visible = false;
            rightPanel.Visible = false;
        }

        private void Begin_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
        }
    }
}

