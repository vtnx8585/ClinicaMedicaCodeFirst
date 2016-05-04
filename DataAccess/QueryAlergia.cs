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
    public class QueryAlergia
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Alergias
        public DataTable LlenadoAlergiaGrid(DataTable dtAlergia)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureAlergia dtStructureTableAlergia = new DataTableStructureAlergia();
                dtAlergia = dtStructureTableAlergia.dtReadAlergias();
                String qry = " Select id_alergia as IdAlergia, ale_nombre as Nombre, ale_descripcion as Descripcion, ale_fecha_creacion as FechaCreacion,";
                qry += " id_estado as IdEstado from ClinicaMedica.dbo.tc_alergia Where id_estado = 1";
                dtAlergia = CRUD.ReadForDatatable(qry, connection, dtAlergia);
                return dtAlergia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Guardar Alergia
        public bool GuardarAlergia(String NombreAlergia, String DescripcionAlergia, DateTime FechaCreacionAlergia)
        {
            try
            {                
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.tc_alergia(ale_nombre,ale_descripcion,ale_fecha_creacion,id_estado)";
                qry += " values('" + NombreAlergia + "','" + DescripcionAlergia + "','" + FechaCreacionAlergia.ToString("MM-dd-yyyy") + "', '1')";
                CRUD.Create(qry, connection);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete Alergia
        public bool DeleteAlergia(Int32 idAlergia)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_alergia Set id_estado = 2 Where id_alergia = " + idAlergia;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update Alergia
        public bool UpdateAlergia(int idAlergia, String NombreAlergia, String DescripcionAlergia)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_alergia Set ale_nombre = '" + NombreAlergia + "', ale_descripcion = '" + DescripcionAlergia + "' Where id_alergia = " + idAlergia;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Datos Update Textbox
        public DataTable LlenadoUpdateCampos(int idAlergia, DataTable dtAlergia)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureAlergia dtStructureTableAlergia = new DataTableStructureAlergia();
                dtAlergia = dtStructureTableAlergia.dtReadAlergias();
                String qry = " Select id_alergia as IdAlergia, ale_nombre as Nombre, ale_descripcion as Descripcion,";
                qry += " ale_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.tc_alergia";
                qry += " Where id_alergia = " + idAlergia;
                dtAlergia = CRUD.ReadForDatatable(qry, connection, dtAlergia);
                return dtAlergia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}