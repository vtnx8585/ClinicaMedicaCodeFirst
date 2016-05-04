using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClinicaMedicaCodeFirst.DataAccess;

namespace ClinicaMedicaCodeFirst.Views.Alergia
{
    public partial class AlergiaDelete : System.Web.UI.Page
    {
        QueryEstado querydt = new QueryEstado();
        QueryAlergia queryDeleteAlergia = new QueryAlergia();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsPostBack)
                {
                    DataTable dtAlergia = new DataTable();
                    dtAlergia = querydt.LlenadoEstadoGrid(dtAlergia);

                    grdAlergias.DataSource = dtAlergia;
                    grdAlergias.DataBind();
                    grdAlergias.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnDeleteAlergia_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                Int32 idAlergia = Convert.ToInt32(gvr.Cells[0].Text);
                String NombreAlergia = gvr.Cells[1].Text;      

                bool resultado = queryDeleteAlergia.DeleteAlergia(idAlergia);

                if (resultado == true)
                {
                    mensaje = "La alergia de nombre " + NombreAlergia + " se a guardado de manera exitosa.";
                }
                else
                {
                    mensaje = "Error al eliminar la alergia " + NombreAlergia;
                }

                Response.Redirect("AlergiaIndex.aspx?mensaje=" + mensaje, false);
                Context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}