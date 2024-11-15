namespace CompanyDirectoryApp
{
    partial class PasswordPrompt
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SubmitButton;

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
            PasswordTextBox = new TextBox();
            SubmitButton = new Button();
            SuspendLayout();

            // PasswordTextBox
            PasswordTextBox.Location = new Point(12, 12);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(260, 27);
            PasswordTextBox.TabIndex = 0;
            PasswordTextBox.UseSystemPasswordChar = true;

            // SubmitButton
            SubmitButton.Location = new Point(12, 45);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(260, 29);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;

            // PasswordPrompt
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 86);
            Controls.Add(PasswordTextBox);
            Controls.Add(SubmitButton);
            Name = "PasswordPrompt";
            Text = "Enter Admin Password";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
