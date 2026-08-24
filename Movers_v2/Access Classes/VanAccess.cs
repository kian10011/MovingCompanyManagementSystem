using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace Movers_v2
{
    internal class VanAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Van getVanFromReader(SqlDataReader reader)
        {
            Van myVan = new Van();

            myVan.VanID = (int)reader[0];
            myVan.MotDueDate = (DateTime)reader[2];
            myVan.RegNo = (string)reader[1];
            myVan.Model = (string)reader[3];
            myVan.Color = (string)reader[4];
            myVan.Size = (string)reader[5];




            return myVan;


        }

        public static List<Van> getFilter(string vanID, string regNo, string model, string color, string size)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> s = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT * FROM VAN WHERE " +
                     "(@vanID = '' OR vanID LIKE '%' + @vanID + '%') AND " +
                    "(@regNo = '' OR regNo LIKE '%' + @regNo + '%') AND " +
                    "(@model = '' OR model LIKE '%' + @model + '%') AND " +
                    "(@color = '' OR color LIKE '%' + @color + '%') AND " +
                    "(@size = '' OR size LIKE '%' + @size + '%')");


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@vanID", vanID);
                cmd.Parameters.AddWithValue("@regNo", regNo);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@model", model);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(new Van((int)reader[0], (string)reader[1], (DateTime)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]));
                }

                conn.Close();
                return s;


            }
        }

      

        public static List<Van> getAllVans()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT * FROM VAN");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }

        public static List<Van> getAllVansunderMaintenance()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT VAN.vanID, VAN.regNo, VAN.motDueDate, VAN.model, VAN.color, VAN.size FROM VAN INNER JOIN MAINTENANCE ON MAINTENANCE.vanID = VAN.vanID");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }

        public static List<Van> getAllVansAvailable()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT * FROM VAN v " +
                    "WHERE NOT EXISTS (SELECT 1 FROM MAINTENANCE m WHERE m.vanID = v.vanID " +
                    "AND (m.maintenanceStartDate > CAST(GETDATE() AS DATE) " +
                    "OR  (m.maintenanceStartDate = CAST(GETDATE() AS DATE) " +
                    "AND CAST(m.maintenanceEndTime AS TIME) > CAST(GETDATE() AS TIME))))");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }

        public static List<Van> returnVansAfterMaintenanceNotSameDate()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT * FROM VAN " +
                    "INNER JOIN MAINTENANCE ON MAINTENANCE.vanID = VAN.vanID " +
                    "WHERE CAST(GETDATE() AS DATE) > MAINTENANCE.maintenanceStartDate;");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
               SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }

        public static List<Van> returnVansAfterMaintenanceSameDate()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT DISTINCT * FROM VAN " +
                    "INNER JOIN MAINTENANCE ON MAINTENANCE.vanID = VAN.vanID " +
                    "WHERE CAST(GETDATE() AS DATE) = MAINTENANCE.maintenanceStartDate " +
                    "AND CAST(GETDATE() AS TIME) > CONVERT(TIME, MAINTENANCE.maintenanceEndTime, 108);");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }


        public static List<Van> getVansByMot()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Van> vans = new List<Van>();
                conn.Open();
                string query = string.Format("SELECT * FROM VAN WHERE motDueDate = 1");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vans.Add(getVanFromReader(reader));
                }

                conn.Close();
                return vans;
            }
        }

        public static int addVan(Van v)
        {

            var sqlFormattedDate = v.MotDueDate.ToString("yyyy-MM-dd");

            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO VAN VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    v.RegNo, sqlFormattedDate, v.Model, v.Color, v.Size);


                SqlCommand command = new SqlCommand(query, myConn);
                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }

        public static Van getVanByID(int vID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Van van = new Van();
                conn.Open();
                string query = string.Format("SELECT * FROM VAN WHERE vanID = {0}", vID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    van = new Van((int)reader[0], (string)reader[1], (DateTime)reader[2], (string)reader[3], (string)reader[4], (string)reader[5]);
                }

                conn.Close();
                return van;

            }
        }

        public static int upDateVan(Van v)
        {

            var sqlFormattedDate = v.MotDueDate.ToString("yyyy-MM-dd");

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE VAN SET regNo = '{1}', motDueDate = '{2}', model = '{3}', color = '{4}', size = '{5}' WHERE vanID = {0}",
                    v.VanID, v.RegNo, sqlFormattedDate, v.Model, v.Color, v.Size);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int deleteVan(int vID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM VAN WHERE vanID = {0}", vID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static int deleteMaintenanceStockOfVan(int vID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM VAN WHERE vanID = {0}", vID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }

        public static int deleteMaintenanceOfVan(int vID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query = string.Format("DELETE FROM VAN WHERE vanID = {0}", vID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
        }
        public static DataTable VanDueForMot()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable vansDue = new DataTable();
                conn.Open();

                string query = @"SELECT vanID, regNo FROM VAN WHERE motDueDate <= GETDATE() AND NOT EXISTS(SELECT 1 FROM MAINTENANCE m WHERE m.vanID = VAN.vanID AND m.typeID = 2 AND m.maintenanceStartDate > GETDATE()); ";


                SqlCommand command = new SqlCommand(query, conn);
            

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(vansDue);

                return vansDue;
            }
        }

        public static int upDateMOT(string newdate, string vID)
        {

           

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE VAN SET motDueDate = '{0}' WHERE vanID = {1}", newdate, vID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }
    }
}
