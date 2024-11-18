namespace CompanyDirectoryApp
{
    partial class EmployeeInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFixedPhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbServiceId;
        private System.Windows.Forms.ComboBox cmbLocationId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFixedPhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblServiceId;
        private System.Windows.Forms.Label lblLocationId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFixedPhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbServiceId = new System.Windows.Forms.ComboBox();
            this.cmbLocationId = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFixedPhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 27);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 27);
            // 
            // txtFixedPhone
            // 
            this.txtFixedPhone.Location = new System.Drawing.Point(120, 100);
            this.txtFixedPhone.Name = "txtFixedPhone";
            this.txtFixedPhone.Size = new System.Drawing.Size(200, 27);
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(120, 140);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(200, 27);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            // 
            // cmbServiceId
            // 
            this.cmbServiceId.Location = new System.Drawing.Point(120, 220);
            this.cmbServiceId.Name = "cmbServiceId";
            this.cmbServiceId.Size = new System.Drawing.Size(200, 28);
            // 
            // cmbLocationId
            // 
            this.cmbLocationId.Location = new System.Drawing.Point(120, 260);
            this.cmbLocationId.Name = "cmbLocationId";
            this.cmbLocationId.Size = new System.Drawing.Size(200, 28);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitButton_Click);

            // Labels
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 25);
            this.lblFirstName.Text = "First Name:";

            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 65);
            this.lblLastName.Text = "Last Name:";

            this.lblFixedPhone.AutoSize = true;
            this.lblFixedPhone.Location = new System.Drawing.Point(20, 105);
            this.lblFixedPhone.Text = "Fixed Phone:";

            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(20, 145);
            this.lblMobilePhone.Text = "Mobile Phone:";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 185);
            this.lblEmail.Text = "Email:";

            this.lblServiceId.AutoSize = true;
            this.lblServiceId.Location = new System.Drawing.Point(20, 225);
            this.lblServiceId.Text = "Service:";

            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Location = new System.Drawing.Point(20, 265);
            this.lblLocationId.Text = "Location:";

            // Add controls to the form
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFixedPhone);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbServiceId);
            this.Controls.Add(this.cmbLocationId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFixedPhone);
            this.Controls.Add(this.lblMobilePhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblServiceId);
            this.Controls.Add(this.lblLocationId);

            this.Text = "Employee Input Form";
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
