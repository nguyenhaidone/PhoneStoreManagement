/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PhoneManagement
{
    class ConnectDB
    {
        public static SqlConnection connect;
        public static SqlCommand cmd;
        public static SqlDataAdapter data;

        public SqlConnection OpenDB()
        {
            connect = new SqlConnection(@"Data Source=127.0.0.1;Initial Catalog=PhoneManagementDB;User ID=sa;Password=Sa@12345678");
            return connect;
        }

        public static void OpenConnection()
        {
            string sql = @"Data Source=127.0.0.1;Initial Catalog=PhoneManagementDB;User ID=sa;Password=Sa@12345678";
            try
            {
                connect = new SqlConnection(sql);
                connect.Open();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Convert.ToString(Ex));
            }
        }

        public static void DisConnection()
        {
            connect.Close();
            connect.Dispose();
            connect = null;
        }

        public static DataTable getDataTable(string sql)
        {
            cmd = new SqlCommand(sql, connect);
            data = new SqlDataAdapter();
            data.SelectCommand = cmd;

            DataTable table = new DataTable();
            data.Fill(table);
            data.Dispose();
            cmd.Dispose();
            return table;
        }

        

        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
        }
    }
}
*/