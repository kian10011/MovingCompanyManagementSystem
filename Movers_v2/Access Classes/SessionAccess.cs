using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class SessionAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["Maintenance_Databaseconnection"].ConnectionString;

        public static Session getSessionFromReader(SqlDataReader reader)
        {
            Session s = new Session();

            s.SessionID = (int)reader[0];
            s.SessionName = (string)reader[1];
            s.Capacity = (int)reader[2];
            s.Duration = (TimeSpan)reader[3];

            return s;

        }

        public static List<Session> getAllSessions()
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                List<Session> s = new List<Session>();
                conn.Open();
                string query = string.Format("SELECT * FROM SESSION");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s.Add(getSessionFromReader(reader));
                }

                conn.Close();
                return s;
            }
        }

        public static Session getSessionByID(int mID)
        {
            using (SqlConnection conn = new SqlConnection(cString))
            {
                Session m = new Session();
                conn.Open();
                string query = string.Format("SELECT * FROM SESSION WHERE sessionID = {0}", mID);
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    m = new Session((int)reader[0], (string)reader[1], (int)reader[2], (TimeSpan)reader[3]);
                }

                conn.Close();
                return m;

            }
        }
    }
}
