using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBClient
{
    static class SqlConnections
    {
        public static string sql;
        public static SqlConnection connection = new SqlConnection();
        public static DataSet ds;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static BindingSource bs;
        public static string user = "Георгий Носачев";
        public static string rights = "admin";
        public static StringBuilder journal = new StringBuilder();

        public static string GetConnectionString()
        {
            string ConnectionString = @"Data Source=ACERBOOK;Initial Catalog=Взаиморасчеты;Integrated Security=True;";
            return ConnectionString;
        }

        public static string MyApp()
        {
            string AppTitle = "СУБД - ПРОМЭКЗ";
            return AppTitle;
        }

        public static void ConnectionState()
        {
            string msg = "Connection state: " + "The connection is ";
            string title = SqlConnections.MyApp();
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            MessageBox.Show(msg + connection.State.ToString(), title, btn, ico);
        }

        public static void OpenConnection()
        {
            connection.Close();
            try
            {
                connection.ConnectionString = SqlConnections.GetConnectionString();
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Attempt to establish the connection failed" + Environment.NewLine + e);
            }
            finally
            {
                //ConnectionState();
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
            connection.Dispose();
            ConnectionState();
        }


    }
}
