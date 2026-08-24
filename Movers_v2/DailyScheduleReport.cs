using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_v2
{
    public partial class DailyScheduleReport : Form
    {
        public DailyScheduleReport()
        {
            InitializeComponent();
            cbxViewBy.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void populateDaily()
        {

        }


        private void DailyScheduleReport_Load(object sender, EventArgs e)
        {

        }

        private void cbxViewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxViewBy.SelectedIndex;

            dgvOrder.DataSource = ReorderAccess.orderReport(index);
            dgvTraining.DataSource = StaffSessionAccess.trainingReport(index);
            dgvMaintenances.DataSource = MaintenanceAccess.maintenanceReport(index);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        public static void ExportDataGridViewsToPDF(DataGridView dgvOrder, DataGridView dgvTraining, DataGridView dgvMaintenances)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "MOVERS_Daily_Schedule.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Define Times New Roman Fonts
                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Times-Roman", 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font headerFont = FontFactory.GetFont("Times-Roman", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                    iTextSharp.text.Font cellFont = FontFactory.GetFont("Times-Roman", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font introFont = FontFactory.GetFont("Times-Roman", 12,  iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);

                    // Add report title
                    Paragraph title = new Paragraph("MOVERS Company Daily Schedule", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);
                    pdfDoc.Add(new Paragraph("\n"));

                    // Add introductory paragraph
                    string introText = "Welcome to the MOVERS Company daily schedule report. This document outlines the " +
                                       "planned activities for today, including order processing, training sessions, " +
                                       "and scheduled maintenance tasks. Each section provides a detailed view of the " +
                                       "tasks assigned to our teams, ensuring efficiency and smooth operations.";
                    Paragraph intro = new Paragraph(introText, introFont);
                    intro.Alignment = Element.ALIGN_JUSTIFIED;
                    pdfDoc.Add(intro);
                    pdfDoc.Add(new Paragraph("\n"));

                    // Export each DataGridView with section headers
                    AddDataGridViewToPDF(pdfDoc, dgvOrder, "Orders Overview", headerFont, cellFont);
                    AddDataGridViewToPDF(pdfDoc, dgvTraining, "Training Sessions", headerFont, cellFont);
                    AddDataGridViewToPDF(pdfDoc, dgvMaintenances, "Scheduled Maintenances", headerFont, cellFont);

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
            pdfDoc.Add(new Paragraph(title, FontFactory.GetFont("Times-Roman", 14,  iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
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
            ExportDataGridViewsToPDF(dgvOrder, dgvTraining, dgvMaintenances);
        }
    }
}
