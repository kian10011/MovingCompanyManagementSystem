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
    public partial class VanQueries : Form
    {
        DataTable table = new DataTable();

        
        public VanQueries()
        {
            InitializeComponent();
           
            createTableVans(VanAccess.getAllVans());

            List<Van> v = VanAccess.getAllVans();
            foreach (Van van in v)
            {
                cbxvanid.Items.Add(van.VanID);

            }

            cbxsize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxvanid.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void popUpMOT()
        {
            try
            {
                // Get vans due for MOT
                DataTable vansDue = VanAccess.VanDueForMot();

                // Check if any rows are returned
                if (vansDue.Rows.Count > 0)
                {
                    // Prepare a message with the van IDs
                    string message = "The following vans are due for MOT:\n\n";

                    foreach (DataRow row in vansDue.Rows)
                    {
                        message += $"Van ID: {row["vanID"]} -  {row["regNo"]}\n";
                    }

                    // Display the message in a popup
                    MessageBox.Show(message, "Vans Due for MOT", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vans due for MOT: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void createTableVans(List<Van> vList)
        {
            //dgvResults.CellClick -= dgvResults_CellClick;

            table.Columns.Clear();
            table.Rows.Clear();
            lblResults.Text = "Result set size: " + Convert.ToString(vList.Count);
            table.Columns.Add("Van ID");
            table.Columns.Add("Registration number");
            table.Columns.Add("Mot due");
            table.Columns.Add("model");
            table.Columns.Add("color");
            table.Columns.Add("size");




            List<Van> vanList = VanAccess.getFilter(cbxvanid.Text, tbxRegNo.Text, tbxmodel.Text, tbxcolor.Text, cbxsize.Text);


            foreach (Van van in vanList)
            {
                table.Rows.Add(van.VanID, van.RegNo, van.MotDueDate, van.Model, van.Color, van.Size);
            }

            dgvResults.DataSource = table;
        }

      

        private void MaintenanceQueries_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAED_Click(object sender, EventArgs e)
        {
            VanAED v = new VanAED();
            v.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxvanid_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableVans(VanAccess.getAllVans());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void tbxRegNo_TextChanged(object sender, EventArgs e)
        {
            createTableVans(VanAccess.getAllVans());
        }

        private void tbxmodel_TextChanged(object sender, EventArgs e)
        {
            createTableVans(VanAccess.getAllVans());
        }

        private void tbxcolor_TextChanged(object sender, EventArgs e)
        {
            createTableVans(VanAccess.getAllVans());
        }

        private void cbxsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableVans(VanAccess.getAllVans());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxsize.SelectedIndex = -1;
            cbxvanid.SelectedIndex = -1;
            
            foreach(Control c in this.Controls)
            {
                if(c is TextBox t)
                {
                    t.Clear();
                }
            }
            createTableVans(VanAccess.getAllVans());
        }

        private void VanQueries_Shown(object sender, EventArgs e)
        {
            popUpMOT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vanReport v = new vanReport();
            v.Show();
            this.Hide();
        }
    }
}
