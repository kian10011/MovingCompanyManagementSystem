using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class MaintenanceStaff
    {
        int  maintenancestaffID, maintenanceID, staffID;
        string role;

        public MaintenanceStaff(int msi, int mi, int si, string r)
        {
            maintenancestaffID = msi;
            maintenanceID = mi;
            staffID = si;
            role = r;
        }

        public MaintenanceStaff()
        {
            maintenancestaffID = 0;
            maintenanceID = 0;
            staffID = 0;
            role = "";
        }

        public int MaintenanceStaffID
        {
            get { return maintenancestaffID; }
            set { maintenancestaffID = value; }
        }
        public int MaintenanceID
        {
            get { return maintenanceID; }
            set { maintenanceID = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
