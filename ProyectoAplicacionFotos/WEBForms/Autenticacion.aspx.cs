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

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Usuario();
            this.Usuario2();
            

        }
        public void  Usuario2()
        {
            if (this.TXTUsuario.Text == " dinia22" | this.TXTEmail.Text == "alvaradodinia22@gmail.com" | this.TXTPassword.Text == "12")
            {
                MessageBox.Show("Ingreso Exitoso");
                Response.Redirect("RegistroFotos.aspx");

            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }

        }

        public void Usuario()
        {
            if (usuario.Usuario(this.TXTUsuario.Text, this.TXTPassword.Text, this.TXTEmail.Text))
            {
                if (this.TXTUsuario.Text == "Pauhz96" | this.TXTEmail.Text == "maripa90@hotmail.com" | this.TXTEmail.Text == "pau199609")
                {
                    MessageBox.Show("Ingreso Exitoso");
                    Response.Redirect("RegistroFotos.aspx");

                }
                else
                {
                    MessageBox.Show("El usuario no existe");

                }

            }

        }
    }
}