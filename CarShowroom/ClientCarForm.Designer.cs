namespace CarShowroom
{
    partial class ClientCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCarForm));
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.specsComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.specsLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandLabel.Location = new System.Drawing.Point(23, 32);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 15);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Ferrari",
            "Ford",
            "GM",
            "GEM",
            "GMC",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Isuzu",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "Mitsubishi",
            "Nissan",
            "Oldsmobile",
            "Peugeot",
            "Pontiac",
            "Porsche",
            "Regal",
            "Saab",
            "Saturn",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.brandComboBox.Location = new System.Drawing.Point(83, 31);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(107, 21);
            this.brandComboBox.TabIndex = 1;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.statusComboBox.Location = new System.Drawing.Point(83, 66);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(107, 21);
            this.statusComboBox.TabIndex = 2;
            // 
            // specsComboBox
            // 
            this.specsComboBox.FormattingEnabled = true;
            this.specsComboBox.Items.AddRange(new object[] {
            "",
            "V4 1.5L Carburator",
            "V4 1.6L Injection",
            "V4 2.0L Atmosphere",
            "V4 2.0L Turbo",
            "V4 2.5 Turbo",
            "V6 3.0L Atmosphere",
            "V6 3.2L TwinTurbo",
            "V6 3.5L Atmospere",
            "V8 4.0L Atmosphere",
            "V8 4.2L Compressor",
            "V8 5.0L Aatmospere",
            "V8 5.2L Turbo",
            "V10 6.0L Atmosphere",
            "V12 6.2L TwiTurbo",
            "V12 6.2L Compressor"});
            this.specsComboBox.Location = new System.Drawing.Point(83, 99);
            this.specsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.specsComboBox.Name = "specsComboBox";
            this.specsComboBox.Size = new System.Drawing.Size(107, 21);
            this.specsComboBox.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(23, 67);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 15);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // specsLabel
            // 
            this.specsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.specsLabel.AutoSize = true;
            this.specsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specsLabel.Location = new System.Drawing.Point(23, 100);
            this.specsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specsLabel.Name = "specsLabel";
            this.specsLabel.Size = new System.Drawing.Size(41, 15);
            this.specsLabel.TabIndex = 5;
            this.specsLabel.Text = "Specs";
            // 
            // budgetLabel
            // 
            this.budgetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.budgetLabel.Location = new System.Drawing.Point(23, 135);
            this.budgetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(46, 15);
            this.budgetLabel.TabIndex = 6;
            this.budgetLabel.Text = "Budget";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(83, 134);
            this.budgetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(107, 20);
            this.budgetTextBox.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(26, 166);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(56, 27);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(134, 166);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(56, 27);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ClientCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(201, 220);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.specsLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.specsComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientCarForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox specsComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label specsLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button closeButton;
    }
}