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
    public partial class TrainingQueries : Form
    {
        public TrainingQueries()
        {
            InitializeComponent();
            populate();
            createTableTraining();
          
        }
        public void populate()
        {
            cbxstaff.Items.Clear();
            cbxsessiontype.Items.Clear();

            dtpsessionDate.CustomFormat = " ";

            List <Staff> s = StaffAccess.getAllStaffWithASession();
            cbxsessiontype.Items.Add("Induction 1 - Van Familiarization & Load Distribution");
            cbxsessiontype.Items.Add("Induction 2 - Lifting Techniques & Basic Repairs");
            cbxsessiontype.Items.Add("Induction 3 - Accident Handling & Legal Responsibilities");
            cbxsessiontype.Items.Add("Refresher - Annual skills");

            foreach( Staff staff in s)
            {
                cbxstaff.Items.Add(staff.StaffID + " - " + staff.Firstname + " " + staff.Surname + " (" + staff.Role + ")");
            }
        }

        public void createTableTraining()
        {
            if(cbxstaff.Text == "" && cbxsessiontype.Text == "" && dtpsessionDate.Text == "")
            {
                dgvResults.DataSource = StaffSessionAccess.getFilter("", "", "", "");
            }
            if (cbxstaff.Text != "")
            {
                int spaceindex = cbxstaff.Text.IndexOf(" ");

                if (cbxsessiontype.Text == "")
                {
                    dgvResults.DataSource = StaffSessionAccess.getFilter(cbxstaff.Text.Substring(0, spaceindex), "", dtpsessionDate.Text, checkboxsessioncompleted.Checked.ToString());
                }
                else
                {

                    dgvResults.DataSource = StaffSessionAccess.getFilter(cbxstaff.Text.Substring(0, spaceindex), cbxsessiontype.SelectedIndex.ToString(), dtpsessionDate.Text, checkboxsessioncompleted.Checked.ToString());
                }
            }
            else
            {
                if (cbxsessiontype.Text == "")
                {
                    dgvResults.DataSource = StaffSessionAccess.getFilter("", "", dtpsessionDate.Text, checkboxsessioncompleted.Checked.ToString());
                }
                else
                {

                    dgvResults.DataSource = StaffSessionAccess.getFilter("", cbxsessiontype.SelectedIndex.ToString(), dtpsessionDate.Text, checkboxsessioncompleted.Checked.ToString());
                }
            }

           
        }
        private void TrainingQueries_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxsessiontype.ResetText();
            cbxstaff.ResetText();
            populate();
            createTableTraining();
        }

        private void cbxstaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableTraining();
        }

        private void cbxsessiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableTraining();
        }

        private void dtpsessionDate_ValueChanged(object sender, EventArgs e)
        {
            dtpsessionDate.CustomFormat = "yyyy/MM/dd";
            createTableTraining();
        }

        private void checkboxsessioncompleted_CheckedChanged(object sender, EventArgs e)
        {
            createTableTraining();
        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(); 
            m.Show();
            this.Close();
        }

        private void btnTraining_Click_1(object sender, EventArgs e)
        {
            StaffTraining s = new StaffTraining();
            s.Show();
            this.Close();
        }
    }
}
