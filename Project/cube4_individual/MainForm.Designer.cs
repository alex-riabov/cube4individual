namespace CompanyDirectoryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.TextBox NameSearchTextBox;
        private System.Windows.Forms.ComboBox SiteSearchComboBox;
        private System.Windows.Forms.ComboBox ServiceSearchComboBox;
        private System.Windows.Forms.Label NameSearchLabel;
        private System.Windows.Forms.Label LocationSearchLabel;
        private System.Windows.Forms.Label ServiceSearchLabel;

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
            NameSearchTextBox = new TextBox();
            SiteSearchComboBox = new ComboBox();
            ServiceSearchComboBox = new ComboBox();
            NameSearchLabel = new Label();
            LocationSearchLabel = new Label();
            ServiceSearchLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();

            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(245, 12);
            employeeDataGridView.Margin = new Padding(3, 4, 3, 4);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.Size = new Size(1005, 648);
            employeeDataGridView.TabIndex = 0;

            // 
            // NameSearchTextBox
            // 
            NameSearchTextBox.Location = new Point(12, 68);
            NameSearchTextBox.Name = "NameSearchTextBox";
            NameSearchTextBox.Size = new Size(227, 27);
            NameSearchTextBox.TabIndex = 1;

            // 
            // SiteSearchComboBox
            // 
            SiteSearchComboBox.FormattingEnabled = true;
            SiteSearchComboBox.Location = new Point(12, 143);
            SiteSearchComboBox.Name = "SiteSearchComboBox";
            SiteSearchComboBox.Size = new Size(227, 28);
            SiteSearchComboBox.TabIndex = 2;

            // 
            // ServiceSearchComboBox
            // 
            ServiceSearchComboBox.FormattingEnabled = true;
            ServiceSearchComboBox.Location = new Point(12, 217);
            ServiceSearchComboBox.Name = "ServiceSearchComboBox";
            ServiceSearchComboBox.Size = new Size(227, 28);
            ServiceSearchComboBox.TabIndex = 3;

            // 
            // NameSearchLabel
            // 
            NameSearchLabel.AutoSize = true;
            NameSearchLabel.Location = new Point(12, 45);
            NameSearchLabel.Name = "NameSearchLabel";
            NameSearchLabel.Size = new Size(124, 20);
            NameSearchLabel.Text = "Search by Name:";

            // 
            // LocationSearchLabel
            // 
            LocationSearchLabel.AutoSize = true;
            LocationSearchLabel.Location = new Point(12, 120);
            LocationSearchLabel.Name = "LocationSearchLabel";
            LocationSearchLabel.Size = new Size(110, 20);
            LocationSearchLabel.Text = "Filter by Location:";

            // 
            // ServiceSearchLabel
            // 
            ServiceSearchLabel.AutoSize = true;
            ServiceSearchLabel.Location = new Point(12, 194);
            ServiceSearchLabel.Name = "ServiceSearchLabel";
            ServiceSearchLabel.Size = new Size(105, 20);
            ServiceSearchLabel.Text = "Filter by Service:";

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(NameSearchLabel);
            Controls.Add(LocationSearchLabel);
            Controls.Add(ServiceSearchLabel);
            Controls.Add(ServiceSearchComboBox);
            Controls.Add(SiteSearchComboBox);
            Controls.Add(NameSearchTextBox);
            Controls.Add(employeeDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Company Directory";
            KeyPreview = true; // Allow KeyDown events to be detected
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
