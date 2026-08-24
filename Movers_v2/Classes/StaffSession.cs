using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class StaffSession
    {
        int sessionID, staffID, attendanceID;
        Boolean sessionCompleted;
        DateTime scheduledDate;


        public StaffSession(int aID, int sID, int seID, bool sC, DateTime d )
        {
            attendanceID = aID;
            sessionID = seID;
            sessionCompleted = sC;
            scheduledDate = d;
            staffID = sID;

        }

        public StaffSession()
        {
             staffID = 0;
            sessionID = 0;
            attendanceID = 0;
            sessionCompleted = false;
            scheduledDate = DateTime.MinValue;
           
        }

        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public int AttendanceID
        {
            get { return attendanceID; }
            set { attendanceID = value; }
        }

        public DateTime ScheduledDate
        {
            get { return scheduledDate; }
            set { scheduledDate = value; }
        }

        public Boolean SessionCompleted
        {
            get { return sessionCompleted; }
            set { sessionCompleted = value; }
        }


    }
}
