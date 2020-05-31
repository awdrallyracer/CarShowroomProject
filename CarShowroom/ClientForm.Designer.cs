namespace CarShowroom
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.carPage = new System.Windows.Forms.TabPage();
            this.carGridView = new System.Windows.Forms.DataGridView();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priorityRadio = new System.Windows.Forms.RadioButton();
            this.noPriorityRadio = new System.Windows.Forms.RadioButton();
            this.priorirtButton = new System.Windows.Forms.Button();
            this.deleteOrderButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.carPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).BeginInit();
            this.orderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.carPage);
            this.tabControl.Controls.Add(this.orderPage);
            this.tabControl.Location = new System.Drawing.Point(12, 44);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(989, 382);
            this.tabControl.TabIndex = 0;
            // 
            // carPage
            // 
            this.carPage.Controls.Add(this.carGridView);
            this.carPage.Location = new System.Drawing.Point(4, 25);
            this.carPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carPage.Name = "carPage";
            this.carPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carPage.Size = new System.Drawing.Size(981, 353);
            this.carPage.TabIndex = 0;
            this.carPage.Text = "Cars";
            this.carPage.UseVisualStyleBackColor = true;
            // 
            // carGridView
            // 
            this.carGridView.AllowUserToAddRows = false;
            this.carGridView.AllowUserToDeleteRows = false;
            this.carGridView.AllowUserToResizeColumns = false;
            this.carGridView.AllowUserToResizeRows = false;
            this.carGridView.AutoGenerateColumns = false;
            this.carGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.carGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.brandDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.specsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.carGridView.DataSource = this.carBindingSource;
            this.carGridView.Location = new System.Drawing.Point(0, 0);
            this.carGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carGridView.Name = "carGridView";
            this.carGridView.ReadOnly = true;
            this.carGridView.RowHeadersWidth = 51;
            this.carGridView.RowTemplate.Height = 24;
            this.carGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carGridView.Size = new System.Drawing.Size(977, 354);
            this.carGridView.TabIndex = 0;
            // 
            // orderPage
            // 
            this.orderPage.Controls.Add(this.dataGridView1);
            this.orderPage.Location = new System.Drawing.Point(4, 25);
            this.orderPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderPage.Name = "orderPage";
            this.orderPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderPage.Size = new System.Drawing.Size(981, 353);
            this.orderPage.TabIndex = 1;
            this.orderPage.Text = "Orders";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn1,
            this.brandDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.specsDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(979, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(225, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.priorityRadio);
            this.groupBox1.Controls.Add(this.noPriorityRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 431);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // priorityRadio
            // 
            this.priorityRadio.AutoSize = true;
            this.priorityRadio.Location = new System.Drawing.Point(29, 48);
            this.priorityRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priorityRadio.Name = "priorityRadio";
            this.priorityRadio.Size = new System.Drawing.Size(73, 21);
            this.priorityRadio.TabIndex = 1;
            this.priorityRadio.TabStop = true;
            this.priorityRadio.Text = "Priority";
            this.priorityRadio.UseVisualStyleBackColor = true;
            this.priorityRadio.CheckedChanged += new System.EventHandler(this.noPriorityRadio_CheckedChanged);
            // 
            // noPriorityRadio
            // 
            this.noPriorityRadio.AutoSize = true;
            this.noPriorityRadio.Checked = true;
            this.noPriorityRadio.Location = new System.Drawing.Point(29, 21);
            this.noPriorityRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noPriorityRadio.Name = "noPriorityRadio";
            this.noPriorityRadio.Size = new System.Drawing.Size(94, 21);
            this.noPriorityRadio.TabIndex = 0;
            this.noPriorityRadio.TabStop = true;
            this.noPriorityRadio.Text = "No priority";
            this.noPriorityRadio.UseVisualStyleBackColor = true;
            this.noPriorityRadio.CheckedChanged += new System.EventHandler(this.noPriorityRadio_CheckedChanged);
            // 
            // priorirtButton
            // 
            this.priorirtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priorirtButton.Location = new System.Drawing.Point(225, 441);
            this.priorirtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priorirtButton.Name = "priorirtButton";
            this.priorirtButton.Size = new System.Drawing.Size(99, 32);
            this.priorirtButton.TabIndex = 3;
            this.priorirtButton.Text = "Set priority";
            this.priorirtButton.UseVisualStyleBackColor = true;
            this.priorirtButton.Click += new System.EventHandler(this.priorirtButton_Click);
            // 
            // deleteOrderButton2
            // 
            this.deleteOrderButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderButton2.Location = new System.Drawing.Point(903, 441);
            this.deleteOrderButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteOrderButton2.Name = "deleteOrderButton2";
            this.deleteOrderButton2.Size = new System.Drawing.Size(99, 32);
            this.deleteOrderButton2.TabIndex = 4;
            this.deleteOrderButton2.Text = "Delete order";
            this.deleteOrderButton2.UseVisualStyleBackColor = true;
            this.deleteOrderButton2.Click += new System.EventHandler(this.deleteOrderButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(600, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 68);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(903, 481);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 32);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // specsDataGridViewTextBoxColumn
            // 
            this.specsDataGridViewTextBoxColumn.DataPropertyName = "Specs";
            this.specsDataGridViewTextBoxColumn.HeaderText = "Specs";
            this.specsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specsDataGridViewTextBoxColumn.Name = "specsDataGridViewTextBoxColumn";
            this.specsDataGridViewTextBoxColumn.ReadOnly = true;
            this.specsDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarShowroom.Models.Car);
            // 
            // imageDataGridViewImageColumn1
            // 
            this.imageDataGridViewImageColumn1.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn1.HeaderText = "Image";
            this.imageDataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn1.MinimumWidth = 6;
            this.imageDataGridViewImageColumn1.Name = "imageDataGridViewImageColumn1";
            this.imageDataGridViewImageColumn1.ReadOnly = true;
            this.imageDataGridViewImageColumn1.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Width = 60;
            // 
            // specsDataGridViewTextBoxColumn1
            // 
            this.specsDataGridViewTextBoxColumn1.DataPropertyName = "Specs";
            this.specsDataGridViewTextBoxColumn1.HeaderText = "Specs";
            this.specsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.specsDataGridViewTextBoxColumn1.Name = "specsDataGridViewTextBoxColumn1";
            this.specsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.specsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn1.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 60;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(CarShowroom.Models.Car);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 519);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteOrderButton2);
            this.Controls.Add(this.priorirtButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cars_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.tabControl.ResumeLayout(false);
            this.carPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).EndInit();
            this.orderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage carPage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.DataGridView carGridView;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton priorityRadio;
        private System.Windows.Forms.RadioButton noPriorityRadio;
        private System.Windows.Forms.Button priorirtButton;
        private System.Windows.Forms.Button deleteOrderButton2;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
    }
}