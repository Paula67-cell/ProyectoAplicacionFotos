using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAplicacionFotos.WEBForms
{
    public partial class Etiquetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNSugerencias_Click(object sender, EventArgs e)
        {
            this.LabelEtiquetas .Visible = true;
            this.Image1.Visible = true;
        }
    }
}