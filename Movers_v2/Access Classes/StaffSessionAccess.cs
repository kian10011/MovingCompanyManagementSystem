using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers_v2
{
    internal class StaffSessionAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static StaffSession getStaffSessionFromReader(SqlDataReader reader)
        {
            StaffSession s = new StaffSession();

            s.AttendanceID = (int)reader[0];
            s.StaffID = (int)reader[1];
            s.SessionID = (int)reader[2];
            s.SessionCompleted = (bool)reader[3];
            s.ScheduledDate = (DateTime)reader[4];




            return s;

        }

        public static DataTable getFilter(string staffID, string sessionID, string scheduledDate, string sessionCompleted)
        {
            DataTable d = new DataTable();
            using (SqlConnection conn = new SqlConnection(cString))
            {

                conn.Open();
                string query = string.Format("SELECT DISTINCT STAFFSESSION.sessionID, SESSION.sessionName, SESSION.capacity, SESSION.duration, STAFFSESSION.staffID, CONCAT(STAFF.firstname + ' ', STAFF.surname) AS 'Staff Name', STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted " +
                    "FROM STAFFSESSION INNER JOIN SESSION ON SESSION.sessionID = STAFFSESSION.sessionID INNER JOIN STAFF ON STAFFSESSION.staffID = STAFF.staffID WHERE " +
                  "(@staffID = '' OR STAFFSESSION.staffID = @staffID) AND " +
                  "(@sessionID = '' OR STAFFSESSION.sessionID = @sessionID) AND " +
                  "(@scheduledDate = '' OR STAFFSESSION.scheduledDate = @scheduledDate) AND " +
                  "(@sessionCompleted = '' OR STAFFSESSION.sessionCompleted = @sessionCompleted);");

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@sessionID", sessionID);
                cmd.Parameters.AddWithValue("@staffID", staffID);
                cmd.Parameters.AddWithValue("@scheduledDate", scheduledDate);
                cmd.Parameters.AddWithValue("@sessionCompleted", sessionCompleted);
              

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(d);



                return d;


            }
        }

        public static DataTable displayStaffInSession(int sessionID, int staffID) //Displays all the sessions of a specific type of the chosen staff member
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.sessionID = {0} AND STAFFSESSION.staffID = {1}", sessionID, staffID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable displayAllStaffInSession(int sessionID, string date) //Displays all the staff members of the selected session and date.
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.sessionID = {0} AND CAST(STAFFSESSION.scheduledDate AS DATE) = '{1}';", sessionID, date);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable displayAllSessionsOfStaff(int staffID) //Displays all the sessions related to the chosen staff member
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.staffID = {0};", staffID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable displayAllSessionsOfSelectedDateAndSession(int sessionID, DateTime dt) //Displays all the sessions related to the chosen staff member
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                var date = dt.ToString("yyyy-MM-dd");
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.sessionID = {0} && STAFFSESSION.scheduledDate = {1};", sessionID, date);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable displayAllUpcomingStaffSessions(int staffID) //Displays all the sessions related to the chosen staff member
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.staffID = {0} AND STAFFSESSION.scheduledDate >= GETDATE();", staffID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable calculateSessionStaff(int sessionID, DateTime dt) //Displays all the sessions related to the chosen staff member
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                var formattedDate = dt.ToString("yyyy-MM-dd");
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION WHERE sessionID = {0} AND CONVERT(DATE,scheduledDate) = '{1}'", sessionID, formattedDate);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }
        public static List<StaffSession> getAllStaffSessions()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<StaffSession> s = new List<StaffSession>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffSessionFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static DataTable getAllStaffSessionsDataTable() 
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT CONCAT(STAFF.Firstname, ' ',STAFF.Surname) AS 'Staff Name', SESSION.sessionName, STAFFSESSION.scheduledDate, STAFFSESSION.sessionCompleted FROM STAFF " +
                    "INNER JOIN STAFFSESSION ON STAFF.staffID = STAFFSESSION.staffID " +
                    "INNER JOIN SESSION ON STAFFSESSION.sessionID = SESSION.sessionID " +
                    "WHERE STAFFSESSION.scheduledDate >= GETDATE();");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }
        public static List<StaffSession> getAllStaffSessionsByStaffID(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<StaffSession> s = new List<StaffSession>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION WHERE staffID = {0}", staffID);
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffSessionFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static bool checkDriverSessionAvailability(int seID, int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool isAvailable = true;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN STAFFSESSION ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "(STAFF.role = 'Driver' OR STAFF.role = 'Assistant Driver') AND STAFFSESSION.sessionID = {0} AND " +
                    "STAFFSESSION.staffID = {1};", seID, sID); //Gets all the staff that have the role of driver and has a scheduled date already existing in the system with the induction session selected.

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    isAvailable = false; // returns a false if the method finds a staff member with the above conditions, implying that the staff member is unavailable
                }

                conn.Close();
                return isAvailable;
            }
        }

        public static bool checkMechanicSessionAvailability(int seID, int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool isAvailable = true;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN STAFFSESSION ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "STAFF.role = 'Mechanic' AND STAFFSESSION.sessionID = {0} AND " +
                    "STAFFSESSION.staffID = {1};", seID, sID); //Gets all the staff that have the role of mechanic and has a scheduled date already existing in the system with the induction session selected.

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    isAvailable = false; // returns a false if the method finds a staff member with the above conditions, implying that the staff member is unavailable
                }

                conn.Close();
                return isAvailable;
            }
        }

        public static bool checkRefresherDone(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool doneRefresher = false;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN STAFFSESSION ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "STAFFSESSION.staffID = {0} AND STAFFSESSION.sessionID = 3 AND STAFFSESSION.sessionCompleted = 1 AND STAFFSESSION.scheduledDate >= DATEADD(YEAR, -1, GETDATE());", sID); //Checks if a specific staff member has already done a refresher within a year of the current date.

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    doneRefresher = true; //if the staff member has been found to already complete a refresher within a year of the current date, return doneRefresher as true
                }

                conn.Close();
                return doneRefresher;
            }
        }

        public static Staff getStaffByStaffSessionID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN STAFFSESSION ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "STAFFSESSION.staffID = {0}; " , sID); 

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;
            }
        }

        public static StaffSession getStaffSessionByID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                StaffSession s = new StaffSession();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION INNER JOIN STAFF ON " +
                    "STAFFSESSION.staffID = STAFF.staffID WHERE " +
                    "STAFFSESSION.staffID = {0}; ", sID); 

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    s = new StaffSession((int)reader[0], (int)reader[1], (int)reader[2], (bool)reader[3], (DateTime)reader[4]);
                }

                conn.Close();
                return s;
            }
        }
        public static bool checkInduction1(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool completed = false;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION WHERE staffID = {0} AND sessionID = 0 AND sessionCompleted = 1", staffID);

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

        public static bool checkInduction2(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool completed = false;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION WHERE staffID = {0} AND sessionID = 1 AND sessionCompleted = 1", staffID);

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

        public static bool checkInduction3(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool completed = false;
                conn.Open();
                string query = string.Format("SELECT * FROM STAFFSESSION WHERE staffID = {0} AND sessionID = 2 AND sessionCompleted = 1", staffID);

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

        public static int addStaffSession(StaffSession s)
        {
            string date = s.ScheduledDate.ToString("yyyy-MM-dd");

            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO STAFFSESSION VALUES ({0}, {1}, @sessionCompleted,'{2}')",
                    s.StaffID, s.SessionID, date);

                SqlCommand command = new SqlCommand(query, myConn);

                command.Parameters.AddWithValue("@sessionCompleted", false);

                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }

        public static void UpdateSessionCompletionStatus()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                conn.Open();
                string query = "UPDATE STAFFSESSION SET sessionCompleted = 1 WHERE scheduledDate <= CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable trainingReport(int index)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                
                DataTable d = new DataTable();
                string query = "";
                conn.Open();

                if(index == 0)
                {
                    query = string.Format("SELECT ss.staffID, s.firstname, s.surname, ss.scheduledDate, se.sessionName, se.duration FROM STAFF AS s INNER JOIN STAFFSESSION ss ON s.staffID = ss.staffID INNER JOIN SESSION AS se ON se.sessionID = ss.sessionID WHERE ss.scheduledDate = CONVERT(DATE, GETDATE()) ORDER BY se.sessionName ASC ");
                }
                if (index == 1)
                {
                    query = string.Format("SELECT ss.staffID, s.firstname, s.surname, ss.scheduledDate, se.sessionName, se.duration FROM STAFF AS s INNER JOIN STAFFSESSION ss ON s.staffID = ss.staffID INNER JOIN SESSION AS se ON se.sessionID = ss.sessionID WHERE ss.scheduledDate >= DATEADD(DAY, -7, GETDATE()) ORDER BY se.sessionName ASC ");
                }
                if (index == 2)
                {
                    query = string.Format("SELECT ss.staffID, s.firstname, s.surname, ss.scheduledDate, se.sessionName, se.duration FROM STAFF AS s INNER JOIN STAFFSESSION ss ON s.staffID = ss.staffID INNER JOIN SESSION AS se ON se.sessionID = ss.sessionID WHERE ss.scheduledDate >= DATEADD(MONTH, -1, GETDATE()) ORDER BY se.sessionName ASC ");
                }
                if (index == 3)
                {
                    query = string.Format("SELECT ss.staffID, s.firstname, s.surname, ss.scheduledDate, se.sessionName, se.duration FROM STAFF AS s INNER JOIN STAFFSESSION ss ON s.staffID = ss.staffID INNER JOIN SESSION AS se ON se.sessionID = ss.sessionID WHERE ss.scheduledDate >= DATEADD(YEAR, -1, GETDATE()) ORDER BY se.sessionName ASC ");
                }

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

    }
}
