using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ClinicaMedicaCodeFirst.DataAccess.DataTableStructure
{
    public class DataTableStructureGenero
    {
        public DataTable dtReadGeneros()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdGenero", typeof(Int32));
                dt.Columns.Add("Nombre", typeof(String));                
                dt.Columns.Add("FechaCreacion", typeof(DateTime));
                dt.Columns.Add("IdEstado", typeof(Int32));

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}