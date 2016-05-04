using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClinicaMedicaCodeFirst.Interfaces;
using System.Data;

namespace ClinicaMedicaCodeFirst.Abstracts
{
    public abstract class DataBaseOperation
    {
        public readonly IDataBaseConn databaseconn;   
     
        public DataBaseOperation(IDataBaseConn databaseconn) {
            this.databaseconn = databaseconn;            
        }

        abstract public bool Create(String qry,String conn);
        abstract public DataTable ReadForDatatable(String qry, String conn, DataTable dt);
        abstract public int ReadForScalar(String qry, String conn, int count);
        abstract public bool Update(String qry, String conn);
        abstract public bool Delete(String qry, String conn);
    }
}