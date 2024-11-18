using System;
using System.Data;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class AdminDashboardForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private DataTable employeeData;
        private DataTable serviceData;
        private DataTable locationData;

        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadEmployeeData();
            LoadServiceData();
            LoadLocationData();

            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGridView.AllowUserToAddRows = false;

            serviceDataGridView.ReadOnly = true;
            serviceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceDataGridView.AllowUserToAddRows = false;

            locationDataGridView.ReadOnly = true;
            locationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            locationDataGridView.AllowUserToAddRows = false;
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
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadServiceData()
        {
            try
            {
                serviceData = dbManager.GetServicesTable();
                serviceDataGridView.DataSource = serviceData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLocationData()
        {
            try
            {
                locationData = dbManager.GetLocationsTable();
                locationDataGridView.DataSource = locationData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading location data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        LoadServiceData();
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
            if (serviceDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(serviceDataGridView.SelectedRows[0].Cells["id"].Value);
                using (var inputForm = new ServiceInputForm(selectedId))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        bool success = dbManager.UpdateService(selectedId, inputForm.ServiceName);
                        if (success)
                        {
                            MessageBox.Show("Service updated successfully.", "Success");
                            LoadServiceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update service.", "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a service to update.", "Info");
            }
        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            if (serviceDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(serviceDataGridView.SelectedRows[0].Cells["id"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        bool success = dbManager.DeleteService(selectedId);
                        if (success)
                        {
                            MessageBox.Show("Service deleted successfully.", "Success");
                            LoadServiceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete service.", "Error");
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Show warning if service is in use
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a service to delete.", "Info");
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
                        MessageBox.Show("Location added successfully.", "Success");
                        LoadLocationData();
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
            if (locationDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(locationDataGridView.SelectedRows[0].Cells["id"].Value);
                using (var inputForm = new LocationInputForm(selectedId))
                {
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        bool success = dbManager.UpdateLocation(selectedId, inputForm.City);
                        if (success)
                        {
                            MessageBox.Show("Location updated successfully.", "Success");
                            LoadLocationData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update location.", "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a location to update.", "Info");
            }
        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            if (locationDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(locationDataGridView.SelectedRows[0].Cells["id"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this location?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        bool success = dbManager.DeleteLocation(selectedId);
                        if (success)
                        {
                            MessageBox.Show("Location deleted successfully.", "Success");
                            LoadLocationData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete location.", "Error");
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Show warning if location is in use
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a location to delete.", "Info");
            }
        }

    }
}
