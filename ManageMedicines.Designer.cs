
namespace DrugStoreManagementSystem
{
    partial class ManageMedicines
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
            this.btn_addMedicine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_medicineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_medicineBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_medicinePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_MedicineCategory = new System.Windows.Forms.ComboBox();
            this.cmbx_MedicineFormat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbx_MedicineManufacturer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.data_Medicines = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editMedicinePanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_EditmedicineSellPrice = new System.Windows.Forms.TextBox();
            this.cmbx_EditMedicineManufacturer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbx_EditMedicineFormat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbx_EditMedicineCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_EditmedicinePrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_EditmedicineBarcode = new System.Windows.Forms.TextBox();
            this.btn_updateMedicine = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_EditmedicineName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_medicineSellPrice = new System.Windows.Forms.TextBox();
            this.txt_FilterByName = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_clearFilters = new System.Windows.Forms.Button();
            this.inventoryImg = new System.Windows.Forms.PictureBox();
            this.backMenuimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicines)).BeginInit();
            this.editMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).BeginInit();
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
            this.label3.TabIndex = 55;
            this.label3.Text = "Əsas Menyu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addMedicine
            // 
            this.btn_addMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_addMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMedicine.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_addMedicine.Location = new System.Drawing.Point(285, 294);
            this.btn_addMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addMedicine.Name = "btn_addMedicine";
            this.btn_addMedicine.Size = new System.Drawing.Size(194, 31);
            this.btn_addMedicine.TabIndex = 53;
            this.btn_addMedicine.Text = "Əlavə Et";
            this.btn_addMedicine.UseVisualStyleBackColor = false;
            this.btn_addMedicine.Click += new System.EventHandler(this.btn_addMedicine_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Dərman adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicineName
            // 
            this.txt_medicineName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineName.Location = new System.Drawing.Point(16, 132);
            this.txt_medicineName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicineName.Name = "txt_medicineName";
            this.txt_medicineName.Size = new System.Drawing.Size(228, 26);
            this.txt_medicineName.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Dərman əlavə et";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(181, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(994, 34);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dərmanların İdarəetməsi";
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Dərman Barkodu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicineBarcode
            // 
            this.txt_medicineBarcode.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineBarcode.Location = new System.Drawing.Point(15, 186);
            this.txt_medicineBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicineBarcode.Name = "txt_medicineBarcode";
            this.txt_medicineBarcode.Size = new System.Drawing.Size(228, 26);
            this.txt_medicineBarcode.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(14, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Dərman qiyməti";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicinePrice
            // 
            this.txt_medicinePrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicinePrice.Location = new System.Drawing.Point(16, 240);
            this.txt_medicinePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicinePrice.Name = "txt_medicinePrice";
            this.txt_medicinePrice.Size = new System.Drawing.Size(228, 26);
            this.txt_medicinePrice.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(282, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Kateqoriya";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_MedicineCategory
            // 
            this.cmbx_MedicineCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_MedicineCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_MedicineCategory.FormattingEnabled = true;
            this.cmbx_MedicineCategory.Location = new System.Drawing.Point(285, 131);
            this.cmbx_MedicineCategory.Name = "cmbx_MedicineCategory";
            this.cmbx_MedicineCategory.Size = new System.Drawing.Size(194, 27);
            this.cmbx_MedicineCategory.TabIndex = 62;
            // 
            // cmbx_MedicineFormat
            // 
            this.cmbx_MedicineFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_MedicineFormat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_MedicineFormat.FormattingEnabled = true;
            this.cmbx_MedicineFormat.Location = new System.Drawing.Point(285, 186);
            this.cmbx_MedicineFormat.Name = "cmbx_MedicineFormat";
            this.cmbx_MedicineFormat.Size = new System.Drawing.Size(194, 27);
            this.cmbx_MedicineFormat.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(282, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Dərmanın formatı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_MedicineManufacturer
            // 
            this.cmbx_MedicineManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_MedicineManufacturer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_MedicineManufacturer.FormattingEnabled = true;
            this.cmbx_MedicineManufacturer.Location = new System.Drawing.Point(285, 241);
            this.cmbx_MedicineManufacturer.Name = "cmbx_MedicineManufacturer";
            this.cmbx_MedicineManufacturer.Size = new System.Drawing.Size(194, 27);
            this.cmbx_MedicineManufacturer.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(282, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "İstehsalçı Şirkət";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_Medicines
            // 
            this.data_Medicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Medicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Medicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Medicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Medicines.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_Medicines.Location = new System.Drawing.Point(0, 407);
            this.data_Medicines.Margin = new System.Windows.Forms.Padding(2);
            this.data_Medicines.Name = "data_Medicines";
            this.data_Medicines.RowTemplate.Height = 24;
            this.data_Medicines.Size = new System.Drawing.Size(1350, 375);
            this.data_Medicines.TabIndex = 68;
            this.data_Medicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Medicines_CellContentClick);
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
            // editMedicinePanel
            // 
            this.editMedicinePanel.Controls.Add(this.label17);
            this.editMedicinePanel.Controls.Add(this.txt_EditmedicineSellPrice);
            this.editMedicinePanel.Controls.Add(this.cmbx_EditMedicineManufacturer);
            this.editMedicinePanel.Controls.Add(this.label10);
            this.editMedicinePanel.Controls.Add(this.cmbx_EditMedicineFormat);
            this.editMedicinePanel.Controls.Add(this.label11);
            this.editMedicinePanel.Controls.Add(this.cmbx_EditMedicineCategory);
            this.editMedicinePanel.Controls.Add(this.label12);
            this.editMedicinePanel.Controls.Add(this.label13);
            this.editMedicinePanel.Controls.Add(this.txt_EditmedicinePrice);
            this.editMedicinePanel.Controls.Add(this.label14);
            this.editMedicinePanel.Controls.Add(this.txt_EditmedicineBarcode);
            this.editMedicinePanel.Controls.Add(this.btn_updateMedicine);
            this.editMedicinePanel.Controls.Add(this.label15);
            this.editMedicinePanel.Controls.Add(this.txt_EditmedicineName);
            this.editMedicinePanel.Location = new System.Drawing.Point(511, 72);
            this.editMedicinePanel.Name = "editMedicinePanel";
            this.editMedicinePanel.Size = new System.Drawing.Size(486, 272);
            this.editMedicinePanel.TabIndex = 69;
            this.editMedicinePanel.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label17.Location = new System.Drawing.Point(10, 202);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 24);
            this.label17.TabIndex = 73;
            this.label17.Text = "Satış qiyməti";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EditmedicineSellPrice
            // 
            this.txt_EditmedicineSellPrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditmedicineSellPrice.Location = new System.Drawing.Point(12, 228);
            this.txt_EditmedicineSellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EditmedicineSellPrice.Name = "txt_EditmedicineSellPrice";
            this.txt_EditmedicineSellPrice.Size = new System.Drawing.Size(228, 26);
            this.txt_EditmedicineSellPrice.TabIndex = 72;
            // 
            // cmbx_EditMedicineManufacturer
            // 
            this.cmbx_EditMedicineManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_EditMedicineManufacturer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_EditMedicineManufacturer.FormattingEnabled = true;
            this.cmbx_EditMedicineManufacturer.Location = new System.Drawing.Point(281, 172);
            this.cmbx_EditMedicineManufacturer.Name = "cmbx_EditMedicineManufacturer";
            this.cmbx_EditMedicineManufacturer.Size = new System.Drawing.Size(194, 27);
            this.cmbx_EditMedicineManufacturer.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(278, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 24);
            this.label10.TabIndex = 78;
            this.label10.Text = "İstehsalçı Şirkət";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_EditMedicineFormat
            // 
            this.cmbx_EditMedicineFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_EditMedicineFormat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_EditMedicineFormat.FormattingEnabled = true;
            this.cmbx_EditMedicineFormat.Location = new System.Drawing.Point(281, 115);
            this.cmbx_EditMedicineFormat.Name = "cmbx_EditMedicineFormat";
            this.cmbx_EditMedicineFormat.Size = new System.Drawing.Size(194, 27);
            this.cmbx_EditMedicineFormat.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(278, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 24);
            this.label11.TabIndex = 76;
            this.label11.Text = "Dərmanın formatı";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_EditMedicineCategory
            // 
            this.cmbx_EditMedicineCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_EditMedicineCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_EditMedicineCategory.FormattingEnabled = true;
            this.cmbx_EditMedicineCategory.Location = new System.Drawing.Point(281, 60);
            this.cmbx_EditMedicineCategory.Name = "cmbx_EditMedicineCategory";
            this.cmbx_EditMedicineCategory.Size = new System.Drawing.Size(194, 27);
            this.cmbx_EditMedicineCategory.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(278, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "Kateqoriya";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(10, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 24);
            this.label13.TabIndex = 73;
            this.label13.Text = "Dərman qiyməti";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EditmedicinePrice
            // 
            this.txt_EditmedicinePrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditmedicinePrice.Location = new System.Drawing.Point(12, 169);
            this.txt_EditmedicinePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EditmedicinePrice.Name = "txt_EditmedicinePrice";
            this.txt_EditmedicinePrice.Size = new System.Drawing.Size(228, 26);
            this.txt_EditmedicinePrice.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(9, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 24);
            this.label14.TabIndex = 71;
            this.label14.Text = "Dərman Barkodu";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EditmedicineBarcode
            // 
            this.txt_EditmedicineBarcode.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditmedicineBarcode.Location = new System.Drawing.Point(11, 115);
            this.txt_EditmedicineBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EditmedicineBarcode.Name = "txt_EditmedicineBarcode";
            this.txt_EditmedicineBarcode.Size = new System.Drawing.Size(228, 26);
            this.txt_EditmedicineBarcode.TabIndex = 70;
            // 
            // btn_updateMedicine
            // 
            this.btn_updateMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_updateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateMedicine.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_updateMedicine.Location = new System.Drawing.Point(281, 223);
            this.btn_updateMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updateMedicine.Name = "btn_updateMedicine";
            this.btn_updateMedicine.Size = new System.Drawing.Size(194, 31);
            this.btn_updateMedicine.TabIndex = 69;
            this.btn_updateMedicine.Text = "Yenilə";
            this.btn_updateMedicine.UseVisualStyleBackColor = false;
            this.btn_updateMedicine.Click += new System.EventHandler(this.btn_updateMedicine_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(10, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 24);
            this.label15.TabIndex = 68;
            this.label15.Text = "Dərman adı";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EditmedicineName
            // 
            this.txt_EditmedicineName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditmedicineName.Location = new System.Drawing.Point(12, 61);
            this.txt_EditmedicineName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EditmedicineName.Name = "txt_EditmedicineName";
            this.txt_EditmedicineName.Size = new System.Drawing.Size(228, 26);
            this.txt_EditmedicineName.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(14, 273);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 24);
            this.label16.TabIndex = 71;
            this.label16.Text = "Satış qiyməti";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicineSellPrice
            // 
            this.txt_medicineSellPrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineSellPrice.Location = new System.Drawing.Point(16, 299);
            this.txt_medicineSellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicineSellPrice.Name = "txt_medicineSellPrice";
            this.txt_medicineSellPrice.Size = new System.Drawing.Size(228, 26);
            this.txt_medicineSellPrice.TabIndex = 70;
            // 
            // txt_FilterByName
            // 
            this.txt_FilterByName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilterByName.Location = new System.Drawing.Point(10, 376);
            this.txt_FilterByName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FilterByName.Name = "txt_FilterByName";
            this.txt_FilterByName.Size = new System.Drawing.Size(228, 27);
            this.txt_FilterByName.TabIndex = 72;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(242, 376);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(96, 27);
            this.btn_Filter.TabIndex = 73;
            this.btn_Filter.Text = "Axtar...";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_clearFilters
            // 
            this.btn_clearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_clearFilters.Enabled = false;
            this.btn_clearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearFilters.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFilters.ForeColor = System.Drawing.Color.White;
            this.btn_clearFilters.Location = new System.Drawing.Point(342, 376);
            this.btn_clearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearFilters.Name = "btn_clearFilters";
            this.btn_clearFilters.Size = new System.Drawing.Size(143, 27);
            this.btn_clearFilters.TabIndex = 74;
            this.btn_clearFilters.Text = "Filterləri Təmizlə";
            this.btn_clearFilters.UseVisualStyleBackColor = false;
            this.btn_clearFilters.Click += new System.EventHandler(this.btn_clearFilters_Click);
            // 
            // inventoryImg
            // 
            this.inventoryImg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.inventoryImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryImg.Image = global::DrugStoreManagementSystem.Properties.Resources.drugs1;
            this.inventoryImg.Location = new System.Drawing.Point(1030, 24);
            this.inventoryImg.Name = "inventoryImg";
            this.inventoryImg.Size = new System.Drawing.Size(316, 320);
            this.inventoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryImg.TabIndex = 67;
            this.inventoryImg.TabStop = false;
            // 
            // backMenuimg
            // 
            this.backMenuimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuimg.Image = global::DrugStoreManagementSystem.Properties.Resources.back;
            this.backMenuimg.Location = new System.Drawing.Point(10, 24);
            this.backMenuimg.Name = "backMenuimg";
            this.backMenuimg.Size = new System.Drawing.Size(25, 25);
            this.backMenuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMenuimg.TabIndex = 54;
            this.backMenuimg.TabStop = false;
            this.backMenuimg.Click += new System.EventHandler(this.backMenuimg_Click);
            // 
            // ManageMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 781);
            this.Controls.Add(this.btn_clearFilters);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txt_FilterByName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_medicineSellPrice);
            this.Controls.Add(this.editMedicinePanel);
            this.Controls.Add(this.data_Medicines);
            this.Controls.Add(this.inventoryImg);
            this.Controls.Add(this.cmbx_MedicineManufacturer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbx_MedicineFormat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbx_MedicineCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_medicinePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_medicineBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backMenuimg);
            this.Controls.Add(this.btn_addMedicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_medicineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1366, 820);
            this.Name = "ManageMedicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMedicines";
            this.Load += new System.EventHandler(this.ManageMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Medicines)).EndInit();
            this.editMedicinePanel.ResumeLayout(false);
            this.editMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox backMenuimg;
        private System.Windows.Forms.Button btn_addMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_medicineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_medicineBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_medicinePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_MedicineCategory;
        private System.Windows.Forms.ComboBox cmbx_MedicineFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbx_MedicineManufacturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox inventoryImg;
        private System.Windows.Forms.DataGridView data_Medicines;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel editMedicinePanel;
        private System.Windows.Forms.ComboBox cmbx_EditMedicineManufacturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbx_EditMedicineFormat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbx_EditMedicineCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_EditmedicinePrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_EditmedicineBarcode;
        private System.Windows.Forms.Button btn_updateMedicine;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_EditmedicineName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_EditmedicineSellPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_medicineSellPrice;
        private System.Windows.Forms.TextBox txt_FilterByName;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_clearFilters;
    }
}