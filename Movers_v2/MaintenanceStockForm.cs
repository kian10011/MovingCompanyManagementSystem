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
    public partial class MaintenanceStockForm : Form
    {
        string maintenanceID;
        string stockID;
        string stockType;
        decimal finalcost = 0;
        decimal previousValue;
        decimal currentQuantity;
        public MaintenanceStockForm(int mID)
        {
            InitializeComponent();
            dgvResults.DataSource = MaintenanceAccess.maintenanceQueries();

            if (mID != 0)
            {
                dgvStockQuantity.DataSource = MaintenanceStockAccess.displayMaintenanceStockNeeded(mID);
                maintenanceID = mID.ToString();
            }
               



        }

        private void MaintenanceStockForm_Load(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            Stock s = StockAccess.getStockByID(stockID);
            currentQuantity = s.Quantity;
            lblTotalCost.Text = "Total maintenance cost (£): " + (MaintenanceStockAccess.calculateTotalCost(Int32.Parse(maintenanceID)).ToString("F2"));
            dgvStockQuantity.DataSource = MaintenanceStockAccess.displayMaintenanceStockNeeded(Int32.Parse(maintenanceID));

        }
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                lblSelectMaintenance.Visible = false;
                DataGridViewRow row = dgvResults.Rows[e.RowIndex];

                maintenanceID = row.Cells["maintenanceID"].Value.ToString();

                lblStockName.Text = "Select stock:";
                lblPricePerUnit.Text = "Price (£) / unit:";

                dgvStockQuantity.DataSource = MaintenanceStockAccess.displayMaintenanceStockNeeded(Int32.Parse(maintenanceID));

                lblTotalCost.Text = "Total maintenance cost (£): " + (MaintenanceStockAccess.calculateTotalCost(Int32.Parse(maintenanceID)).ToString("F2")); // makes it so that the total price is only displayed as two decimal places
            }
        }

        private void dgvStockQuantity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {

                DataGridViewRow row = dgvStockQuantity.Rows[e.RowIndex];

                stockID = row.Cells["stockID"].Value.ToString();
                Stock s = StockAccess.getStockByID(stockID);
                currentQuantity = s.Quantity;

                stockType = row.Cells["type"].Value.ToString();
                lblStockName.Text = row.Cells["itemname"].Value.ToString();
                lblPricePerUnit.Text = "Price (£) / unit: " + s.Price.ToString();

                numQuantity.Minimum = 0;
                numQuantity.Maximum = s.Quantity;

                if(stockType == "Solid")
                {
                    numQuantity.DecimalPlaces = 0;
                    numQuantity.Increment = 1M;
                    
                }
                else
                {
                    numQuantity.DecimalPlaces = 2;
                    numQuantity.Increment = 0.1M;
                }
                numQuantity.Value = Decimal.Parse(row.Cells["quantity"].Value.ToString());



            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Are you sure you want to add this quantity for the maintenance? \n The total cost is: " + (MaintenanceStockAccess.calculateTotalCost(Int32.Parse(maintenanceID)) + finalcost).ToString("F2"), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Check the result of the MessageBox
            if (re == DialogResult.Yes)
            {
                MaintenanceStock m = new MaintenanceStock(0, Int32.Parse(maintenanceID), Int32.Parse(stockID), finalcost, (decimal)numQuantity.Value);
                Stock s = StockAccess.getStockByID(stockID);

                bool exists = MaintenanceStockAccess.checkMaintenanceStockExists(Int32.Parse(maintenanceID), Int32.Parse(stockID));


                if (!exists)
                {
                    int result = MaintenanceStockAccess.addmaintenancestock(m);




                    if (result == 1)
                    {


                        MessageBox.Show("Stock has been added for the maintenance!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        MessageBox.Show("Quantity of stock has been updated \n " + s.StockID + " - " + s.Itemname + "|| Quantity: " + currentQuantity + "->" + s.Quantity);
                        refresh();
                    }
                    else
                        MessageBox.Show("Stock has not been added for the maintenance!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                }
                else
                {
                    int result2 = MaintenanceStockAccess.updateMaintenanceStock(Int32.Parse(maintenanceID), (decimal)numQuantity.Value, Int32.Parse(stockID));

                    if (result2 == 1)
                    {
                        MessageBox.Show("Stock has been added for the maintenance!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Quantity of stock has been updated \n " + s.StockID + " - " + s.Itemname + "|| Quantity: " + currentQuantity + "->" + s.Quantity);

                        refresh();
                    }
                    else
                        MessageBox.Show("Stock has not been added for the maintenance!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            
            finalcost = MaintenanceStockAccess.calculateFinalCost(stockID, (decimal)numQuantity.Value);
            lblTotalCost.Text = "Total maintenance cost (£): " + (MaintenanceStockAccess.calculateTotalCost(Int32.Parse(maintenanceID)) + finalcost).ToString("F2"); // makes it so that the total price is only displayed as two decimal places

            Stock s = StockAccess.getStockByID(stockID);

            if (numQuantity.Value > previousValue)
            {
                if(stockType == "Solid")
                {
                    StockAccess.decreaseStockQuantity(stockID); //if solid, and numeric up-down has been increased, decrease stock qty by  increments of 1
                }
                else
                {
                    StockAccess.decreaseStockQuantityLiquids(stockID); // if liquid, decrease stock qty in increments of 0.1
                }
                
            }
            else
            {
                if(stockType == "Solid")
                {
                    StockAccess.increaseStockQuantity(stockID); // if solid, and numeric up-down has been decreased, increase stock qty by increments of 1
                }
                else
                {
                    StockAccess.increaseStockQuantityLiquids(stockID); // if liquid, increase stock qty in increments of 0.1
                }
            }
            dgvStockQuantity.DataSource = MaintenanceStockAccess.displayMaintenanceStockNeeded(Int32.Parse(maintenanceID));
            previousValue = numQuantity.Value;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MaintenanceQueries m = new MaintenanceQueries();
            m.Show();
            this.Hide();
        }
    }
}
