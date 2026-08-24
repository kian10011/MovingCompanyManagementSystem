using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Drawing.Text;

namespace Movers_v2
{
    public partial class MaintenanceAED : Form
    {

        DataTable table = new DataTable();
        bool mot = false;
        bool loadingMaintenance = false;
        bool driverChanged = false;
        bool mechanicChanged = false;

        ToolTip t = new ToolTip();
        public MaintenanceAED()
        {
            InitializeComponent();
            clear();
            refreshTabs();
            

            cbxstaffidd0.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxstaffidm0.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxvanid0.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxmaintenancetype0.DropDownStyle = ComboBoxStyle.DropDownList;


            tbxregno0.ReadOnly = true;
            tbxsize0.ReadOnly = true;
            dtpmotduedate0.Enabled = false;
            cbxmaintenancetype0.Enabled = false;

            tbxfirstd0.ReadOnly = true;
            tbxsurd0.ReadOnly = true;
            tbxteld0.ReadOnly = true;
            tbxfirstm0.ReadOnly = true;
            tbxsurm0.ReadOnly = true;
            tbxtelm0.ReadOnly = true;



            cbxmaintenanceid1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxstaffidd1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxstaffidm1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxvanid1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxmaintenancetype1.DropDownStyle = ComboBoxStyle.DropDownList;

            tbxfirstd1.ReadOnly = true;
            tbxsurd1.ReadOnly = true;
            tbxteld1.ReadOnly = true;
            tbxfirstm1.ReadOnly = true;
            tbxsurm1.ReadOnly = true;
            tbxtelm1.ReadOnly = true;
            tbxregno1.ReadOnly = true;
            tbxsize1.ReadOnly = true;
            dtpmotduedate1.Enabled = false;

            cbxmaintenanceid2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxstaffidd2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxstaffidm2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxvanid2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxmaintenancetype2.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxfirstd2.ReadOnly = true;
            tbxfirstm2.ReadOnly = true;
            tbxsurd2.ReadOnly = true;
            tbxsurm2.ReadOnly = true;
            tbxregno2.ReadOnly = true;
            tbxsize2.ReadOnly = true;
            tbxteld2.ReadOnly = true;
            tbxtelm2.ReadOnly = true;
            tbxmaintenancedetails2.ReadOnly = true;
            cbxmaintenancetype2.Enabled = false;
            cbxstaffidd2.Enabled = false;
            cbxstaffidm2.Enabled = false;
            cbxvanid2.Enabled = false;
            tbxregno2.ReadOnly = true;
            tbxsize2.ReadOnly = true;
            dtpmotduedate2.Enabled = false;





        }

        public void createTableMaintenance()
        {

            //create table
            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Maintenance ID");
            table.Columns.Add("Van ID");
            table.Columns.Add("Start Date");
            table.Columns.Add("Start Time");
            table.Columns.Add("End Time");
            table.Columns.Add("Staff firstname");
            table.Columns.Add("Staff surname");

            int spaceIndexvan = cbxvanid0.Text.IndexOf(" "); //get index of first space to appear

            dgvResults.DataSource = MaintenanceAccess.displayMaintenanceForSpecificVan(Int32.Parse(cbxvanid0.Text.Substring(0, spaceIndexvan))); // get only van id by substring up until first space




        }

