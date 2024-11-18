namespace CompanyDirectoryApp
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.DataGridView locationDataGridView;
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
            serviceDataGridView = new DataGridView();
            locationDataGridView = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)serviceDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(20, 20);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.Size = new Size(800, 200);
            employeeDataGridView.TabIndex = 0;
            // 
            // serviceDataGridView
            // 
            serviceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceDataGridView.Location = new Point(20, 230);
            serviceDataGridView.Name = "serviceDataGridView";
            serviceDataGridView.RowHeadersWidth = 51;
            serviceDataGridView.Size = new Size(341, 200);
            serviceDataGridView.TabIndex = 1;
            // 
            // locationDataGridView
            // 
            locationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationDataGridView.Location = new Point(20, 440);
            locationDataGridView.Name = "locationDataGridView";
            locationDataGridView.RowHeadersWidth = 51;
            locationDataGridView.Size = new Size(341, 200);
            locationDataGridView.TabIndex = 2;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(850, 20);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(150, 30);
            AddEmployeeButton.TabIndex = 3;
            AddEmployeeButton.Text = "Add Employee";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // UpdateEmployeeButton
            // 
            UpdateEmployeeButton.Location = new Point(850, 60);
            UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            UpdateEmployeeButton.Size = new Size(150, 30);
            UpdateEmployeeButton.TabIndex = 4;
            UpdateEmployeeButton.Text = "Update Employee";
            UpdateEmployeeButton.UseVisualStyleBackColor = true;
            UpdateEmployeeButton.Click += UpdateEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new Point(850, 100);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(150, 30);
            DeleteEmployeeButton.TabIndex = 5;
            DeleteEmployeeButton.Text = "Delete Employee";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // AddServiceButton
            // 
            AddServiceButton.Location = new Point(392, 230);
            AddServiceButton.Name = "AddServiceButton";
            AddServiceButton.Size = new Size(150, 30);
            AddServiceButton.TabIndex = 6;
            AddServiceButton.Text = "Add Service";
            AddServiceButton.UseVisualStyleBackColor = true;
            AddServiceButton.Click += AddServiceButton_Click;
            // 
            // UpdateServiceButton
            // 
            UpdateServiceButton.Location = new Point(392, 270);
            UpdateServiceButton.Name = "UpdateServiceButton";
            UpdateServiceButton.Size = new Size(150, 30);
            UpdateServiceButton.TabIndex = 7;
            UpdateServiceButton.Text = "Update Service";
            UpdateServiceButton.UseVisualStyleBackColor = true;
            UpdateServiceButton.Click += UpdateServiceButton_Click;
            // 
            // DeleteServiceButton
            // 
            DeleteServiceButton.Location = new Point(392, 310);
            DeleteServiceButton.Name = "DeleteServiceButton";
            DeleteServiceButton.Size = new Size(150, 30);
            DeleteServiceButton.TabIndex = 8;
            DeleteServiceButton.Text = "Delete Service";
            DeleteServiceButton.UseVisualStyleBackColor = true;
            DeleteServiceButton.Click += DeleteServiceButton_Click;
            // 
            // AddLocationButton
            // 
            AddLocationButton.Location = new Point(392, 440);
            AddLocationButton.Name = "AddLocationButton";
            AddLocationButton.Size = new Size(150, 30);
            AddLocationButton.TabIndex = 9;
            AddLocationButton.Text = "Add Location";
            AddLocationButton.UseVisualStyleBackColor = true;
            AddLocationButton.Click += AddLocationButton_Click;
            // 
            // UpdateLocationButton
            // 
            UpdateLocationButton.Location = new Point(392, 480);
            UpdateLocationButton.Name = "UpdateLocationButton";
            UpdateLocationButton.Size = new Size(150, 30);
            UpdateLocationButton.TabIndex = 10;
            UpdateLocationButton.Text = "Update Location";
            UpdateLocationButton.UseVisualStyleBackColor = true;
            UpdateLocationButton.Click += UpdateLocationButton_Click;
            // 
            // DeleteLocationButton
            // 
            DeleteLocationButton.Location = new Point(392, 520);
            DeleteLocationButton.Name = "DeleteLocationButton";
            DeleteLocationButton.Size = new Size(150, 30);
            DeleteLocationButton.TabIndex = 11;
            DeleteLocationButton.Text = "Delete Location";
            DeleteLocationButton.UseVisualStyleBackColor = true;
            DeleteLocationButton.Click += DeleteLocationButton_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 680);
            Controls.Add(employeeDataGridView);
            Controls.Add(serviceDataGridView);
            Controls.Add(locationDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)serviceDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
