using System;
using System.Windows.Forms;

public class BaseForm : Form
{
    private Form? currentFormChild;
    protected void OpenChildForm(Form childForm, Panel groundPanel)
    {
        currentFormChild?.Close();

        currentFormChild = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        groundPanel.Controls.Add(childForm);
        groundPanel.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
        this.BeginInvoke((MethodInvoker)delegate
        {
            this.Refresh();
        });
    }
}