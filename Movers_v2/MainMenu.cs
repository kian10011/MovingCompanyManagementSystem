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
    public partial class MainMenu : Form
    {
        int staffID;

        public MainMenu()
        {
            InitializeComponent();
            hideMenu();

            cbxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSelectUser.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VanQueries v = new VanQueries();
            v.Show();
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            StaffQueries staff = new StaffQueries();
            staff.Show();
            this.Hide();
        }

        public void hideMenu()
        {
           
            btnDaily.Visible = false;
            btnMaintenance.Visible = false;
            btnMail.Visible = false;
            btnStaff.Visible = false;
            btnStock.Visible = false;
            btnTraining.Visible = false;
            btnVan.Visible = false;

            lblUser.Visible = true;
            cbxUser.Visible = true;



            imgwrench.Visible = false;

        }

        public void showMenu()
        {
           
            btnDaily.Visible = true;
            btnMaintenance.Visible = true;
            btnMail.Visible = true;
            btnStaff.Visible = true;
            btnStock.Visible = true;
            btnTraining.Visible = true;
            btnVan.Visible = true;

            lblUser.Visible = false;
            cbxUser.Visible = false;
            lblSelectUser.Visible = false;
            cbxSelectUser.Visible = false;

            imgwrench.Visible = true;

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MaintenanceQueries m = new MaintenanceQueries();
            m.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockQueries s = new StockQueries();
            s.Show();
            this.Hide();

        }

       

        private void btnTraining_Click(object sender, EventArgs e)
        {
            TrainingQueries train = new TrainingQueries();
            train.Show();
            this.Hide();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            DailyScheduleReport d = new DailyScheduleReport();
            d.Show();
            this.Hide();
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxSelectUser.Items.Clear();

            List<Staff> m = StaffAccess.getAllMechanics();
            List<Staff> d = StaffAccess.getAllDrivers();

            if (cbxUser.SelectedIndex == 0)
            {
                cbxSelectUser.Visible = true;
                lblSelectUser.Visible = true;

                foreach (Staff s in m)
                {
                    cbxSelectUser.Items.Add(s.StaffID + " " + s.Firstname + " " + s.Surname + " - " + s.Role);

                }
            }

            if (cbxUser.SelectedIndex == 1)
            {
                cbxSelectUser.Visible = true;
                lblSelectUser.Visible = true;

                foreach (Staff s in d)
                {
                    cbxSelectUser.Items.Add(s.StaffID + " " + s.Firstname + " " + s.Surname + " - " + s.Role);

                }
            }

            if (cbxUser.SelectedIndex == 2)
            {
                cbxSelectUser.Visible = false;
                lblSelectUser.Visible = false;
                btnEnter.Visible = true;
            }




        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            showMenu();
            btnEnter.Visible = false;
            btnLogOut.Visible = true;
            

            int spaceIndex = cbxSelectUser.Text.IndexOf(" ");
            if(cbxUser.SelectedIndex != 2)
            {
                btnTraining.Visible = false;
                staffID = Int32.Parse(cbxSelectUser.Text.Substring(0, spaceIndex));
            }
            
        }

        private void cbxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEnter.Visible = true;
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            string message = "";

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            if (cbxUser.SelectedIndex == 0)
                dt = MaintenanceAccess.getAllMaintenancesForSpecificMechanic(staffID);

            if (cbxUser.SelectedIndex == 1)
                dt = MaintenanceAccess.getAllMaintenancesForSpecificDriver(staffID);

            if (cbxUser.SelectedIndex == 2)
                dt = MaintenanceAccess.getAllMaintenanceDataTable();

            if (cbxUser.SelectedIndex != 2)
            {
                dt2 = StaffSessionAccess.displayAllUpcomingStaffSessions(staffID);
            }
            else
                dt2 = StaffSessionAccess.getAllStaffSessionsDataTable();
           

            message += "----UPCOMING MAINTENANCES----";
            foreach (DataRow row in dt.Rows)
            {
                message += $" \r\n Maintenance ID: {row["maintenanceID"]} \r\n maintenance date: {row["maintenanceStartDate"]} \r\n Van ID: {row["vanID"]}\r\n ";
            }
            if (dt.Rows.Count < 1)
            {
                message += "\r\n No upcoming maintenances!";
            }
            message += "\r\n\r\n\r\n----UPCOMING STAFF TRAINING----";
            foreach (DataRow row in dt2.Rows)
            {
                message += $" \r\n Staff name:  {row["Staff Name"]}  \r\n session name: {row["sessionName"]} \r\n Session Date: {row["scheduledDate"]}\r\n ";
            }
            if (dt2.Rows.Count < 1)
            {
                message += "\r\n No upcoming training!";
            }

            if (dt.Rows.Count < 1 && dt2.Rows.Count < 1)
            {
                message = "No mail available!";
            }
            tbxMail.Text = message;
            tbxMail.Visible = true;
            btnBackFromMail.Visible = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackFromMail_Click(object sender, EventArgs e)
        {
            btnBackFromMail.Visible = false;
            tbxMail.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideMenu();
        }
    }
}
