using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreManagementSystem
{
    public partial class ManageCategories : Form
    {
        ModelContext _context = new ModelContext();

        string role;
        public ManageCategories(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        private void backMenuimg_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Main(role);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void updateDataGridView()
        {
            data_Category.DataSource = _context.Category.ToList();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btn_addCategory_Click_1(object sender, EventArgs e)
        {
            if (txt_categoryName.Text.Trim() != "")
            {
                Category category = new Category
                {
                    categoryName = txt_categoryName.Text
                };

                _context.Category.Add(category);
                _context.SaveChanges();
                txt_categoryName.Text = "";
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Kateqoriya adı boş ola bilməz", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_categoryName.Text = "";
            }
        }

        private void data_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Category.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = Convert.ToInt32(data_Category.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.Category.Where(c => c.categoryId == id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bu kateqoriya və ona bağlı olan dərmanlar silinəcək. Davam etmək istəyirsiniz?", "Xəbərdarlıq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _context.Category.Remove(x);
                    _context.SaveChanges();
                    updateDataGridView();
                    MessageBox.Show("Kateqoriya silindi", "Məlumat", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {
                    updateDataGridView();
                }
            }
            else if (data_Category.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = Convert.ToInt32(data_Category.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.Category.Where(c => c.categoryId == id).FirstOrDefault();

                var updated = data_Category.Rows[e.RowIndex].Cells[1].Value.ToString();

                x.categoryName = updated;
                _context.SaveChanges();
                updateDataGridView();
                MessageBox.Show("Kateqoriya yeniləndi", "Məlumat", MessageBoxButtons.OK);
            }
        }
    }
}
