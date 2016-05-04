using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ClinicaMedicaCodeFirst.DataAccess.Connection;
using ClinicaMedicaCodeFirst.DataAccess.CRUD;
using ClinicaMedicaCodeFirst.Abstracts;
using ClinicaMedicaCodeFirst.Interfaces;
using ClinicaMedicaCodeFirst.DataAccess.DataTableStructure;

namespace ClinicaMedicaCodeFirst.DataAccess
{
    public class QueryMedicamento
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Medicamento
        public DataTable LlenadoMedicamentoGrid(DataTable dtMedicamento)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureMedicamento dtStructureTableMedicamento = new DataTableStructureMedicamento();
                dtMedicamento = dtStructureTableMedicamento.dtReadMedicamentos();
                String qry = " Select id_medicamento as IdMedicamento, med_nombre as Nombre, med_descripcion as Descripcion, ";
                qry += " med_presentacion as Presentacion, med_medida as Medida, id_unidad_medida as IdUnidadMedida, ";
                qry += " med_alerta_minimo as AlertaMinimo, med_fecha_creacion as FechaCreacion,";
                qry += " id_estado as IdEstado from ClinicaMedica.dbo.tc_medicamento Where id_estado = 1";
                dtMedicamento = CRUD.ReadForDatatable(qry, connection, dtMedicamento);
                return dtMedicamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Guardar Medicamento
        public bool GuardarMedicamento(String NombreMedicamento, String DescripcionMedicamento, DateTime FechaCreacionMedicamento)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.tc_medicamento(med_nombre,med_descripcion,med_presentacion,med_medida,id_unidad_medida, ";
                qry += " med_alerta_minimo, med_fecha_creacion, id_estado)";
                qry += " values('" + NombreMedicamento + "','" + DescripcionMedicamento + "','" + FechaCreacionMedicamento.ToString("MM-dd-yyyy") + "', '1')";
                CRUD.Create(qry, connection);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}