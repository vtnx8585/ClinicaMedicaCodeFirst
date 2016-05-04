using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ClinicaMedicaCodeFirst.Interfaces;

namespace ClinicaMedicaCodeFirst.DataAccess.Connection
{
    public class SqlConn : IDataBaseConn
    {
        public void ConnectionClose(String connection)
        {
            string cs = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            conn.Close();
        }

        public SqlConnection ConnectionOpen(string connection)
        {
            string cs = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            return conn;
        }
    }
}