        private void checkAvailability()
        {
            int spaceIndexm0 = cbxstaffidm0.Text.IndexOf(" ");
            int spaceIndexd0 = cbxstaffidd0.Text.IndexOf(" ");

            int spaceIndexm1 = cbxstaffidm1.Text.IndexOf(" ");
            int spaceIndexd1 = cbxstaffidd1.Text.IndexOf(" ");

            if (tcMaintenance.SelectedIndex == 0)
            {
                if (cbxstaffidm0.Text != "" && dtpmaintenancedate0.Text != "" && dtpmaintenancestarttime0.Text != "" && dtpmaintenancetime0.Text != "") //check empty fields
                {
                    DateTime selectedDate = dtpmaintenancedate0.Value.Date; //get only date value of dtpmaintenancedate

                    string formattedDate = selectedDate.ToString("yyyy-MM-dd"); //format the date

                    string selectedStartTime = formattedDate + " " + dtpmaintenancestarttime0.Value.TimeOfDay; //add the time value to formatted date; this makes it so that the date and time values are correctly compared
                    string selectedEndTime = formattedDate + " " + dtpmaintenancetime0.Value.TimeOfDay;

                    if (int.TryParse(cbxstaffidm0.Text.Substring(0, spaceIndexm0), out int result)) //if the item selected is an int
                    {
                        bool isAvailable = StaffAccess.checkMechanicAvailability(Int32.Parse(cbxstaffidm0.Text.Substring(0, spaceIndexm0)), selectedStartTime, selectedEndTime); //create bool to check availability

                        if (!isAvailable) //if not available, show image
                        {
                            imgMechanic0.Visible = true;

                        }
                        else // if not, do not show image
                        {
                            imgMechanic0.Visible = false;
                        }
                    }
                }

                if (cbxstaffidd0.Text != "" && dtpmaintenancedate0.Text != "" && dtpmaintenancestarttime0.Text != "" && dtpmaintenancetime0.Text != "") //everything same but for the drivers instead of mechanics
                {
                    DateTime selectedDate = dtpmaintenancedate0.Value.Date;

                    string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                    string selectedStartTime = formattedDate + " " + dtpmaintenancestarttime0.Value.TimeOfDay;
                    string selectedEndTime = formattedDate + " " + dtpmaintenancetime0.Value.TimeOfDay;



                    bool isAvailable = StaffAccess.checkDriverAvailability(Int32.Parse(cbxstaffidd0.Text.Substring(0, spaceIndexd0)), selectedStartTime, selectedEndTime);

                    if (!isAvailable)
                    {
                        imgDriver0.Visible = true;

                    }
                    else
                    {
                        imgDriver0.Visible = false;
                    }

                }

            }
            if (tcMaintenance.SelectedIndex == 1)
            {
                if (cbxstaffidm1.Text != "" && dtpmaintenancedate1.Text != "" && dtpmaintenancestarttime1.Text != "" && dtpmaintenancetime1.Text != "") //check empty fields
                {
                    DateTime selectedDate = dtpmaintenancedate1.Value.Date; //get only date value of dtpmaintenancedate

                    string formattedDate = selectedDate.ToString("yyyy-MM-dd"); //format the date

                    string selectedStartTime = formattedDate + " " + dtpmaintenancestarttime1.Value.TimeOfDay; //add the time value to formatted date; this makes it so that the date and time values are correctly compared
                    string selectedEndTime = formattedDate + " " + dtpmaintenancetime1.Value.TimeOfDay;

                    if (int.TryParse(cbxstaffidm1.Text.Substring(0, spaceIndexm1), out int result)) //if the item selected is an int
                    {
                        bool isAvailable = StaffAccess.checkMechanicAvailability(Int32.Parse(cbxstaffidm1.Text.Substring(0, spaceIndexm1)), selectedStartTime, selectedEndTime); //create bool to check availability

                        if (!isAvailable && mechanicChanged == true) //if not available, show image
                        {
                            imgMechanic1.Visible = true;

                        }
                        else // if not, do not show image
                        {
                            imgMechanic1.Visible = false;
                        }
                    }
                }

                if (cbxstaffidd1.Text != "" && dtpmaintenancedate1.Text != "" && dtpmaintenancestarttime1.Text != "" && dtpmaintenancetime1.Text != "") //everything same but for the drivers instead of mechanics
                {
                    DateTime selectedDate = dtpmaintenancedate1.Value.Date;

                    string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                    string selectedStartTime = formattedDate + " " + dtpmaintenancestarttime1.Value.TimeOfDay;
                    string selectedEndTime = formattedDate + " " + dtpmaintenancetime1.Value.TimeOfDay;



                    bool isAvailable = StaffAccess.checkDriverAvailability(Int32.Parse(cbxstaffidd1.Text.Substring(0, spaceIndexd1)), selectedStartTime, selectedEndTime);

                    if (!isAvailable && driverChanged == true)
                    {
                        imgDriver1.Visible = true;

                    }
                    else
                    {
                        imgDriver1.Visible = false;
                    }

                }
            }



        }
        private void clear()
        {

            imgMechanic0.Visible = false;
            imgDriver0.Visible = false;
            imgType.Visible = false;
            imgWarning0.Visible = false;
            imgMechanic1.Visible = false;
            imgDriver1.Visible = false;
            imgType1.Visible = false;

            cbxmaintenanceid1.Items.Clear();
            cbxmaintenanceid2.Items.Clear();

            cbxvanid0.Items.Clear();
            tbxregno0.Clear();
            tbxsize0.Clear();

            cbxstaffidd0.Items.Clear();
            tbxfirstd0.Clear();
            tbxsurd0.Clear();
            tbxteld0.Clear();

            cbxstaffidm0.Items.Clear();
            tbxfirstm0.Clear();
            tbxsurm0.Clear();
            tbxtelm0.Clear();


            cbxmaintenancetype0.Items.Clear();
            tbxmaintenancedetails0.Clear();

            cbxvanid1.Items.Clear();
            tbxregno1.Clear();
            tbxsize1.Clear();

            cbxstaffidd1.Items.Clear();
            tbxfirstd1.Clear();
            tbxsurd1.Clear();
            tbxteld1.Clear();

            cbxstaffidm1.Items.Clear();
            tbxfirstm1.Clear();
            tbxsurm1.Clear();
            tbxtelm1.Clear();


            cbxmaintenancetype1.Items.Clear();
            tbxmaintenancedetails1.Clear();

            mechanicChanged = false;
            driverChanged = false;

         
        }

