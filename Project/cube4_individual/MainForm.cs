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
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Detect key combination (e.g., Ctrl + Shift + A)
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                TriggerAdminMode();
            }
        }

        private void TriggerAdminMode()
        {
            if (!isAdminMode)
            {
                using (var passwordForm = new PasswordPrompt())
                {
                    if (passwordForm.ShowDialog() == DialogResult.OK && passwordForm.IsPasswordCorrect)
                    {
                        isAdminMode = true;
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
                MessageBox.Show("Admin mode disabled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAdminControls();
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
            SiteSearchComboBox.Items.Add("All Locations");
            ServiceSearchComboBox.Items.Add("All Services");

            var locations = dbManager.GetLocations();
            var services = dbManager.GetServices();

            SiteSearchComboBox.Items.AddRange(locations.ToArray());
            ServiceSearchComboBox.Items.AddRange(services.ToArray());

            SiteSearchComboBox.SelectedIndex = 0;
            ServiceSearchComboBox.SelectedIndex = 0;
        }

        private void EnableAdminControls()
        {
            // Code to enable CRUD controls for admin mode
        }

        private void DisableAdminControls()
        {
            // Code to disable CRUD controls
        }
    }
}
