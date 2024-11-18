using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    public partial class PasswordPrompt : Form
    {
        public bool IsPasswordCorrect { get; private set; }

        public PasswordPrompt()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "admin123") // Replace with a secure password check
            {
                IsPasswordCorrect = true;
                this.DialogResult = DialogResult.OK;

                // Open the AdminDashboardForm when the password is correct
                AdminDashboardForm adminDashboard = new AdminDashboardForm();
                adminDashboard.ShowDialog();
            }
            else
            {
                IsPasswordCorrect = false;
                MessageBox.Show("Incorrect password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
