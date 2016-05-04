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
    public class QueryLaboratorio
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Laboratorio
        public DataTable LlenadoLaboratorioGrid(DataTable dtLaboratorio)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureLaboratorio dtStructureTableLaboratorio = new DataTableStructureLaboratorio();
                dtLaboratorio = dtStructureTableLaboratorio.dtReadLaboratorios();
                String qry = " Select id_laboratorio as IdLaboratorio, lab_nombre as Nombre, lab_fecha_creacion as FechaCreacion,";
                qry += " id_estado as IdEstado from ClinicaMedica.dbo.tc_laboratorio Where id_estado = 1";
                dtLaboratorio = CRUD.ReadForDatatable(qry, connection, dtLaboratorio);
                return dtLaboratorio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Guardar Laboratorio
        public bool GuardarLaboratorio(String NombreLaboratorio, String DescripcionLaboratorio, DateTime FechaCreacionLaboratorio)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.tc_laboratorio(lab_nombre,lab_descripcion,lab_fecha_creacion,id_estado)";
                qry += " values('" + NombreLaboratorio + "','" + DescripcionLaboratorio + "','" + FechaCreacionLaboratorio.ToString("MM-dd-yyyy") + "', '1')";
                CRUD.Create(qry, connection);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete Laboratorio
        public bool DeleteLaboratorio(Int32 idLaboratorio)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_laboratorio Set id_estado = 2 Where id_laboratorio = " + idLaboratorio;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update Laboratorio
        public bool UpdateLaboratorio(int idLaboratorio, String NombreLaboratorio, String DescripcionLaboratorio)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_laboratorio Set lab_nombre = '" + NombreLaboratorio + "', lab_descripcion = '" + DescripcionLaboratorio + "' Where id_laboratorio = " + idLaboratorio;
                CRUD.Update(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Datos Update Textbox
        public DataTable LlenadoUpdateCampos(int idLaboratorio, DataTable dtLaboratorio)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEnfermedad dtStructureTableEnfermedad = new DataTableStructureEnfermedad();
                dtLaboratorio = dtStructureTableEnfermedad.dtReadEnfermedades();
                String qry = " Select id_laboratorio as IdLaboratorio, lab_nombre as Nombre, lab_descripcion as Descripcion,";
                qry += " lab_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.tc_laboratorio";
                qry += " Where id_laboratorio = " + idLaboratorio;
                dtLaboratorio = CRUD.ReadForDatatable(qry, connection, dtLaboratorio);
                return dtLaboratorio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}