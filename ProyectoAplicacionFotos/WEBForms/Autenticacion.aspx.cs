using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ProyectoAplicacionFotos.WEBForms
{
    public partial class Autenticacion : System.Web.UI.Page
       
    {
        CL_Autenticacion usuario = new CL_Autenticacion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.TXTUsuario .Text.Length >0 && this.TXTEmail .Text.Length >0 && this.TXTPassword .Text.Length >0)
            {
                MessageBox.Show("Registro Exitoso");
                Response.Redirect("RegistroFotos.aspx");

            }
            else
            {
                MessageBox.Show("No puede guardar espacios en blancos");

            }



            this.TXTEmail.Text = " ";
            this.TXTPassword.Text  = " ";
            this.TXTUsuario.Text = " ";
        }
        

        
    }
}