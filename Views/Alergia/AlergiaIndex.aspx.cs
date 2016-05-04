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
    public partial class AlergiaIndex : System.Web.UI.Page
    {
        QueryAlergia querydt = new QueryAlergia();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String mensaje = Request.QueryString["mensaje"];
                lblmensaje.Text = mensaje;
                if (!this.IsPostBack)
                {
                    DataTable dtAlergia = new DataTable();
                    dtAlergia = querydt.LlenadoAlergiaGrid(dtAlergia);

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

        protected void btnEditAlergia_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                String idAlergia = Convert.ToString(gvr.Cells[0].Text);
                Response.Redirect("AlergiaUpdate.aspx?id=" + idAlergia, false);
                Context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}