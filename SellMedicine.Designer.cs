
namespace DrugStoreManagementSystem
{
    partial class SellMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellMedicine));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_medicineBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.cheque = new System.Windows.Forms.ListView();
            this.medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Say = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qiymət = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_completePurchase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_residue = new System.Windows.Forms.Label();
            this.txt_paidMoney = new System.Windows.Forms.TextBox();
            this.panel_Print = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.backMenuimg = new System.Windows.Forms.PictureBox();
            this.panel_Print.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Dərman Barkodu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_medicineBarcode
            // 
            this.txt_medicineBarcode.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medicineBarcode.Location = new System.Drawing.Point(16, 96);
            this.txt_medicineBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medicineBarcode.Name = "txt_medicineBarcode";
            this.txt_medicineBarcode.Size = new System.Drawing.Size(273, 26);
            this.txt_medicineBarcode.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 18);
            this.panel1.TabIndex = 60;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToCart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.ForeColor = System.Drawing.Color.White;
            this.btn_addToCart.Location = new System.Drawing.Point(16, 139);
            this.btn_addToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(124, 31);
            this.btn_addToCart.TabIndex = 62;
            this.btn_addToCart.Text = "Əlavə Et";
            this.btn_addToCart.UseVisualStyleBackColor = false;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // cheque
            // 
            this.cheque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicine,
            this.Say,
            this.Qiymət});
            this.cheque.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheque.GridLines = true;
            this.cheque.HideSelection = false;
            this.cheque.Location = new System.Drawing.Point(3, 3);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(419, 448);
            this.cheque.TabIndex = 64;
            this.cheque.UseCompatibleStateImageBehavior = false;
            this.cheque.View = System.Windows.Forms.View.Details;
            // 
            // medicine
            // 
            this.medicine.Text = "Dərman";
            this.medicine.Width = 280;
            // 
            // Say
            // 
            this.Say.Text = "Say";
            this.Say.Width = 61;
            // 
            // Qiymət
            // 
            this.Qiymət.Text = "Qiymət";
            this.Qiymət.Width = 72;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cəm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(337, 461);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(85, 24);
            this.lbl_total.TabIndex = 67;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(45, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "Əsas Menyu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label4.TabIndex = 68;
            this.label4.Text = "Satış Et";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_completePurchase
            // 
            this.btn_completePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.btn_completePurchase.Enabled = false;
            this.btn_completePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_completePurchase.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_completePurchase.ForeColor = System.Drawing.Color.White;
            this.btn_completePurchase.Location = new System.Drawing.Point(311, 667);
            this.btn_completePurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_completePurchase.Name = "btn_completePurchase";
            this.btn_completePurchase.Size = new System.Drawing.Size(425, 36);
            this.btn_completePurchase.TabIndex = 71;
            this.btn_completePurchase.Text = "Tamamla";
            this.btn_completePurchase.UseVisualStyleBackColor = false;
            this.btn_completePurchase.Click += new System.EventHandler(this.btn_completePurchase_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(258, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ödəndi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(272, 533);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 74;
            this.label6.Text = "Qalıq:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_residue
            // 
            this.lbl_residue.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_residue.ForeColor = System.Drawing.Color.Black;
            this.lbl_residue.Location = new System.Drawing.Point(337, 533);
            this.lbl_residue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_residue.Name = "lbl_residue";
            this.lbl_residue.Size = new System.Drawing.Size(85, 24);
            this.lbl_residue.TabIndex = 76;
            this.lbl_residue.Text = "0";
            this.lbl_residue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_paidMoney
            // 
            this.txt_paidMoney.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paidMoney.ForeColor = System.Drawing.Color.Black;
            this.txt_paidMoney.Location = new System.Drawing.Point(341, 494);
            this.txt_paidMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txt_paidMoney.Name = "txt_paidMoney";
            this.txt_paidMoney.Size = new System.Drawing.Size(81, 30);
            this.txt_paidMoney.TabIndex = 77;
            this.txt_paidMoney.TextChanged += new System.EventHandler(this.txt_paidMoney_TextChanged);
            // 
            // panel_Print
            // 
            this.panel_Print.Controls.Add(this.cheque);
            this.panel_Print.Controls.Add(this.txt_paidMoney);
            this.panel_Print.Controls.Add(this.label1);
            this.panel_Print.Controls.Add(this.lbl_residue);
            this.panel_Print.Controls.Add(this.lbl_total);
            this.panel_Print.Controls.Add(this.label6);
            this.panel_Print.Controls.Add(this.label2);
            this.panel_Print.Location = new System.Drawing.Point(311, 96);
            this.panel_Print.Name = "panel_Print";
            this.panel_Print.Size = new System.Drawing.Size(425, 566);
            this.panel_Print.TabIndex = 79;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // backMenuimg
            // 
            this.backMenuimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenuimg.Image = global::DrugStoreManagementSystem.Properties.Resources.back;
            this.backMenuimg.Location = new System.Drawing.Point(17, 24);
            this.backMenuimg.Name = "backMenuimg";
            this.backMenuimg.Size = new System.Drawing.Size(25, 25);
            this.backMenuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMenuimg.TabIndex = 70;
            this.backMenuimg.TabStop = false;
            this.backMenuimg.Click += new System.EventHandler(this.backMenuimg_Click);
            // 
            // SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_completePurchase);
            this.Controls.Add(this.backMenuimg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_medicineBarcode);
            this.Controls.Add(this.panel_Print);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "SellMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellMedicine";
            this.Load += new System.EventHandler(this.SellMedicine_Load);
            this.panel_Print.ResumeLayout(false);
            this.panel_Print.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backMenuimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_medicineBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.ListView cheque;
        private System.Windows.Forms.ColumnHeader medicine;
        private System.Windows.Forms.ColumnHeader Qiymət;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.PictureBox backMenuimg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_completePurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_residue;
        private System.Windows.Forms.TextBox txt_paidMoney;
        private System.Windows.Forms.Panel panel_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColumnHeader Say;
    }
}