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
            employeeDataGridView = new DataGridView();
            AddEmployeeButton = new Button();
            UpdateEmployeeButton = new Button();
            DeleteEmployeeButton = new Button();
            AddServiceButton = new Button();
            UpdateServiceButton = new Button();
            DeleteServiceButton = new Button();
            AddLocationButton = new Button();
            UpdateLocationButton = new Button();
            DeleteLocationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(20, 20);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.Size = new Size(800, 400);
            employeeDataGridView.TabIndex = 0;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(850, 20);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(150, 30);
            AddEmployeeButton.TabIndex = 1;
            AddEmployeeButton.Text = "Add Employee";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // UpdateEmployeeButton
            // 
            UpdateEmployeeButton.Location = new Point(850, 60);
            UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            UpdateEmployeeButton.Size = new Size(150, 30);
            UpdateEmployeeButton.TabIndex = 2;
            UpdateEmployeeButton.Text = "Update Employee";
            UpdateEmployeeButton.UseVisualStyleBackColor = true;
            UpdateEmployeeButton.Click += UpdateEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new Point(850, 100);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(150, 30);
            DeleteEmployeeButton.TabIndex = 3;
            DeleteEmployeeButton.Text = "Delete Employee";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // AddServiceButton
            // 
            AddServiceButton.Location = new Point(850, 163);
            AddServiceButton.Name = "AddServiceButton";
            AddServiceButton.Size = new Size(150, 30);
            AddServiceButton.TabIndex = 4;
            AddServiceButton.Text = "Add Service";
            AddServiceButton.UseVisualStyleBackColor = true;
            AddServiceButton.Click += AddServiceButton_Click;
            // 
            // UpdateServiceButton
            // 
            UpdateServiceButton.Location = new Point(850, 203);
            UpdateServiceButton.Name = "UpdateServiceButton";
            UpdateServiceButton.Size = new Size(150, 30);
            UpdateServiceButton.TabIndex = 5;
            UpdateServiceButton.Text = "Update Service";
            UpdateServiceButton.UseVisualStyleBackColor = true;
            UpdateServiceButton.Click += UpdateServiceButton_Click;
            // 
            // DeleteServiceButton
            // 
            DeleteServiceButton.Location = new Point(850, 243);
            DeleteServiceButton.Name = "DeleteServiceButton";
            DeleteServiceButton.Size = new Size(150, 30);
            DeleteServiceButton.TabIndex = 6;
            DeleteServiceButton.Text = "Delete Service";
            DeleteServiceButton.UseVisualStyleBackColor = true;
            DeleteServiceButton.Click += DeleteServiceButton_Click;
            // 
            // AddLocationButton
            // 
            AddLocationButton.Location = new Point(850, 309);
            AddLocationButton.Name = "AddLocationButton";
            AddLocationButton.Size = new Size(150, 30);
            AddLocationButton.TabIndex = 7;
            AddLocationButton.Text = "Add Location";
            AddLocationButton.UseVisualStyleBackColor = true;
            AddLocationButton.Click += AddLocationButton_Click;
            // 
            // UpdateLocationButton
            // 
            UpdateLocationButton.Location = new Point(850, 349);
            UpdateLocationButton.Name = "UpdateLocationButton";
            UpdateLocationButton.Size = new Size(150, 30);
            UpdateLocationButton.TabIndex = 8;
            UpdateLocationButton.Text = "Update Location";
            UpdateLocationButton.UseVisualStyleBackColor = true;
            UpdateLocationButton.Click += UpdateLocationButton_Click;
            // 
            // DeleteLocationButton
            // 
            DeleteLocationButton.Location = new Point(850, 389);
            DeleteLocationButton.Name = "DeleteLocationButton";
            DeleteLocationButton.Size = new Size(150, 30);
            DeleteLocationButton.TabIndex = 9;
            DeleteLocationButton.Text = "Delete Location";
            DeleteLocationButton.UseVisualStyleBackColor = true;
            DeleteLocationButton.Click += DeleteLocationButton_Click;
            // 
            // AdminDashboardForm
            // 
            ClientSize = new Size(1262, 673);
            Controls.Add(employeeDataGridView);
            Controls.Add(AddEmployeeButton);
            Controls.Add(UpdateEmployeeButton);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(AddServiceButton);
            Controls.Add(UpdateServiceButton);
            Controls.Add(DeleteServiceButton);
            Controls.Add(AddLocationButton);
            Controls.Add(UpdateLocationButton);
            Controls.Add(DeleteLocationButton);
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
