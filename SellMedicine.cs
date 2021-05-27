using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreManagementSystem
{
    public partial class SellMedicine : Form
    {
        ModelContext _context = new ModelContext();

        //List<Inventory> cart = new List<Inventory>();

        List<int> barcodes = new List<int>();
        List<decimal> prices = new List<decimal>();

        decimal total;
        decimal paid;

        string role;
        public SellMedicine(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {

        }

        private void backMenuimg_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Main(role);
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //string drawing = "";
            //foreach (var item in cheque.Items.Cast<ListViewItem>())
            //{
            //    drawing = drawing + String.Format("{0,6} | {1,4} | {2,4}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text) + "\n";
            //}

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(panel_Print.Width, panel_Print.Height);
            panel_Print.DrawToBitmap(bmp, new Rectangle(0, 0, panel_Print.Width, panel_Print.Height));
            e.Graphics.DrawString("**** DRUGSTORE ****", new Font("Roboto", 20, FontStyle.Bold), Brushes.Black, new PointF(200, 200));

            //e.Graphics.DrawString(String.Format("{0,6} | {1,4} | {2,4}", "Derman", "Say", "Qiymet"), new Font("Roboto", 20, FontStyle.Regular), Brushes.Black, new PointF(200, 200));
            //e.Graphics.DrawString(drawing, new Font("Roboto", 20, FontStyle.Regular), Brushes.Black, new PointF(200, 300));

            e.Graphics.DrawImage((Image)bmp, (e.PageBounds.Width - bmp.Width) / 2, (e.PageBounds.Height - bmp.Height) / 2, bmp.Width, bmp.Height);
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            int barcode = Convert.ToInt32(txt_medicineBarcode.Text);

            var x = _context.Medicine.Where(m => m.medicineBarcode == barcode).FirstOrDefault();

            barcodes.Add(barcode);
            prices.Add(x.medicinePrice);

            if (!cheque.Items.Cast<ListViewItem>().Any(item => item.SubItems[0].Text == x.medicineName))
            {
                cheque.Items.Add(new ListViewItem(new string[] { x.medicineName, "1", x.medicineSellingPrice.ToString() }));
            }
            else
            {
                var foundItem = cheque.Items.Cast<ListViewItem>().Where(item => item.SubItems[0].Text == x.medicineName).FirstOrDefault();

                int prevCount = Convert.ToInt32(foundItem.SubItems[1].Text);
                int currentCount = prevCount + 1;
                decimal currentPrice = x.medicineSellingPrice * currentCount;

                foundItem.SubItems[1].Text = currentCount.ToString();
                foundItem.SubItems[2].Text = currentPrice.ToString();
            }

            string[] totalList = this.cheque.Items.Cast<ListViewItem>().Select(item => item.SubItems[2].Text).ToArray();

            total = totalList.Sum(n => Convert.ToDecimal(n));

            lbl_total.Text = total.ToString();
        }

        private void btn_completePurchase_Click(object sender, EventArgs e)
        {
            var q = from n in barcodes
                    group n by n into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var n in q)
            {
                var x = _context.Medicine.Where(m => m.medicineBarcode == n.Value).FirstOrDefault();

                var y = _context.Inventory.Where(i => i.medicineId == x.medicineId).FirstOrDefault();

                y.count -= n.Count;

                _context.SaveChanges();
            }

            decimal profit = total - prices.Sum();

            Sales sale = new Sales
            {
                saleDate = DateTime.Now,
                profit = profit
            };

            _context.Sales.Add(sale);
            _context.SaveChanges();

            DialogResult dialogResult = MessageBox.Show("Çek çap edilsin?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.doc_PrintPage;

                PrintPreviewDialog dlgPrev = new PrintPreviewDialog();
                PrintDialog dlg = new PrintDialog();
                dlg.Document = doc;
                dlgPrev.Document = doc;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlgPrev.ShowDialog() == DialogResult.OK)
                    {
                        doc.Print();
                    }
                }
            }
            txt_medicineBarcode.Text = "";
            cheque.Items.Clear();
            barcodes.Clear();
            prices.Clear();
            lbl_total.Text = "0";
            txt_paidMoney.Text = "";
            lbl_residue.Text = "0";
            btn_completePurchase.Enabled = false;
        }

        private void txt_paidMoney_TextChanged(object sender, EventArgs e)
        {
            if (txt_paidMoney.Text.Trim() != "")
            {
                paid = Convert.ToDecimal(txt_paidMoney.Text);
                lbl_residue.Text = (paid - total).ToString();

                if (total <= Convert.ToDecimal(txt_paidMoney.Text))
                {
                    btn_completePurchase.Enabled = true;
                }
                else
                {
                    btn_completePurchase.Enabled = false;
                }

            }

        }
    }
}
