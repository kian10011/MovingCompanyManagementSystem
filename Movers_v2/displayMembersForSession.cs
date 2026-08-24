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
    public partial class displayMembersForSession : Form
    {
        DataTable table = new DataTable();
        public displayMembersForSession( int sessionID, string Date)
        {
            InitializeComponent();
            
            createTableSessions(sessionID, Date);

            if (dgvResults.Rows.Count == 0)
            {
                
                lblNoResults.Visible = true;  // Show the label if no data is found
            }
            else
            {
                lblNoResults.Visible = false; // Hide the label if data exists
            }
        }

        private void displayMembersForSession_Load(object sender, EventArgs e)
        {

        }

        private void createTableSessions(int sessionID, string Date) //Displays results with matching staffID
        {
            

            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Staff Name");
            table.Columns.Add("Session name");
            table.Columns.Add("Scheduled Date");
            table.Columns.Add("Session Completed?");



            dgvResults.DataSource = StaffSessionAccess.displayAllStaffInSession(sessionID, Date); //input sessionID and session date


            


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            StaffTraining s = new StaffTraining();
            s.Show();
            this.Close();
        }
    }
}
