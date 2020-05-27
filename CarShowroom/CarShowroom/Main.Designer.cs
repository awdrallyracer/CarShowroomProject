namespace CarShowroom
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.carlistGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.carsTabControl = new System.Windows.Forms.TabControl();
            this.Vehicles = new System.Windows.Forms.TabPage();
            this.Clients = new System.Windows.Forms.TabPage();
            this.clientsGridView = new System.Windows.Forms.DataGridView();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCLientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carlistGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.carsTabControl.SuspendLayout();
            this.Vehicles.SuspendLayout();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carlistGridView
            // 
            this.carlistGridView.AllowUserToAddRows = false;
            this.carlistGridView.AllowUserToDeleteRows = false;
            this.carlistGridView.AutoGenerateColumns = false;
            this.carlistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carlistGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.brandDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.specsDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.carlistGridView.DataSource = this.carBindingSource;
            this.carlistGridView.Location = new System.Drawing.Point(0, 0);
            this.carlistGridView.Name = "carlistGridView";
            this.carlistGridView.ReadOnly = true;
            this.carlistGridView.RowHeadersWidth = 51;
            this.carlistGridView.RowTemplate.Height = 24;
            this.carlistGridView.Size = new System.Drawing.Size(815, 308);
            this.carlistGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(644, 436);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(739, 436);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.carToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "FIle";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // carsTabControl
            // 
            this.carsTabControl.Controls.Add(this.Vehicles);
            this.carsTabControl.Controls.Add(this.Clients);
            this.carsTabControl.Location = new System.Drawing.Point(12, 59);
            this.carsTabControl.Name = "carsTabControl";
            this.carsTabControl.SelectedIndex = 0;
            this.carsTabControl.Size = new System.Drawing.Size(819, 333);
            this.carsTabControl.TabIndex = 4;
            // 
            // Vehicles
            // 
            this.Vehicles.Controls.Add(this.carlistGridView);
            this.Vehicles.Location = new System.Drawing.Point(4, 25);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.Vehicles.Size = new System.Drawing.Size(811, 304);
            this.Vehicles.TabIndex = 0;
            this.Vehicles.Text = "Vehicles";
            this.Vehicles.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.clientsGridView);
            this.Clients.Location = new System.Drawing.Point(4, 25);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(811, 304);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // clientsGridView
            // 
            this.clientsGridView.AutoGenerateColumns = false;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.clientsGridView.DataSource = this.clientBindingSource;
            this.clientsGridView.Location = new System.Drawing.Point(0, 0);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.RowHeadersWidth = 51;
            this.clientsGridView.RowTemplate.Height = 24;
            this.clientsGridView.Size = new System.Drawing.Size(808, 304);
            this.clientsGridView.TabIndex = 0;
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem1,
            this.editCLientToolStripMenuItem1,
            this.deleteClientToolStripMenuItem1});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // editCLientToolStripMenuItem1
            // 
            this.editCLientToolStripMenuItem1.Name = "editCLientToolStripMenuItem1";
            this.editCLientToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.editCLientToolStripMenuItem1.Text = "Edit";
            this.editCLientToolStripMenuItem1.Click += new System.EventHandler(this.editCLientToolStripMenuItem1_Click);
            // 
            // deleteClientToolStripMenuItem1
            // 
            this.deleteClientToolStripMenuItem1.Name = "deleteClientToolStripMenuItem1";
            this.deleteClientToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.deleteClientToolStripMenuItem1.Text = "Delete";
            this.deleteClientToolStripMenuItem1.Click += new System.EventHandler(this.deleteClientToolStripMenuItem1_Click);
            // 
            // newClientToolStripMenuItem1
            // 
            this.newClientToolStripMenuItem1.Name = "newClientToolStripMenuItem1";
            this.newClientToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.newClientToolStripMenuItem1.Text = "New";
            this.newClientToolStripMenuItem1.Click += new System.EventHandler(this.newClientToolStripMenuItem1_Click);
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 125;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 70;
            // 
            // specsDataGridViewTextBoxColumn
            // 
            this.specsDataGridViewTextBoxColumn.DataPropertyName = "Specs";
            this.specsDataGridViewTextBoxColumn.HeaderText = "Specs";
            this.specsDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.specsDataGridViewTextBoxColumn.Name = "specsDataGridViewTextBoxColumn";
            this.specsDataGridViewTextBoxColumn.ReadOnly = true;
            this.specsDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 70;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarShowroom.Models.Car);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CarShowroom.Models.Client);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 471);
            this.Controls.Add(this.carsTabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cars_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.carlistGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.carsTabControl.ResumeLayout(false);
            this.Vehicles.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carlistGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl carsTabControl;
        private System.Windows.Forms.TabPage Vehicles;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView clientsGridView;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCLientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}