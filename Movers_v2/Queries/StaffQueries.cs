using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_v2
{
    public partial class StaffQueries : Form
    {
        DataTable table = new DataTable();
        public StaffQueries()
        {
            InitializeComponent();
            createTableStaff("Firstname", "ASC");

            cbxQuery.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void InitializeCombo()
        {
            string[] allQueries = { "display all staff (firstname asc)", "display all staff (firstname desc)", "display all staff (staffID asc)", "display all staff (staffID desc)", "display all staff (surname asc)", "display all staff (surname desc)" };

            for (int i = 0; i < allQueries.Length; i++)
            {
                cbxQuery.Items.Add(allQueries[i]);
            }
        }

        public void createTableStaff(string type, string order)
        {
            //dgvResults.CellClick -= dgvResults_CellClick;

            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Staff ID");
            table.Columns.Add("First name");
            table.Columns.Add("Surname");
            table.Columns.Add("Telephone number");
            table.Columns.Add("Job role");
            

           List<Staff> StaffList = StaffAccess.getFilter(tbxfirstname.Text, tbxsurname.Text, tbxtelno.Text, cbxjobrole.Text, type, order);

            foreach (Staff staff in StaffList)
            {
               
                table.Rows.Add(staff.StaffID, staff.Firstname, staff.Surname, staff.TelNo, staff.Role);
            }

            lblResults.Text = "Result set size: " + Convert.ToString(StaffList.Count);



            dgvResults.DataSource = table;

        }
        private void StaffQueries_Load(object sender, EventArgs e)
        {

        }

        private void btnAED_Click(object sender, EventArgs e)
        {
            StaffAED s = new StaffAED();
            s.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();

        }

        private void tbxfirstname_TextChanged(object sender, EventArgs e)
        {
            createTableStaff("Firstname", "ASC");
        }

        private void tbxsurname_TextChanged(object sender, EventArgs e)
        {
            createTableStaff("Firstname", "ASC");
        }

        private void tbxtelno_TextChanged(object sender, EventArgs e)
        {
            createTableStaff("Firstname", "ASC");
        }

        private void cbxjobrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableStaff("Firstname", "ASC");
        }
        private void cbxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxQuery.SelectedIndex)
            {
                case 0: createTableStaff("Firstname", "ASC"); break;
                case 1: createTableStaff("Firstname", "DESC"); ; break;
                case 2: createTableStaff("ID", "ASC"); break;
                case 3: createTableStaff("ID", "DESC"); break;
                case 4: createTableStaff("Surname", "ASC"); break;
                case 5: createTableStaff("Surname", "DESC"); ; break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxjobrole.SelectedIndex = -1;
            cbxQuery.SelectedIndex = -1;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox t)
                {
                    t.Clear();
                }

                createTableStaff("Firstname", "ASC");
            }
        }
    }
}
