
namespace DrugStoreManagementSystem
{
    partial class ManageMedicineFormats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.backMenuimg = new System.Windows.Forms.PictureBox();
            this.btn_addMedicineFormat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_medicineFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_MedicineFormats = new System.Windows.Forms.DataGridView();
            this.formatIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.medicineFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicineFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineFormatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Əsas Menyu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backMenuimg
            // 
            this.backMenuimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuimg.Image = global::DrugStoreManagementSystem.Properties.Resources.back;
            this.backMenuimg.Location = new System.Drawing.Point(10, 24);
            this.backMenuimg.Name = "backMenuimg";
            this.backMenuimg.Size = new System.Drawing.Size(25, 25);
            this.backMenuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMenuimg.TabIndex = 45;
            this.backMenuimg.TabStop = false;
            this.backMenuimg.Click += new System.EventHandler(this.backMenuimg_Click);
            // 
            // btn_addMedicineFormat
            // 
            this.btn_addMedicineFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMedicineFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_addMedicineFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMedicineFormat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMedicineFormat.ForeColor = System.Drawing.Color.White;
            this.btn_addMedicineFormat.Location = new System.Drawing.Point(192, 186);
            this.btn_addMedicineFormat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addMedicineFormat.Name = "btn_addMedicineFormat";
            this.btn_addMedicineFormat.Size = new System.Drawing.Size(80, 30);
            this.btn_addMedicineFormat.TabIndex = 44;
            this.btn_addMedicineFormat.Text = "Əlavə Et";
            this.btn_addMedicineFormat.UseVisualStyleBackColor = false;
            this.btn_addMedicineFormat.Click += new System.EventHandler(this.btn_addMedicineFormat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(40, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Dərman formatı daxil edin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicineFormat
            // 
            this.txt_medicineFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_medicineFormat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineFormat.Location = new System.Drawing.Point(44, 155);
            this.txt_medicineFormat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicineFormat.Name = "txt_medicineFormat";
            this.txt_medicineFormat.Size = new System.Drawing.Size(228, 27);
            this.txt_medicineFormat.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(39, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "Dərman formatı əlavə et";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_MedicineFormats
            // 
            this.data_MedicineFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_MedicineFormats.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_MedicineFormats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_MedicineFormats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MedicineFormats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formatIdDataGridViewTextBoxColumn,
            this.formatNameDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.data_MedicineFormats.DataSource = this.medicineFormatBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_MedicineFormats.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_MedicineFormats.Location = new System.Drawing.Point(464, 85);
            this.data_MedicineFormats.Margin = new System.Windows.Forms.Padding(2);
            this.data_MedicineFormats.Name = "data_MedicineFormats";
            this.data_MedicineFormats.RowTemplate.Height = 24;
            this.data_MedicineFormats.Size = new System.Drawing.Size(875, 633);
            this.data_MedicineFormats.TabIndex = 40;
            this.data_MedicineFormats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_MedicineFormats_CellContentClick);
            // 
            // formatIdDataGridViewTextBoxColumn
            // 
            this.formatIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formatIdDataGridViewTextBoxColumn.DataPropertyName = "formatId";
            this.formatIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.formatIdDataGridViewTextBoxColumn.Name = "formatIdDataGridViewTextBoxColumn";
            this.formatIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatNameDataGridViewTextBoxColumn
            // 
            this.formatNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formatNameDataGridViewTextBoxColumn.DataPropertyName = "formatName";
            this.formatNameDataGridViewTextBoxColumn.HeaderText = "Dərman Formatı";
            this.formatNameDataGridViewTextBoxColumn.Name = "formatNameDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // medicineFormatBindingSource
            // 
            this.medicineFormatBindingSource.DataSource = typeof(DrugStoreManagementSystem.MedicineFormat);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1328, 34);
            this.label4.TabIndex = 39;
            this.label4.Text = "Dərman Formatlarının İdarəetməsi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 18);
            this.panel1.TabIndex = 38;
            // 
            // ManageMedicineFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backMenuimg);
            this.Controls.Add(this.btn_addMedicineFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_medicineFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_MedicineFormats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ManageMedicineFormats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMedicineFormats";
            this.Load += new System.EventHandler(this.ManageMedicineFormats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MedicineFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineFormatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox backMenuimg;
        private System.Windows.Forms.Button btn_addMedicineFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_medicineFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_MedicineFormats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource medicineFormatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}