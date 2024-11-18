using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class LocationInputForm : Form
    {
        public int LocationId { get; private set; }
        public string City => txtCity.Text;

        public LocationInputForm()
        {
            InitializeComponent();
        }

        // Constructor for updating an existing location
        public LocationInputForm(int locationId)
        {
            InitializeComponent();
            LocationId = locationId;
            LoadLocationDetails();
        }

        private void LoadLocationDetails()
        {
            var location = new DatabaseManager().GetLocationById(LocationId);
            if (location != null)
            {
                txtCity.Text = location.City;
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
                MessageBox.Show("Please fill in the city name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(City);
        }
    }
}
