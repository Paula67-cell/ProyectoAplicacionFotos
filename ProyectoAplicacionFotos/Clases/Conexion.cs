using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoAplicacionFotos
{
    public class Conexion
    {
        public String coneccion = "Data Source=DESKTOP-PPP3N8C\\SQLEXPRESS;Initial Catalog=ArchivoFotos;Integrated Security=True";

        public Boolean Conectando()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(this.coneccion);//Probamos que ahy coneccion.
                cnn.Close();//Cerramos la coneccion
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}