using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class ServiceInputForm : Form
    {
        public int ServiceId { get; private set; }
        public string ServiceName => txtServiceName.Text;

        public ServiceInputForm()
        {
            InitializeComponent();
        }

        // Constructor for updating an existing service
        public ServiceInputForm(int serviceId)
        {
            InitializeComponent();
            ServiceId = serviceId;
            LoadServiceDetails();
        }

        private void LoadServiceDetails()
        {
            var service = new DatabaseManager().GetServiceById(ServiceId);
            if (service != null)
            {
                txtServiceName.Text = service.ServiceName;
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
                MessageBox.Show("Please fill in the service name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrEmpty(ServiceName);
        }
    }
}
