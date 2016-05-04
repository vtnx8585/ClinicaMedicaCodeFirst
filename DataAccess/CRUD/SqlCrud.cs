using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ClinicaMedicaCodeFirst.Interfaces;
using ClinicaMedicaCodeFirst.Abstracts;
using ClinicaMedicaCodeFirst.DataAccess.Connection;

namespace ClinicaMedicaCodeFirst.DataAccess.CRUD
{
    public class SqlCrud : DataBaseOperation
    {        
        public SqlCrud(IDataBaseConn databaseconn) : base(databaseconn) { }       

        public override bool Create(String qry, String connection)
        {
            SqlConnection conn = databaseconn.ConnectionOpen(connection);
            SqlTransaction sqltr = conn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn, sqltr);
                cmd.ExecuteNonQuery();                
                sqltr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                sqltr.Rollback();                
                throw ex;                
            }
            finally {
                databaseconn.ConnectionClose(connection);
            }
        }

        public override bool Delete(string qry, String connection)
        {
            SqlConnection conn = databaseconn.ConnectionOpen(connection);
            SqlTransaction sqltr = conn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn, sqltr);
                cmd.ExecuteNonQuery();
                sqltr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                sqltr.Rollback();
                throw ex;
            }
            finally
            {
                databaseconn.ConnectionClose(connection);
            }
        }

        public override DataTable ReadForDatatable(string qry, String connection, DataTable dt)
        {
            SqlConnection conn = databaseconn.ConnectionOpen(connection);            
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
                sqladapter.Fill(dt);                
                return dt;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            finally
            {
                databaseconn.ConnectionClose(connection);
            }
        }

        public override int ReadForScalar(string qry, String connection, int count)
        {
            SqlConnection conn = databaseconn.ConnectionOpen(connection);
            SqlTransaction sqltr = conn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                databaseconn.ConnectionClose(connection);
            }
        }

        public override bool Update(string qry, String connection)
        {
            SqlConnection conn = databaseconn.ConnectionOpen(connection);
            SqlTransaction sqltr = conn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn, sqltr);
                cmd.ExecuteNonQuery();
                sqltr.Commit();
                return true;
            }
            catch (Exception ex)
            {
                sqltr.Rollback();
                throw ex;
            }
            finally
            {
                databaseconn.ConnectionClose(connection);
            }
        }
    }
}