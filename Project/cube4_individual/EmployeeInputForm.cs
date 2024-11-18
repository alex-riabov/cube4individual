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
                // Create an instance of DatabaseManager
                var dbManager = new DatabaseManager();

                // Load services into the Service dropdown
                cmbServiceId.DataSource = dbManager.GetServices(); // Call GetServices() using the instance
                cmbServiceId.DisplayMember = "ServiceName"; // Ensure this matches the property name in the Service class
                cmbServiceId.ValueMember = "Id"; // Ensure this matches the property name in the Service class

                // Load locations into the Location dropdown
                cmbLocationId.DataSource = dbManager.GetLocations(); // Call GetLocations() using the instance
                cmbLocationId.DisplayMember = "City"; // Ensure this matches the property name in the Location class
                cmbLocationId.ValueMember = "Id"; // Ensure this matches the property name in the Location class
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
