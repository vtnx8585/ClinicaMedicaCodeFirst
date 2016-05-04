using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ClinicaMedicaCodeFirst.DataAccess.DataTableStructure
{
    public class DataTableStructureMedicamento
    {
        public DataTable dtReadMedicamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdMedicamento", typeof(Int32));
                dt.Columns.Add("Nombre", typeof(String));
                dt.Columns.Add("Descripcion", typeof(String));
                dt.Columns.Add("Presentacion", typeof(String));
                dt.Columns.Add("Medida", typeof(Int32));
                dt.Columns.Add("IdUnidadMedida", typeof(Int32));
                dt.Columns.Add("AlertaMinimo", typeof(Int32));
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