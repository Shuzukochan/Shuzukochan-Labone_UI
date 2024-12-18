namespace Labone_UI
{
    public partial class DistributionLocation : BaseForm
    {
        public DistributionLocation()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProgramParameter(GlobalVariables.ProgramName), groundPanel);
        }
    }
}