        private void refreshTabs()
        {
            DateTime s = DateTime.Now.Date; // gets today's current date
            TimeSpan ts1 = new TimeSpan(8, 30, 0); // sets default start time of 8:30am
            TimeSpan ts2 = new TimeSpan(17, 30, 0);// sets default end time of 5:30pm
           

            dtpmaintenancestarttime0.Value = s + ts1;
            dtpmaintenancetime0.Value = s + ts2;

            cbxmaintenancetype0.Items.Add("Monthly Check");
            cbxmaintenancetype0.Items.Add("MOT Service");
            cbxmaintenancetype0.Items.Add("MOT Exam");
            cbxmaintenancetype0.Items.Add("Repair");

            cbxmaintenancetype1.Items.Add("Monthly Check");
            cbxmaintenancetype1.Items.Add("MOT Service");
            cbxmaintenancetype1.Items.Add("MOT Exam");
            cbxmaintenancetype1.Items.Add("Repair");

            cbxmaintenancetype2.Items.Add("Monthly Check");
            cbxmaintenancetype2.Items.Add("MOT Service");
            cbxmaintenancetype2.Items.Add("MOT Exam");
            cbxmaintenancetype2.Items.Add("Repair");





            List<Maintenance> m = MaintenanceAccess.getAllmaintenance();
            foreach (Maintenance maintenance in m)
            {
                cbxmaintenanceid1.Items.Add(maintenance.MaintenanceID); //populate maintenance id combobox in edit and delete tabs
                cbxmaintenanceid2.Items.Add(maintenance.MaintenanceID);


            }

            List<Van> vv = VanAccess.getAllVans();

            foreach (Van van in vv)
            {
                cbxvanid0.Items.Add(van.VanID + " - " + van.RegNo);
                cbxvanid1.Items.Add(van.VanID + " - " + van.RegNo); //populate van cbx
                cbxvanid2.Items.Add(van.VanID + " - " + van.RegNo);

            }


            List<Staff> ss1 = StaffAccess.getAllMechanicsAvailable();

            foreach (Staff staff in ss1)
            {

                cbxstaffidm2.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname); //populate delete tab mechanic id


            }


            List<Staff> ss2 = StaffAccess.getAllDriversAvailable();


