using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_v2
{
    public partial class StockDetails : Form
    {
        private string stockIDFromCell;
        private Stock s;
        public StockDetails(int stockID)
        {
            InitializeComponent();
            stockIDFromCell = stockID.ToString();

            tbxStockID.ReadOnly = true;

           fillTextboxes();

        }

        private void fillTextboxes()
        {
            s = StockAccess.getStockByID(stockIDFromCell);

            tbxStockID.Text = stockIDFromCell.ToString();
            tbxItemname.Text = s.Itemname;
            tbxQuantity.Text = s.Quantity.ToString();
            tbxThreshold.Text = s.Threshold.ToString();
            tbxPrice.Text = s.Price.ToString();
            cbxItemType.Text = s.StockType.ToString();
        }

       
        private void StockDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StockQueries stockQueries = new StockQueries();
            stockQueries.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (tbxStockID.Text != "" && tbxItemname.Text != "" && tbxQuantity.Text != "" && tbxThreshold.Text != "" && tbxPrice.Text != "" && cbxItemType.Text != "")
            {
                Stock stock = new Stock(Int32.Parse(tbxStockID.Text), tbxItemname.Text, Decimal.Parse(tbxQuantity.Text), Int32.Parse(tbxThreshold.Text), Decimal.Parse(tbxPrice.Text), cbxItemType.Text);
                int result = StockAccess.upDateStock(stock);

                if (result == 1)
                {
                    MessageBox.Show("Van has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    foreach (Control co in this.Controls)
                    {

                        if (co is TextBox)
                            co.Text = "";
                    }
                }
                else
                    MessageBox.Show("Stock has not been updated!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Make sure no textboxes are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            StockQueries s = new StockQueries();
            s.Show();
            this.Hide();
        }
    }
}
