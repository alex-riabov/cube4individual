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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            employeeDataGridView = new DataGridView();
            NameSearchTextBox = new TextBox();
            SiteSearchComboBox = new ComboBox();
            ServiceSearchComboBox = new ComboBox();
            NameSearchLabel = new Label();
            LocationSearchLabel = new Label();
            ServiceSearchLabel = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(12, 12);
            employeeDataGridView.Margin = new Padding(3, 4, 3, 4);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.Size = new Size(952, 648);
            employeeDataGridView.TabIndex = 0;
            // 
            // NameSearchTextBox
            // 
            NameSearchTextBox.Location = new Point(986, 241);
            NameSearchTextBox.Name = "NameSearchTextBox";
            NameSearchTextBox.Size = new Size(227, 27);
            NameSearchTextBox.TabIndex = 1;
            // 
            // SiteSearchComboBox
            // 
            SiteSearchComboBox.FormattingEnabled = true;
            SiteSearchComboBox.Location = new Point(986, 316);
            SiteSearchComboBox.Name = "SiteSearchComboBox";
            SiteSearchComboBox.Size = new Size(227, 28);
            SiteSearchComboBox.TabIndex = 2;
            // 
            // ServiceSearchComboBox
            // 
            ServiceSearchComboBox.FormattingEnabled = true;
            ServiceSearchComboBox.Location = new Point(986, 390);
            ServiceSearchComboBox.Name = "ServiceSearchComboBox";
            ServiceSearchComboBox.Size = new Size(227, 28);
            ServiceSearchComboBox.TabIndex = 3;
            // 
            // NameSearchLabel
            // 
            NameSearchLabel.AutoSize = true;
            NameSearchLabel.Location = new Point(986, 218);
            NameSearchLabel.Name = "NameSearchLabel";
            NameSearchLabel.Size = new Size(120, 20);
            NameSearchLabel.TabIndex = 0;
            NameSearchLabel.Text = "Search by Name:";
            // 
            // LocationSearchLabel
            // 
            LocationSearchLabel.AutoSize = true;
            LocationSearchLabel.Location = new Point(986, 293);
            LocationSearchLabel.Name = "LocationSearchLabel";
            LocationSearchLabel.Size = new Size(126, 20);
            LocationSearchLabel.TabIndex = 1;
            LocationSearchLabel.Text = "Filter by Location:";
            // 
            // ServiceSearchLabel
            // 
            ServiceSearchLabel.AutoSize = true;
            ServiceSearchLabel.Location = new Point(986, 367);
            ServiceSearchLabel.Name = "ServiceSearchLabel";
            ServiceSearchLabel.Size = new Size(116, 20);
            ServiceSearchLabel.TabIndex = 2;
            ServiceSearchLabel.Text = "Filter by Service:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(986, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 187);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox1);
            Controls.Add(NameSearchLabel);
            Controls.Add(LocationSearchLabel);
            Controls.Add(ServiceSearchLabel);
            Controls.Add(ServiceSearchComboBox);
            Controls.Add(SiteSearchComboBox);
            Controls.Add(NameSearchTextBox);
            Controls.Add(employeeDataGridView);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Company Directory";
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
