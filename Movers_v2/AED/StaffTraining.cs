using iTextSharp.text.pdf;
using Microsoft.Win32;
using Movers_v2.Access_Classes;
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
    public partial class StaffTraining : Form
    {
        DataTable table = new DataTable();
        ToolTip t = new ToolTip();
        string errorMessage = "";

        bool doneInd1 = false;
        bool doneInd2 = false;
        bool doneInd3 = false;
        bool doneRefresher = false;
        public StaffTraining()
        {
            InitializeComponent();
            refreshTabs();



            cbxSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCertificateSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDisplayCertificateForSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStaffCertificate.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void createTableSession() //Displays results with matching staffID AND sessionID
        {
            int spaceindexstaff = cbxStaff.Text.IndexOf(" ");
            int sessionIDMech = 3;
            int sessionIDDriver = cbxSession.SelectedIndex;
            //dgvResults.CellClick -= dgvResults_CellClick;

            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Staff Name");
            table.Columns.Add("Session name");
            table.Columns.Add("Scheduled Date");
            table.Columns.Add("Session Completed?");


            if (!cbxStaff.SelectedItem.ToString().Contains("Mechanic")) // if not mechanic
            {
                dgvResults.DataSource = StaffSessionAccess.displayStaffInSession(sessionIDDriver, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff))); //input sessionID and session date with sessionID being the selected index - Driver
            }
            else
            {
                dgvResults.DataSource = StaffSessionAccess.displayStaffInSession(sessionIDMech, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff))); //input sessionID and session date with manually added sessionID - Mechanic
            }






        }

        private void createTableSessionsOfStaff() //Displays results with matching staffID
        {
            int spaceindexstaff = cbxStaff.Text.IndexOf(" ");
            //dgvResults.CellClick -= dgvResults_CellClick;

            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Staff Name");
            table.Columns.Add("Session name");
            table.Columns.Add("Scheduled Date");
            table.Columns.Add("Session Completed?");


            if (cbxStaff.SelectedIndex != -1)
                dgvResults.DataSource = StaffSessionAccess.displayAllSessionsOfStaff(Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff))); //input sessionID and session date





        }

        private void createTableCertificate(int index)
        {
            if (index == 3)
            {
                dgvCertificate.DataSource = CertificateAccess.displayCertificateForAllSessions();
            }
            else
            {
                dgvCertificate.DataSource = CertificateAccess.displayCertificateForSelectedSession(index);
            }
            

            
        }



        private void addStaffToSession()
        {

            DateTime dt = Convert.ToDateTime(dtpSessionDate.Value);
            int spaceindexstaff = cbxStaff.Text.IndexOf(" ");
            Staff staff = StaffSessionAccess.getStaffByStaffSessionID(Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)));
            int sessionID = cbxSession.SelectedIndex;

            if (!cbxStaff.SelectedItem.ToString().Contains("Mechanic"))
            {
                if (sessionID == 0)
                {
                    if (dtpSessionDate.Value.Date >= DateTime.Today.Date)
                    {
                        if (!doneInd1 && !imgSession.Visible)
                        {
                            StaffSession s = new StaffSession(0, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)), cbxSession.SelectedIndex, false, DateTime.Parse(dt.ToShortDateString()));
                            int rows = StaffSessionAccess.addStaffSession(s);

                            if (rows == 1)
                            {
                                MessageBox.Show("Staff member has been added successfully to the training session!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                createTableSession();
                                refreshTabs();
                            }
                            else
                                MessageBox.Show("Staff member has not been added to the training session! An error occurred when trying to add staff member to session selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Staff member has not been added to the training session! Staff member: " + staff.Firstname + " " + staff.Surname + " has either been booked for or has already completed induction 1!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the training session! Selected session date must not be before today's current date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (sessionID == 1)
                {
                    if (dtpSessionDate.Value.Date >= DateTime.Today.Date)
                    {
                        if (!doneInd2 && !imgSession.Visible)
                        {
                            StaffSession s = new StaffSession(0, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)), cbxSession.SelectedIndex, false, DateTime.Parse(dt.ToShortDateString()));
                            int rows = StaffSessionAccess.addStaffSession(s);

                            if (rows == 1)
                            {
                                MessageBox.Show("Staff member has been added successfully to the training session!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                createTableSession();
                                refreshTabs();

                            }
                            else
                                MessageBox.Show("Staff member has not been added to the training session! An error occurred when trying to add staff member to session selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Staff member has not been added to the training session! Staff member: " + staff.Firstname + " " + staff.Surname + " has either been booked for or has already completed induction 2!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the training session! Selected session date must not be before today's current date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (sessionID == 2)
                {
                    if (dtpSessionDate.Value.Date >= DateTime.Today.Date)
                    {
                        if (!doneInd3 && !imgSession.Visible)
                        {
                            StaffSession s = new StaffSession(0, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)), cbxSession.SelectedIndex, false, DateTime.Parse(dt.ToShortDateString()));
                            int rows = StaffSessionAccess.addStaffSession(s);

                            if (rows == 1)
                            {
                                MessageBox.Show("Staff member has been added successfully to the training session!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                createTableSession();
                                refreshTabs();
                            }
                            else
                                MessageBox.Show("Staff member has not been added to the training session! An error occurred when trying to add staff member to session selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Staff member has not been added to the training session! Staff member: " + staff.Firstname + " " + staff.Surname + " has either been booked for or has already completed induction 3!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the training session! Selected session date must not be before today's current date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (dtpSessionDate.Value.Date >= DateTime.Today.Date)
                    {
                        if (!doneRefresher && !imgSession.Visible)
                        {
                            StaffSession s = new StaffSession(0, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)), cbxSession.SelectedIndex, false, DateTime.Parse(dt.ToShortDateString()));
                            int rows = StaffSessionAccess.addStaffSession(s);

                            if (rows == 1)
                            {
                                MessageBox.Show("Staff member has been added successfully to the training session!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                createTableSession();
                                refreshTabs();
                            }
                            else
                                MessageBox.Show("Staff member has not been added to the training session! An error occurred when trying to add staff member to session selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Staff member has not been added to the training session! Staff member: " + staff.Firstname + " " + staff.Surname + " has either been booked for or has already completed a refresher session within a year from today!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the training session! Selected session date must not be before today's current date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                if (dtpSessionDate.Value.Date >= DateTime.Today.Date)
                {
                    if (!doneRefresher && !imgSession.Visible)
                    {
                        StaffSession s = new StaffSession(0, Int32.Parse(cbxStaff.Text.Substring(0, spaceindexstaff)), 3, false, DateTime.Parse(dt.ToShortDateString()));
                        int rows = StaffSessionAccess.addStaffSession(s);

                        if (rows == 1)
                        {
                            MessageBox.Show("Staff member has been added successfully to the training session!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createTableSession();
                            refreshTabs();
                        }
                        else
                            MessageBox.Show("Staff member has not been added to the training session! An error occurred when trying to add staff member to session selected.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Staff member has not been added to the training session! Staff member: " + staff.Firstname + " " + staff.Surname + " has either been booked for or has already completed a refresher session within a year from today!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void checkAvailability()
        {
            int spaceIndex = cbxStaff.Text.IndexOf(" ");
            bool isAvailable;




            if (cbxStaff.Text != "" && cbxSession.Text != "" && dtpSessionDate.Text != "") //check empty fields
            {
                DateTime selectedDate = dtpSessionDate.Value; //get only date value of dtpSessionDate
                string formattedDate = selectedDate.ToString("yyyy/MM/dd");




                if (int.TryParse(cbxStaff.Text.Substring(0, spaceIndex), out int result)) //if the item selected is an int
                {
                    if (!cbxStaff.SelectedItem.ToString().Contains("Mechanic"))
                    {
                        isAvailable = StaffSessionAccess.checkDriverSessionAvailability(cbxSession.SelectedIndex, Int32.Parse(cbxStaff.Text.Substring(0, spaceIndex)) /*formattedDate*/); //create bool to check availability - If its a driver, the sessionID will match the selected index of the combobox.

                        if (!isAvailable) //if not available, show image
                        {
                            imgSession.Visible = true;
                            errorMessage = "Staff member  is already in the database for the selected session or date! Please select a different date or session.";

                        }
                        else //if available, check that the date selected is equal or after today's current date
                        {
                            if (dtpSessionDate.Value.Date >= DateTime.Today)
                            {
                                imgSession.Visible = false; // if date selected is after or today's current date, do not show image.
                            }
                            else
                            {
                                imgSession.Visible = true; // else, show image.
                                errorMessage = "Date selected must not be before today's current date! Please select a different date.";
                            }

                        }
                    }
                    else
                    {
                        isAvailable = StaffSessionAccess.checkMechanicSessionAvailability(3, Int32.Parse(cbxStaff.Text.Substring(0, spaceIndex)) /*formattedDate*/); //create bool to check availability - If its a mechanic, the sessionID will not match the selected index of the combobox; manually set to 3.

                        if (!isAvailable) //if not available, show image
                        {
                            imgSession.Visible = true;
                            errorMessage = "Staff member  is already in the database for the selected session or date! Please select a different date or session.";

                        }
                        else //if available, check that the date selected is equal or after today's current date
                        {
                            if (dtpSessionDate.Value.Date >= DateTime.Today)
                            {
                                imgSession.Visible = false; // if date selected is after or today's current date, do not show image.
                            }
                            else
                            {
                                imgSession.Visible = true; // else, show image.
                                errorMessage = "Date selected must not be before today's current date! Please select a different date.";
                            }

                        }
                    }

                }

            }

        }



        private void checkRefresher()
        {
            int spaceIndex = cbxStaff.Text.IndexOf(" ");
            if (cbxStaff.SelectedIndex != -1)
            {
                if (StaffSessionAccess.checkRefresherDone(Int32.Parse(cbxStaff.Text.Substring(0, spaceIndex))))
                {
                    lblRefresher.Text = "Refresher completed ?: Yes";
                    doneRefresher = true;
                }
                else
                {
                    lblRefresher.Text = "Refresher completed ?: No";
                    doneRefresher = false;
                }
            }

        }
        public void refreshTabs()
        {
            StaffSessionAccess.UpdateSessionCompletionStatus();

            cbxSession.Items.Clear();
            cbxStaff.Items.Clear();
            cbxCertificateSession.Items.Clear();
            cbxDisplayCertificateForSession.Items.Clear();

            dgvResults.DataSource = null;

            dtpSessionDate.Format = DateTimePickerFormat.Custom;
            dtpSessionDate.CustomFormat = " ";

            lblPleaseSelect.Visible = true;
            lblNoSessionsCompleted.Visible = false;
            imgSession.Visible = false;
            imgCertificate.Visible = false;

            cbxSession.Enabled = false;
            dtpSessionDate.Enabled = false;

            tbxCertificateDetails.Text = "";
            cbxStaffCertificate.Items.Clear();
            
            createTableCertificate(0);


            lblInd1.Text = "Induction 1 completed?:";
            lblInd2.Text = "Induction 2 completed?:";
            lblInd3.Text = "Induction 3 completed?:";
            lblRefresher.Text = "Refresher completed?:";
            lblNoBooked.Text = "Staff booked for selected session:";

            cbxCertificateSession.Items.Add(" Induction 1 - Van Familiarization & Load Distribution");
            cbxCertificateSession.Items.Add(" Induction 2 - Lifting Techniques & Basic Repairs");
            cbxCertificateSession.Items.Add(" Induction 3 - Accident Handling & Legal Responsibilities");

            cbxDisplayCertificateForSession.Items.Add(" Induction 1 - Van Familiarization & Load Distribution");
            cbxDisplayCertificateForSession.Items.Add(" Induction 2 - Lifting Techniques & Basic Repairs");
            cbxDisplayCertificateForSession.Items.Add(" Induction 3 - Accident Handling & Legal Responsibilities");
            cbxDisplayCertificateForSession.Items.Add("All sessions");

            cbxDisplayCertificateForSession.SelectedIndex = 3;






            List<Staff> ss = StaffAccess.getAllStaff();
            List<Staff> drivers = StaffAccess.getAllDrivers();


            foreach (Staff staff in ss)
            {
                cbxStaff.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname + "(" + staff.Role + ")");


            }
            foreach (Staff staff in drivers)
            {
                cbxStaffCertificate.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname + "(" + staff.Role + ")");
            }




        }
        private void tbxfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void StaffTraining_Load(object sender, EventArgs e)
        {


        }

        private void cbxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAvailability();
            int no = calculateSessionNumbers();

            StaffSessionAccess.UpdateSessionCompletionStatus();
            lblSessionCap.Text = "";
            lblDuration.Text = "";

            createTableSession();

            Session s = SessionAccess.getSessionByID(cbxSession.SelectedIndex);
            lblSessionCap.Text += "Session Capacity: " + s.Capacity;
            lblDuration.Text += "Session Duration: " + s.Duration;
            lblNoBooked.Text = "Staff booked for selected session: " + no;

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {




            if (cbxSession.Text != "" && cbxStaff.Text != "" & dtpSessionDate.Text != "")
            {
                addStaffToSession();
            }
            else
                MessageBox.Show("Ensure no fields are empty before proceeding.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void cbxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxSession.Items.Clear();

            checkAvailability();
            checkRefresher();
            lblInd1.Text = "";
            lblInd2.Text = "";
            lblInd3.Text = "";
            createTableSessionsOfStaff();

            cbxSession.Enabled = true;
            dtpSessionDate.Enabled = true;

            lblPleaseSelect.Visible = false;

            if (dgvResults.Rows.Count == 0)
            {

                lblNoSessionsCompleted.Visible = true;
            }
            else
            {
                lblNoSessionsCompleted.Visible = false; // Hide the label if data exists
            }

            int staffID = 0;



            int spaceIndex = cbxStaff.Text.IndexOf(" ");

            if (cbxStaff.SelectedIndex != -1)
            {
                staffID = Int32.Parse(cbxStaff.Text.Substring(0, spaceIndex));
            }


            List<Session> s = SessionAccess.getAllSessions();



            if (cbxStaff.SelectedItem != null && !cbxStaff.SelectedItem.ToString().Contains("Mechanic"))
            {

                for (int i = 0; i < s.Count; i++)
                {
                    cbxSession.Items.Add($"Induction {i + 1} - {s[i].SessionName}");
                }

                if (StaffSessionAccess.checkInduction1(staffID) == true)
                {
                    lblInd1.Text = "Induction 1 completed?: Yes";
                    doneInd1 = true;
                }
                else
                {
                    lblInd1.Text = "Induction 1 completed?: No";
                    doneInd1 = false;
                }



                if (StaffSessionAccess.checkInduction2(staffID) == true)
                {
                    lblInd2.Text = "Induction 2 completed?: Yes";
                    doneInd2 = true;
                }
                else
                {
                    lblInd2.Text = "Induction 2 completed?: No";
                    doneInd2 = false;
                }




                if (StaffSessionAccess.checkInduction3(staffID) == true)
                {
                    lblInd3.Text = "Induction 3 completed?: Yes";
                    doneInd3 = true;
                }
                else
                {
                    lblInd3.Text = "Induction 3 completed?: No";
                    doneInd3 = false;
                }

            }
            else
            {

                cbxSession.Items.Add("Refresher - Annual Skills");
                lblInd1.Text = "Induction 1 completed?: N/A";
                lblInd2.Text = "Induction 2 completed?: N/A";
                lblInd3.Text = "Induction 3 completed?: N/A";

            }



        }

        public int calculateSessionNumbers()
        {
            int rows = 0;
            DataTable dt = new DataTable();

            if (cbxSession.Text != "" && cbxStaff.Text != "" && dtpSessionDate.Text != " ")
            {
                dt = StaffSessionAccess.calculateSessionStaff(cbxSession.SelectedIndex, dtpSessionDate.Value);

                rows = dt.Rows.Count;
            }

            return rows;
        }

        private void dtpSessionDate_ValueChanged(object sender, EventArgs e)
        {
            checkAvailability();
            int no = calculateSessionNumbers();

            lblNoBooked.Text = "Staff booked for selected session: " + no;
            dtpSessionDate.Format = DateTimePickerFormat.Short;


        }

        private void dgvResults_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvResults.Columns[e.ColumnIndex].Name == "sessionCompleted")
            {
                e.Cancel = true; // Cancels editing the checkbox column
            }
        }

        private void tooltipmethod()
        {
            if (imgSession.Visible == true)
            {

                t.SetToolTip(imgSession, errorMessage);
            }
            if (imgCertificate.Visible == true)
            {
                t.SetToolTip (imgCertificate, errorMessage);
            }
        }

        private void imgSession_MouseHover(object sender, EventArgs e)
        {
            tooltipmethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffSessionAccess.UpdateSessionCompletionStatus();
        }

        private void cbxSession_MouseHover(object sender, EventArgs e)
        {
            if (cbxSession.Text != "")
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void showAllMembersOfSelectedSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbxSession.Text != "" && dtpSessionDate.Text != " ")
            {
                int sessionID;
                DateTime dt = dtpSessionDate.Value;
                string formattedDate = dt.ToString("yyyy/MM/dd");

                if (cbxStaff.SelectedItem != null && !cbxStaff.SelectedItem.ToString().Contains("Mechanic"))
                {
                    sessionID = cbxSession.SelectedIndex;
                }
                else
                {
                    sessionID = 3;
                }



                displayMembersForSession s = new displayMembersForSession(sessionID, formattedDate);
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Make sure that a session and date is selected before proceeding!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void lblNoSessionsCompleted_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TrainingQueries q = new TrainingQueries();
            q.Show();
            this.Close();
        }

        private void cbxDisplayCertificateForSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableCertificate(cbxDisplayCertificateForSession.SelectedIndex);
        }

        private void btnAddCertificate_Click(object sender, EventArgs e)
        {
            int spaceindex = cbxStaffCertificate.Text.IndexOf(" ");
            DateTime currentdate = DateTime.Now;


            if (tbxCertificateDetails.Text != "" && cbxCertificateSession.Text != "" && cbxStaffCertificate.Text != "")
            {
                if (imgCertificate.Visible != true)
                {
                    Certificate c = new Certificate(0, Int32.Parse(cbxStaffCertificate.Text.Substring(0, spaceindex)), cbxCertificateSession.SelectedIndex, currentdate, tbxCertificateDetails.Text);
                    Staff s = StaffAccess.getStaffByID(Int32.Parse(cbxStaffCertificate.Text.Substring(0, spaceindex)));
                    Session se = SessionAccess.getSessionByID(cbxCertificateSession.SelectedIndex);


                    try
                    {
                        DialogResult re = MessageBox.Show("Are you sure you want to award the following Staff member?:\n " + "Staff member: " + s.Firstname + " " + s.Surname + "\n Session: " + se.SessionName, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                        if (re == DialogResult.Yes)
                        {
                            int add = CertificateAccess.addCertificate(c);

                            if (add == 1)
                            {
                                MessageBox.Show("Staff member has been awarded with a certficate of completion of " + se.SessionName + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                createTableCertificate(0);
                                refreshTabs();
                            }
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading Stock below threshold: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Staff member has either not completed this session, or has already been given a certificate for this session!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);





            }
            else
                MessageBox.Show("Please fill all fields before proceeding.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }

        private void cbxCertificateSession_SelectedIndexChanged(object sender, EventArgs e)
        {

            int spaceindex = cbxStaffCertificate.Text.IndexOf(" ");
            string staffID = cbxStaffCertificate.Text.Substring(0, spaceindex);
            bool Completed = CertificateAccess.checkSessionCompletion(cbxCertificateSession.SelectedIndex, Int32.Parse(staffID));
            bool alreadyGiven = CertificateAccess.checkCertificateNotGivenYet(cbxCertificateSession.SelectedIndex, Int32.Parse(staffID));

            if (!Completed)
            {
                imgCertificate.Visible = true;
                errorMessage = "Staff member has not completed the selected session!";
            }


            if (alreadyGiven)
            {
                imgCertificate.Visible = true;
                errorMessage = "Staff member has already been given a certificate for the selected session!";
            }

            if ((Completed && !alreadyGiven))
            {
                imgCertificate.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            refreshTabs();


        }

        private void cbxStaffCertificate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spaceindex = cbxStaffCertificate.Text.IndexOf(" ");
            string staffID = cbxStaffCertificate.Text.Substring(0, spaceindex);
            bool Completed = CertificateAccess.checkSessionCompletion(cbxCertificateSession.SelectedIndex, Int32.Parse(staffID));
            bool alreadyGiven = CertificateAccess.checkCertificateNotGivenYet(cbxCertificateSession.SelectedIndex, Int32.Parse(staffID));

            if (!Completed)
            {
                imgCertificate.Visible = true;
                errorMessage = "Staff member has not completed the selected session!";
            }
            

            if (alreadyGiven)
            {
                imgCertificate.Visible = true;
                errorMessage = "Staff member has already been given a certificate for the selected session!";
            }
           
            if((Completed && !alreadyGiven))
            {
                imgCertificate.Visible = false;
            }
        }

        private void imgCertificate_MouseHover(object sender, EventArgs e)
        {
            tooltipmethod();
        }
    }
}
