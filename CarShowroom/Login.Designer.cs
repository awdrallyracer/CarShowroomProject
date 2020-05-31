namespace CarShowroom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginLaber = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.Location = new System.Drawing.Point(25, 42);
            this.loginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBox.MaximumSize = new System.Drawing.Size(129, 20);
            this.loginBox.MinimumSize = new System.Drawing.Size(129, 20);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(129, 20);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(25, 96);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.MaximumSize = new System.Drawing.Size(129, 20);
            this.passwordBox.MinimumSize = new System.Drawing.Size(129, 20);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(129, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // loginLaber
            // 
            this.loginLaber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLaber.AutoSize = true;
            this.loginLaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLaber.Location = new System.Drawing.Point(67, 19);
            this.loginLaber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLaber.MaximumSize = new System.Drawing.Size(44, 18);
            this.loginLaber.MinimumSize = new System.Drawing.Size(44, 18);
            this.loginLaber.Name = "loginLaber";
            this.loginLaber.Size = new System.Drawing.Size(44, 18);
            this.loginLaber.TabIndex = 2;
            this.loginLaber.Text = "Login";
            // 
            // registrationLabel
            // 
            this.registrationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(51, 74);
            this.registrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registrationLabel.MaximumSize = new System.Drawing.Size(82, 20);
            this.registrationLabel.MinimumSize = new System.Drawing.Size(82, 20);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(82, 20);
            this.registrationLabel.TabIndex = 3;
            this.registrationLabel.Text = "Password";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(98, 145);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.MaximumSize = new System.Drawing.Size(56, 25);
            this.registerButton.MinimumSize = new System.Drawing.Size(56, 25);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(56, 25);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.Location = new System.Drawing.Point(25, 145);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterButton.MaximumSize = new System.Drawing.Size(56, 25);
            this.enterButton.MinimumSize = new System.Drawing.Size(56, 25);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(56, 25);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 181);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.loginLaber);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(200, 220);
            this.MinimumSize = new System.Drawing.Size(200, 220);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label loginLaber;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button enterButton;
    }
}