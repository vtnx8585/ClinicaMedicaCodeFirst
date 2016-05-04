using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ClinicaMedicaCodeFirst.DataAccess.DataTableStructure
{
    public class DataTableStructureEstado
    {
        public DataTable dtReadEstados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdEstado", typeof(Int32));
                dt.Columns.Add("Nombre", typeof(String));
                dt.Columns.Add("Descripcion", typeof(String));
                dt.Columns.Add("FechaCreacion", typeof(DateTime));

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}