using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Movers_v2
{
    internal class StockAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Stock getStockFromReader(SqlDataReader reader)
        {
            Stock s = new Stock();

            s.StockID = (int)reader[0];
            s.Itemname = (string)reader[1];
            s.Quantity = (Decimal)reader[2];
            s.Threshold = (int)reader[3];
            s.Price = (Decimal)reader[4];
            s.StockType = (string)reader[5];


            return s;
          

        }

        public static List<Stock> getAllStock()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Stock> s = new List<Stock>();
                conn.Open();
                string query = string.Format("SELECT * FROM STOCK");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getStockFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }
        public static Stock getStockByID(string sID)
        {
            using (SqlConnection conn = new SqlConnection(cString))  {
                Stock s = new Stock();
                conn.Open();
                string query = string.Format("SELECT * FROM STOCK WHERE stockID = {0}", sID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Stock((int)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[3], (decimal)reader[4], (string)reader[5]);
                }

                conn.Close();
                return s;

            }
        }
        public static DataTable getallstockIDasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY stockID ASC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstockIDdesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY stockID DESC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstocknameasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY itemname ASC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }
        //public static DataTable<Stock> getStockNameAndPrice()
        //{
        //    using (SqlConnection conn = new SqlConnection(cString))
        //    {
        //        DataTable dt = new DataTable();
        //        conn.Open();
        //        string query = string.Format("SELECT STOCK.itemname, STOCK.price FROM STOCK ORDER BY STOCK.price ASC");
        //        SqlCommand sqlCommand = new SqlCommand(query, conn);
        //        SqlDataReader reader = sqlCommand.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            s.Add(getStockFromReader(reader));
        //        }

        //        conn.Close();
        //        return s;
        //    }
        //}

        public static DataTable getallstocknamedesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY itemname DESC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstockquantityasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY quantity ASC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstockquantitydesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY quantity DESC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstockpriceasc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY price ASC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }

        public static DataTable getallstockpricedesc()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT STOCK.stockID, COUNT(reorderID) AS 'total orders placed' , STOCK.itemname, STOCK.quantity, STOCK.threshold, STOCK.price, STOCK.stockType FROM STOCK LEFT JOIN REORDER ON REORDER.stockID = STOCK.stockID GROUP BY STOCK.stockID, STOCK.itemname, STOCK.quantity,  STOCK.threshold, STOCK.price, STOCK.stockType ORDER BY price DESC");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;
            }
        }



        public static int upDateStock(Stock s)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET itemname = '{1}', quantity = '{2}', threshold = '{3}', price = '{4}', stockType = '{5}' WHERE stockID = {0}",
                    s.StockID, s.Itemname, s.Quantity, s.Threshold, s.Price, s.StockType);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int upDateStockQuantity(int stockID, decimal quantity)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity += {1} WHERE stockID = {0}; ", stockID, quantity);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int increaseStockQuantity(string stockID )
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity = quantity + 1 WHERE stockID = {0}; ", stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int increaseStockQuantityLiquids(string stockID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity = quantity + 0.1 WHERE stockID = {0}; ", stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int decreaseStockQuantity(string stockID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity = quantity - 1 WHERE stockID = {0}; ", stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int decreaseStockQuantityLiquids(string stockID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format("UPDATE STOCK SET quantity = quantity - 0.1 WHERE stockID = {0}; ", stockID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static int upDateToNoDiscrepancies(int reorderID)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                conn.Open();
                string query =
                    string.Format(" UPDATE REORDER SET discrepancies = 'N/A' WHERE reorderID = {0}", reorderID);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

       
        public static bool checkStockIDExists(int stockID)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(cString))
            {
                string query = "SELECT COUNT(*) FROM Stock WHERE StockID = @stockID";


                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@stockID", stockID);

                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }

                return exists;
            }
        }

        public static DataTable getAllStockNames()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT itemname FROM STOCK ORDER BY itemname ASC ");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable StockBelowThresold()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT * FROM STOCK WHERE quantity < threshold");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }
    }
}
