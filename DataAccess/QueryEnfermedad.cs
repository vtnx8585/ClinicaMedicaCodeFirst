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
    public class QueryEnfermedad
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Enfermedades
        public DataTable LlenadoEnfermedadGrid(DataTable dtEnfermedad)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEnfermedad dtStructureTableEnfermedad = new DataTableStructureEnfermedad();
                dtEnfermedad = dtStructureTableEnfermedad.dtReadEnfermedades();
                String qry = " Select id_alergia as IdAlergia, ale_nombre as Nombre, ale_descripcion as Descripcion, ale_fecha_creacion as FechaCreacion,";
                qry += " id_estado as IdEstado from ClinicaMedica.dbo.tc_alergia Where id_estado = 1";
                dtEnfermedad = CRUD.ReadForDatatable(qry, connection, dtEnfermedad);
                return dtEnfermedad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Guardar Enfermedad
        public bool GuardarEnfermedad(String NombreEnfermedad, String DescripcionEnfermedad, DateTime FechaCreacionEnfermedad)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.tc_enfermedad(enf_nombre,enf_descripcion,enf_fecha_creacion,id_estado)";
                qry += " values('" + NombreEnfermedad + "','" + DescripcionEnfermedad + "','" + FechaCreacionEnfermedad.ToString("MM-dd-yyyy") + "', '1')";
                CRUD.Create(qry, connection);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete Enfermedad
        public bool DeleteEnfermedad(Int32 idEnfermedad)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_enfermedad Set id_estado = 2 Where id_enfermedad = " + idEnfermedad;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update Enfermedad
        public bool UpdateEnfermedad(int idEnfermedad, String NombreEnfermedad, String DescripcionEnfermedad)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_enfermedad Set enf_nombre = '" + NombreEnfermedad + "', enf_descripcion = '" + DescripcionEnfermedad + "' Where id_enfermedad = " + idEnfermedad;
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
        public DataTable LlenadoUpdateCampos(int idEnfermedad, DataTable dtEnfermedad)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEnfermedad dtStructureTableEnfermedad = new DataTableStructureEnfermedad();
                dtEnfermedad = dtStructureTableEnfermedad.dtReadEnfermedades();
                String qry = " Select id_enfermedad as IdEnfermedad, enf_nombre as Nombre, enf_descripcion as Descripcion,";
                qry += " enf_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.tc_enfermedad";
                qry += " Where id_enfermedad = " + idEnfermedad;
                dtEnfermedad = CRUD.ReadForDatatable(qry, connection, dtEnfermedad);
                return dtEnfermedad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}