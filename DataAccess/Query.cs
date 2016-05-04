using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClinicaMedicaCodeFirst.DataBase;

namespace ClinicaMedicaCodeFirst.DataAccess
{
    public class Query
    {
        public Object Estado() {
            try
            {
                using (var context = new ClinicaMedicaDataLayer())
                {
                    //context.Database.CreateIfNotExists();
                    //context.Database.Create();                
                    Object est = context.Database.SqlQuery<string>("Select id_estado as id, est_nombre as name from Estado").ToList();
                    return est;
                }                
            }
            catch (Exception ex) {
                throw ex;                   
            }               
        }
    }
}