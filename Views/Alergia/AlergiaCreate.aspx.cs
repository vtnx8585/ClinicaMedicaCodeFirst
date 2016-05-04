using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaMedicaCodeFirst.DataAccess;

namespace ClinicaMedicaCodeFirst.Views.Alergia
{
    public partial class AlergiaCreate : System.Web.UI.Page
    {
        QueryAlergia qryGuardarAlergia = new QueryAlergia();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarAlergia_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                String NombreAlergia = txtNombreAlergia.Text;
                String DescripcionAlergia = txtDescripcionAlergia.Text;
                DateTime FechaCreacionAlergia = DateTime.Today;                
                
                bool resultado = qryGuardarAlergia.GuardarAlergia(NombreAlergia, DescripcionAlergia, FechaCreacionAlergia);

                if (resultado == true)
                {
                    mensaje = "La alergia de nombre " + NombreAlergia + " se a guardado de manera exitosa.";
                }
                else
                {
                    mensaje = "Error al guardar la alergia " + NombreAlergia;
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