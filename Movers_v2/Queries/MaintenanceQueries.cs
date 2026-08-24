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
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_v2
{
    public partial class MaintenanceQueries : Form
    {
        DataTable table = new DataTable();
        public MaintenanceQueries()
        {
            InitializeComponent();
            createTableMaintenance();
            refresh();

            populate();

            cbxmaintenanceid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxregno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxvanid.DropDownStyle = ComboBoxStyle.DropDownList;
        }

     
        public void populate()
        {
            List <Maintenance> m = MaintenanceAccess.getAllmaintenance();
            List<Van> v = VanAccess.getAllVansunderMaintenance();
           

            foreach(Van van in v)
            {
                cbxvanid.Items.Add(van.VanID);
                cbxregno.Items.Add(van.RegNo);
            }

            foreach(Maintenance maintenance in m)
            {
                cbxmaintenanceid.Items.Add(maintenance.MaintenanceID);
            }
        }
        public void refresh()
        {
            dtpmaintenancedate.CustomFormat = " ";
            dtpMOT.CustomFormat = " ";
            
            

            cbxmaintenanceid.ResetText();
            cbxvanid.ResetText();
            cbxtype.ResetText();

            cbxvanid.ResetText();

            
          
        }

        public void createTableMaintenance()
        {


            //table.Columns.Clear();
            //table.Rows.Clear();
            //table.Columns.Add("Maintenance ID");
            //table.Columns.Add("Van ID");
            //table.Columns.Add("Van registration number");
            //table.Columns.Add("Van MOT due date");
            //table.Columns.Add("Maintenance Start Date");
            //table.Columns.Add("Maintenance Start Time");
            //table.Columns.Add("Maintenance End Time");
            //table.Columns.Add("Service Description");
            //table.Columns.Add("Type");
            //table.Columns.Add("Staff firstname");
            //table.Columns.Add("Staff surname");
            //string maintenanceID, string vanID, string regNo, string motDueDate, string maintenanceStartDate, string maintenanceStartTime, string maintenanceEndTime,
            // string typeName, string firstname, string surname



            dgvResults.DataSource = MaintenanceAccess.getFilter(cbxmaintenanceid.Text, cbxvanid.Text, cbxregno.Text, dtpMOT.Text, dtpmaintenancedate.Text, cbxtype.Text, tbxfirst.Text, tbxsur.Text);


        }
        private void MaintenanceQueries_Load(object sender, EventArgs e)
        {

        }

        private void btnAED_Click(object sender, EventArgs e)
        {
             MaintenanceAED m = new MaintenanceAED();
            m.Show();
            this.Hide();
        }

        private void tbxfirst_TextChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void dtpmaintenancedate_ValueChanged(object sender, EventArgs e)
        {

            dtpmaintenancedate.CustomFormat = "yyyy/MM/dd";
            createTableMaintenance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
            createTableMaintenance();
            
        }

        private void dtpMOT_ValueChanged(object sender, EventArgs e)
        {

            dtpMOT.CustomFormat = "yyyy/MM/dd";
            createTableMaintenance();
        }

        private void cbxstafftype_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void cbxmaintenanceid_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void cbxvanid_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void tbxsur_TextChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void cbxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableMaintenance();
        }

      

        private void editMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (dgvResults.SelectedCells.Count > 0 && dgvResults.SelectedCells[0].ColumnIndex == 0) // Ensure a row is selected
            {


                int rowIndex = dgvResults.SelectedCells[0].RowIndex; // Get row index of the selected cell
                int maintenanceID = Convert.ToInt32(dgvResults.Rows[rowIndex].Cells["maintenanceID"].Value);

                // Open Maintenance AED form in Edit Mode
                MaintenanceAED maintenanceForm = new MaintenanceAED();
                maintenanceForm.openAtEdit(maintenanceID);
                maintenanceForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a maintenance record to edit.", "Edit Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void dgvResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0) //checks right click is being done to a cell
            {
                dgvResults.ClearSelection();
                dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                var cellValue = dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Check if the cell is not null or empty
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    // Show context menu at mouse position
                    contextMenuStrip1.Show(Cursor.Position);
                }
               
            }
        }

        private void deleteMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedCells.Count > 0 && dgvResults.SelectedCells[0].ColumnIndex == 0) // Ensure a row is selected
            {
                int rowIndex = dgvResults.SelectedCells[0].RowIndex; // Get row index of the selected cell
                int maintenanceID = Convert.ToInt32(dgvResults.Rows[rowIndex].Cells["maintenanceID"].Value);

                // Open Maintenance AED form in Edit Mode
                MaintenanceAED maintenanceForm = new MaintenanceAED();
                maintenanceForm.openAtDelete(maintenanceID);
                maintenanceForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a maintenance record to edit.", "Edit Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvResults.Rows.Count < 1)
            {
                MessageBox.Show("No data available for the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = (DataTable)dgvResults.DataSource;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MaintenanceReport.pdf");

            try
            {
                Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Title
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Custom maintenance Report: " + DateTime.Now.ToString(), titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20
                };
                doc.Add(title);

                // Create PDF table

                string[] customHeaders = { "Maintenance ID", "Van ID", "Reg. No", "MOT Due Date", "Start Date", "Start Time", "End Time", "Service Description", "Maintenance type", "Driver", "Mechanic" };
                PdfPTable table = new PdfPTable(customHeaders.Length)
                {
                    WidthPercentage = 100
                };

                // Add column headers
                float[] columnWidths = { 1f, 1f, 1.5f, 2f, 2f, 2f, 2f, 3f, 2f, 1.5f, 1.5f};
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
                iTextSharp.text.Font rowFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                bool alternateRow = false;

                foreach (DataRow row in dt.Rows)
                {
                    BaseColor rowColor = alternateRow ? BaseColor.LIGHT_GRAY : BaseColor.WHITE;
                    alternateRow = !alternateRow;

                    foreach (var item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), rowFont))
                        {
                            BackgroundColor = rowColor,
                            Padding = 4,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show($"Maintenance Report has been generated successfully!\nSaved at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the generated PDF
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when trying to generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maintenanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvResults.SelectedCells[0].RowIndex;
            MaintenanceStockForm ma = new MaintenanceStockForm(Convert.ToInt32(dgvResults.Rows[rowIndex].Cells["maintenanceID"].Value));

            ma.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MaintenanceStockForm m = new MaintenanceStockForm(0);
            m.Show();
            this.Close();
        }
    }
}
