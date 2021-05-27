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
    public partial class ManageSales : Form
    {
        ModelContext _context = new ModelContext();

        string role;
        public ManageSales(string _role)
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

        private void ManageSales_Load(object sender, EventArgs e)
        {
            data_Sales.DataSource = _context.Sales.ToList();
        }

        private void btn_searchInterval_Click(object sender, EventArgs e)
        {
            data_Sales.DataSource = _context.Sales.Where(d => d.saleDate >= date_Start.Value && d.saleDate <= date_End.Value).ToList();
            btn_clearFilters.Enabled = true;
        }

        private void btn_clearFilters_Click(object sender, EventArgs e)
        {
            data_Sales.DataSource = _context.Sales.ToList();
            btn_clearFilters.Enabled = false;
        }
    }
}
