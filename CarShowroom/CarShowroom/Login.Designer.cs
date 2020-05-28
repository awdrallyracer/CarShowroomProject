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
            this.loginBox.Location = new System.Drawing.Point(34, 62);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(171, 22);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(34, 120);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(171, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // loginLaber
            // 
            this.loginLaber.AutoSize = true;
            this.loginLaber.Location = new System.Drawing.Point(102, 42);
            this.loginLaber.Name = "loginLaber";
            this.loginLaber.Size = new System.Drawing.Size(43, 17);
            this.loginLaber.TabIndex = 2;
            this.loginLaber.Text = "Login";
            // 
            // registrationLabel
            // 
            this.registrationLabel.Location = new System.Drawing.Point(34, 99);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(171, 24);
            this.registrationLabel.TabIndex = 3;
            this.registrationLabel.Text = "Password";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(130, 159);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(34, 159);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 251);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.loginLaber);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Name = "Login";
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