            foreach (Staff staff in ss2)
            {
                cbxstaffidd0.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname);
                cbxstaffidd1.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname); //populate driver id combobox
                cbxstaffidd2.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname);
            }

            cbxstaffidm0.Items.Add("Please select a maintenance type!"); //initial message to prompt user to select maintenance type before mechanic can be selected; MOT exam does not require a mechanic
            cbxstaffidm0.SelectedIndex = 0;






        }

        public void openAtEdit(int mID)
        {
            tcMaintenance.SelectedTab = tabEdit;
            cbxmaintenanceid1.Text = mID.ToString();

            
        }

        public void openAtDelete(int mID)
        {
            cbxmaintenanceid2.Text = mID.ToString();

            tcMaintenance.SelectedTab = tabDelete;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();

        }



        private void MaintenanceAED_Load(object sender, EventArgs e)
        {

        }

        private void cbxvanid0_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkMOTService(); // check if van has done MOT service if mot exam ha been selected
            int spaceIndex = cbxvanid0.Text.IndexOf(" ");
            cbxmaintenancetype0.Enabled = true;

            Van v = VanAccess.getVanByID(Int32.Parse(cbxvanid0.Text.Substring(0, spaceIndex)));
            tbxregno0.Text = v.RegNo;
            tbxsize0.Text = v.Size; //display selected van details
            dtpmotduedate0.Value = v.MotDueDate;

            createTableMaintenance();

        }

        private void cbxstaffidm0_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxstaffidm0.Text.IndexOf(" ");

            if (int.TryParse(cbxstaffidm0.Text.Substring(0, spaceIndex), out int result))
            {
                Staff s = StaffAccess.getMechanicsByID(Int32.Parse(cbxstaffidm0.Text.Substring(0, spaceIndex)));
                tbxfirstm0.Text = s.Firstname;  //display seleced mechanic details
                tbxsurm0.Text = s.Surname;
                tbxtelm0.Text = s.TelNo;
            }

            checkAvailability();
        }

        private void cbxstaffidd0_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxstaffidd0.Text.IndexOf(" ");
            Staff s = StaffAccess.getDriversByID(Int32.Parse(cbxstaffidd0.Text.Substring(0, spaceIndex)));
            tbxfirstd0.Text = s.Firstname; // display selected driver details
            tbxsurd0.Text = s.Surname;
            tbxteld0.Text = s.TelNo;

            checkAvailability();
        }

        private void cbxvanid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkMOTService();
            int spaceIndex = cbxvanid1.Text.IndexOf(" ");


            Van v = VanAccess.getVanByID(Int32.Parse(cbxvanid1.Text.Substring(0, spaceIndex)));
            tbxregno1.Text = v.RegNo;
            tbxsize1.Text = v.Size;
            dtpmotduedate1.Value = v.MotDueDate;

            checkAvailability();
        }

        private void cbxstaffidm1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mechanicChanged = true;

            int spaceIndex = cbxstaffidm1.Text.IndexOf(" ");

            if (int.TryParse(cbxstaffidm1.Text.Substring(0, spaceIndex), out int result))
            {
                Staff s = StaffAccess.getMechanicsByID(Int32.Parse(cbxstaffidm1.Text.Substring(0, spaceIndex)));
                tbxfirstm1.Text = s.Firstname;
                tbxsurm1.Text = s.Surname;
                tbxtelm1.Text = s.TelNo;
            }
            if (loadingMaintenance == false)
            {
                checkAvailability();
            }

        }

        private void cbxstaffidd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverChanged = true;

            int spaceIndex = cbxstaffidd1.Text.IndexOf(" ");
            Staff s = StaffAccess.getDriversByID(Int32.Parse(cbxstaffidd1.Text.Substring(0, spaceIndex)));
            tbxfirstd1.Text = s.Firstname;
            tbxsurd1.Text = s.Surname;
            tbxteld1.Text = s.TelNo;
            if (loadingMaintenance == false)
            {
                checkAvailability();
            }
        }

        private void cbxmaintenanceid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAvailability();

            imgType1.Visible = false;
            imgMechanic1.Visible = false;
            imgDriver1.Visible = false;

            loadingMaintenance = true;

            Maintenance m = MaintenanceAccess.getMaintenanceByID((int)cbxmaintenanceid1.SelectedItem);

            if (cbxstaffidm1.Text != "")
            {
                Staff s = StaffAccess.getMechanicByMaintenanceID((int)cbxmaintenanceid1.SelectedItem);
                cbxstaffidm1.Text = s.StaffID.ToString() + " - " + s.Firstname.ToString() + " " + s.Surname.ToString();
            }

            Staff ss = StaffAccess.getDriverByMaintenanceID((int)cbxmaintenanceid1.SelectedItem);

            Van v = VanAccess.getVanByID(Int32.Parse(m.VanID.ToString()));



            cbxvanid1.Text = m.VanID.ToString() + " - " + v.RegNo.ToString();
            dtpmaintenancedate1.Text = m.MaintenanceStartDate.ToString();
            dtpmaintenancestarttime1.Text = m.MaintenanceStartTime.ToString();
            dtpmaintenancetime1.Text = m.MaintenanceEndTime.ToString(); //display details of every field of the selected maintenance
            tbxmaintenancedetails1.Text = m.ServiceDescription;
            cbxmaintenancetype1.SelectedIndex = m.TypeID;


            cbxstaffidd1.Text = ss.StaffID.ToString() + " - " + ss.Firstname.ToString() + " " + ss.Surname.ToString();



            loadingMaintenance = false;
            driverChanged = false;
            mechanicChanged = false; 

        }

        private void cbxmaintenanceid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maintenance m = MaintenanceAccess.getMaintenanceByID((int)cbxmaintenanceid2.SelectedItem);

            MaintenanceStaff s = MaintenanceAccess.getMaintenanceStaffMechanicByID((int)cbxmaintenanceid2.SelectedItem);

            MaintenanceStaff ss = MaintenanceAccess.getMaintenanceStaffDriverByID((int)cbxmaintenanceid2.SelectedItem);

            Van v = VanAccess.getVanByID(Int32.Parse(m.VanID.ToString()));

            cbxvanid2.Text = m.VanID.ToString() + " - " + v.RegNo.ToString();
            dtpmaintenancedate2.Text = m.MaintenanceStartDate.ToString();
            dtpmaintenancestarttime2.Text = m.MaintenanceStartTime.ToString();
            dtpmaintenanceendtime2.Text = m.MaintenanceEndTime.ToString();
            tbxmaintenancedetails2.Text = m.ServiceDescription;
            cbxmaintenancetype2.SelectedIndex = m.TypeID;

            cbxstaffidm2.Text = s.StaffID.ToString();
            cbxstaffidd2.Text = ss.StaffID.ToString();
        }


        private void tcMaintenance_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMaintenance.SelectedIndex)
            {
                case 0: btnExecute.Text = "ADD MAINTENANCE"; break;
                case 1: btnExecute.Text = "EDIT MAINTENANCE"; break;
                case 2: btnExecute.Text = "DELETE MAINTENANCE"; break;

            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int result = 0;
          
            int staffresult2 = 0;
            int staffrows1 = 0;
            int motUpdated = 0;

            int spacevanIndex0 = cbxvanid0.Text.IndexOf(" ");
            int spacevanIndex1 = cbxvanid1.Text.IndexOf(" ");
            int spacevanIndex2 = cbxvanid2.Text.IndexOf(" ");

            int spacemechIndex0 = cbxstaffidm0.Text.IndexOf(" ");
            int spacemechIndex1 = cbxstaffidm1.Text.IndexOf(" ");
            int spacemechIndex2 = cbxstaffidm2.Text.IndexOf(" ");

            int spaceDriverIndex0 = cbxstaffidd0.Text.IndexOf(" ");
            int spaceDriverIndex1 = cbxstaffidd1.Text.IndexOf(" ");
            int spaceDriverIndex2 = cbxstaffidd2.Text.IndexOf(" ");


            DateTime dt = Convert.ToDateTime(dtpmaintenancedate0.Value);
            string formattedDate = dt.ToString("yyyy/MM/dd");

            if (tcMaintenance.SelectedIndex == 0)
            {


                if (cbxvanid0.Text != "" && dtpmaintenancedate0.Text != "" && dtpmaintenancestarttime0.Text != "" && dtpmaintenancetime0.Text != "" && tbxmaintenancedetails0.Text != "" && cbxmaintenancetype0.Text != "" && cbxstaffidd0.Text != "")
                {
                    if (dtpmaintenancestarttime0.Value != dtpmaintenancetime0.Value)
                    {

                        if (dtpmaintenancestarttime0.Value < dtpmaintenancetime0.Value)
                        {
                            if (imgMechanic0.Visible != true)
                            {
                                if (imgDriver0.Visible != true)
                                {
                                    if (imgType.Visible != true)
                                    {
                                        Maintenance maintenance = new Maintenance(0, Int32.Parse(cbxvanid0.Text.Substring(0, spacevanIndex0)), DateTime.Parse(dt.ToShortDateString()), dtpmaintenancetime0.Value, tbxmaintenancedetails0.Text, cbxmaintenancetype0.SelectedIndex, dtpmaintenancestarttime0.Value);

                                        int maintenanceid = MaintenanceAccess.addMaintenance(maintenance); //add maintenance

                                        if (cbxmaintenancetype0.SelectedIndex == 2) // if mot exam is selected, add driver only
                                        {
                                            staffrows1 = MaintenanceAccess.addMaintenanceStaffDriverOnly(maintenanceid, Int32.Parse(cbxstaffidd0.Text.Substring(0, spaceDriverIndex0)), "Driver");
                                        }
                                        else //else add both staff members
                                        {
                                            staffrows1 = MaintenanceAccess.addMaintenanceStaff(maintenanceid, Int32.Parse(cbxstaffidm0.Text.Substring(0, spacemechIndex0)), Int32.Parse(cbxstaffidd0.Text.Substring(0, spaceDriverIndex0)), "mechanic", "driver");
                                        }

                                        if (staffrows1 == 1 || staffrows1 == 2) // if the adding of staff is successful
                                        {
                                            if (cbxmaintenancetype0.SelectedIndex == 2)
                                            {
                                                //update the mot of van if an mot exam is selected
                                                motUpdated = VanAccess.upDateMOT(formattedDate, cbxvanid0.Text.Substring(0, spacevanIndex0));

                                                if (motUpdated == 1)
                                                {
                                                    MessageBox.Show("Maintenance has been added to the database, and the MOT due date of the van has been updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                   
                                                    foreach (Control co in this.tabAdd.Controls)
                                                    {
                                                        if (co is TextBox)
                                                            co.Text = "";
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Maintenance has been added to the database, but an error occurred when attempting to update the MOT due date of the van!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                   
                                                    foreach (Control co in this.tabAdd.Controls)
                                                    {
                                                        if (co is TextBox)
                                                            co.Text = "";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Maintenance has been added successfully to the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                              
                                                foreach (Control co in this.tabAdd.Controls)
                                                {
                                                    if (co is TextBox)
                                                        co.Text = "";
                                                }
                                            }

                                            // Show a MessageBox with Yes and No buttons
                                            DialogResult r = MessageBox.Show("Do you want to produce a report of \n the booked maintenance?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                            // Check the result of the MessageBox
                                            if (r == DialogResult.Yes)
                                            {
                                                createMaintenanceReportOfVan(maintenanceid, Int32.Parse(cbxvanid0.Text.Substring(0, spacevanIndex0)), cbxmaintenancetype0.SelectedIndex);

                                               
                                            }

                                            clear();
                                            refreshTabs();

                                        }
                                        else
                                            MessageBox.Show("Maintenance has not been added to the database! staff members have been selected to do the maintenance.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    else
                                        MessageBox.Show("Maintenance has not been added to the database! Ensure that an MOT service has been completed for the van before conducting an MOT test.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                else
                                    MessageBox.Show("Maintenance has not been added to the database! Driver selected is booked for maintenance on these date and times. Please select another driver!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                                MessageBox.Show("Maintenance has not been added to the database! Mechanic selected is booked for maintenance on these date and times. Please select another mechanic!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                            MessageBox.Show("Maintenance has not been added to the database! Selected start time must be before selected end time.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Maintenance has not been added to the database! Start Time and End time cannot be the same value.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Maintenance has not been added to the database! Make sure no fields are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            else if (tcMaintenance.SelectedIndex == 1)
            {
                if (dtpmaintenancestarttime1.Value != dtpmaintenancetime1.Value)
                {
                    if (dtpmaintenancestarttime1.Value < dtpmaintenancetime1.Value)
                    {
                        if (imgMechanic1.Visible != true)
                        {
                            if (imgDriver1.Visible != true)
                            {
                                if (imgType1.Visible != true)
                                {
                                    if (cbxvanid1.Text != "" && dtpmaintenancedate1.Text != "" & dtpmaintenancestarttime1.Text != "" & dtpmaintenancetime1.Text != "" & tbxmaintenancedetails1.Text != "" & cbxmaintenancetype1.Text != "")
                                    {
                                        Maintenance maintenance = new Maintenance(Int32.Parse(cbxmaintenanceid1.Text), Int32.Parse(cbxvanid1.Text.Substring(0, spacevanIndex1)), dtpmaintenancedate1.Value, dtpmaintenancetime1.Value, tbxmaintenancedetails1.Text, cbxmaintenancetype1.SelectedIndex, dtpmaintenancestarttime1.Value);
                                        result = MaintenanceAccess.upDateMaintenance(maintenance);

                                        if (result == 1)
                                        {

                                            if (cbxmaintenancetype1.SelectedIndex != 2)
                                            {
                                                MaintenanceAccess.upDateMaintenanceStaff1(Int32.Parse(cbxmaintenanceid1.Text), Int32.Parse(cbxstaffidm1.Text.Substring(0, spacemechIndex1)));
                                            }
                                            staffresult2 = MaintenanceAccess.upDateMaintenanceStaff2(Int32.Parse(cbxmaintenanceid1.Text), Int32.Parse(cbxstaffidd1.Text.Substring(0, spaceDriverIndex1)));

                                            if (staffresult2 == 1)
                                            {
                                                MessageBox.Show("Maintenance has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                clear();
                                                refreshTabs();

                                                foreach (Control co in this.tabEdit.Controls)
                                                {
                                                    if (co is TextBox)
                                                        co.Text = "";
                                                }

                                            }
                                            else
                                                MessageBox.Show("Maintenance has not been updated. Make sure that a maintenanceID and staffIDs have been selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        else
                                            MessageBox.Show("Maintenance has not been updated! An error occurred when attempting to add maintenance..", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                        MessageBox.Show("Maintenance has not been updated! Some fields are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                    MessageBox.Show("Maintenance has not been added to the database! Ensure that an MOT service has been completed for the van before conducting an MOT test.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                                MessageBox.Show("Maintenance has not been added to the database! Driver selected is booked for maintenance on these date and times. Please select another driver!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Maintenance has not been added to the database! Mechanic selected is booked for maintenance on these date and times. Please select another mechanic!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Maintenance has not been added to the database! Selected start time must be before selected end time.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Maintenance has not been added to the database! Start Time and End time cannot be the same value.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (cbxmaintenanceid2.Text != "")
                {
                    if (cbxstaffidm2.Text != "")
                    {
                        MaintenanceAccess.deleteMaintenanceMechanic(Int32.Parse(cbxstaffidm2.Text.Substring(0, spacemechIndex2)));
                    }
                    staffresult2 = MaintenanceAccess.deleteMaintenanceDriver(Int32.Parse(cbxstaffidd2.Text.Substring(0, spaceDriverIndex2)));

                    if (staffresult2 == 0)
                    {


                        Maintenance maintenance = new Maintenance(Int32.Parse(cbxmaintenanceid2.Text), Int32.Parse(cbxvanid2.Text.Substring(0, spacevanIndex2)), dtpmaintenancedate2.Value, dtpmaintenanceendtime2.Value, tbxmaintenancedetails2.Text, cbxmaintenancetype2.SelectedIndex, dtpmaintenancestarttime2.Value);
                        result = MaintenanceAccess.deleteMaintenance(Int32.Parse(cbxmaintenanceid2.Text));

                        if (result == 1)
                        {
                            MessageBox.Show("Maintenance has been successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clear();
                            refreshTabs();

                            foreach (Control co in this.tabDelete.Controls)
                            {
                                if (co is TextBox)
                                    co.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Maintenance has not been deleted. An error occurred when attempting to delete maintenance.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Maintenance has not been deleted. An error occurred when attempting to delete maintenance staff.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Maintenance has not been deleted. Ensure that a maintenance ID to be deleted is selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            

        }

        private void tabEdit_Click(object sender, EventArgs e)
        {

        }

        private void tabDelete_Click(object sender, EventArgs e)
        {

        }

        private void cbxmaintenanceid2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Maintenance m = MaintenanceAccess.getMaintenanceByID((int)cbxmaintenanceid2.SelectedItem);

            if (cbxstaffidm2.Text != "")
            {
                Staff s = StaffAccess.getMechanicByMaintenanceID((int)cbxmaintenanceid2.SelectedItem);
                cbxstaffidm2.Text = s.StaffID.ToString() + " - " + s.Firstname.ToString() + " " + s.Surname.ToString();
            }


            Staff ss = StaffAccess.getDriverByMaintenanceID((int)cbxmaintenanceid2.SelectedItem);

            Van v = VanAccess.getVanByID(Int32.Parse(m.VanID.ToString()));

            cbxvanid2.Text = m.VanID.ToString() + " - " + v.RegNo.ToString();
            dtpmaintenancedate2.Text = m.MaintenanceStartDate.ToString();
            dtpmaintenancestarttime2.Text = m.MaintenanceStartTime.ToString();
            dtpmaintenanceendtime2.Text = m.MaintenanceEndTime.ToString();
            tbxmaintenancedetails2.Text = m.ServiceDescription;
            cbxmaintenancetype2.SelectedIndex = m.TypeID;


            cbxstaffidd2.Text = ss.StaffID.ToString() + " - " + ss.Firstname.ToString() + " " + ss.Surname.ToString();
        }

        private void cbxvanid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxvanid2.Text.IndexOf(" ");

            Van v = VanAccess.getVanByID(Int32.Parse(cbxvanid2.Text.Substring(0, spaceIndex)));
            tbxregno2.Text = v.RegNo;
            tbxsize2.Text = v.Size;
            dtpmotduedate2.Value = v.MotDueDate;
        }

        private void cbxstaffidm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxstaffidm2.Text.IndexOf(" ");

            Staff s = StaffAccess.getMechanicsByID(Int32.Parse(cbxstaffidm2.Text.Substring(0, spaceIndex)));
            tbxfirstm2.Text = s.Firstname;
            tbxsurm2.Text = s.Surname;
            tbxtelm2.Text = s.TelNo;
        }

        private void cbxstaffidd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxstaffidd2.Text.IndexOf(" ");

            Staff s = StaffAccess.getDriversByID(Int32.Parse(cbxstaffidd2.Text.Substring(0, spaceIndex)));
            tbxfirstd2.Text = s.Firstname;
            tbxsurd2.Text = s.Surname;
            tbxteld2.Text = s.TelNo;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            MaintenanceQueries a = new MaintenanceQueries();
            a.Show();
            this.Hide();

        }

        public void checkMOTService()
        {
            if (tcMaintenance.SelectedIndex == 0) // if add maintenance tab is selected
            {
                int vanidspaceindex = cbxvanid0.Text.IndexOf(" ");

                bool motServiceCompleted = MaintenanceAccess.checkServiceBeforeMOT(cbxvanid0.Text.Substring(0, vanidspaceindex)); //check if mot service has ben completed
                bool checkMOT = MaintenanceAccess.isMOTDue(cbxvanid0.Text.Substring(0, vanidspaceindex)); // check if mot due date is after current date

                mot = true;

                if (!motServiceCompleted && cbxmaintenancetype0.SelectedIndex == 2)
                {
                    imgType.Visible = true; // if mot service is not completed and mot exam has been chosen, show symbol
                }
                else
                {
                    imgType.Visible = false;
                }
                if (checkMOT && cbxmaintenancetype0.SelectedIndex == 2)
                {
                    imgWarning0.Visible = true; // if mot due date is after current date, show symbol
                }
                else
                {
                    imgWarning0.Visible = false;
                }
            }
            if (tcMaintenance.SelectedIndex == 1) // if edit maintenance tab is selected, do the same as the previous tab, but without the checking of the mot due date.
            {
                int vanidspaceindex1 = cbxvanid1.Text.IndexOf(" ");
                bool motServiceCompleted1 = MaintenanceAccess.checkServiceBeforeMOT(cbxvanid1.Text.Substring(0, vanidspaceindex1));


                mot = true;

                if (!motServiceCompleted1 && cbxmaintenancetype1.SelectedIndex == 2)
                {
                    imgType1.Visible = true;
                }
                else
                {
                    imgType1.Visible = false;
                }
            }


        }

        private void cbxmaintenancetype0_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxstaffidm0.Items.Clear();
            imgMechanic0.Visible = false;


            if (cbxmaintenancetype0.SelectedIndex == 2)
            {
                checkMOTService();



            }
            else
            {
                mot = false;
                imgType.Visible = false;
                imgWarning0.Visible = false;
            }




            if (!mot)
            {

                List<Staff> ss1 = StaffAccess.getAllMechanicsAvailable();


                foreach (Staff staff in ss1)
                {


                    cbxstaffidm0.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname);
                    cbxstaffidm0.SelectedIndex = 0;



                }


            }
            else
            {
                cbxstaffidm0.Items.Add("No mechanics available for an MOT exam!");
                cbxstaffidm0.SelectedIndex = 0;

            }


        }

        private void cbxstaffidm0_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void cbxmaintenancetype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxstaffidm1.Items.Clear();
            imgMechanic1.Visible = false;
            int vanidspaceindex = cbxvanid1.Text.IndexOf(" ");


            if (cbxmaintenancetype1.SelectedIndex == 2)
            {
                checkMOTService();

            }

            else
            {
                mot = false;
                imgType1.Visible = false;
            }

            if (!mot)
            {

                List<Staff> ss1 = StaffAccess.getAllMechanicsAvailable();


                foreach (Staff staff in ss1)
                {


                    cbxstaffidm1.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname);
                    cbxstaffidm1.SelectedIndex = 0;


                }


            }
            else
            {
                cbxstaffidm1.Items.Add("No mechanics available for an MOT exam!");
                cbxstaffidm1.SelectedIndex = 0;

                tbxfirstm1.Clear();
                tbxsurm1.Clear();
                tbxtelm1.Clear();

            }
        }

        private void cbxstaffidm1_MouseHover(object sender, EventArgs e)
        {
            if (cbxstaffidm1.Text != "")
            {
                string text = cbxstaffidm1.SelectedItem.ToString();
                t.SetToolTip(cbxstaffidm1, text);
            }
        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxmaintenancedetails0_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpmaintenancestarttime0_ValueChanged(object sender, EventArgs e)
        {

            checkAvailability();


        }

        private void dtpmaintenancetime0_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void dtpmaintenancedate0_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void imgMechanic0_Click(object sender, EventArgs e)
        {

        }

        private void toolTipMethod() //set the messages for the tooltip
        {
            if (cbxstaffidm0 != null)
            {
                string text = cbxstaffidm0.SelectedItem.ToString();
                t.SetToolTip(cbxstaffidm0, text);
            }

            if (imgMechanic0.Visible == true)
            {
                string errortext = "The following mechanic is currently booked for this session: Please select different date/ times. ";
                t.SetToolTip(imgMechanic0, errortext);
            }
            if (imgDriver0.Visible == true)
            {
                string errortext = "The following Driver is currently booked for this session: Please select different date/ times. ";
                t.SetToolTip(imgDriver0, errortext);
            }
            if (imgMechanic1.Visible == true)
            {
                string errortext = "The following mechanic is currently booked for this session: Please select different date/ times. ";
                t.SetToolTip(imgMechanic1, errortext);
            }
            if (imgDriver1.Visible == true)
            {
                string errortext = "The following Driver is currently booked for this session: Please select different date/ times. ";
                t.SetToolTip(imgDriver1, errortext);
            }
            if (imgType.Visible == true)
            {
                string errortext = "Make sure the selected van has been booked for an MOT service before booking for an MOT exam. ";
                t.SetToolTip(imgType, errortext);
            }
            if (imgType1.Visible == true)
            {
                string errortext = "Make sure the selected van has been booked for an MOT service before booking for an MOT exam. ";
                t.SetToolTip(imgType1, errortext);
            }
            if (imgWarning0.Visible == true)
            {
                string errortext = "Information: \n MOT for this van is not yet due. ";
                t.SetToolTip(imgWarning0, errortext);
            }

        }

        private void imgMechanic0_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void imgType_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void dtpmaintenancedate1_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void dtpmaintenancestarttime1_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void dtpmaintenancetime1_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
        }

        private void imgWarning0_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void createMaintenanceReportOfVan(int maintenanceID, int vanID, int typeID)
        {
            //initialize objects
            Maintenance m = MaintenanceAccess.getMaintenanceByID(maintenanceID);
            Staff msD = StaffAccess.getDriverByMaintenanceID(maintenanceID);
            Van v = VanAccess.getVanByID(vanID);
            MaintenanceType mt = MaintenanceAccess.getMaintenanceTypeByID(typeID);

            // Creating the document
            Document document = new Document(PageSize.A4);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MaintenanceOfVanReport.pdf");
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();

            // Title
            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
            Paragraph title = new Paragraph("MOVERS COMPANY", titleFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(title);

            // Subtitle (Date)
            iTextSharp.text.Font subtitleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            Paragraph subtitle = new Paragraph("Maintenance Report - " + DateTime.Now.ToString("dd/MM/yyyy"), subtitleFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(subtitle);

            document.Add(new Paragraph("\n")); // Line break

            // Add the maintenance records details

            // Formatting each maintenance entry
            document.Add(new Paragraph("This report provides an overview of the scheduled maintenance activities for MOVERS COMPANY vehicles. " +
                "It includes detailed information on the maintenance tasks carried out, " +
                "including the type of service performed, the staff involved, " +
                "and the maintenance timelines. The report aims to ensure transparency and assist in tracking the upkeep of the fleet, " +
                "helping maintain operational efficiency and vehicle readiness. \n\n")
            { Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 14) });

            document.Add(new Paragraph("Maintenance ID: " + m.MaintenanceID));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Van ID: " + m.VanID));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Registration No: " + v.RegNo));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Maintenance Date: " + m.MaintenanceStartDate.ToString("dd/MM/yyyy")));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Maintenance Start Time: " + m.MaintenanceStartTime.ToString("HH:mm:ss")));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Maintenance End Time: " + m.MaintenanceEndTime.ToString("HH:mm:ss")));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Service Description: " + m.ServiceDescription));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Service Type: " + mt.TypeName));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));
            document.Add(new Paragraph("Driver Responsible: " + msD.Firstname + " " + msD.Surname));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("---------------------------------------------------------------------------"));

            Staff msM = new Staff();
            if (cbxmaintenancetype0.SelectedIndex != 2 || cbxmaintenancetype1.SelectedIndex != 2)
            {
                msM = StaffAccess.getMechanicByMaintenanceID(maintenanceID);
                document.Add(new Paragraph("Driver Responsible: " + msM.Firstname + " " + msM.Surname));

            }
            else
            {
                msM = StaffAccess.getMechanicByMaintenanceID(maintenanceID);
                document.Add(new Paragraph("Driver Responsible: " + msM.Firstname + " " + msM.Surname));
            }



            // Close the document
            document.Close();

            MessageBox.Show($"Van Service Report has been generated successfully!\nSaved at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open the generated PDF
            Process.Start(filePath);
        }

        private void imgDriver0_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void imgMechanic1_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void imgDriver1_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }

        private void imgType1_MouseHover(object sender, EventArgs e)
        {
            toolTipMethod();
        }
    }
}




