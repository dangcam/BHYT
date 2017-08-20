using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT
{
    public class ConnectionDB
    {
        public static SqlConnection getNetwork ()
        {
            SqlConnection conn = new SqlConnection ();
            conn.ConnectionString = "Data Source=" + AppConfig.ServerName + ";Network Library=DBMSSOCN;"
             + "Initial Catalog=" + AppConfig.Database + ";User ID=" + AppConfig.Username + ";Password=" + AppConfig.Password + ";";
            return conn;

            //SqlConnection conn = new SqlConnection ();
            //conn.ConnectionString = "Data Source=" + AppConfig.ServerName + ";"
            //+ "Initial Catalog=" + AppConfig.Database + ";"
            //+ "Integrated Security=True" 
            //+";User ID=" + AppConfig.Username + ";Password=" + AppConfig.Password + ";";
            //return conn;

        }
    }
}
