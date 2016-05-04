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


namespace ClinicaMedicaCodeFirst.DataAccess.DataTableStructure
{
    public class QueryGenero
    {
        IDataBaseConn sqlconn = new SqlConn();
        String connection = "ClinicaMedicaDataLayer";

        #region Llenado de Grid de Genero
        public DataTable LlenadoGeneroGrid(DataTable dtGenero)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureGenero dtStructureTableGenero = new DataTableStructureGenero();
                dtGenero = dtStructureTableGenero.dtReadGeneros();
                String qry = " Select id_genero as IdGenero, gen_nombre as Nombre, gen_fecha_creacion as FechaCreacion,";
                qry += " id_estado as IdEstado from ClinicaMedica.dbo.tc_genero Where id_estado = 1";
                dtGenero = CRUD.ReadForDatatable(qry, connection, dtGenero);
                return dtGenero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Guardar Genero
        public bool GuardarGenero(String NombreGenero, String DescripcionGenero, DateTime FechaCreacionGenero)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = " Insert into ClinicaMedica.dbo.tc_genero(gen_nombre,gen_descripcion,gen_fecha_creacion,id_estado)";
                qry += " values('" + NombreGenero + "','" + DescripcionGenero + "','" + FechaCreacionGenero.ToString("MM-dd-yyyy") + "', '1')";
                CRUD.Create(qry, connection);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete Genero
        public bool DeleteGenero(Int32 idGenero)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_genero Set id_estado = 2 Where id_genero = " + idGenero;
                CRUD.Delete(qry, connection);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update Genero
        public bool UpdateGenero(int idGenero, String NombreGenero, String DescripcionGenero)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                String qry = "Update ClinicaMedica.dbo.tc_genero Set gen_nombre = '" + NombreGenero + "', gen_descripcion = '" + DescripcionGenero + "' Where id_genero = " + idGenero;
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
        public DataTable LlenadoUpdateCampos(int idGenero, DataTable dtGenero)
        {
            try
            {
                DataBaseOperation CRUD = new SqlCrud(sqlconn);
                DataTableStructureEnfermedad dtStructureTableEnfermedad = new DataTableStructureEnfermedad();
                dtGenero = dtStructureTableEnfermedad.dtReadEnfermedades();
                String qry = " Select id_genero as IdGenero, gen_nombre as Nombre, gen_descripcion as Descripcion,";
                qry += " gen_fecha_creacion as FechaCreacion from ClinicaMedica.dbo.tc_genero";
                qry += " Where id_genero = " + idGenero;
                dtGenero = CRUD.ReadForDatatable(qry, connection, dtGenero);
                return dtGenero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}