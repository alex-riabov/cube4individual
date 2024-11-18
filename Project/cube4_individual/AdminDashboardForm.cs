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

        // Event handler for adding an employee
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            // Code for adding an employee (to be implemented)
            MessageBox.Show("Add Employee functionality not yet implemented.");
        }

        // Event handler for updating an employee
        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            // Code for updating an employee (to be implemented)
            MessageBox.Show("Update Employee functionality not yet implemented.");
        }

        // Event handler for deleting an employee
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            // Code for deleting an employee (to be implemented)
            MessageBox.Show("Delete Employee functionality not yet implemented.");
        }

        // Event handler for adding a service
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            // Code for adding a service (to be implemented)
            MessageBox.Show("Add Service functionality not yet implemented.");
        }

        // Event handler for updating a service
        private void UpdateServiceButton_Click(object sender, EventArgs e)
        {
            // Code for updating a service (to be implemented)
            MessageBox.Show("Update Service functionality not yet implemented.");
        }

        // Event handler for deleting a service
        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            // Code for deleting a service (to be implemented)
            MessageBox.Show("Delete Service functionality not yet implemented.");
        }

        // Event handler for adding a location
        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            // Code for adding a location (to be implemented)
            MessageBox.Show("Add Location functionality not yet implemented.");
        }

        // Event handler for updating a location
        private void UpdateLocationButton_Click(object sender, EventArgs e)
        {
            // Code for updating a location (to be implemented)
            MessageBox.Show("Update Location functionality not yet implemented.");
        }

        // Event handler for deleting a location
        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            // Code for deleting a location (to be implemented)
            MessageBox.Show("Delete Location functionality not yet implemented.");
        }
    }
}
