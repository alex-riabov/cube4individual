using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class ServiceInputForm : Form
    {
        public string ServiceName => txtServiceName.Text;

        public ServiceInputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the service name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(ServiceName);
        }
    }
}
