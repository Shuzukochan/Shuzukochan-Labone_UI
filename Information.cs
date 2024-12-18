using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labone_UI.Resources
{
    public partial class Information : BaseForm
    {
        public Information()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.BackColor == Color.White)
            {
                playButton.BackColor = Color.LimeGreen;
                playButton.ForeColor = Color.White;
            }
            else
            {
                playButton.BackColor = Color.White;
                playButton.ForeColor = Color.FromArgb(45, 48, 129);
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();

            });
            for (int i = 0; i < GlobalVariables.ButtonStates.Length; i++)
            {
                // Tên của Panel tương ứng
                string panelName = $"shuzukoPanel{i + 15}";

                // Tìm Panel trong giao diện
                Control[] foundPanels = this.Controls.Find(panelName, true);

                if (foundPanels.Length > 0 && foundPanels[0] is Panel panel)
                {
                    // Cập nhật màu của Panel dựa trên trạng thái trong ButtonStates
                    panel.BackColor = GlobalVariables.ButtonStates[i] ? Color.Red : Color.LightGray;
                }
            }
            for (int i = 0; i < GlobalVariables.ButtonStates_1.Length; i++)
            {
                // Tên của Panel tương ứng
                string panelName_1 = $"shuzukoPanel{i + 111}";

                // Tìm Panel trong giao diện
                Control[] foundPanels_1 = this.Controls.Find(panelName_1, true);

                if (foundPanels_1.Length > 0 && foundPanels_1[0] is Panel panel)
                {
                    // Cập nhật màu của Panel dựa trên trạng thái trong ButtonStates
                    panel.BackColor = GlobalVariables.ButtonStates_1[i] ? Color.Red : Color.LightGray;
                }
            }
            programNameLabel1.Text = GlobalVariables.ProgramName;
            programNameLabel1_1.Text = GlobalVariables.ProgramName;
            programNameLabel2.Text = GlobalVariables.ProgramName_1;
            programNameLabel2_1.Text = GlobalVariables.ProgramName_1;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
            leftPanel.Visible = false;
            midPanel.Visible = false;
        }
    }
}
