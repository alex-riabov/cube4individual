namespace CompanyDirectoryApp
{
    partial class ServiceInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblServiceName;

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
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblServiceName = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(120, 20);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(200, 27);

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitButton_Click);

            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(20, 25);
            this.lblServiceName.Text = "Service Name:";

            // 
            // ServiceInputForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 120);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblServiceName);
            this.Name = "ServiceInputForm";
            this.Text = "Service Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
