//using ProyectoAplicacionFotos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ProyectoAplicacionFotos.WEBForms
{
   
    public partial class Etiquetas : System.Web.UI.Page
    {
        Clase_Etiqueta Eti = new Clase_Etiqueta();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNSugerencias_Click(object sender, EventArgs e)
        {
            this.LabelEtiquetas .Visible = true;
            this.Image1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
            
        {
            if (this.TxtNombreEti.Text == "Arbol" | this.TxtNombreEti.Text == "Paisajes" | this.TxtNombreEti.Text == "Flores" | this.TxtNombreEti.Text == "Casas" | this.TxtNombreEti.Text == "Objetos" | this.TxtNombreEti.Text == "animales" | this.TxtNombreEti.Text == "personas")
            {

                String cadena = "Sistema";
                this.TxtUsuarioSistema.Text = cadena.ToString();



            }
            else
            {

                String cadena = "Usuario";
                this.TxtUsuarioSistema.Text = cadena.ToString();


            }
            if (this.TXTID .Text .Length > 0 && this.TxtCantidad .Text .Length > 0 && this.TxtNombreEti .Text .Length > 0 && this.TxtUsuarioSistema.Text .Length >0)
            {
                if (Eti.Agregar_Etiquetas(Convert.ToInt32(TXTID.Text), TxtNombreEti.Text, TxtCantidad.Text, TxtUsuarioSistema.Text))
                {
                    
                    MessageBox.Show("Registro Agregado con Exito", "Agregado");

                }
            } else
            {
                MessageBox.Show("No puede guardar espacios en blancos");

            }

         



            this.TXTID.Text = "";
            this.TxtCantidad.Text = " ";
          
            this.TxtNombreEti.Text = "";
            //this.TxtUsuarioSistema.Text = "";


        }

        protected void Mostrar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Eti .Mostrar_Etiquetas ();
            GridView1.DataBind();
        }

        protected void BTNActualizar_Click(object sender, EventArgs e)
        {
            if (this.TXTID.Text.Length > 0 && this.TxtCantidad.Text.Length > 0 && this.TxtNombreEti.Text.Length > 0 && this.TxtUsuarioSistema.Text.Length > 0)
            {
                if (Eti.Modificar_Etiquetas(Convert.ToInt32(TXTID.Text), TxtNombreEti.Text, TxtCantidad.Text, TxtUsuarioSistema.Text))
                {
                    MessageBox.Show("Registro Modificado con Exito");
                }

            }
            else
            {
                MessageBox.Show("No puede guardar espacios en blancos");

            }

           
            this.TXTID.Text = "";
            this.TxtCantidad.Text = " ";
           
            this.TxtNombreEti.Text = "";
            this.TxtUsuarioSistema.Text = "";
          

        }

        protected void BTNElimar_Click(object sender, EventArgs e)
        {
            if (this.TXTID .Text .Length > 0)
            {
                if (Eti.Eliminar_Etiquetas(Convert.ToInt32(TXTID.Text)))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                }
            }else
            {
                MessageBox.Show("Debe de introducir el ID que desea eliminar");
            }
            this.TXTID.Text = "";
        }

        protected void BTNAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroFotos.aspx");
        }
    }
}