using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    class MaintenanceType
    {
        TimeSpan expectedDuration;
        int typeID;
        string typeName;

        public MaintenanceType(int tID, string tN, TimeSpan ex)
        {
            typeID = tID;
            typeName = tN;
            expectedDuration = ex;

        }

        public MaintenanceType()
        {
            typeID = 0;
            typeName = "";
            expectedDuration = TimeSpan.MinValue;
        }

        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        public TimeSpan ExpectedDuration
        {
            get { return expectedDuration; }
            set { expectedDuration = value; }
        }
    }
}
