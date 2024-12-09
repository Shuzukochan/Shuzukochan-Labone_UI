using System;
using System.Windows.Forms;

public class BaseForm : Form
{
    private Form? currentFormChild;
    protected void OpenChildForm(Form childForm, Panel groundPanel)
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
        this.BeginInvoke((MethodInvoker)delegate
        {
            this.Refresh();
        });
    }
}
