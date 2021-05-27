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
    public partial class ManageMedicineFormats : Form
    {
        ModelContext _context = new ModelContext();

        string role;
        public ManageMedicineFormats(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        private void updateDataGridView()
        {
            data_MedicineFormats.DataSource = _context.MedicineFormat.ToList();
        }

        private void ManageMedicineFormats_Load(object sender, EventArgs e)
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

        private void btn_addMedicineFormat_Click(object sender, EventArgs e)
        {
            if (txt_medicineFormat.Text.Trim() != "")
            {
                MedicineFormat medicineFormat = new MedicineFormat
                {
                    formatName = txt_medicineFormat.Text
                };

                _context.MedicineFormat.Add(medicineFormat);
                _context.SaveChanges();
                txt_medicineFormat.Text = "";
                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Dərman formatı boş ola bilməz", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_medicineFormat.Text = "";
            }
        }

        private void data_MedicineFormats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_MedicineFormats.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = Convert.ToInt32(data_MedicineFormats.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.MedicineFormat.Where(c => c.formatId == id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bu dərman formatı və ona bağlı olan dərmanlar silinəcək. Davam etmək istəyirsiniz?", "Xəbərdarlıq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _context.MedicineFormat.Remove(x);
                    _context.SaveChanges();
                    updateDataGridView();
                    MessageBox.Show("Dərman formatı silindi", "Məlumat", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {
                    updateDataGridView();
                }
            }
            else if (data_MedicineFormats.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = Convert.ToInt32(data_MedicineFormats.Rows[e.RowIndex].Cells[0].Value.ToString());
                var x = _context.MedicineFormat.Where(c => c.formatId == id).FirstOrDefault();

                var updated = data_MedicineFormats.Rows[e.RowIndex].Cells[1].Value.ToString();

                x.formatName = updated;
                _context.SaveChanges();
                updateDataGridView();
                MessageBox.Show("Dərman formatı yeniləndi", "Məlumat", MessageBoxButtons.OK);
            }
        }
    }
}
