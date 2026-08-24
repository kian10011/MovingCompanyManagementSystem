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
    public partial class StaffAED : Form
    {
        public StaffAED()
        {
            InitializeComponent();
            refreshTabs();

            cbxrole0.DropDownStyle = ComboBoxStyle.DropDownList;

            //edit
            cbxstaffid1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxrole1.DropDownStyle = ComboBoxStyle.DropDownList;


            //delete
            cbxstaffid2.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxfirstname2.ReadOnly = true;
            tbxsurname2.ReadOnly = true;
            tbxtel2.ReadOnly = true;
            cbxrole2.Enabled = false;


        }

        private void refreshTabs()
        {
            cbxstaffid1.Items.Clear();
            cbxstaffid2.Items.Clear();

            cbxrole0.SelectedIndex = -1;
            cbxrole1.SelectedIndex = -1;
            cbxrole2.SelectedIndex = -1;

            List<Staff> s = StaffAccess.getAllStaff();
            foreach (Staff staff in s)
            {
                cbxstaffid1.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname + " (" + staff.Role + ")");
                cbxstaffid2.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname + " (" + staff.Role + ")");


            }

        }

        private void StaffAED_Load(object sender, EventArgs e)
        {

        }

        private void cbxstaffid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceIndex = cbxstaffid1.Text.IndexOf(" ");
            Staff s = StaffAccess.getStaffByID(Int32.Parse(cbxstaffid1.Text.Substring(0, spaceIndex)));

            tbxfirstname1.Text = s.Firstname;
            tbxsurname1.Text = s.Surname;
            tbxtel1.Text = s.TelNo;
            cbxrole1.Text = s.Role;

        }

        private void cbxstaffid2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int spaceIndex = cbxstaffid2.Text.IndexOf(" ");
            Staff s = StaffAccess.getStaffByID(Int32.Parse(cbxstaffid2.Text.Substring(0, spaceIndex)));

            tbxfirstname2.Text = s.Firstname;
            tbxsurname2.Text = s.Surname;
            tbxtel2.Text = s.TelNo;
            cbxrole2.Text = s.Role;

        }

        private void tcStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcStaff.SelectedIndex)
            {
                case 0: btnExecute.Text = "ADD STAFF"; break;
                case 1: btnExecute.Text = "EDIT STAFF"; break;
                case 2: btnExecute.Text = "DELETE STAFF"; break;

            }
        }
        private string telNoValid(string phoneNumber)
        {
            // Ensures the number starts with an optional '+' or '0', followed by digits (1-15 digits)
            string valid = @"^(\+?0)\d{1,14}$";

            if (Regex.IsMatch(phoneNumber, valid))
            {
                return "Phone number is valid.";
            }

            // Check for specific cases:
            if (!phoneNumber.StartsWith("0") && !phoneNumber.StartsWith("+0"))
            {
                return "Phone number must start with '0' or '+0'.";
            }

            // Check if the number has more than 15 digits
            if (phoneNumber.Length > 15)
            {
                return "Phone number cannot have more than 15 digits.";
            }

            // Check if the number has fewer than 2 digits (including the starting '0')
            if (phoneNumber.Length < 2)
            {
                return "Phone number must be at least 2 characters long, starting with '0'.";
            }

            // General catch-all error message if no other condition matched (optional)
            return "Invalid phone number format.";
        }



        private void btnExecute_Click(object sender, EventArgs e)
        {
            int result = 0;

            int spaceIndex1 = cbxstaffid1.Text.IndexOf(" ");
            int spaceIndex2 = cbxstaffid2.Text.IndexOf(" ");


            if (tcStaff.SelectedIndex == 0)
            {


                if (tbxfirstname0.Text != "" && tbxsurname0.Text != "" & tbxtel0.Text != "" & cbxrole0.Text != "")
                {
                    if (!tbxfirstname0.Text.Contains("'") || !tbxsurname0.Text.Contains("'"))
                    {
                        if (telNoValid(tbxtel0.Text) == "Phone number is valid.")
                        {
                            try
                            {
                                Staff staff = new Staff(0, tbxfirstname0.Text, tbxsurname0.Text, tbxtel0.Text, cbxrole0.Text);
                                int staffID = StaffAccess.addStaff(staff);

                                if (chbReadyToWork.Checked)
                                {
                                    int ready = StaffAccess.readyToWork(staff.Role, staffID);

                                    try
                                    {
                                        if (ready == 1 || ready == 4)
                                        {
                                            MessageBox.Show("Staff has been added successfully to the database and is now ready to work!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Staff member has been added successfully to the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }


                                foreach (Control co in this.tabAdd.Controls)
                                {
                                    if (co is TextBox)
                                        co.Text = "";


                                    refreshTabs();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            
                            
                               
                          

                        }
                        else
                            MessageBox.Show(telNoValid(tbxtel0.Text), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the database! Character: ' is not permitted when entering a name. Please try a different name.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Staff member has not been added to the database! Some fields are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tcStaff.SelectedIndex == 1)
            {

                if (cbxstaffid1.Text != "" && tbxfirstname1.Text != "" && tbxsurname1.Text != "" & tbxtel1.Text != "" & cbxrole1.Text != "")
                {
                    if (!tbxfirstname1.Text.Contains("'") || !tbxsurname1.Text.Contains("'"))
                    {

                        if (telNoValid(tbxtel1.Text) == "Phone number is valid.")
                        {
                            Staff staff = new Staff(Int32.Parse(cbxstaffid1.Text.Substring(0, spaceIndex1)), tbxfirstname1.Text, tbxsurname1.Text, tbxtel1.Text, cbxrole1.Text);
                            result = StaffAccess.upDateStaff(staff);
                            if (result == 1)
                            {

                                MessageBox.Show("Staff member has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                foreach (Control co in this.tabEdit.Controls)
                                {

                                    if (co is TextBox)
                                        co.Text = "";


                                    refreshTabs();
                                }
                            }
                            else
                                MessageBox.Show("Staff member has not been updated! Attempt to update staff was unsuccessful.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        }
                        else
                            MessageBox.Show(telNoValid(tbxtel1.Text), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Staff member has not been updated! The character : ' is not permitted when entering names. Please enter a different name.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                else
                    MessageBox.Show("Staff member has not been updated! Some fields are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (cbxstaffid2.Text != "")
                {
                    Staff staff = new Staff(Int32.Parse(cbxstaffid2.Text.Substring(0, spaceIndex2)), tbxfirstname2.Text, tbxsurname2.Text, tbxtel2.Text, cbxrole2.Text);
                    string delete = "Deleting this staff member will also delete the following records: \n\n -----TRAINING RECORDS----- \n\n";
                    List<StaffSession> sessions = StaffSessionAccess.getAllStaffSessionsByStaffID(staff.StaffID);

                    foreach (StaffSession session in sessions)
                    {
                        delete += "Attendance ID: " + session.AttendanceID + "\n\n Session date: " + session.ScheduledDate.ToString("dd/MM/yyyy") + "\n";
                    }
                    delete += "\n\n -----MAINTENANCE STAFF RECORDS----- \n\n";

                    List<MaintenanceStaff> mstafflist = MaintenanceAccess.getAllMaintenanceStaffByStaffID(staff.StaffID);

                    foreach (MaintenanceStaff mStaff in mstafflist)
                    {
                        delete += "Maintenance staff ID: " + mStaff.MaintenanceStaffID + "\n\n Maintenance ID: " + mStaff.MaintenanceID + "\n";
                    }

                    delete += "\n\n -----MAINTENANCE RECORDS----- \n\n";
                    List<Maintenance> mlist = new List<Maintenance>();

                    foreach (MaintenanceStaff mStaff in mstafflist)
                    {
                        mlist.AddRange(MaintenanceAccess.getAllMaintenancesByMaintenanceID(mStaff.MaintenanceID));
                    }

                    foreach (Maintenance m in mlist)
                    {
                        delete += "Maintenance ID: " + m.MaintenanceID + "\n\n Maintenance date: " + m.MaintenanceStartDate.ToString("dd/MM/yyyy") + "\n\n Van ID: " + m.VanID + "\n";
                    }

                    delete += "\n Would you like to continue?";

                    DialogResult d = MessageBox.Show(delete, "WARNING", MessageBoxButtons.YesNo);

                    if (d == DialogResult.Yes)
                    {
                        int maintenance = StaffAccess.deleteMaintenanceForSpecificStaff(staff.StaffID);
                        result = StaffAccess.deleteStaff(staff.StaffID);
                       

                        if (result == 1)
                        {
                            MessageBox.Show("Staff member has been successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cbxstaffid2.ResetText();
                            foreach (Control co in this.tabDelete.Controls)
                            {
                                if (co is TextBox)
                                    co.Text = "";

                                refreshTabs();
                            }
                        }
                        else
                            MessageBox.Show("Staff member has not been deleted!", "An error occurred when attempting to delete staff member.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                   
                }
                else
                    MessageBox.Show("Staff member has not been deleted!", "Make sure staffID combobox is not empty.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu s = new MainMenu();
            s.Show();
            this.Hide();

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            StaffQueries s = new StaffQueries();
            s.Show();
            this.Hide();
        }

        private void chbReadyToWork_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
