using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class LocationInputForm : Form
    {
        public string City => txtCity.Text;

        public LocationInputForm()
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
                MessageBox.Show("Please fill in the city name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(City);
        }
    }
}
