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
        private UInt16 state = 0;
        public SelectProgram(UInt16 stateMode)
        {
            InitializeComponent();
            state = stateMode;
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
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 1"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 1"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 1"), groundPanel);
                        GlobalVariables.ProgramName = "Program 1";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 1"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 1";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram2ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 2"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 2"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 2"), groundPanel);
                        GlobalVariables.ProgramName = "Program 2";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 2"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 2";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram3ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 3"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 3"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 3"), groundPanel);
                        GlobalVariables.ProgramName = "Program 3";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 3"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 3";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram4ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 4"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 4"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 4"), groundPanel);
                        GlobalVariables.ProgramName = "Program 4";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 4"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 4";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram5ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 5"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 5"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 5"), groundPanel);
                        GlobalVariables.ProgramName = "Program 5";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 5"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 5";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram6ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 6"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 6"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 6"), groundPanel);
                        GlobalVariables.ProgramName = "Program 6";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 6"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 6";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram7ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 7"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 7"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 7"), groundPanel);
                        GlobalVariables.ProgramName = "Program 7";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 7"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 7";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram8ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 8"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 8"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 8"), groundPanel);
                        GlobalVariables.ProgramName = "Program 8";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 8"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 8";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram9ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 9"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 9"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false)
                    {
                        OpenChildForm(new Distribution("Program 9"), groundPanel);
                        GlobalVariables.ProgramName = "Program 9";
                    }
                    else
                    {
                        OpenChildForm(new Distribution_1("Program 9"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 9";
                    }

                }

                // Ẩn các panel không cần thiết
                leftPanel.Visible = false;
                rightPanel.Visible = false;

                // Reset cờ sau khi hoàn thành
                isProgram1ButtonClicked = false;
            }

            if (isProgram10ButtonClicked)
            {
                if (state == 0)
                {
                    OpenChildForm(new ProgramParameter("Program 10"), groundPanel);
                }
                else if (state == 1) OpenChildForm(new ProgramParameter_1("Program 10"), groundPanel);
                else
                {
                    if (GlobalVariables.AreaState == false) 
                    {
                        OpenChildForm(new Distribution("Program 10"), groundPanel);
                        GlobalVariables.ProgramName = "Program 10";
                    }
                    else 
                    {
                        OpenChildForm(new Distribution_1("Program 10"), groundPanel);
                        GlobalVariables.ProgramName_1 = "Program 10"; 
                    }

                }

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
