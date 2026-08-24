using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    public class Maintenance
    {
        int maintenanceID, vanID, typeID;
       
        DateTime maintenanceStartDate;
        DateTime  maintenanceStartTime, maintenanceEndTime;
        string serviceDescription;

        public Maintenance(int m, int v, DateTime md, DateTime mt, string sd, int t, DateTime mst)
        {
            maintenanceID = m;
            vanID = v;
            maintenanceStartDate = md;
            maintenanceStartTime = mst;
            maintenanceEndTime = mt;
            
            serviceDescription = sd;
            typeID = t;
            
        }

        public Maintenance()
        {
            maintenanceID = 0;
            vanID = 0;
            maintenanceStartDate = DateTime.MinValue;
            maintenanceStartTime = DateTime.MinValue;
            maintenanceEndTime = DateTime.MinValue;
          
            serviceDescription = "";
            typeID = 0;
        }

        public int MaintenanceID
        {
            get { return maintenanceID; }
            set { maintenanceID = value; }
        }
        public int VanID
        {
            get { return vanID; }
            set { vanID = value; }
        }

        public DateTime MaintenanceStartDate
        {
            get { return maintenanceStartDate; }
            set { maintenanceStartDate = value; }
        }

        public DateTime MaintenanceStartTime
        {
            get { return maintenanceStartTime; }
            set { maintenanceStartTime = value; }
        }

        public DateTime MaintenanceEndTime
        {
            get { return maintenanceEndTime; }
            set { maintenanceEndTime = value; }
        }

      

        public string ServiceDescription
        {
            get { return serviceDescription; }
            set { serviceDescription = value; }
        }

        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }


    }
}
