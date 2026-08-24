using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Org.BouncyCastle.Ocsp;

namespace Movers_v2
{
    class ReorderAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Reorder getOrderFromReader(SqlDataReader reader)
        {
            Reorder s = new Reorder();

            s.ReorderID = (int)reader[0];
            s.StockID = (int)reader[1];
            s.Order_Date = (DateTime)reader[2];
            s.Quantityordered = (decimal)reader[3];
            s.Status = (string)reader[4];
            s.Discrepancies = (string)reader[5];
            s.TotalPrice = (decimal)reader[6];
           


            return s;

        }

        public static DataTable getTodaysOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE order_date = CONVERT(DATE,GETDATE()) ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getWeeksOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE order_date >= DATEADD(DAY, -7, GETDATE()) ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getMonthsOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE  order_date >= DATEADD(MONTH, -1, GETDATE()) ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getYearsOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE order_date >= DATEADD(YEAR, -1, GETDATE()) ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getUndeliveredOrders ()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE re.status = 'Not delivered' ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getOrdersWithDiscrepancies()    
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, CONVERT(DATE,re.order_date) AS 'order date', re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE re.discrepancies != 'N/A' ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        public static DataTable getDeliveredOrders()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable d = new DataTable();
                conn.Open();
                string query = string.Format("SELECT re.reorderID, re.stockID, st.itemname, st.Price, re.order_date, re.quantity_ordered,  re.status, re.discrepancies, re.totalPrice AS 'total price (£)'  FROM REORDER AS re " +
                    "INNER JOIN STOCK st ON st.stockID = re.stockID WHERE re.status = 'Delivered' ORDER BY order_date ASC;");
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

        
        public static int addOrder(Reorder r)
        {
            var sqlFormattedDate = r.Order_Date.ToString("yyyy/MM/dd");

            using (SqlConnection myConn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myConn.Open();

                string query = string.Format("INSERT INTO REORDER VALUES ({0},'{1}',{2} ,'{3}', '{4}', {5})", r.StockID, sqlFormattedDate, r.Quantityordered, r.Status, r.Discrepancies, r.TotalPrice);


                SqlCommand command = new SqlCommand(query, myConn);
                rowsAffected = command.ExecuteNonQuery();

                myConn.Close();
                return rowsAffected;
            }
        }

        public static int updateOrder(int reorderID, string status, string discrepancies, string date)
        {

            using (SqlConnection conn = new SqlConnection(cString))
            {
                int rowsAffected = 0;
               
                conn.Open();
                string query =
                    string.Format("UPDATE REORDER SET status = '{1}', discrepancies = '{2}' WHERE (reorderID = {0} AND order_date = '{3}');", reorderID, status, discrepancies, date);
                SqlCommand myCommand = new SqlCommand(query, conn);
                rowsAffected = myCommand.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
        }

        public static DataTable undeliveredStock()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                DataTable undeliveredStock = new DataTable();
                conn.Open();

                string query = @"SELECT re.reorderID, re.status, re.order_date, st.itemname FROM REORDER AS re INNER JOIN STOCK st ON st.stockID = re.stockID  WHERE re.status = 'Not delivered'";


                SqlCommand command = new SqlCommand(query, conn);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(undeliveredStock);

                return undeliveredStock;
            }
        }

        public static Reorder getOrderByID(int oID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Reorder s = new Reorder();
                conn.Open();
                string query = string.Format("SELECT * FROM REORDER WHERE reorderID = {0}", oID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = new Reorder((int)reader[0], (int)reader[1], (DateTime)reader[2], Convert.ToDecimal(reader[3]), (string)reader[4], (string)reader[5], (decimal)reader[6]);
                }

                conn.Close();
                return s;

            }
        }

        public static DataTable orderReport(int index) // input index to determine whether a daily, weekly, monthly or yearly report is produced.
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                
                DataTable d = new DataTable();
                string query = "";
                conn.Open();
                
                if(index == 0)
                {
                     query = string.Format("SELECT re.reorderID, st.itemname, re.quantity_ordered, re.discrepancies, re.status, re.order_date, re.totalPrice FROM REORDER AS re INNER JOIN STOCK AS st ON st.stockID = re.stockID WHERE re.order_date = CONVERT(DATE, GETDATE());" );
                }
                if (index == 1)
                {
                    query = string.Format("SELECT re.reorderID, st.itemname, re.quantity_ordered, re.discrepancies, re.status, re.order_date, re.totalPrice FROM REORDER AS re INNER JOIN STOCK AS st ON st.stockID = re.stockID WHERE re.order_date >= DATEADD(DAY, -7, GETDATE());");
                }
                if (index == 2)
                {
                    query = string.Format("SELECT re.reorderID, st.itemname, re.quantity_ordered, re.discrepancies, re.status, re.order_date, re.totalPrice FROM REORDER AS re INNER JOIN STOCK AS st ON st.stockID = re.stockID WHERE re.order_date >= DATEADD(MONTH, -1, GETDATE());");
                }
                if (index == 3)
                {
                    query = string.Format("SELECT re.reorderID, st.itemname, re.quantity_ordered, re.discrepancies, re.status, re.order_date, re.totalPrice FROM REORDER AS re INNER JOIN STOCK AS st ON st.stockID = re.stockID WHERE re.order_date >= DATEADD(YEAR, -1, GETDATE());");
                }

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(d);



                return d;

            }
        }

    }
}
