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
    public partial class ManageInventory : Form
    {
        ModelContext _context = new ModelContext();

        string role;
        public ManageInventory(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        private void updateDataGridView()
        {
            var inventory = _context.Inventory.Select(i => new
            {
                ID = i.inventoryId,
                Dərman = i.Medicine.medicineName,
                Barkod = i.Medicine.medicineBarcode,
                Kateqoriya = i.Medicine.Category.categoryName,
                Format = i.Medicine.MedicineFormat.formatName,
                İstehsalçı = i.Medicine.Manufacturer.manufacturerName,
                Say = i.count
            }).ToList();

            data_Inventory.DataSource = inventory.ToList();
            data_Inventory.Columns["Edit"].DisplayIndex = 7;
        }

        private void searchMedicineByName()
        {
            var inventory = _context.Inventory.Select(i => new
            {
                ID = i.inventoryId,
                Dərman = i.Medicine.medicineName,
                Barkod = i.Medicine.medicineBarcode,
                Kateqoriya = i.Medicine.Category.categoryName,
                Format = i.Medicine.MedicineFormat.formatName,
                İstehsalçı = i.Medicine.Manufacturer.manufacturerName,
                Say = i.count
            }).ToList();

            data_Inventory.DataSource = inventory.Where(i => i.Dərman.ToLower().Contains(txt_FilterByName.Text.ToLower())).ToList();
        }

        private void backMenuimg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Main(role);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            updateDataGridView();

            cmbx_Medicine.DataSource = _context.Medicine.ToList();
            cmbx_Medicine.DisplayMember = "medicineName";
            cmbx_Medicine.ValueMember = "medicineId";
        }

        private void btn_addToInventory_Click(object sender, EventArgs e)
        {
            if (txt_MedicineCount.Value != 0)
            {
                if (_context.Inventory.Any(i => i.medicineId == (int)cmbx_Medicine.SelectedValue))
                {
                    var x = _context.Inventory.Where(c => c.medicineId == (int)cmbx_Medicine.SelectedValue).FirstOrDefault();

                    x.count += Convert.ToInt32(txt_MedicineCount.Value);

                    _context.SaveChanges();
                    txt_MedicineCount.Value = 0;

                    updateDataGridView();

                    MessageBox.Show("Mövcud dərman yeniləndi", "Məlumat", MessageBoxButtons.OK);
                }
                else
                {
                    Inventory inventory = new Inventory
                    {
                        medicineId = (int)cmbx_Medicine.SelectedValue,
                        count = Convert.ToInt32(txt_MedicineCount.Value)
                    };

                    _context.Inventory.Add(inventory);
                    _context.SaveChanges();
                    txt_MedicineCount.Value = 0;

                    updateDataGridView();

                    MessageBox.Show("Yeni dərman əlavə edildi", "Məlumat", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Inventory.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = Convert.ToInt32(data_Inventory.Rows[e.RowIndex].Cells[1].Value.ToString());
                var x = _context.Inventory.Where(c => c.inventoryId == id).FirstOrDefault();
                btn_addToInventory.Enabled = false;
                btn_UpdateInventory.Enabled = true;

                cmbx_Medicine.SelectedValue = x.medicineId;
                cmbx_Medicine.Enabled = false;
            }
        }

        private void btn_UpdateInventory_Click(object sender, EventArgs e)
        {
            if (txt_MedicineCount.Value != 0)
            {
                var x = _context.Inventory.Where(c => c.medicineId == (int)cmbx_Medicine.SelectedValue).FirstOrDefault();

                x.count = Convert.ToInt32(txt_MedicineCount.Value);

                _context.SaveChanges();
                txt_MedicineCount.Value = 0;
                cmbx_Medicine.Enabled = true;
                btn_UpdateInventory.Enabled = false;
                btn_addToInventory.Enabled = true;

                updateDataGridView();

                MessageBox.Show("Say yeniləndi", "Məlumat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (txt_FilterByName.Text.Trim() != "")
            {
                searchMedicineByName();
                btn_clearFilters.Enabled = true;
                txt_FilterByName.Text = "";
            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clearFilters_Click_1(object sender, EventArgs e)
        {
            txt_FilterByName.Text = "";
            btn_clearFilters.Enabled = false;
            updateDataGridView();
        }
    }
}
