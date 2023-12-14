using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdditionalFunc_Lib
{
    public class SQLConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-F44IGH7\SQLEXPRESS;Initial Catalog=Quadro_Auth;Integrated Security=True");

        public void DBopen()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void DBclose()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection DBget()
        {
            return sqlConnection;
        }
    }
}
