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
    public partial class ManageMedicines : Form
    {
        ModelContext _context = new ModelContext();

        int updatedMedicineId;

        string role;
        public ManageMedicines(string _role)
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
            var medicines = _context.Medicine.Select(m => new
            {
                ID = m.medicineId,
                Dərman = m.medicineName,
                Alış = m.medicinePrice,
                Satış = m.medicineSellingPrice,
                Barkod = m.medicineBarcode,
                Kateqoriya = m.Category.categoryName,
                Format = m.MedicineFormat.formatName,
                İstehsalçı = m.Manufacturer.manufacturerName
            }).ToList();

            data_Medicines.DataSource = medicines.ToList();
            data_Medicines.Columns["Edit"].DisplayIndex = 9;
            data_Medicines.Columns["Delete"].DisplayIndex = 9;
        }

        private void searchMedicineByName()
        {
            var medicines = _context.Medicine.Select(m => new
            {
                ID = m.medicineId,
                Dərman = m.medicineName,
                Alış = m.medicinePrice,
                Satış = m.medicineSellingPrice,
                Barkod = m.medicineBarcode,
                Kateqoriya = m.Category.categoryName,
                Format = m.MedicineFormat.formatName,
                İstehsalçı = m.Manufacturer.manufacturerName
            }).ToList();

            data_Medicines.DataSource = medicines.Where(n => n.Dərman.ToLower().Contains(txt_FilterByName.Text.ToLower())).ToList();
        }

        private void ManageMedicines_Load(object sender, EventArgs e)
        {
            updateDataGridView();

            cmbx_MedicineCategory.DataSource = _context.Category.ToList();
            cmbx_MedicineCategory.DisplayMember = "categoryName";
            cmbx_MedicineCategory.ValueMember = "categoryId";

            cmbx_MedicineFormat.DataSource = _context.MedicineFormat.ToList();
            cmbx_MedicineFormat.DisplayMember = "formatName";
            cmbx_MedicineFormat.ValueMember = "formatId";

            cmbx_MedicineManufacturer.DataSource = _context.Manufacturer.ToList();
            cmbx_MedicineManufacturer.DisplayMember = "manufacturerName";
            cmbx_MedicineManufacturer.ValueMember = "manufacturerId";

            cmbx_EditMedicineCategory.DataSource = _context.Category.ToList();
            cmbx_EditMedicineCategory.DisplayMember = "categoryName";
            cmbx_EditMedicineCategory.ValueMember = "categoryId";

            cmbx_EditMedicineFormat.DataSource = _context.MedicineFormat.ToList();
            cmbx_EditMedicineFormat.DisplayMember = "formatName";
            cmbx_EditMedicineFormat.ValueMember = "formatId";

            cmbx_EditMedicineManufacturer.DataSource = _context.Manufacturer.ToList();
            cmbx_EditMedicineManufacturer.DisplayMember = "manufacturerName";
            cmbx_EditMedicineManufacturer.ValueMember = "manufacturerId";
        }

        private void btn_addMedicine_Click(object sender, EventArgs e)
        {
            if (txt_medicineName.Text.Trim() != "" && txt_medicineBarcode.Text.Trim() != "" && txt_medicinePrice.Text.Trim() != "")
            {
                Medicine medicine = new Medicine
                {
                    medicineName = txt_medicineName.Text,
                    medicineBarcode = Convert.ToInt32(txt_medicineBarcode.Text),
                    medicinePrice = Convert.ToDecimal(txt_medicinePrice.Text),
                    medicineSellingPrice = Convert.ToDecimal(txt_medicineSellPrice.Text),
                    categoryId = (int)cmbx_MedicineCategory.SelectedValue,
                    manufacturerId = (int)cmbx_MedicineManufacturer.SelectedValue,
                    formatId = (int)cmbx_MedicineFormat.SelectedValue
                };

                _context.Medicine.Add(medicine);
                _context.SaveChanges();
                txt_medicineName.Text = "";
                txt_medicineBarcode.Text = "";
                txt_medicinePrice.Text = "";
                txt_medicineSellPrice.Text = "";
                updateDataGridView();
                MessageBox.Show("Dərman əlavə edildi", "Məlumat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bütün xanaları doldurun", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_Medicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_Medicines.Columns[e.ColumnIndex].Name == "Delete")
            {
                var id = Convert.ToInt32(data_Medicines.Rows[e.RowIndex].Cells[2].Value.ToString());
                var x = _context.Medicine.Where(m => m.medicineId == id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bu dərman silinəcək. Davam etmək istəyirsiniz?", "Xəbərdarlıq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _context.Medicine.Remove(x);
                    _context.SaveChanges();
                    updateDataGridView();
                    MessageBox.Show("Dərman silindi", "Məlumat", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {
                    updateDataGridView();
                }
            }
            else if (data_Medicines.Columns[e.ColumnIndex].Name == "Edit")
            {
                var id = Convert.ToInt32(data_Medicines.Rows[e.RowIndex].Cells[2].Value.ToString());
                var x = _context.Medicine.Where(c => c.medicineId == id).FirstOrDefault();
                updatedMedicineId = id;
                editMedicinePanel.Visible = true;

                txt_EditmedicineName.Text = x.medicineName;
                txt_EditmedicineBarcode.Text = x.medicineBarcode.ToString();
                txt_EditmedicinePrice.Text = x.medicinePrice.ToString();
                txt_EditmedicineSellPrice.Text = x.medicineSellingPrice.ToString();

                cmbx_EditMedicineCategory.SelectedValue = x.categoryId;
                cmbx_EditMedicineFormat.SelectedValue = x.formatId;
                cmbx_EditMedicineManufacturer.SelectedValue = x.manufacturerId;
            }
        }

        private void btn_updateMedicine_Click(object sender, EventArgs e)
        {

            if (txt_EditmedicineName.Text.Trim() != "" && txt_EditmedicineBarcode.Text.Trim() != "" && txt_EditmedicinePrice.Text.Trim() != "" && txt_EditmedicineSellPrice.Text.Trim() != "")
            {
                var x = _context.Medicine.Where(c => c.medicineId == updatedMedicineId).FirstOrDefault();

                x.medicineName = txt_EditmedicineName.Text.Trim();
                x.medicineBarcode = Convert.ToInt32(txt_EditmedicineBarcode.Text.Trim());
                x.medicinePrice = Convert.ToDecimal(txt_EditmedicinePrice.Text.Trim());
                x.medicineSellingPrice = Convert.ToDecimal(txt_EditmedicineSellPrice.Text.Trim());

                x.categoryId = (int)cmbx_EditMedicineCategory.SelectedValue;
                x.formatId = (int)cmbx_EditMedicineFormat.SelectedValue;
                x.manufacturerId = (int)cmbx_EditMedicineManufacturer.SelectedValue;

                _context.SaveChanges();
                updateDataGridView();
                txt_EditmedicineName.Text = "";
                txt_EditmedicineBarcode.Text = "";
                txt_EditmedicinePrice.Text = "";
                txt_EditmedicineSellPrice.Text = "";
                editMedicinePanel.Visible = false;
                MessageBox.Show("Dərman yeniləndi", "Məlumat", MessageBoxButtons.OK);
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

        private void btn_clearFilters_Click(object sender, EventArgs e)
        {
            txt_FilterByName.Text = "";
            btn_clearFilters.Enabled = false;
            updateDataGridView();
        }
    }
}
