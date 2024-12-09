using System;
using System.Windows.Forms;

public class BaseForm : Form
{
    private Form? currentFormChild;

    /// <summary>
    /// Phương thức dùng để mở form con bên trong groundPanel
    /// </summary>
    /// <param name="childForm">Form con cần hiển thị</param>
    /// <param name="groundPanel">Panel mà form con sẽ nằm trong</param>
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
