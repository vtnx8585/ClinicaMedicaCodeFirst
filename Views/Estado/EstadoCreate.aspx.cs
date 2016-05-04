using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaMedicaCodeFirst.DataAccess;

namespace ClinicaMedicaCodeFirst.Views.Estado
{
    public partial class EstadoCreate : System.Web.UI.Page
    {
        QueryEstado qryGuardarEstado = new QueryEstado();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

            }            
        }

        protected void btnIngresarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                String NombreEstado = txtNombreEstado.Text;
                String DescripcionEstado = txtDescripcionEstado.Text;
                DateTime FechaCreacionEstado = DateTime.Today;

                bool resultado = qryGuardarEstado.GuardarEstado(NombreEstado, DescripcionEstado, FechaCreacionEstado);

                if (resultado == true)
                {
                    mensaje = "El estado de nombre " + NombreEstado + " se a guardado de manera exitosa.";                    
                }
                else {
                    mensaje = "Error al guardar el estado " + NombreEstado;                    
                }

                Response.Redirect("EstadoIndex.aspx?mensaje=" + mensaje, false);
                Context.ApplicationInstance.CompleteRequest();     
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}