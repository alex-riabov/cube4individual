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
            }
            else
            {
                IsPasswordCorrect = false;
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
