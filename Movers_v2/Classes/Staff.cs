using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    public class Staff
    {
        int staffID;
        string firstname, surname, telNo, role;

        public Staff(int staffID, string firstname, string surname, string telNo, string role)
        {
            this.staffID = staffID;
            this.firstname = firstname;
            this.surname = surname;
            this.telNo = telNo;
            this.role = role;
            
        }

        public Staff()
        {
            staffID = 0;
            firstname = null;
            surname = null;
            telNo = null;
            role = null;
            
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }


        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        
    }
}
