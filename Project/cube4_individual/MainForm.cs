using System;
using System.Data;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private DataTable employeeData;

        public MainForm()
        {
            InitializeComponent();
            LoadEmployeeData();
            LoadLocationAndServiceFilters();
            this.KeyDown += MainForm_KeyDown; // Ensure the KeyDown event is wired up
            this.KeyPreview = true; // Ensure the form captures key events
            employeeDataGridView.MultiSelect = false;
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGridView.AllowUserToAddRows = false;
            NameSearchTextBox.TextChanged += NameSearchTextBox_TextChanged;
            SiteSearchComboBox.SelectedIndexChanged += SiteSearchComboBox_SelectedIndexChanged;
            ServiceSearchComboBox.SelectedIndexChanged += ServiceSearchComboBox_SelectedIndexChanged;
        }

        private bool isPasswordFormOpen = false; // Flag to track if the form is open

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Detect key combination (e.g., Ctrl + Alt + A)
            if (e.Control && e.Alt && e.KeyCode == Keys.A)
            {
                OpenPasswordForm();
            }
        }


        private void OpenPasswordForm()
        {
            using (var passwordForm = new PasswordPrompt())
            {
                DialogResult result = passwordForm.ShowDialog();
                if (result == DialogResult.OK && passwordForm.IsPasswordCorrect)
                {
                    // Code to handle successful password entry (e.g., enabling admin mode)
                }
                else if (result != DialogResult.Cancel && !passwordForm.IsPasswordCorrect)
                {
                    // Show the message only if the user entered an incorrect password
                    MessageBox.Show("Incorrect password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void LoadLocationAndServiceFilters()
        {
            // Create empty fields for "no filter" options
            Location emptyLocation = new Location { Id = 0, City = "" }; // Represents no filter
            Service emptyService = new Service { Id = 0, ServiceName = "" }; // Represents no filter

            // Load locations and services from the database
            var locations = dbManager.GetLocations();
            var services = dbManager.GetServices();

            // Add empty options at the beginning
            locations.Insert(0, emptyLocation);
            services.Insert(0, emptyService);

            // Set DisplayMember for services and locations
            SiteSearchComboBox.DisplayMember = "City";
            SiteSearchComboBox.ValueMember = "Id";
            SiteSearchComboBox.DataSource = locations;

            ServiceSearchComboBox.DisplayMember = "ServiceName";
            ServiceSearchComboBox.ValueMember = "Id";
            ServiceSearchComboBox.DataSource = services;

            // Select the empty options as default
            SiteSearchComboBox.SelectedIndex = 0;
            ServiceSearchComboBox.SelectedIndex = 0;
        }


        private void NameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterEmployeeData();
        }

        private void SiteSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployeeData();
        }

        private void ServiceSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployeeData();
        }

        private void FilterEmployeeData()
        {
            if (employeeData == null) return;

            string nameFilter = NameSearchTextBox.Text.Trim().ToLower();
            string selectedLocation = SiteSearchComboBox.SelectedItem is Location location && !string.IsNullOrEmpty(location.City) ? location.City : null;
            string selectedService = ServiceSearchComboBox.SelectedItem is Service service && !string.IsNullOrEmpty(service.ServiceName) ? service.ServiceName : null;

            // Create a DataView for filtering
            DataView dataView = new DataView(employeeData);

            // Build the filter expression
            List<string> filterExpressions = new List<string>();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                filterExpressions.Add($"(CONVERT(first_name, System.String) LIKE '%{nameFilter}%' OR CONVERT(last_name, System.String) LIKE '%{nameFilter}%')");
            }

            if (!string.IsNullOrEmpty(selectedLocation) && selectedLocation != "All Locations")
            {
                filterExpressions.Add($"location = '{selectedLocation.Replace("'", "''")}'"); // Escaping single quotes
            }

            if (!string.IsNullOrEmpty(selectedService) && selectedService != "All Services")
            {
                filterExpressions.Add($"service_name = '{selectedService.Replace("'", "''")}'"); // Escaping single quotes
            }

            // Combine the filter expressions and apply them
            dataView.RowFilter = filterExpressions.Count > 0 ? string.Join(" AND ", filterExpressions) : string.Empty;

            // Check if the filtered DataView has any rows and update the DataGridView accordingly
            employeeDataGridView.DataSource = dataView.Count > 0 ? dataView : null;
        }





    }
}
