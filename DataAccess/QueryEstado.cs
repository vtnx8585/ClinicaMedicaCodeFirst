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
    public class QueryEstado
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Estados
        public DataTable LlenadoEstadoGrid(DataTable dtEstado)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEstado dtStructureTableEstado = new DataTableStructureEstado();
                dtEstado = dtStructureTableEstado.dtReadEstados();
                String qry = "Select id_estado as IdEstado, est_nombre as Nombre, est_descripcion as Descripcion, est_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.estado";                
                dtEstado = CRUD.ReadForDatatable(qry, connection, dtEstado);
                return dtEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion 

        #region Guardar Estado
        public bool GuardarEstado(String NombreEstado, String DescripcionEstado, DateTime FechaCreacionEstado) 
        {
            try
            {
                //String.Format("yyyyMMdd", FechaCreacionEstado) 
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.estado(est_nombre,est_descripcion,est_fecha_creacion)";
                qry += " values('" + NombreEstado + "','" + DescripcionEstado + "','" + FechaCreacionEstado.ToString("MM-dd-yyyy") + "')";
                CRUD.Create(qry, connection);
                
                return true;
            }
            catch(Exception ex) {
                throw ex;
            }
        }
        #endregion

        #region Delete Estado
        public bool DeleteEstado(int idEstado) {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Delete from ClinicaMedica.dbo.estado Where id_estado = " + idEstado;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        #endregion

        #region Update Estado
        public bool UpdateEstado(int idEstado,String NombreEstado,String DescripcionEstado)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.estado Set est_nombre = '" + NombreEstado + "', est_descripcion = '" + DescripcionEstado + "' Where id_estado = " + idEstado;
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
        public DataTable LlenadoUpdateCampos(int idEstado,DataTable dtEstado)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEstado dtStructureTableEstado = new DataTableStructureEstado();
                dtEstado = dtStructureTableEstado.dtReadEstados();
                String qry = " Select id_estado as IdEstado, est_nombre as Nombre, est_descripcion as Descripcion,";
                qry += " est_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.estado";
                qry += " Where id_estado = " + idEstado;
                dtEstado = CRUD.ReadForDatatable(qry, connection, dtEstado);
                return dtEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}