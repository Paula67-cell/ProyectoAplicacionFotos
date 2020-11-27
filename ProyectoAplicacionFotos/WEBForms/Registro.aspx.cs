using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ProyectoAplicacionFotos
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Autenticacion.aspx");
        }

        protected void BTNRegistrar_Click(object sender, EventArgs e)
        {
            CL_Autenticacion usuario = new CL_Autenticacion();
            if (usuario.Usuario(this.TxtUsuario.Text, this.TXTContraseña.Text, this.TxtCorreo.Text))
            {
              
                MessageBox.Show("Pudo accesar");
                Response.Redirect("Autenticacion.aspx");

            }
            else
            {
                MessageBox.Show("Error al registro");
            }
        }
    }
}