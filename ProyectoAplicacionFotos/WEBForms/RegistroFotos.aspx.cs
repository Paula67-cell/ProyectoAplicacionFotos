using ProyectoAplicacionFotos.Fotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace ProyectoAplicacionFotos.WEBForms
{
    public partial class RegistroFotos : System.Web.UI.Page
    {
        Class_Fotos cCLS_Fotos = new Class_Fotos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Etiquetas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            if (TxtId.Text .Length > 0 && TxtURL.Text.Length > 0 && TxtNombre.Text.Length >0 && TxtTipo.Text.Length > 0 && TxtTamaño.Text.Length >0 && TxtResolucion.Text.Length >0  && TxtTipoFoto.Text.Length >0)
            {
                if (cCLS_Fotos.Agregar_Fotos(Convert.ToInt32(TxtId.Text), TxtURL.Text, TxtNombre.Text, TxtTipo.Text, Convert.ToInt32(TxtTamaño.Text), TxtResolucion.Text, TxtTipoFoto.Text))
                {
                    MessageBox.Show("Registro Agregado con Exito", "Agregado");
                }

            }
            else
            {
                MessageBox.Show("No puede guardar espacios en blanco");
            }
           
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Length > 0 && TxtURL.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTipo.Text.Length > 0 && TxtTamaño.Text.Length > 0 && TxtResolucion.Text.Length > 0 && TxtTipoFoto.Text.Length > 0)
            {
                if (cCLS_Fotos.Modificar_Foto(Convert.ToInt32(TxtId.Text), TxtURL.Text, TxtNombre.Text, TxtTipo.Text, Convert.ToInt32(TxtTamaño.Text), TxtResolucion.Text, TxtTipoFoto.Text))
                {
                    MessageBox.Show("Datos Modificados");
                }
            }
            else
            {
                MessageBox.Show("No puede guardar espacios en blanco");
            }

           
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cCLS_Fotos.Eliminar_Fotos(Convert.ToInt32(TxtId.Text)))
            {
                MessageBox.Show("Datos Eliminados");
            }


        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            GridView2 .DataSource = cCLS_Fotos.Mostrar_Fotos();
            GridView2.DataBind();
        }

        
    }
}