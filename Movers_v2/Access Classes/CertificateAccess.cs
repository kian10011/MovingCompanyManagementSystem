using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Movers_v2.Access_Classes
{
    internal class CertificateAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Certificate getCertificateFromReader(SqlDataReader reader)
        {
            Certificate s = new Certificate();

            s.CertificateID = (int)reader[0];
            s.StaffID = (int)reader[1];
            s.SessionID = (int)reader[2];
            s.CertificationDate = (DateTime)reader[3];
            s.CertificateDetails = (string)reader[4];
          

            return s;

        }
        public static DataTable displayCertificateForSelectedSession(int index) //input index as session ID and display all certificates with the session ID equal to the index
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(s.firstname, + ' ' + s.surname) AS 'Staff member', se.sessionName, c.certificationDate, c.certificateDetails FROM STAFF s INNER JOIN CERTIFICATE c ON c.staffID = s.staffID " +
                    "INNER JOIN SESSION se ON se.sessionID = c.sessionID WHERE c.sessionID = {0}", index);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable displayCertificateForAllSessions()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(s.firstname, + ' ' + s.surname) AS 'Staff member', se.sessionName, c.certificationDate, c.certificateDetails FROM STAFF s INNER JOIN CERTIFICATE c ON c.staffID = s.staffID INNER JOIN SESSION se ON se.sessionID = c.sessionID;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }


        public static bool checkSessionCompletion(int seID, int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool completed = false;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN STAFFSESSION ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "STAFFSESSION.sessionID = {0} AND STAFFSESSION.staffID = {1} AND STAFFSESSION.sessionCompleted = 1", seID, sID);

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    completed = true;
                }

                conn.Close();
                return completed;
            }
        }

        public static bool checkCertificateNotGivenYet(int seID, int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool given = false;
                conn.Open();
                string query = string.Format("SELECT * FROM CERTIFICATE WHERE sessionID = {0} AND staffID = {1}", seID, sID);

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    given = true;
                }

                conn.Close();
                return given;
            }
        }


        public static int addCertificate(Certificate s)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
              
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO CERTIFICATE VALUES ({0}, {1}, '{2}', '{3}')",
                    s.StaffID, s.SessionID, s.CertificationDate.ToString("yyyy/MM/dd"), s.CertificateDetails);


                SqlCommand command = new SqlCommand(query, myConn);
                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }
    }
}
