using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class EmployeeInputForm : Form
    {
        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public string FixedPhone => txtFixedPhone.Text;
        public string MobilePhone => txtMobilePhone.Text;
        public string Email => txtEmail.Text;
        public int ServiceId => (int)cmbServiceId.SelectedValue;
        public int LocationId => (int)cmbLocationId.SelectedValue;

        public EmployeeInputForm()
        {
            InitializeComponent();
            LoadDropdownData();
        }
        private void LoadDropdownData()
        {
            try
            {
                var dbManager = new DatabaseManager();

                // Load services
                var services = dbManager.GetServices();
                if (services.Count == 0)
                {
                    MessageBox.Show("No services found. Please check your database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cmbServiceId.DataSource = services;

                // Load locations
                var locations = dbManager.GetLocations();
                if (locations.Count == 0)
                {
                    MessageBox.Show("No locations found. Please check your database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cmbLocationId.DataSource = locations;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            // Basic validation to ensure fields are filled
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(Email);
        }
    }
}
