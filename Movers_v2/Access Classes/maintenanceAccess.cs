using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Security.Cryptography;

namespace Movers_v2
{
    class MaintenanceAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Maintenance getMaintenanceFromReader(SqlDataReader reader)
        {
            Maintenance s = new Maintenance();

            s.MaintenanceID = (int)reader[0];
            s.VanID = (int)reader[1];
            s.MaintenanceStartDate = (DateTime)reader[2];
            s.MaintenanceStartTime = (DateTime)reader[6];
            s.MaintenanceEndTime = (DateTime)reader[3];
            s.ServiceDescription = (string)reader[4];
            s.TypeID = (int)reader[5];

            return s;

        }

      

        public static DataTable getFilter(string maintenanceID, string vanID, string regNo, string motDueDate, string maintenanceStartDate,
            string typeName, string firstname, string surname)
        {
            DataTable d = new DataTable();
            using (SqlConnection conn = new SqlConnection(cString))
            {
                
                conn.Open();
                string query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " + // combine the first and surname of the staff members 
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID WHERE " + 
                  "(@maintenanceID = '' OR MAINTENANCE.maintenanceID LIKE '%' + @maintenanceID + '%') AND " +
                  "(@vanID = '' OR MAINTENANCE.vanID LIKE '%' + @vanID + '%') AND " +
                  "(@regNo = '' OR VAN.regNo LIKE '%' + @regNo + '%') AND " +
                  "(@motDueDate = '' OR VAN.motDueDate = @motDueDate) AND " +
                  "(@maintenanceStartDate = '' OR MAINTENANCE.maintenanceStartDate = @maintenanceStartDate) AND " +
                  "(@typeName = '' OR MAINTENANCETYPE.typeName LIKE '%' + @typeName + '%') AND ((@firstname = '' OR mechanic.firstname LIKE '%' + @firstname + '%') AND (@surname = '' OR mechanic.surname LIKE '%' + @surname + '%') OR (@firstname = '' OR driver.firstname LIKE '%' + @firstname + '%') AND (@surname = '' OR driver.surname LIKE '%' + @surname + '%')) ORDER BY MAINTENANCE.maintenanceStartDate DESC"); // filter that checks for every field, if blank show everything, if something has been inputted, only show the records with the matching fields.

                SqlCommand cmd = new SqlCommand(query, conn);

               
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@typeName", typeName);
                cmd.Parameters.AddWithValue("@maintenanceStartDate", maintenanceStartDate);
                cmd.Parameters.AddWithValue("@motDueDate", motDueDate);
                cmd.Parameters.AddWithValue("@regNo", regNo);
                cmd.Parameters.AddWithValue("@vanID", vanID);
                cmd.Parameters.AddWithValue("@maintenanceID", maintenanceID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(d);



                return d;



            }
        }
        public static MaintenanceStaff getMaintenancestaffFromReader(SqlDataReader reader)
        {
            MaintenanceStaff s = new MaintenanceStaff();

            s.MaintenanceStaffID = (int)reader[0];
            s.MaintenanceID = (int)reader[1];
            s.StaffID = (int)reader[2];
            s.Role = (string)reader[3];

            return s;
        }

        public static List<Maintenance> getAllmaintenance()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Maintenance> s = new List<Maintenance>();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getMaintenanceFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static DataTable getAllMaintenanceDataTable()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE WHERE maintenanceStartDate >= GETDATE();");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }


