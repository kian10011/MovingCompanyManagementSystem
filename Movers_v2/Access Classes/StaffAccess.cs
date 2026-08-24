using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class StaffAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Staff getStaffFromReader(SqlDataReader reader)
        {
            Staff s = new Staff();

            s.StaffID = (int)reader[0];
            s.Firstname = (string)reader[1];
            s.Surname = (string)reader[2];
            s.TelNo = (string)reader[3];
            s.Role = (string)reader[4];





            return s;

        }

        public static List<Staff> getAllStaff()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getFilter(string firstname, string surname, string telNo, string role, string type, string order)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE " +
                     "(@firstname = '' OR firstname LIKE '%' + @firstname + '%') AND " +
                    "(@surname = '' OR surname LIKE '%' + @surname + '%') AND " +
                    "(@telNo = '' OR telNo LIKE '%' + @telNo + '%') AND " +
                    "(@role = '' OR role = @role)");

                if (type == "Firstname" && order == "ASC")
                {
                    query += " ORDER BY firstname ASC";
                }
                else if (type == "Firstname" && order == "DESC")
                {
                    query += " ORDER BY firstname DESC";
                }
                else if (type == "Surname" && order == "ASC")
                {
                    query += " ORDER BY surname ASC";
                }
                else if (type == "Surname" && order == "DESC")
                {
                    query += " ORDER BY surname DESC";
                }
                else if (type == "ID" && order == "ASC")
                {
                    query += " ORDER BY staffID ASC";
                }
                else if (type == "ID" && order == "DESC")
                {
                    query += " ORDER BY staffID DESC";
                }


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@telNo", telNo);
                cmd.Parameters.AddWithValue("@role", role);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]));
                }

                conn.Close();
                return s;


            }
        }


        public static List<Staff> getAllMechanics()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE role = 'Mechanic'");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllMechanicsAvailable()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT * FROM STAFF INNER JOIN STAFFSESSION ON STAFFSESSION.staffID = STAFF.staffID WHERE role = 'Mechanic' AND STAFFSESSION.scheduledDate >= DATEADD(YEAR, -1, GETDATE()) AND (STAFFSESSION.sessionID = 3 AND STAFFSESSION.sessionCompleted = 1);");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllDrivers()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE (role = 'Driver' OR role = 'Assistant Driver')");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllDriversAvailable()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {


                List<Staff> s = new List<Staff>();
                conn.Open();
                string query1 = string.Format("SELECT DISTINCT s.staffID, s.firstname, s.surname, s.telNo, s.role FROM STAFF AS s INNER JOIN STAFFSESSION AS ss ON ss.staffID = s.staffID " +
                    "WHERE s.role IN ('Driver', 'Assistant Driver') " + // only includes staff members with role of driver or assistant driver
                    "GROUP BY s.staffID, s.firstname, s.surname, s.telNo, s.role" + // group by staff to ensure counting works
                    " HAVING COUNT(DISTINCT CASE WHEN ss.sessionCompleted = 1 THEN ss.sessionID END) = 4 " + //Ensure all 4 required sessions(Induction 1, Induction 2, Induction 3, and Refresher) are completed
                    "AND SUM(CASE WHEN ss.sessionID IN (0, 1, 2, 3) THEN 1 ELSE 0 END) = 4 " + //Double-check that all 4 session IDs (0, 1, 2, 3) exist in the database for each staff member
                    "AND MAX(CASE WHEN ss.sessionID = 3 " +
                    "THEN ss.scheduledDate END) >= DATEADD(YEAR, -1, GETDATE());"); //Ensure the refresher session (sessionID = 3) was completed within the last 12 months

                SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                SqlDataReader reader1 = sqlCommand1.ExecuteReader();

                while (reader1.Read())
                {
                    s.Add(getStaffFromReader(reader1));
                }



                conn.Close();
                return s;
            }
        }

        public static bool checkMechanicAvailability(int sID, string t1, string t2)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool isAvailable = true;
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE INNER JOIN MAINTENANCESTAFF ON " +
                    "MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID WHERE " +
                    "MAINTENANCESTAFF.role = 'Mechanic' AND " +
                    "MAINTENANCESTAFF.staffID = {0} AND " +
                    "('{1}' < MAINTENANCE.maintenanceEndTime AND '{2}' > MAINTENANCE.maintenanceStartTime);", sID, t1, t2); //Gets all the maintenances that have the mechanic ID inputted, and is in between the start and end times inputted.

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    isAvailable = false; // returns a false if the method finds a maintenance within these conditions; Means that the mechanic is unavailable if a maintenance within these conditions exist.
                }

                conn.Close();
                return isAvailable;
            }
        }




        public static bool checkDriverAvailability(int sID, string t1, string t2)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool isAvailable = true;
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE INNER JOIN MAINTENANCESTAFF ON " +
                    "MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID WHERE " +
                    "(MAINTENANCESTAFF.role = 'Driver' OR MAINTENANCESTAFF.role = 'Assistant Driver') AND " +
                    "MAINTENANCESTAFF.staffID = {0} AND " +
                    "('{1}' < MAINTENANCE.maintenanceEndTime AND '{2}' > MAINTENANCE.maintenanceStartTime);", sID, t1, t2); //Gets all the maintenances that have the driver ID inputted, and is in between the start and end times inputted.

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    isAvailable = false; // returns a false if the method finds a maintenance within these conditions; Means that the driver is unavailable if a maintenance within these conditions exist.
                }

                conn.Close();
                return isAvailable;
            }
        }



        public static List<Staff> getAllStafffirstAsc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY firstname ASC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllStafffirstDesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY firstname DESC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllStaffidasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY staffID ASC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllStaffiddesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY staffID DESC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllStaffsurasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY surname ASC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static List<Staff> getAllStaffsurdesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> s = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF ORDER BY surname DESC");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }
        public static int addStaff(Staff s)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int staffID = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO STAFF VALUES ('{0}', '{1}', '{2}', '{3}'); SELECT SCOPE_IDENTITY();",
                    s.Firstname, s.Surname, s.TelNo, s.Role);


                SqlCommand command = new SqlCommand(query, myConn);
                 staffID = Convert.ToInt32(command.ExecuteScalar());

                myConn.Close();
                return staffID;
            }
        }

        public static int readyToWork(string role, int staffID)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                string query = "";
                myConn.Open();

                if (role == "Mechanic")
                {
                    query = string.Format("INSERT INTO STAFFSESSION VALUES ({0}, 3, 1, CONVERT(DATE,GETDATE()))", staffID);

                }
                else
                {
                    query = string.Format("INSERT INTO STAFFSESSION VALUES ({0}, 0, 1, CONVERT(DATE,GETDATE())),  ({0}, 1, 1, CONVERT(DATE,GETDATE())),  ({0}, 2, 1, CONVERT(DATE,GETDATE())),  ({0}, 3, 1, CONVERT(DATE,GETDATE()))", staffID);
                }


                SqlCommand command = new SqlCommand(query, myConn);
                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }

        public static Staff getStaffByID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE staffID = {0}", sID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;

            }
        }

        public static Staff getMechanicByMaintenanceID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN MAINTENANCESTAFF ON MAINTENANCESTAFF.staffID = STAFF.staffID INNER JOIN MAINTENANCE ON MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID WHERE MAINTENANCESTAFF.role = 'Mechanic' AND " +
                    "MAINTENANCE.maintenanceID = {0};", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;

            }
        }

        public static Staff getDriverByMaintenanceID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF INNER JOIN MAINTENANCESTAFF ON MAINTENANCESTAFF.staffID = STAFF.staffID INNER JOIN MAINTENANCE ON MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID WHERE (MAINTENANCESTAFF.role = 'Assistant Driver' OR MAINTENANCESTAFF.role = 'Driver') AND " +
                    "MAINTENANCE.maintenanceID = {0};", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;

            }
        }


        public static Staff getMechanicsByID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE staffID = {0} AND role = 'Mechanic'", sID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;

            }
        }

        public static Staff getDriversByID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Staff s = new Staff();
                conn.Open();
                string query = string.Format("SELECT * FROM STAFF WHERE staffID = {0} AND (role = 'Driver' OR role = 'Assistant Driver')", sID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Staff((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                }

                conn.Close();
                return s;

            }
        }

        public static int upDateStaff(Staff s)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STAFF SET firstname = '{1}', surname = '{2}', telNo = '{3}', role = '{4}' WHERE staffID = {0}",
                    s.StaffID, s.Firstname, s.Surname, s.TelNo, s.Role);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int deleteStaff(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM STAFF WHERE staffID = {0}", sID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static int deleteMaintenanceForSpecificStaff(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM MAINTENANCE WHERE EXISTS (SELECT 1 FROM MAINTENANCESTAFF WHERE MAINTENANCESTAFF.maintenanceID = MAINTENANCE.maintenanceID AND MAINTENANCESTAFF.staffID = {0});", sID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }


        public static List<Staff> getAllStaffWithSession()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT * FROM STAFF INNER JOIN MAINTENANCESTAFF ON MAINTENANCESTAFF.staffID = STAFF.staffID INNER JOIN MAINTENANCE ON MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID WHERE CAST(GETDATE() AS DATE) >= MAINTENANCE.maintenanceStartDate AND CAST(GETDATE() AS TIME) > CONVERT(TIME, MAINTENANCE.maintenanceEndTime, 108) AND STAFF.role = 'Mechanic';");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    staff.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return staff;
            }
        }

        public static List<Staff> getAllStaffWithASession() //get all the staff members with a session booked in the database
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT STAFF.staffID, STAFF.firstname, STAFF.surname, STAFF.telNo, STAFF.role FROM STAFF  INNER JOIN STAFFSESSION ON STAFFSESSION.staffID = STAFF.staffID");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    staff.Add(getStaffFromReader(reader));
                }

                conn.Close();
                return staff;
            }
        }



    }
}
