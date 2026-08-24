using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class Session
    {
        int sessionID, capacity;
        string sessionName;
        TimeSpan duration;


        public Session(int tID, string sN, int cap, TimeSpan d)
        {
           sessionID = tID;
            capacity = cap;
            duration = d;
            sessionName = sN;


        }

        public Session()
        {
            sessionID = 0;
            sessionName = "";
            duration = TimeSpan.MinValue;
            capacity = 0;
        }

        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public string SessionName
        {
            get { return sessionName; }
            set { sessionName = value; }
        }

        public TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
