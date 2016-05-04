using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClinicaMedicaCodeFirst.DataAccess;

namespace ClinicaMedicaCodeFirst.Views.Estado
{
    public partial class EstadoIndex : System.Web.UI.Page
    {        
        QueryEstado querydt = new QueryEstado();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String mensaje = Request.QueryString["mensaje"];
                lblmensaje.Text = mensaje;
                if (!this.IsPostBack)
                {                    
                    DataTable dtEstado = new DataTable();
                    dtEstado = querydt.LlenadoEstadoGrid(dtEstado);

                    grdEstados.DataSource = dtEstado;
                    grdEstados.DataBind();
                    grdEstados.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEditEstado_Click(object sender, EventArgs e)
        {
            try
            {                
                LinkButton btn = (LinkButton)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                String idEstado = Convert.ToString(gvr.Cells[0].Text);
                Response.Redirect("EstadoUpdate.aspx?id=" + idEstado,false);
                Context.ApplicationInstance.CompleteRequest();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}