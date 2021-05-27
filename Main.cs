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
    public partial class Main : Form
    {
        string role;
        public Main(string _role)
        {
            InitializeComponent();
            lbl_roleName.Text = _role;
            role = _role;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (role == "Admin")
            {
                panel_Sales.Visible = true;
            }
        }

        private void inventoryImg_MouseEnter(object sender, EventArgs e)
        {
            labelInv.ForeColor = Color.FromArgb(12, 123, 147);
        }

        private void inventoryImg_MouseLeave(object sender, EventArgs e)
        {
            labelInv.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void medicineImg_MouseEnter(object sender, EventArgs e)
        {
            labelMedicine.ForeColor = Color.FromArgb(12, 123, 147);
        }
        private void medicineImg_MouseLeave(object sender, EventArgs e)
        {
            labelMedicine.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void categoryImg_MouseEnter(object sender, EventArgs e)
        {
            labelCat.ForeColor = Color.FromArgb(12, 123, 147);
        }
        private void categoryImg_MouseLeave(object sender, EventArgs e)
        {
            labelCat.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void manufacturerImg_MouseEnter(object sender, EventArgs e)
        {
            labelManufacturer.ForeColor = Color.FromArgb(12, 123, 147);
        }
        private void manufacturerImg_MouseLeave(object sender, EventArgs e)
        {
            labelManufacturer.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void medicineFormatImg_MouseEnter(object sender, EventArgs e)
        {
            labelMedicineFormat.ForeColor = Color.FromArgb(12, 123, 147);
        }
        private void medicineFormatImg_MouseLeave(object sender, EventArgs e)
        {
            labelMedicineFormat.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void sellImg_MouseEnter(object sender, EventArgs e)
        {
            labelSell.ForeColor = Color.FromArgb(12, 123, 147);
        }
        private void sellImg_MouseLeave(object sender, EventArgs e)
        {
            labelSell.ForeColor = Color.FromArgb(20, 40, 80);
        }

        private void categoryImg_Click(object sender, EventArgs e)
        {
            if (role == "Admin" || role == "Anbardar")
            {
                this.Hide();
                var manageCategories = new ManageCategories(role);
                manageCategories.Closed += (s, args) => this.Close();
                manageCategories.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void manufacturerImg_Click(object sender, EventArgs e)
        {
            if (role == "Admin" || role == "Anbardar")
            {
                this.Hide();
                var manageManufacturers = new ManageManufacturers(role);
                manageManufacturers.Closed += (s, args) => this.Close();
                manageManufacturers.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void medicineFormatImg_Click(object sender, EventArgs e)
        {

            if (role == "Admin" || role == "Anbardar")
            {
                this.Hide();
                var manageMedicineFormats = new ManageMedicineFormats(role);
                manageMedicineFormats.Closed += (s, args) => this.Close();
                manageMedicineFormats.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void medicineImg_Click(object sender, EventArgs e)
        {
            if (role == "Admin" || role == "Anbardar")
            {
                this.Hide();
                var manageMedicines = new ManageMedicines(role);
                manageMedicines.Closed += (s, args) => this.Close();
                manageMedicines.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inventoryImg_Click(object sender, EventArgs e)
        {
            if (role == "Admin" || role == "Anbardar")
            {
                this.Hide();
                var manageInventory = new ManageInventory(role);
                manageInventory.Closed += (s, args) => this.Close();
                manageInventory.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sellImg_Click(object sender, EventArgs e)
        {
            if (role == "Admin" || role == "Satıcı")
            {
                this.Hide();
                var sell = new SellMedicine(role);
                sell.Closed += (s, args) => this.Close();
                sell.Show();
            }
            else
            {
                MessageBox.Show("Bu bölməyə giriş icazəniz yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salesImg_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sales = new ManageSales(role);
            sales.Closed += (s, args) => this.Close();
            sales.Show();
        }
    }
}
