using ProyectoAplicacionFotos.Etiquetas;
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
        Class_Etiquetas cCLS_Etiquetas = new Class_Etiquetas();
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
            if (TxtId.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTotal.Text.Length > 0 && TxtSugerencia.Text.Length > 0 && TxtCodigo.Text.Length > 0)
            {
                if (cCLS_Etiquetas.Agregar_Etiquetas(Convert.ToInt32(TxtId.Text), TxtNombre.Text,TxtTotal.Text, TxtSugerencia.Text, Convert.ToInt32(TxtCodigo.Text)))
                {
                    MessageBox.Show("Registro Agregado con Exito", "Agregado");
                }
            }
            else
            {
                MessageBox.Show("No puede guardar espacios en blanco");
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cCLS_Etiquetas.Eliminar_Etiquetas(Convert.ToInt32(TxtId.Text)))
            {
                MessageBox.Show("Datos Eliminados");
            }
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Length > 0 && TxtNombre.Text.Length > 0 && TxtTotal.Text.Length > 0 && TxtSugerencia.Text.Length > 0 && TxtCodigo.Text.Length > 0)
            {
                if (cCLS_Etiquetas.Modificar_Etiquetas(Convert.ToInt32(TxtId.Text), TxtNombre.Text, TxtTotal.Text, TxtSugerencia.Text, Convert.ToInt32(TxtCodigo.Text)))
                {
                    MessageBox.Show("Datos modificados con exito ");
                }
            }
        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = cCLS_Etiquetas.Mostrar_Etiquetas();
            GridView1.DataBind();
        }
    }
}