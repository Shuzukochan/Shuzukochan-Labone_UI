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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shuzukoPanel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
