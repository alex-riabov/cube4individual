namespace CompanyDirectoryApp
{
    partial class LocationInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCity;

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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 20);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 27);

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitButton_Click);

            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 25);
            this.lblCity.Text = "City:";

            // 
            // LocationInputForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCity);
            this.Name = "LocationInputForm";
            this.Text = "Location Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