        public static int addMaintenance(Maintenance s)
        {
            //adds maintenance and gets the last maintenanceid using scope_identity. 
            string date = s.MaintenanceStartDate.ToString("yyyy-MM-dd");

            using (SqlConnection myConn = new SqlConnection(cString))
            {
                object maintenanceID = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO MAINTENANCE VALUES ({0}, '{1}', convert(datetime, '{2}'), '{3}', {4}, convert(datetime, '{5}')); SELECT SCOPE_IDENTITY();",
                    s.VanID, date, date + " " + s.MaintenanceEndTime.ToString("HH:mm:ss"), s.ServiceDescription, s.TypeID, date + " " + s.MaintenanceStartTime.ToString("HH:mm:ss"));




                SqlCommand command = new SqlCommand(query, myConn);

                //gets maintenanceid from scope_identity
                maintenanceID = command.ExecuteScalar();

                //Converts the object to an int
                return Convert.ToInt32(maintenanceID);


            }
        }

        public static int addMaintenanceStaff(int mID, int sID1, int sID2, string role1, string role2)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO MAINTENANCESTAFF (maintenanceID, staffID, role) VALUES ({0}, {1}, '{3}'), ({0}, {2}, '{4}')", mID, sID1, sID2, role1, role2);

                SqlCommand command = new SqlCommand(query, myConn);

                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;

            }
        }

        public static int addMaintenanceStaffDriverOnly(int mID, int sID1,  string role1)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO MAINTENANCESTAFF (maintenanceID, staffID, role) VALUES ({0}, {1}, '{2}')", mID, sID1, role1);

                SqlCommand command = new SqlCommand(query, myConn);

                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;

            }
        }


        public static int upDateMaintenance(Maintenance s)
        {

            string date = s.MaintenanceStartDate.ToString("yyyy-MM-dd");
            using (SqlConnection conn = new SqlConnection(cString))
            {


                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE MAINTENANCE SET vanID = {1}, maintenanceStartDate = '{2}', maintenanceStartTime = '{3}', maintenanceEndTime = '{4}', serviceDescription = '{5}', typeID = {6} WHERE maintenanceID = {0}",
                    s.MaintenanceID, s.VanID, date, date + " " + s.MaintenanceStartTime.ToString("HH:mm:ss"), date + " " + s.MaintenanceEndTime.ToString("HH:mm:ss"), s.ServiceDescription, s.TypeID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int upDateMaintenanceStaff1(int mID, int sID1) // update mechanic 
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE MAINTENANCESTAFF SET staffID = {1} WHERE maintenanceID = {0} AND role = 'mechanic'", mID, sID1);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int upDateMaintenanceStaff2(int mID, int sID2) // update driver
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE MAINTENANCESTAFF SET staffID = {1} WHERE maintenanceID = {0} AND role = 'Driver' OR role = 'Assistant Driver'", mID, sID2);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int deleteMaintenance(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM MAINTENANCE WHERE maintenanceID = {0}", mID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static int deleteMaintenanceDriver(int dID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM MAINTENANCESTAFF WHERE maintenanceID = {0} AND role = 'Driver' OR role = 'Assistant Driver'", dID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static int deleteMaintenanceMechanic(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM MAINTENANCESTAFF WHERE maintenanceID = {0} AND role = 'mechanic'", mID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static Maintenance getMaintenanceByID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Maintenance m = new Maintenance();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE WHERE maintenanceID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m = new Maintenance((int)reader[0], (int)reader[1], (DateTime)reader[2], (DateTime)reader[3], (string)reader[4], (int)reader[5], (DateTime)reader[6]);
                }

                conn.Close();
                return m;

            }
        }

        public static MaintenanceType getMaintenanceTypeByID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                MaintenanceType m = new MaintenanceType();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCETYPE WHERE typeID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m = new MaintenanceType((int)reader[0], (string)reader[1], (TimeSpan)reader[2]);
                }

                conn.Close();
                return m;

            }
        }



        public static MaintenanceStaff getMaintenanceStaffMechanicByID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                MaintenanceStaff m = new MaintenanceStaff();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCESTAFF WHERE maintenanceID = {0} AND role = 'mechanic'", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m = new MaintenanceStaff((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3]);
                }

                conn.Close();
                return m;

            }
        }

        public static List<Maintenance> getMaintenanceStaffMechanicByStaffID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Maintenance> m = new List<Maintenance>();
                conn.Open();
                string query = string.Format("SELECT MAINTENANCE.* FROM MAINTENANCE INNER JOIN MAINTENANCESTAFF ON MAINTENANCESTAFF.maintenanceID = MAINTENANCE.maintenanceID WHERE MAINTENANCESTAFF.staffID = {0} AND MAINTENANCESTAFF.role = 'mechanic'", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenanceFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }

        public static List<MaintenanceStaff> getAllMaintenanceStaffByStaffID(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<MaintenanceStaff> m = new List<MaintenanceStaff>();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCESTAFF WHERE staffID = {0}", sID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenancestaffFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }

        public static List<MaintenanceStaff> getAllMaintenanceStaffByMaintenanceID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<MaintenanceStaff> m = new List<MaintenanceStaff>();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCESTAFF WHERE maintenanceID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenancestaffFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }
        public static List<Maintenance> getAllMaintenancesByMaintenanceID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Maintenance> m = new List<Maintenance>();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE WHERE maintenanceID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenanceFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }

        public static List<Maintenance> getAllMaintenancesByVanID(int vanID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Maintenance> m = new List<Maintenance>();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE WHERE vanID = {0}", vanID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenanceFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }
        public static MaintenanceStaff getMaintenanceStaffDriverByID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                MaintenanceStaff m = new MaintenanceStaff();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCESTAFF WHERE maintenanceID = {0} AND role = 'Driver' OR role = 'Assistant Driver'", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m = new MaintenanceStaff((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3]);
                }

                conn.Close();
                return m;

            }
        }

        public static DataTable displayMaintenanceForSpecificVan( int vID) //get the maintenance for the inputted van ID
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID, MAINTENANCE.maintenanceStartDate, " +
                    "CONVERT(VARCHAR, MAINTENANCE.maintenanceStartTime, 108) AS 'Maintenance Start Time',  CONVERT(VARCHAR, MAINTENANCE.maintenanceEndTime, 108) AS 'Maintenance End Time', " +
                    " STAFF.firstname, STAFF.surname FROM MAINTENANCE INNER JOIN MAINTENANCESTAFF ON MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID INNER JOIN STAFF ON STAFF.staffID = MAINTENANCESTAFF.staffID WHERE MAINTENANCE.vanID = {0}", vID);
                SqlCommand command = new SqlCommand(query, conn);
              
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);


                
                return d;

            }
        }

        public static DataTable getAllMaintenancesForSpecificMechanic(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE m INNER JOIN MAINTENANCESTAFF ms ON ms.maintenanceID = m.maintenanceID WHERE ms.staffID = {0} AND m.maintenanceStartDate >= GETDATE() AND ms.role = 'Mechanic'", sID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getAllMaintenancesForSpecificDriver(int sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE m INNER JOIN MAINTENANCESTAFF ms ON ms.maintenanceID = m.maintenanceID WHERE ms.staffID = {0} AND m.maintenanceStartDate >= GETDATE() AND (ms.role = 'Driver' OR ms.role = 'Assistant Driver')", sID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable maintenanceQueries() 
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID, VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " +
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID");

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable vanServiceReport()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                    "MAINTENANCE.maintenanceStartDate, MAINTENANCE.maintenanceStartTime, " +
                    "MAINTENANCE.maintenanceEndTime, MAINTENANCE.serviceDescription, " +
                    "MAINTENANCETYPE.typeName, CONCAT(STAFF.firstname + ' ', STAFF.surname) AS 'Staff Name', STAFF.role " +
                    "FROM MAINTENANCE INNER JOIN MAINTENANCESTAFF ON MAINTENANCE.maintenanceID = MAINTENANCESTAFF.maintenanceID " +
                    "INNER JOIN STAFF ON STAFF.staffID = MAINTENANCESTAFF.staffID " +
                    "INNER JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                    "INNER JOIN MAINTENANCETYPE ON MAINTENANCE.typeID = MAINTENANCETYPE.typeID");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static bool checkServiceBeforeMOT(string vanID)
        {
            bool completed = false;
            using (SqlConnection conn = new SqlConnection(cString))
            {
                
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCE WHERE vanID = {0} AND typeID = 1 AND  maintenanceStartDate >= DATEADD(MONTH, -1, GETDATE())", vanID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    completed = true;
                }

                conn.Close();
                return completed;

            }
        }

        public static bool isMOTDue(string vanID) // checks if a van is due for an MOT; this is so that the warning image is displayed when trying to book an MOT exam for a van that has an MOT not yet due.
        {
            bool due = false;
            using (SqlConnection conn = new SqlConnection(cString))
            {
                
                conn.Open();
                string query = string.Format("SELECT 1 FROM VAN WHERE vanID = {0} AND motDueDate > GETDATE()", vanID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    due = true;
                }

                conn.Close();
                return due;

            }
        }

        public static DataTable maintenanceReport(int index)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
               
                DataTable d = new DataTable();
                string query = "";
                conn.Open();

                if(index == 0) // get all maintenances today
                {
                    query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " +
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID WHERE MAINTENANCE.maintenanceStartDate = CONVERT(DATE, GETDATE()) ORDER BY MAINTENANCE.maintenanceID");
                }
                if (index == 1) // all upcoming maintenances within a week
                {
                    query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " +
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID WHERE MAINTENANCE.maintenanceStartDate >= DATEADD( DAY, -7, GETDATE()) ORDER BY MAINTENANCE.maintenanceID");
                }
                if (index == 2) // all upcoming maintenances within a month
                {
                    query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " +
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID WHERE MAINTENANCE.maintenanceStartDate >= DATEADD( MONTH, -1, GETDATE()) ORDER BY MAINTENANCE.maintenanceID");
                }
                if (index == 3) // gets all upcoming maintenances within a year
                {
                    query = string.Format("SELECT MAINTENANCE.maintenanceID, MAINTENANCE.vanID,  VAN.regNo, VAN.motDueDate, " +
                  "MAINTENANCE.maintenanceStartDate, CONVERT(TIME,MAINTENANCE.maintenanceStartTime) AS 'maintenance start time', " +
                  "CONVERT(TIME,MAINTENANCE.maintenanceEndTime) AS 'maintenance end time', MAINTENANCE.serviceDescription, " +
                  "MAINTENANCETYPE.typeName,CONCAT( driver.firstname, ' ', driver.surname) AS driver, CONCAT(mechanic.firstname, ' ', mechanic.surname) AS mechanic " +
                  "FROM MAINTENANCE LEFT JOIN MAINTENANCETYPE ON MAINTENANCETYPE.typeID = MAINTENANCE.typeID LEFT JOIN VAN ON MAINTENANCE.vanID = VAN.vanID " +
                  "LEFT JOIN MAINTENANCESTAFF msDriver ON msDriver.maintenanceID = MAINTENANCE.maintenanceID AND (msDriver.role = 'Driver' OR msDriver.role = 'Assistant Driver') " +
                  "LEFT JOIN STAFF driver ON driver.staffID = msDriver.staffID " +
                  "LEFT JOIN MAINTENANCESTAFF msMechanic ON msMechanic.maintenanceID = MAINTENANCE.maintenanceID AND msMechanic.role = 'Mechanic' " +
                  "LEFT JOIN STAFF mechanic ON mechanic.staffID = msMechanic.staffID WHERE MAINTENANCE.maintenanceStartDate >= DATEADD( YEAR, -1, GETDATE()) ORDER BY MAINTENANCE.maintenanceID");
                }

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

    }
}
