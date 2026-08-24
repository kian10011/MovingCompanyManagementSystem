using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Movers_v2
{
    public partial class StockQueries : Form
    {
        DataTable table = new DataTable();
        decimal totalPrice = 0;




        public StockQueries()
        {


            InitializeComponent();
            createTableStock(StockAccess.getallstockIDasc());
            createTableReorder(cbxViewOrder.SelectedIndex);

            populate();



            cbxOrderItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDisplayStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxViewOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrdersWithDiscrepancies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuery.DropDownStyle = ComboBoxStyle.DropDownList;


            string formattedDate = DateTime.Today.ToString("yyyy/MM/dd");
            lbldate.Text += formattedDate;

            tbxDisplayReorderID.ReadOnly = true;
            tbxDisplayQty.ReadOnly = true;
            tbxDisplayStockID.ReadOnly = true;
            tbxReportedDiscrepancies.ReadOnly = true;



        }

        public void popupUndeliveredItems()
        {

            try
            {
                cbxViewOrder.SelectedIndex = 0;

                DataTable undeliveredStock = ReorderAccess.undeliveredStock();


                if (undeliveredStock.Rows.Count > 0)
                {

                    string message = "The following Orders have not been delivered yet:\n\n";

                    foreach (DataRow row in undeliveredStock.Rows)
                    {
                        message += $"Reorder ID: {row["reorderID"]} -  {row["itemname"]} ordered on {row["order_date"]} \n";
                    }


                    MessageBox.Show(message, "Undelivered stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading undelivered stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void popupUnderThreshold()
        {

            try
            { 
                DataTable dt = StockAccess.StockBelowThresold();

                if(dt.Rows.Count > 0)
                {
                    string message = "The following stock is below the minimum threshold!: \n";

                    foreach (DataRow row in dt.Rows)
                    {



                        message += "StockID: " + row["stockID"] + " - " + row["itemname"] + "|| Threshold of " + row["threshold"] + "\n";



                    }
                    MessageBox.Show(message, "Stock below minimum threshold", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Stock below threshold: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void createTableStock(DataTable d)
        {


            //table.Columns.Clear();
            //table.Rows.Clear();
            //lblResults.Text = "Result set size: " + Convert.ToString(StockList.Count);
            //table.Columns.Add("Stock ID");
            //table.Columns.Add("Item name");
            //table.Columns.Add("Item type");
            //table.Columns.Add("quantity");
            //table.Columns.Add("Threshold");
            //table.Columns.Add("Price");
            //table.Columns.Add("Stock Type");

            //foreach (Stock stock in StockList)
            //{
            //    table.Rows.Add(stock.StockID, stock.Itemname, stock.StockType, stock.Quantity, stock.Threshold, "£" + stock.Price, stock.StockType);
            //}

            dgvResults.DataSource = d;

        }
        public void createTableReorder(int index)
        {
            if (index == 0)
            {
                dgvReorder.DataSource = ReorderAccess.getAllOrders();
            }
            else if (index == 1)
            {
                dgvReorder.DataSource = ReorderAccess.getTodaysOrders();
            }
            else if (index == 2)
            {
                dgvReorder.DataSource = ReorderAccess.getWeeksOrders();
            }
            else if (index == 3)
            {
                dgvReorder.DataSource = ReorderAccess.getMonthsOrders();
            }
            else if (index == 4)
            {
                dgvReorder.DataSource = ReorderAccess.getYearsOrders();
            }


        }

        public void createTableDiscrepancies()
        {
            dgvDiscrepancies.DataSource = ReorderAccess.getOrdersWithDiscrepancies();


        }

        public void populate()
        {

            cbxOrderItem.Items.Clear();
            cbxOrdersWithDiscrepancies.Items.Clear();

            List<Stock> s = StockAccess.getAllStock();

            foreach (Stock stock in s)
            {
                cbxOrderItem.Items.Add(stock.StockID + " - " + stock.Itemname + "|| " + stock.StockType);
            }

            if(dgvDiscrepancies.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgvDiscrepancies.Rows)
                {
                    cbxOrdersWithDiscrepancies.Items.Add(row.Cells["reorderID"].Value.ToString() + " - " + row.Cells["itemname"].Value.ToString() + " || ordered on " + row.Cells["order date"].Value.ToString());
                }
            }
           





        }

        public void clear()
        {
            cbxOrderItem.SelectedIndex = -1;
            cbxOrderItem.SelectedIndex = -1;


            tbxDiscrepancies.Text = "";

            

        }
        private void StockQueries_Load(object sender, EventArgs e)
        {


        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxQuery.SelectedIndex)
            {
                case 0: createTableStock(StockAccess.getallstockIDasc()); break;
                case 1: createTableStock(StockAccess.getallstockIDdesc()); break;
                case 2: createTableStock(StockAccess.getallstocknameasc()); break;
                case 3: createTableStock(StockAccess.getallstocknamedesc()); break;
                case 4: createTableStock(StockAccess.getallstockquantityasc()); break;
                case 5: createTableStock(StockAccess.getallstockquantitydesc()); break;
                case 6: createTableStock(StockAccess.getallstockpriceasc()); break;
                case 7: createTableStock(StockAccess.getallstockpricedesc()); break;

            }
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //makes sure cellnames are not selected
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < 1)
            {
                //gets the value inside the cell being selected
                var cellValue = dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                //checks if cell is not empty, cell is an int, and if it is an int, outputs the int to the variable stockID
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int stockID))
                {
                    //checks if the stockID inside the cell being selected exists in database
                    if (StockAccess.checkStockIDExists(stockID))
                    {
                        //opens stockdetails form
                        StockDetails r = new StockDetails(stockID);
                        r.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Selected Stock ID does not exist in the database!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Please select the StockID of stock to be edited.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Please select the StockID of stock to be edited.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            bool emptyFields = false;

            if (cbxOrderItem.Text == "" || tbxOrderQty.Text == "")
            {
                emptyFields = true;
            }



            if (emptyFields == false && decimal.TryParse(tbxOrderQty.Text, out decimal result))
            {


                decimal orderQty = Decimal.Parse(tbxOrderQty.Text);

                int spaceIndexItem = cbxOrderItem.Text.IndexOf(" ");
                string stockID = cbxOrderItem.Text.Substring(0, spaceIndexItem);

                Stock s = StockAccess.getStockByID(stockID);
                totalPrice = orderQty * s.Price;

                if (s.StockType == "Solid")
                {
                    if (orderQty >= 1)
                    {
                        Reorder reorder = new Reorder(0, Int32.Parse(stockID), DateTime.Today, orderQty, "Not delivered", "N/A", totalPrice);
                        int rows = ReorderAccess.addOrder(reorder);

                        if (rows == 1)
                        {
                            MessageBox.Show("Order for item has been placed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbxOrderQty.Text = "";
                            clear();
                        }
                        else
                            MessageBox.Show("Order for item has not been placed!", "An error occurred when attempting to place order for selected item.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Ensure that quantity amount should be above 1 for solid items.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (orderQty > 0)
                    {
                        Reorder reorder = new Reorder(0, Int32.Parse(stockID), DateTime.Today.Date, orderQty, "Not delivered", "N/A", totalPrice);
                        int rows = ReorderAccess.addOrder(reorder);

                        if (rows == 1)
                        {
                            MessageBox.Show("Order for item has been placed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbxOrderQty.Text = "";
                            clear();
                        }
                        else
                            MessageBox.Show("Order for item has not been placed!", "An error occurred when attempting to place order for selected item.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Ensure that quantity amount should be above 0 for liquid items.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                createTableReorder(cbxViewOrder.SelectedIndex);
            }
            else
                MessageBox.Show("Ensure that an item has been selected, and the quantity required to order.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);








        }

        private void dgvReorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dgvReorder.Rows[e.RowIndex];

                tbxDisplayReorderID.Text = row.Cells["reorderID"].Value.ToString();
                tbxDisplayStockID.Text = row.Cells["stockID"].Value.ToString();
                tbxDisplayQty.Text = row.Cells["quantity_ordered"].Value.ToString();
                cbxDisplayStatus.Text = row.Cells["status"].Value.ToString(); // If it's a ComboBox
                tbxDiscrepancies.Text = "";

                if (row.Cells["status"].Value.ToString() == "Delivered")
                {

                    cbxDisplayStatus.Enabled = false;

                }
                else
                {
                    cbxDisplayStatus.Enabled = true;
                }
                
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (tbxDisplayReorderID.Text != "")
            {
                Reorder r = ReorderAccess.getOrderByID(Int32.Parse(tbxDisplayReorderID.Text));





                if (tbxDiscrepancies.Text == "")
                {
                    tbxDiscrepancies.Text = "N/A";
                }
                if (cbxDisplayStatus.Text != "" && cbxDisplayStatus.Text != "Not Delivered")
                {
                    int rowsUpdated = ReorderAccess.updateOrder(Int32.Parse(tbxDisplayReorderID.Text), cbxDisplayStatus.Text, tbxDiscrepancies.Text, r.Order_Date.ToString("yyyy/MM/dd"));



                    if (rowsUpdated == 1)
                    {


                        MessageBox.Show("Order has been successfully changed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        if (tbxDiscrepancies.Text == "N/A")
                        {
                            int quantityUpdated = StockAccess.upDateStockQuantity(r.StockID, r.Quantityordered);

                            if (quantityUpdated == 1)
                            {
                                MessageBox.Show("Updated quantity of delivered stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clear();

                                createTableReorder(cbxViewOrder.SelectedIndex);
                            }


                        }
                        else
                        {
                            DialogResult re = MessageBox.Show("Delivered stock quantity has not been delivered as discrepancies have been reported!\n Would you like to go to the discrepancies screen?" , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (re == DialogResult.Yes)
                            {
                                tcStock.SelectedIndex = 2;
                            }

                            clear();

                            createTableReorder(cbxViewOrder.SelectedIndex);
                        }


                    }
                    else
                        MessageBox.Show("Order status has not been changed! Something went wrong when attempting to change status of order.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Order status has not been changed! Please update order to delivered!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("Please select an order to update before proceeding.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static void GenerateOrderReport(DataGridView dgvReorder)
        {
            if (dgvReorder.DataSource == null)
            {
                MessageBox.Show("No data available for the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = (DataTable)dgvReorder.DataSource;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "OrderReport.pdf");

            try
            {
                //create a4 pdf with margin sizes
                Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create)); // set up pdf writer to write the document to the specified file
                doc.Open();

                // Title
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Order Report: " + DateTime.Now.ToString(), titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20
                };
                doc.Add(title);

                // Create PDF table

                string[] customHeaders = { "Reorder ID", "Stock ID", "Order Date", "Quantity Ordered", "Order status", "Order discrepancies", "Total Price" };
                PdfPTable table = new PdfPTable(customHeaders.Length)
                {
                    WidthPercentage = 100
                };

                // Add column headers
                float[] columnWidths = { 1.2f, 1.2f, 1.5f, 1.2f, 1.5f, 1.5f, 1.2f };
                table.SetWidths(columnWidths);

                // Define header font
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6, BaseColor.WHITE);

                // Add custom headers instead of default column names
                foreach (string header in customHeaders)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, headerFont))
                    {
                        BackgroundColor = BaseColor.BLACK,
                        Padding = 6,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        NoWrap = false
                    };
                    table.AddCell(cell);
                }

                // Add row data
                iTextSharp.text.Font rowFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                bool alternateRow = false;

                //loop datatable rows and add to the pdf table
                foreach (DataRow row in dt.Rows)
                {
                    //set alternating row colors to read data easier
                    BaseColor rowColor = alternateRow ? BaseColor.LIGHT_GRAY : BaseColor.WHITE; //background color
                    alternateRow = !alternateRow;

                    foreach (var item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), rowFont))
                        {
                            BackgroundColor = rowColor, //apply background color
                            Padding = 4, //set padding for each cell; controls the space inside a cell between the text and cell border
                            HorizontalAlignment = Element.ALIGN_CENTER //align text to center
                        };
                        table.AddCell(cell); //add cell to table
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show($"Order report has been created successfully!\nSaved at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the generated PDF
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when trying to generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxOrderQty_TextChanged(object sender, EventArgs e)
        {
            if (cbxOrderItem.Text != "" && tbxOrderQty.Text != "")
            {
                decimal orderQty = Decimal.Parse(tbxOrderQty.Text);

                int spaceIndexItem = cbxOrderItem.Text.IndexOf(" ");
                string stockID = cbxOrderItem.Text.Substring(0, spaceIndexItem);

                Stock s = StockAccess.getStockByID(stockID);
                totalPrice = Math.Round(orderQty * s.Price, 2);

                string priceString = totalPrice.ToString();

                lblPrice.Text = "Total Price: " + priceString;
            }
            else
            {
                lblPrice.Text = "Total Price: ";
            }
        }

        private void tbxOrderQty_KeyPress(object sender, KeyPressEventArgs e) //TextChanged event only triggers when numbers have been inputted
        {
            // Allow control keys (backspace), numbers, and dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();

            if (tcStock.SelectedIndex == 0)
            {
                createTableStock(StockAccess.getallstockIDasc());
            }
            if (tcStock.SelectedIndex == 2)
            {
                createTableDiscrepancies();
            }

            populate();
        }

        private void cbxViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            createTableReorder(cbxViewOrder.SelectedIndex);
        }

        public void checkBoxProperties()
        {
            if (!checkBox2.Checked && checkBox1.Checked)
            {

                dgvReorder.DataSource = ReorderAccess.getDeliveredOrders();

            }
            if (!checkBox2.Checked && !checkBox1.Checked)
            {

                createTableReorder(cbxViewOrder.SelectedIndex);

            }
            if (checkBox2.Checked && checkBox1.Checked)
            {

                createTableReorder(cbxViewOrder.SelectedIndex);

            }
            if (checkBox2.Checked && !checkBox1.Checked)
            {
                dgvReorder.DataSource = ReorderAccess.getUndeliveredOrders();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxProperties();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxProperties();
        }

        private void cbxOrdersWithDiscrepancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxOrdersWithDiscrepancies.Text.IndexOf(" ");
            int reorderID = Int32.Parse(cbxOrdersWithDiscrepancies.Text.Substring(0, spaceIndex));

            Reorder r = ReorderAccess.getOrderByID(reorderID);

            tbxReportedDiscrepancies.Text = r.Discrepancies;

        }

        private void btnUpdateDiscrepancy_Click(object sender, EventArgs e)
        {
            int spaceIndex = cbxOrdersWithDiscrepancies.Text.IndexOf(" ");
            string reorderID = cbxOrdersWithDiscrepancies.Text.Substring(0, spaceIndex);

            Reorder r = ReorderAccess.getOrderByID(Int32.Parse(reorderID));

            if (cbxOrdersWithDiscrepancies.Text != "")
            {


                if (checkBoxDiscrepancy.Checked)
                {
                    int quantityUpdated = StockAccess.upDateStockQuantity(r.StockID, r.Quantityordered);
                    int updateDisc = StockAccess.upDateToNoDiscrepancies(r.ReorderID);

                    try
                    {
                        if (quantityUpdated == 1 && updateDisc == 1)
                        {
                            MessageBox.Show("Updated quantity of delivered stock.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                            createTableDiscrepancies();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating quantity of stock: {ex.Message}. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }
                else
                {
                    MessageBox.Show("No changes have beeen made! Please mark the item's discrepancies as resolved.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Please select an order with discrepancies before proceeding.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void StockQueries_Shown(object sender, EventArgs e)
        {
            popupUndeliveredItems();
            popupUnderThreshold();
        }

        private void checkBoxDiscrepancy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAED_Click_1(object sender, EventArgs e)
        {

        }


        public static void ExportDataGridviewToPDF(string fileName, DataGridView dgv, string intromsg, string reportTitle)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = fileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Define Times New Roman Fonts
                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Times-Roman", 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font headerFont = FontFactory.GetFont("Times-Roman", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                    iTextSharp.text.Font cellFont = FontFactory.GetFont("Times-Roman", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font introFont = FontFactory.GetFont("Times-Roman", 12, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);

                    // Add report title
                    Paragraph title = new Paragraph("MOVERS Company Stock Form", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);
                    pdfDoc.Add(new Paragraph("\n"));

                    // Add introductory paragraph
                    string introText = intromsg;
                    Paragraph intro = new Paragraph(introText, introFont);
                    intro.Alignment = Element.ALIGN_JUSTIFIED;
                    pdfDoc.Add(intro);
                    pdfDoc.Add(new Paragraph("\n"));

                    // Export each DataGridView with section headers
                    AddDataGridViewToPDF(pdfDoc, dgv, reportTitle, headerFont, cellFont);


                    pdfDoc.Close();
                    MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AddDataGridViewToPDF(Document pdfDoc, DataGridView dgv, string title, iTextSharp.text.Font headerFont, iTextSharp.text.Font cellFont)
        {
            pdfDoc.Add(new Paragraph(title, FontFactory.GetFont("Times-Roman", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
            pdfDoc.Add(new Paragraph("\n"));

            if (dgv.Rows.Count > 0)
            {
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;

                // Add column headers with black background and white text
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                    {
                        BackgroundColor = BaseColor.BLACK,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(headerCell);
                }

                // Add data rows with alternating row colors
                bool isGray = false;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        BaseColor rowColor = isGray ? BaseColor.LIGHT_GRAY : BaseColor.WHITE;
                        isGray = !isGray; // Toggle row color

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", cellFont))
                            {
                                BackgroundColor = rowColor,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(dataCell);
                        }
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("\n")); // Add spacing
            }
            else
            {
                pdfDoc.Add(new Paragraph("No data available.", cellFont));
                pdfDoc.Add(new Paragraph("\n"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDiscrepancies.Rows.Count >= 1)
            {
                DialogResult re = MessageBox.Show("Do you want to produce a report of \n all orders with discrepancies?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Check the result of the MessageBox
                if (re == DialogResult.Yes)
                {
                    ExportDataGridviewToPDF("MOVERS_DISCREPANCIES.pdf", dgvDiscrepancies, "Welcome to the MOVERS Company Stock report. This document displays the details of all orders placed listed with discrepancies. To keep the company flowing, stock control is a big priority, therefore all discrepancies must be resolved as soon as possible.", "Orders with discrepancies");
                }
            }
            else
                MessageBox.Show("Report cannot be produced, as there are no orders with discrepancies!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void btnReportOrders_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to produce a report of \n orders?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Check the result of the MessageBox
            if (re == DialogResult.Yes)
            {
                ExportDataGridviewToPDF("MOVERS_ORDERS.pdf", dgvReorder, "Welcome to the MOVERS Company Stock report. This document displays the details of all orders placed. All orders are recorded in the system.", "Orders placed : " + dgvReorder.Rows.Count);
            }
        }
    }
}
