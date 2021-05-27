
namespace DrugStoreManagementSystem
{
    partial class ManageSales
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
            this.data_Sales = new System.Windows.Forms.DataGridView();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_End = new System.Windows.Forms.DateTimePicker();
            this.btn_searchInterval = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(41, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Əsas Menyu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backMenuimg
            // 
            this.backMenuimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuimg.Image = global::DrugStoreManagementSystem.Properties.Resources.back;
            this.backMenuimg.Location = new System.Drawing.Point(11, 9);
            this.backMenuimg.Name = "backMenuimg";
            this.backMenuimg.Size = new System.Drawing.Size(25, 25);
            this.backMenuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMenuimg.TabIndex = 38;
            this.backMenuimg.TabStop = false;
            this.backMenuimg.Click += new System.EventHandler(this.backMenuimg_Click);
            // 
            // data_Sales
            // 
            this.data_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Sales.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.data_Sales.DataSource = this.salesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Sales.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_Sales.Location = new System.Drawing.Point(11, 146);
            this.data_Sales.Margin = new System.Windows.Forms.Padding(2);
            this.data_Sales.Name = "data_Sales";
            this.data_Sales.RowTemplate.Height = 24;
            this.data_Sales.Size = new System.Drawing.Size(1328, 572);
            this.data_Sales.TabIndex = 40;
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "saleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "Satış ID";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "saleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Satış Tarixi";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Gəlir (AZN)";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(DrugStoreManagementSystem.Sales);
            // 
            // date_Start
            // 
            this.date_Start.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Start.Location = new System.Drawing.Point(12, 104);
            this.date_Start.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(192, 26);
            this.date_Start.TabIndex = 41;
            // 
            // date_End
            // 
            this.date_End.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_End.Location = new System.Drawing.Point(210, 104);
            this.date_End.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.date_End.Name = "date_End";
            this.date_End.Size = new System.Drawing.Size(192, 26);
            this.date_End.TabIndex = 42;
            // 
            // btn_searchInterval
            // 
            this.btn_searchInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_searchInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchInterval.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchInterval.ForeColor = System.Drawing.Color.White;
            this.btn_searchInterval.Location = new System.Drawing.Point(407, 104);
            this.btn_searchInterval.Margin = new System.Windows.Forms.Padding(2);
            this.btn_searchInterval.Name = "btn_searchInterval";
            this.btn_searchInterval.Size = new System.Drawing.Size(96, 27);
            this.btn_searchInterval.TabIndex = 79;
            this.btn_searchInterval.Text = "Axtar...";
            this.btn_searchInterval.UseVisualStyleBackColor = false;
            this.btn_searchInterval.Click += new System.EventHandler(this.btn_searchInterval_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1328, 34);
            this.label4.TabIndex = 80;
            this.label4.Text = "Satışların Siyahısı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clearFilters
            // 
            this.btn_clearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_clearFilters.Enabled = false;
            this.btn_clearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearFilters.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFilters.ForeColor = System.Drawing.Color.White;
            this.btn_clearFilters.Location = new System.Drawing.Point(507, 104);
            this.btn_clearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearFilters.Name = "btn_clearFilters";
            this.btn_clearFilters.Size = new System.Drawing.Size(143, 27);
            this.btn_clearFilters.TabIndex = 81;
            this.btn_clearFilters.Text = "Filterləri Təmizlə";
            this.btn_clearFilters.UseVisualStyleBackColor = false;
            this.btn_clearFilters.Click += new System.EventHandler(this.btn_clearFilters_Click);
            // 
            // ManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_clearFilters);
            this.Controls.Add(this.btn_searchInterval);
            this.Controls.Add(this.date_End);
            this.Controls.Add(this.date_Start);
            this.Controls.Add(this.data_Sales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backMenuimg);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ManageSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.ManageSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox backMenuimg;
        private System.Windows.Forms.DataGridView data_Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DateTimePicker date_End;
        private System.Windows.Forms.Button btn_searchInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clearFilters;
    }
}