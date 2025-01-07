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
    public partial class Distribution_1 : BaseForm
    {
        public Distribution_1(string programName)
        {
            InitializeComponent();
            programNameLabel.Text = programName;
            if (programName == "Program 10")
            {
                programNameLabel.Location = new Point(173, 6);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 96; i++)
            {
                string buttonName = $"shuzukoButton{i}";
                Control[] foundControls = this.Controls.Find(buttonName, true);
                if (foundControls.Length > 0 && foundControls[0] is Button button)
                {
                    button.BackColor = Color.LightGray;
                    GlobalVariables.ButtonStates_1[i - 1] = false;
                }
            }
        }

        private void fullButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 96; i++)
            {
                string buttonName = $"shuzukoButton{i}";
                Control[] foundControls = this.Controls.Find(buttonName, true);
                if (foundControls.Length > 0 && foundControls[0] is Button button)
                {
                    button.BackColor = Color.Red;
                    GlobalVariables.ButtonStates_1[i - 1] = true;
                }
            }
        }

        private void Distribution_1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 96; i++)
            {
                string buttonName = $"shuzukoButton{i}";
                Control[] foundControls = this.Controls.Find(buttonName, true);

                if (foundControls.Length > 0 && foundControls[0] is Button button)
                {
                    button.Click += ShuzukoButton_Click;
                }
            }
        }
        private void ShuzukoButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int index = int.Parse(button.Name.Replace("shuzukoButton", "")) - 1;

                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.LightGray;
                    GlobalVariables.ButtonStates_1[index] = false;
                }
                else
                {
                    button.BackColor = Color.Red;
                    GlobalVariables.ButtonStates_1[index] = true;
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
        }
    }
}
