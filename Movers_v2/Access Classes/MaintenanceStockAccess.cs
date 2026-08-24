using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class MaintenanceStockAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static MaintenanceStock getMaintenanceStockFromReader(SqlDataReader reader)
        {
            MaintenanceStock s = new MaintenanceStock();

            s.MaintenancestockID = (int)reader[0];
            s.MaintenanceID = (int)reader[1];
            s.StockID = (int)reader[2];
            s.TotalCost = (Decimal)reader[3];
            s.MaintenanceStockQuantity = (Decimal)reader[4];

            return s;

        }

        public static DataTable displayMaintenanceStockNeeded(int maintenanceID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT s.stockID, s.itemname, ISNULL(ms.maintenanceStockQuantity, 0) AS quantity, s.quantity AS 'quantity in stock', s.stockType AS 'type' FROM STOCK s LEFT JOIN MAINTENANCESTOCK ms ON s.stockID = ms.stockID AND ms.maintenanceID = {0}", maintenanceID);
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }


        public static decimal calculateTotalCost(int maintenanceID)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                try
                {
                    myConn.Open(); 

                    string query = string.Format("SELECT SUM(ISNULL(ms.maintenanceStockQuantity, 0) * s.price) AS totalCost FROM STOCK s LEFT JOIN MAINTENANCESTOCK ms ON s.stockID = ms.stockID AND ms.maintenanceID = {0}", maintenanceID); // gets the quantity and price of every stock item used for the maintenance, multiplies it together, and adds it all up.


                    SqlCommand command = new SqlCommand(query, myConn);
                    object result = command.ExecuteScalar();

                    decimal totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    myConn.Close();
                    return totalCost;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return 0;
                }
            }
        }


        public static decimal calculateFinalCost(string stockID, decimal quantity)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                try
                {
                    myConn.Open();

                    string query = string.Format("SELECT s.price * {1} AS totalCost FROM STOCK s WHERE s.stockID = {0}", stockID, quantity); // multiplies the quantity of the single stock used by the price of it.


                    SqlCommand command = new SqlCommand(query, myConn);
                    object result = command.ExecuteScalar();

                    decimal totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    myConn.Close();
                    return totalCost;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return 0;
                }
            }
        }


        public static int addmaintenancestock(MaintenanceStock s)
        {


            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO MAINTENANCESTOCK VALUES ({0}, {1}, {2}, {3});",
                    s.MaintenanceID, s.StockID, s.TotalCost, s.MaintenanceStockQuantity);


                SqlCommand command = new SqlCommand(query, myConn);
                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }

        public static int updateMaintenanceStock(int maintenanceID, decimal maintenanceStockQuantity, int stockID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE MAINTENANCESTOCK SET maintenanceStockQuantity = {1} WHERE maintenanceID = {0} AND stockID = {2};",
                    maintenanceID, maintenanceStockQuantity, stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int ReduceQuantityOfStock(decimal maintenanceStockQuantity, int stockID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity -= {0} WHERE stockID = {1};",
                     maintenanceStockQuantity, stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static bool checkMaintenanceStockExists(int maintenanceID, int stockID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                bool exists = false;
                conn.Open();
                string query = string.Format("SELECT * FROM MAINTENANCESTOCK WHERE stockID = {0} AND maintenanceID = {1} ", stockID, maintenanceID);

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    exists = true;
                }

                conn.Close();
                return exists;
            }
        }


        public static List<MaintenanceStock> getAllMaintenanceStockByMaintenanceID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<MaintenanceStock> m = new List<MaintenanceStock>();
                conn.Open();
                string query = string.Format("SELECT * FROM MaintenanceStock WHERE maintenanceID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m.Add(getMaintenanceStockFromReader(reader));
                }

                conn.Close();
                return m;

            }
        }


    }
}
