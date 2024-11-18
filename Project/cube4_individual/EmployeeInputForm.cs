using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class EmployeeInputForm : Form
    {
        private int? employeeId;

        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public string FixedPhone => txtFixedPhone.Text;
        public string MobilePhone => txtMobilePhone.Text;
        public string Email => txtEmail.Text;
        public int ServiceId
        {
            get
            {
                return cmbServiceId.SelectedValue != null ? (int)cmbServiceId.SelectedValue : 0;
            }
        }

        public int LocationId
        {
            get
            {
                return cmbLocationId.SelectedValue != null ? (int)cmbLocationId.SelectedValue : 0;
            }
        }



        public EmployeeInputForm(int? id = null)
        {
            InitializeComponent();
            this.employeeId = id;

            if (id.HasValue)
            {
                LoadEmployeeData(id.Value);
            }
            LoadDropdownData();
        }

        private void LoadEmployeeData(int id)
        {
            var dbManager = new DatabaseManager();
            var employee = dbManager.GetEmployeeById(id);

            if (employee != null)
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtFixedPhone.Text = employee.FixedPhone;
                txtMobilePhone.Text = employee.MobilePhone;
                txtEmail.Text = employee.Email;
                cmbServiceId.SelectedValue = employee.ServiceId;
                cmbLocationId.SelectedValue = employee.LocationId;
            }
        }

        private void LoadDropdownData()
        {
            var dbManager = new DatabaseManager();

            // Load services
            var services = dbManager.GetServices();
            if (services.Count == 0)
            {
                MessageBox.Show("No services found. Please check your database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmbServiceId.DataSource = services;
            cmbServiceId.DisplayMember = "ServiceName"; // Matches the property in the Service class
            cmbServiceId.ValueMember = "Id"; // Matches the property in the Service class

            // Load locations
            var locations = dbManager.GetLocations();
            if (locations.Count == 0)
            {
                MessageBox.Show("No locations found. Please check your database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmbLocationId.DataSource = locations;
            cmbLocationId.DisplayMember = "City"; // Matches the property in the Location class
            cmbLocationId.ValueMember = "Id"; // Matches the property in the Location class
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate form data if needed
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Close the form and return OK status if everything is valid
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
