namespace Labone_UI
{
    public partial class SelectProgram : BaseForm
    {
        private bool isProgram1ButtonClicked = false;
        private bool isProgram2ButtonClicked = false;
        private bool isProgram3ButtonClicked = false;
        private bool isProgram4ButtonClicked = false;
        private bool isProgram5ButtonClicked = false;
        private bool isProgram6ButtonClicked = false;
        private bool isProgram7ButtonClicked = false;
        private bool isProgram8ButtonClicked = false;
        private bool isProgram9ButtonClicked = false;
        private bool isProgram10ButtonClicked = false;
        private bool iscalibMode = false;
        public SelectProgram(bool calibMode)
        {
            InitializeComponent();
            iscalibMode = calibMode;
        }
        private void SelectProgram_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
            labelProgramCur.Visible = false;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin(), groundPanel);
            // Ẩn các panel
            leftPanel.Visible = false;
            rightPanel.Visible = false;
        }

        private void program1Button_Click(object sender, EventArgs e)
        {
            isProgram1ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 1";
        }

        private void program2Button_Click(object sender, EventArgs e)
        {
            isProgram2ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 2";
        }

        private void program3Button_Click(object sender, EventArgs e)
        {
            isProgram3ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 3";
        }

        private void program4Button_Click(object sender, EventArgs e)
        {
            isProgram4ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 4";
        }

        private void program5Button_Click(object sender, EventArgs e)
        {
            isProgram5ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 5";
        }

        private void program6Button_Click(object sender, EventArgs e)
        {
            isProgram6ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 6";
        }

        private void program7Button_Click(object sender, EventArgs e)
        {
            isProgram7ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 7";
        }

        private void program8Button_Click(object sender, EventArgs e)
        {
            isProgram8ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 8";
        }

        private void program9Button_Click(object sender, EventArgs e)
        {
            isProgram9ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 9";
        }

        private void program10Button_Click(object sender, EventArgs e)
        {
            isProgram10ButtonClicked = true;
            labelProgramCur.Visible = true;
            labelProgramCur.Location = new Point(388, 6);
            labelProgramCur.Text = "Program 10";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (isProgram1ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 1"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 1"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram2ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 2"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 2"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram3ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 3"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 3"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram4ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 4"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 4"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram5ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 5"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 5"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram6ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 6"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 6"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram7ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 7"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 7"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram8ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 8"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 8"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram9ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 9"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 9"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram10ButtonClicked)
            {
                if (iscalibMode == false)
                {
                    OpenChildForm(new ProgramParameter("Program 10"), groundPanel);
                }
                else OpenChildForm(new ProgramParameter_1("Program 10"), groundPanel);

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Setting(), groundPanel);
            leftPanel.Visible = false;
            rightPanel.Visible = false;
        }
    }
}
