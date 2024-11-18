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
                        MessageBox.Show("Employee added successfully.", "Success");
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee.", "Error");
                    }
                }
            }
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells["id"].Value);
                using (var inputForm = new EmployeeInputForm(selectedId))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        bool success = dbManager.UpdateEmployee(
                            selectedId,
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
                            MessageBox.Show("Employee updated successfully.", "Success");
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update employee.", "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to update.", "Info");
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells["id"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool success = dbManager.DeleteEmployee(selectedId);
                    if (success)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success");
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Info");
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
                        MessageBox.Show("Service added successfully.", "Success");
                        // Optionally refresh the data
                    }
                    else
                    {
                        MessageBox.Show("Failed to add service.", "Error");
                    }
                }
            }
        }

        private void UpdateServiceButton_Click(object sender, EventArgs e)
        {
            // Implement logic similar to UpdateEmployeeButton_Click
        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            // Implement logic similar to DeleteEmployeeButton_Click
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
                        MessageBox.Show("Location added successfully.", "Success");
                        // Optionally refresh the data
                    }
                    else
                    {
                        MessageBox.Show("Failed to add location.", "Error");
                    }
                }
            }
        }

        private void UpdateLocationButton_Click(object sender, EventArgs e)
        {
            // Implement logic similar to UpdateEmployeeButton_Click
        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            // Implement logic similar to DeleteEmployeeButton_Click
        }
    }
}
