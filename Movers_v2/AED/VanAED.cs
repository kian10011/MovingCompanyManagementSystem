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
    public partial class VanAED : Form
    {
        public VanAED()
        {

            InitializeComponent();
            refreshTabs();

            //edit
            cbxVanID1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxsize1.DropDownStyle = ComboBoxStyle.DropDownList;


            //delete
            cbxVanID2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxsize2.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxRegNo2.ReadOnly = true;
            tbxColor2.ReadOnly = true;
            tbxModel2.ReadOnly = true;
            dtpMOT2.Enabled = false;
            cbxsize2.Enabled = false;



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Van van = VanAccess.getVanByID((int)cbxVanID1.SelectedItem);
            tbxRegNo1.Text = van.RegNo;
            dtpMOT1.Text = van.MotDueDate.ToString();
            tbxModel1.Text = van.Model;
            tbxColor1.Text = van.Color;
            cbxsize1.Text = van.Size;
        }

        private void cbxVanID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Van van = VanAccess.getVanByID((int)cbxVanID2.SelectedItem);
            tbxRegNo2.Text = van.RegNo;
            dtpMOT2.Text = van.MotDueDate.ToString();
            tbxModel2.Text = van.Model;
            tbxColor2.Text = van.Color;
            cbxsize2.Text = van.Size;
        }

        private void VanAED_Load(object sender, EventArgs e)
        {
            tcVAN.SelectedIndex = 0;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            VanQueries mq = new VanQueries();
            mq.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcVAN.SelectedIndex)
            {
                case 0: btnExecute.Text = "ADD VAN"; break;
                case 1: btnExecute.Text = "EDIT VAN"; break;
                case 2: btnExecute.Text = "DELETE VAN"; break;

            }
        }

        private void refreshTabs()
        {
            cbxVanID1.Items.Clear();
            cbxVanID2.Items.Clear();

            cbxsize0.SelectedIndex = -1;
            cbxsize1.SelectedIndex = -1;
            cbxsize2.SelectedIndex = -1;

            dtpMOT0.Value = DateTime.Now.AddDays(1);
            dtpMOT1.Value = DateTime.Now.AddDays(1);

            

            List<Van> allVans = VanAccess.getAllVans();
            foreach (Van van in allVans)
            {
                cbxVanID1.Items.Add(van.VanID);
                cbxVanID2.Items.Add(van.VanID);


            }

        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            int result = 0;


            if (tcVAN.SelectedIndex == 0)
            {

                if (tbxRegNo0.Text != "" && dtpMOT0.Text != "" && tbxModel0.Text != "" && tbxColor0.Text != "" && cbxsize0.Text != "")
                {
                    string regnovalid = VanValidation.ValidateRegistrationPlate(tbxRegNo0.Text);

                    if (regnovalid == " ")
                    {
                        if(dtpMOT0.Value.Date > DateTime.Today.Date)
                        {
                            Van van = new Van(0, tbxRegNo0.Text, dtpMOT0.Value, tbxModel0.Text, tbxColor0.Text, cbxsize0.Text);

                            int rows = VanAccess.addVan(van);

                            if (rows == 1)
                            {
                                MessageBox.Show("Van has been added successfully to the database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                foreach (Control co in this.tabAdd.Controls)
                                {
                                    if (co is TextBox)
                                        co.Text = "";

                                    refreshTabs();

                                }
                            }
                            else
                                MessageBox.Show("Van has not been added to the database! Something went wrong when attempting to add van.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Van has not been added to the database! Selected MOT due date for van must not be before today's date. \n Please select a different date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Van has not been added to the database! " + regnovalid, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Van has not been added to the database! Ensure no fields are empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tcVAN.SelectedIndex == 1)
            {



                if (tbxRegNo1.Text != "" && dtpMOT1.Text != "" && tbxModel1.Text != "" && tbxColor1.Text != "" && cbxsize1.Text != "")
                {
                    string regnovalid = VanValidation.ValidateRegistrationPlate(tbxRegNo1.Text);

                    if (regnovalid == " ")
                    {
                        if(dtpMOT1.Value.Date > DateTime.Today.Date)
                        {
                            Van van = new Van(Int32.Parse(cbxVanID1.Text), tbxRegNo1.Text, dtpMOT1.Value, tbxModel1.Text, tbxColor1.Text, cbxsize1.Text);
                            result = VanAccess.upDateVan(van);

                            if (result == 1)
                            {

                                MessageBox.Show("Van has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                foreach (Control co in this.tabEdit.Controls)
                                {

                                    if (co is TextBox)
                                        co.Text = "";

                                    refreshTabs();
                                }
                            }
                            else
                                MessageBox.Show("Van has not been updated!", "Something went wrong when attempting to update van.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Van has not been updated! Selected MOT due date for van must not be before today's date. \n Please select a different date.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Van has not been updated to the database! " + regnovalid, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Van has not been updated!", "Ensure no fields are empty.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {



                if (cbxVanID2.Text != "")
                {
                    Van van = new Van(Int32.Parse(cbxVanID2.Text), tbxRegNo2.Text, dtpMOT2.Value, tbxModel2.Text, tbxColor2.Text, cbxsize2.Text);
                    string delete = "Deleting this van will also delete the following records: \n\n -----MAINTENANCE RECORDS----- \n\n";

                    List<Maintenance> maintenance = MaintenanceAccess.getAllMaintenancesByVanID(van.VanID);

                    foreach (Maintenance m in maintenance)
                    {
                        delete += "Maintenance ID: " + m.MaintenanceID + "\n\n Maintenance date: " + m.MaintenanceStartDate.ToString("dd/MM/yyyy") + "\n\n Van ID: " + m.VanID + "\n\n";
                    }
                    delete += "\n\n -------MAINTENANCE STAFF RECORDS------- \n\n";

                    List<MaintenanceStaff> mstafflist = new List<MaintenanceStaff>();
                    List<MaintenanceStock> mstocklist = new List<MaintenanceStock>();

                    foreach (Maintenance m in maintenance)
                    {
                        mstafflist.AddRange(MaintenanceAccess.getAllMaintenanceStaffByMaintenanceID(m.MaintenanceID));
                        mstocklist.AddRange(MaintenanceStockAccess.getAllMaintenanceStockByMaintenanceID(m.MaintenanceID));
                    }

                    foreach (MaintenanceStaff mStaff in mstafflist)
                    {
                        delete += "Maintenance staff ID: " + mStaff.MaintenanceStaffID + "\n\n Maintenance ID: " + mStaff.MaintenanceID + "\n\n";
                    }

                    delete += "\n\n ------MAINTENANCE STOCK RECORDS------ \n\n";

                    foreach (MaintenanceStock mstock in mstocklist)
                    {
                        delete += "Maintenance Stock ID: " + mstock.MaintenancestockID + "\n\n Total cost: " + mstock.TotalCost + "\n\n";
                    }


                    delete += "\n Would you like to continue?";

                    DialogResult d = MessageBox.Show(delete, "WARNING", MessageBoxButtons.YesNo);

                    if (d == DialogResult.Yes)
                    {
                        result = VanAccess.deleteVan(van.VanID);

                        if (result == 1)
                        {
                            MessageBox.Show("Van has been successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            foreach (Control co in this.tabDelete.Controls)
                            {
                                if (co is TextBox)
                                    co.Text = "";

                                refreshTabs();
                            }
                        }
                        else
                            MessageBox.Show("Van has not been deleted from the database! Something went wrong when attempting to delete van.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                       
                }
                else
                    MessageBox.Show("Van has not been deleted!", "Please enter a VanID to delete.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            
        }

        private void tbxRegNo0_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMOT0_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
