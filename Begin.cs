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
    public partial class Begin : Form
    {
        private Form? currentFormChild; // Cho phép nullable để tránh cảnh báo CS8618

        public Begin()
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

        private void settingButton_Click(object sender, EventArgs e)
        {
            // Mở form cài đặt
            OpenChildForm(new Setting());

            // Ẩn các panel
            leftPanel.Visible = false;
            midPanel.Visible = false;
            rightPanel.Visible = false;
        }
    }
}

