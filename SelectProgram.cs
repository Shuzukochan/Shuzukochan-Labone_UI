namespace Labone_UI
{
    public partial class SelectProgram : Form
    {
        private Form? currentFormChild; // Cho phép nullable để tránh cảnh báo CS8618
        public SelectProgram()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            // Đóng form con hiện tại nếu tồn tại
            currentFormChild?.Close();

            // Thiết lập form con mới
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel
            groundPanel.Controls.Add(childForm);
            groundPanel.Tag = childForm;

            // Hiển thị form con
            childForm.BringToFront();
            childForm.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.Refresh();
            });
            labelProgramCur.Visible = false;
        }

        private void leftPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Begin());
            // Ẩn các panel
            leftPanel.Visible = false;
            rightPanel.Visible = false;
        }

        private void program1Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 1";
        }

        private void program2Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 2";
        }

        private void program3Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 3";
        }

        private void program4Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 4";
        }

        private void program5Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 5";
        }

        private void program6Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 6";
        }

        private void program7Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 7";
        }

        private void program8Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 8";
        }

        private void program9Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Text = "Program 9";
        }

        private void program10Button_Click(object sender, EventArgs e)
        {
            labelProgramCur.Visible = true;
            labelProgramCur.Location = new Point(388,6);
            labelProgramCur.Text = "Program 10";
        }
    }
}
