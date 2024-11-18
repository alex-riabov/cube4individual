using System;
using System.Data;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class AdminDashboardForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private DataTable employeeData;

        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                employeeData = dbManager.GetEmployees();
                employeeDataGridView.DataSource = employeeData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new EmployeeInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    bool success = dbManager.AddEmployee(
                        inputForm.FirstName,
                        inputForm.LastName,
                        inputForm.FixedPhone,
                        inputForm.MobilePhone,
                        inputForm.Email,
                        inputForm.ServiceId,
                        inputForm.LocationId
                    );

                    if (success)
                    {
                        MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeData(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new ServiceInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    bool success = dbManager.AddService(inputForm.ServiceName);

                    if (success)
                    {
                        MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally reload data if needed
                    }
                    else
                    {
                        MessageBox.Show("Failed to add service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new LocationInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    bool success = dbManager.AddLocation(inputForm.City);

                    if (success)
                    {
                        MessageBox.Show("Location added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally reload data if needed
                    }
                    else
                    {
                        MessageBox.Show("Failed to add location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            // Code to update an employee. You can use an input form to modify the selected employee's details.
            MessageBox.Show("Update Employee functionality not yet implemented.");
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            // Code to delete an employee.
            MessageBox.Show("Delete Employee functionality not yet implemented.");
        }

        private void UpdateServiceButton_Click(object sender, EventArgs e)
        {
            // Code to update a service. You can use an input form to modify the selected service's details.
            MessageBox.Show("Update Service functionality not yet implemented.");
        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            // Code to delete a service.
            MessageBox.Show("Delete Service functionality not yet implemented.");
        }

        private void UpdateLocationButton_Click(object sender, EventArgs e)
        {
            // Code to update a location. You can use an input form to modify the selected location's details.
            MessageBox.Show("Update Location functionality not yet implemented.");
        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            // Code to delete a location.
            MessageBox.Show("Delete Location functionality not yet implemented.");
        }

    }
}
