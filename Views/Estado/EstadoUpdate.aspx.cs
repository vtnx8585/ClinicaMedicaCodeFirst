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
    public partial class EstadoUpdate : System.Web.UI.Page
    {
        QueryEstado querydt = new QueryEstado();
        QueryEstado queryUpdateEstado = new QueryEstado();
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!this.IsPostBack)
            {
                int idEstado = Convert.ToInt32(Request.QueryString["id"]);      
                DataTable dtEstado = new DataTable();
                dtEstado = querydt.LlenadoUpdateCampos(idEstado,dtEstado);

                txtNombreEstado.Text = Convert.ToString(dtEstado.Rows[0]["Nombre"]);
                txtDescripcionEstado.Text = Convert.ToString(dtEstado.Rows[0]["Descripcion"]);
                txtIdEstado.Text = Convert.ToString(dtEstado.Rows[0]["IdEstado"]);
                txtIdEstado.Visible = false;
                
                //grdEstados.DataSource = dtEstado;
                //grdEstados.DataBind();
                //grdEstados.Columns[0].Visible = false;
              
            }
            
        }

        protected void btnEditEstado_Click(object sender, EventArgs e)
        {
            try
            {
                String mensaje = "";
                String NombreEstado = txtNombreEstado.Text;
                String DescripcionEstado = txtDescripcionEstado.Text;
                int idEstado = Convert.ToInt32(txtIdEstado.Text);

                bool resultado = queryUpdateEstado.UpdateEstado(idEstado,NombreEstado,DescripcionEstado);

                if (resultado == true)
                {
                    mensaje = "El estado actualizado de manera exitosa.";                    
                }
                else
                {
                    mensaje = "Error al actualizar el estado ";                     
                }

                Response.Redirect("EstadoIndex.aspx?mensaje=" + mensaje,false);
                Context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}