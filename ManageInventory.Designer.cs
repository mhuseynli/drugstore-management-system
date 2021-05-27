
namespace DrugStoreManagementSystem
{
    partial class ManageInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_Inventory = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbx_Medicine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MedicineCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addToInventory = new System.Windows.Forms.Button();
            this.btn_UpdateInventory = new System.Windows.Forms.Button();
            this.btn_clearFilters = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.txt_FilterByName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backMenuimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MedicineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(38, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Əsas Menyu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1328, 34);
            this.label4.TabIndex = 48;
            this.label4.Text = "Anbar İdarəetməsi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 18);
            this.panel1.TabIndex = 47;
            // 
            // data_Inventory
            // 
            this.data_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_Inventory.Location = new System.Drawing.Point(0, 389);
            this.data_Inventory.Margin = new System.Windows.Forms.Padding(2);
            this.data_Inventory.Name = "data_Inventory";
            this.data_Inventory.RowTemplate.Height = 24;
            this.data_Inventory.Size = new System.Drawing.Size(1350, 393);
            this.data_Inventory.TabIndex = 69;
            this.data_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Inventory_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // cmbx_Medicine
            // 
            this.cmbx_Medicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Medicine.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Medicine.FormattingEnabled = true;
            this.cmbx_Medicine.Location = new System.Drawing.Point(20, 127);
            this.cmbx_Medicine.Name = "cmbx_Medicine";
            this.cmbx_Medicine.Size = new System.Drawing.Size(194, 27);
            this.cmbx_Medicine.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(17, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Dərman seçin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MedicineCount
            // 
            this.txt_MedicineCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedicineCount.Location = new System.Drawing.Point(20, 188);
            this.txt_MedicineCount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MedicineCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_MedicineCount.Name = "txt_MedicineCount";
            this.txt_MedicineCount.Size = new System.Drawing.Size(75, 27);
            this.txt_MedicineCount.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(17, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Anbardakı say";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addToInventory
            // 
            this.btn_addToInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_addToInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToInventory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToInventory.ForeColor = System.Drawing.Color.White;
            this.btn_addToInventory.Location = new System.Drawing.Point(20, 233);
            this.btn_addToInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addToInventory.Name = "btn_addToInventory";
            this.btn_addToInventory.Size = new System.Drawing.Size(195, 31);
            this.btn_addToInventory.TabIndex = 74;
            this.btn_addToInventory.Text = "Əlavə Et";
            this.btn_addToInventory.UseVisualStyleBackColor = false;
            this.btn_addToInventory.Click += new System.EventHandler(this.btn_addToInventory_Click);
            // 
            // btn_UpdateInventory
            // 
            this.btn_UpdateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_UpdateInventory.Enabled = false;
            this.btn_UpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateInventory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateInventory.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateInventory.Location = new System.Drawing.Point(20, 268);
            this.btn_UpdateInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateInventory.Name = "btn_UpdateInventory";
            this.btn_UpdateInventory.Size = new System.Drawing.Size(195, 31);
            this.btn_UpdateInventory.TabIndex = 75;
            this.btn_UpdateInventory.Text = "Yenilə";
            this.btn_UpdateInventory.UseVisualStyleBackColor = false;
            this.btn_UpdateInventory.Click += new System.EventHandler(this.btn_UpdateInventory_Click);
            // 
            // btn_clearFilters
            // 
            this.btn_clearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_clearFilters.Enabled = false;
            this.btn_clearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearFilters.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFilters.ForeColor = System.Drawing.Color.White;
            this.btn_clearFilters.Location = new System.Drawing.Point(352, 357);
            this.btn_clearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearFilters.Name = "btn_clearFilters";
            this.btn_clearFilters.Size = new System.Drawing.Size(143, 27);
            this.btn_clearFilters.TabIndex = 78;
            this.btn_clearFilters.Text = "Filterləri Təmizlə";
            this.btn_clearFilters.UseVisualStyleBackColor = false;
            this.btn_clearFilters.Click += new System.EventHandler(this.btn_clearFilters_Click_1);
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(252, 357);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(96, 27);
            this.btn_Filter.TabIndex = 77;
            this.btn_Filter.Text = "Axtar...";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // txt_FilterByName
            // 
            this.txt_FilterByName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilterByName.Location = new System.Drawing.Point(20, 357);
            this.txt_FilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FilterByName.Name = "txt_FilterByName";
            this.txt_FilterByName.Size = new System.Drawing.Size(228, 27);
            this.txt_FilterByName.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrugStoreManagementSystem.Properties.Resources.warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(991, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // backMenuimg
            // 
            this.backMenuimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuimg.Image = global::DrugStoreManagementSystem.Properties.Resources.back;
            this.backMenuimg.Location = new System.Drawing.Point(10, 24);
            this.backMenuimg.Name = "backMenuimg";
            this.backMenuimg.Size = new System.Drawing.Size(25, 25);
            this.backMenuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMenuimg.TabIndex = 55;
            this.backMenuimg.TabStop = false;
            this.backMenuimg.Click += new System.EventHandler(this.backMenuimg_Click_1);
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 781);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clearFilters);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txt_FilterByName);
            this.Controls.Add(this.btn_UpdateInventory);
            this.Controls.Add(this.btn_addToInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MedicineCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_Medicine);
            this.Controls.Add(this.data_Inventory);
            this.Controls.Add(this.backMenuimg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1366, 820);
            this.Name = "ManageInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageInventory";
            this.Load += new System.EventHandler(this.ManageInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MedicineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backMenuimg;
        private System.Windows.Forms.DataGridView data_Inventory;
        private System.Windows.Forms.ComboBox cmbx_Medicine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_MedicineCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addToInventory;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btn_UpdateInventory;
        private System.Windows.Forms.Button btn_clearFilters;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.TextBox txt_FilterByName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}