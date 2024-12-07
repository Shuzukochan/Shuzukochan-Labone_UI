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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groundPanel.Controls.Add(childForm);
            groundPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting());
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
