using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class Certificate
    {
        int certificateID, sessionID, staffID;
        DateTime certificationDate;
        string certificateDetails;

        public Certificate(int cID, int stID,int sID, DateTime d, string cD)
        {
            certificateID = cID;
            sessionID = sID;
            certificationDate = d;
            certificateDetails = cD;
            staffID = stID;


        }

        public Certificate()
        {
            sessionID = 0;
            certificationDate = DateTime.MinValue;
            staffID = 0;
            certificateDetails = "";
            certificateID = 0;
        }

        public int SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }
        public int CertificateID
        {
            get { return certificateID; }
            set { certificateID = value; }
        }
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public DateTime CertificationDate
        {
            get { return certificationDate; }
            set { certificationDate = value; }
        }

        public string CertificateDetails
        {
            get { return certificateDetails; }
            set { certificateDetails = value; }
        }
    }
}
