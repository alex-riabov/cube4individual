using System;
using System.Data;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private DataTable employeeData;
        private bool isAdminMode = false;

        public MainForm()
        {
            InitializeComponent();
            LoadEmployeeData();
            LoadLocationAndServiceFilters();

            // Event handlers for search and admin mode button
            NameSearchTextBox.TextChanged += NameSearchTextBox_TextChanged;
            SiteSearchComboBox.SelectedIndexChanged += SiteSearchComboBox_SelectedIndexChanged;
            ServiceSearchComboBox.SelectedIndexChanged += ServiceSearchComboBox_SelectedIndexChanged;
            AdminModeButton.Click += AdminModeButton_Click;
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
            SiteSearchComboBox.Items.Add("All Locations");
            ServiceSearchComboBox.Items.Add("All Services");

            var locations = dbManager.GetLocations();
            var services = dbManager.GetServices();

            SiteSearchComboBox.Items.AddRange(locations.ToArray());
            ServiceSearchComboBox.Items.AddRange(services.ToArray());

            SiteSearchComboBox.SelectedIndex = 0;
            ServiceSearchComboBox.SelectedIndex = 0;
        }

        private void NameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = NameSearchTextBox.Text.ToLower();
            DataView dv = employeeData.DefaultView;
            dv.RowFilter = $"first_name LIKE '%{filterText}%' OR last_name LIKE '%{filterText}%'";
            employeeDataGridView.DataSource = dv.ToTable();
        }

        private void SiteSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void ServiceSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string locationFilter = SiteSearchComboBox.SelectedItem.ToString() == "All Locations" ? "" : SiteSearchComboBox.SelectedItem.ToString();
            string serviceFilter = ServiceSearchComboBox.SelectedItem.ToString() == "All Services" ? "" : ServiceSearchComboBox.SelectedItem.ToString();

            DataView dv = employeeData.DefaultView;
            dv.RowFilter = $"(location LIKE '%{locationFilter}%' OR '{locationFilter}' = '') AND (service_name LIKE '%{serviceFilter}%' OR '{serviceFilter}' = '')";
            employeeDataGridView.DataSource = dv.ToTable();
        }

        private void AdminModeButton_Click(object sender, EventArgs e)
        {
            if (!isAdminMode)
            {
                using (var passwordForm = new PasswordPrompt())
                {
                    if (passwordForm.ShowDialog() == DialogResult.OK && passwordForm.IsPasswordCorrect)
                    {
                        isAdminMode = true;
                        AdminModeButton.Text = "Exit Admin Mode";
                        MessageBox.Show("Admin mode enabled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnableAdminControls();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                isAdminMode = false;
                AdminModeButton.Text = "Enter Admin Mode";
                MessageBox.Show("Admin mode disabled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAdminControls();
            }
        }

        private void EnableAdminControls()
        {
            // Code to enable CRUD controls for locations, services, and employees
        }

        private void DisableAdminControls()
        {
            // Code to disable CRUD controls
        }
    }
}
