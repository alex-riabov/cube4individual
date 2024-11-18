namespace CompanyDirectoryApp
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button UpdateServiceButton;
        private System.Windows.Forms.Button DeleteServiceButton;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button UpdateLocationButton;
        private System.Windows.Forms.Button DeleteLocationButton;

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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.UpdateServiceButton = new System.Windows.Forms.Button();
            this.DeleteServiceButton = new System.Windows.Forms.Button();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.UpdateLocationButton = new System.Windows.Forms.Button();
            this.DeleteLocationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(20, 20);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(800, 400);
            this.employeeDataGridView.TabIndex = 0;

            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(850, 20);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(150, 30);
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);

            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(850, 60);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(150, 30);
            this.UpdateEmployeeButton.Text = "Update Employee";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);

            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(850, 100);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);

            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Location = new System.Drawing.Point(850, 140);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(150, 30);
            this.AddServiceButton.Text = "Add Service";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);

            // 
            // UpdateServiceButton
            // 
            this.UpdateServiceButton.Location = new System.Drawing.Point(850, 180);
            this.UpdateServiceButton.Name = "UpdateServiceButton";
            this.UpdateServiceButton.Size = new System.Drawing.Size(150, 30);
            this.UpdateServiceButton.Text = "Update Service";
            this.UpdateServiceButton.UseVisualStyleBackColor = true;
            this.UpdateServiceButton.Click += new System.EventHandler(this.UpdateServiceButton_Click);

            // 
            // DeleteServiceButton
            // 
            this.DeleteServiceButton.Location = new System.Drawing.Point(850, 220);
            this.DeleteServiceButton.Name = "DeleteServiceButton";
            this.DeleteServiceButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteServiceButton.Text = "Delete Service";
            this.DeleteServiceButton.UseVisualStyleBackColor = true;
            this.DeleteServiceButton.Click += new System.EventHandler(this.DeleteServiceButton_Click);

            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(850, 260);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(150, 30);
            this.AddLocationButton.Text = "Add Location";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);

            // 
            // UpdateLocationButton
            // 
            this.UpdateLocationButton.Location = new System.Drawing.Point(850, 300);
            this.UpdateLocationButton.Name = "UpdateLocationButton";
            this.UpdateLocationButton.Size = new System.Drawing.Size(150, 30);
            this.UpdateLocationButton.Text = "Update Location";
            this.UpdateLocationButton.UseVisualStyleBackColor = true;
            this.UpdateLocationButton.Click += new System.EventHandler(this.UpdateLocationButton_Click);

            // 
            // DeleteLocationButton
            // 
            this.DeleteLocationButton.Location = new System.Drawing.Point(850, 340);
            this.DeleteLocationButton.Name = "DeleteLocationButton";
            this.DeleteLocationButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteLocationButton.Text = "Delete Location";
            this.DeleteLocationButton.UseVisualStyleBackColor = true;
            this.DeleteLocationButton.Click += new System.EventHandler(this.DeleteLocationButton_Click);

            // 
            // AdminDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.UpdateServiceButton);
            this.Controls.Add(this.DeleteServiceButton);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.UpdateLocationButton);
            this.Controls.Add(this.DeleteLocationButton);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
