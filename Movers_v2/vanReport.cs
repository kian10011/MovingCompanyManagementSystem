using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Movers_v2
{
    public partial class vanReport : Form
    {

        public vanReport()
        {
            InitializeComponent();
            dgvResults.DataSource = MaintenanceAccess.vanServiceReport();
        }

        private void vanReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateVanServiceReport(dgvResults);
           

        }

        public static void GenerateVanServiceReport(DataGridView dgvResults)
        {
            if (dgvResults.DataSource == null)
            {
                MessageBox.Show("No data available for the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = (DataTable)dgvResults.DataSource;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "VanServiceReport.pdf");

            try
            {
                //create a4 pdf with margin sizes
                Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create)); // set up pdf writer to write the document to the specified file
                doc.Open();

                // Title
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Van Service Report: " + DateTime.Now.ToString(), titleFont)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 20
                };
                doc.Add(title);

                // Create PDF table

                string[] customHeaders = { "Maintenance ID", "Van ID", "Reg. No", "MOT Due Date", "Start Date", "Start Time", "End Time", "Service Description", "Maintenance type", "Staff Name", "staff role" };
                PdfPTable table = new PdfPTable(customHeaders.Length)
                {
                    WidthPercentage = 100
                };

                // Add column headers
                float[] columnWidths = { 1.2f, 1.2f, 1.5f, 2f, 2f, 2f, 2f, 3f, 2f, 2f, 2f };
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

                MessageBox.Show($"Van Service Report has been generated successfully!\nSaved at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the generated PDF
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when trying to generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
