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
    public partial class EstadoDelete : System.Web.UI.Page
    {
        QueryEstado querydt = new QueryEstado();
        QueryEstado queryDeleteEstado = new QueryEstado();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
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

        protected void btnDeleteEstado_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;                
                int idEstado = Convert.ToInt32(gvr.Cells[0].Text);
                String NombreEstado = gvr.Cells[1].Text;

                bool resultado = queryDeleteEstado.DeleteEstado(idEstado);

                if (resultado == true)
                {
                    mensaje = "El estado de nombre " + NombreEstado + " se a guardado de manera exitosa.";
                }
                else
                {
                    mensaje = "Error al eliminar el estado " + NombreEstado;                    
                }

                Response.Redirect("EstadoIndex.aspx?mensaje=" + mensaje, false);
                Context.ApplicationInstance.CompleteRequest();  
            }
            catch (Exception ex){
                throw ex;
            }
        }
    }
}