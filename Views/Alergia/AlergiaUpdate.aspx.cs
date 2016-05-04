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
    public partial class AlergiaUpdate : System.Web.UI.Page
    {
        QueryAlergia querydt = new QueryAlergia();
        QueryAlergia queryUpdateAlergia = new QueryAlergia();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int idAlergia = Convert.ToInt32(Request.QueryString["id"]);
                DataTable dtAlergia = new DataTable();
                dtAlergia = querydt.LlenadoUpdateCampos(idAlergia, dtAlergia);

                txtNombreAlergia.Text = Convert.ToString(dtAlergia.Rows[0]["Nombre"]);
                txtDescripcionAlergia.Text = Convert.ToString(dtAlergia.Rows[0]["Descripcion"]);
                txtIdAlergia.Text = Convert.ToString(dtAlergia.Rows[0]["IdEstado"]);
                txtIdAlergia.Visible = false;
            }
        }

        protected void btnEditAlergia_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                String NombreAlergia = txtNombreAlergia.Text;
                String DescripcionAlergia = txtDescripcionAlergia.Text;
                Int32 idAlergia = Convert.ToInt32(txtIdAlergia.Text);

                bool resultado = queryUpdateAlergia.UpdateAlergia(idAlergia, NombreAlergia, DescripcionAlergia);

                if (resultado == true)
                {
                    mensaje = "El estado actualizado de manera exitosa.";
                }
                else
                {
                    mensaje = "Error al actualizar el estado ";
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