using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreManagementSystem
{
    public partial class ManageManufacturers : Form
    {
        ModelContext _context = new ModelContext();

        string role;
        public ManageManufacturers(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        private void updateDataGridView()
        {
            data_Manufacturer.DataSource = _context.Manufacturer.ToList();
        }

        private void ManageManufacturers_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void backMenuimg_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Main(role);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btn_addManufacturer_Click(object sender, EventArgs e)
        {
            if (txt_manufacturerName.Text.Trim() != "")
            {
                Manufacturer manufacturer = new Manufacturer
                {
                    manufacturerName = txt_manufacturerName.Text
                };

                _context.Manufacturer.Add(manufacturer);
                _context.SaveChanges();
                txt_manufacturerName.Text = "";
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("İstehsalçı adı boş ola bilməz", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_manufacturerName.Text = "";
            }
        }

        private void data_Manufacturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Manufacturer.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = Convert.ToInt32(data_Manufacturer.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.Manufacturer.Where(c => c.manufacturerId == id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bu istehsalçı və ona bağlı olan dərmanlar silinəcək. Davam etmək istəyirsiniz?", "Xəbərdarlıq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _context.Manufacturer.Remove(x);
                    _context.SaveChanges();
                    updateDataGridView();
                    MessageBox.Show("İstehsalçı silindi", "Məlumat", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {
                    updateDataGridView();
                }
            }
            else if (data_Manufacturer.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = Convert.ToInt32(data_Manufacturer.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.Manufacturer.Where(c => c.manufacturerId == id).FirstOrDefault();

                var updated = data_Manufacturer.Rows[e.RowIndex].Cells[1].Value.ToString();

                x.manufacturerName = updated;
                _context.SaveChanges();
                updateDataGridView();
                MessageBox.Show("İstehsalçı yeniləndi", "Məlumat", MessageBoxButtons.OK);
            }
        }
    }
}
