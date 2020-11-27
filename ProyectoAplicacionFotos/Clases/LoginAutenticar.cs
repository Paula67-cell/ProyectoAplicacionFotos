using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoAplicacionFotos.Clases
{
    public class LoginAutenticar 

    {
        SqlCommandBuilder cmb;
        DataSet ds = new  DataSet();
        SqlDataAdapter da;
        SqlCommand command;
        public String coneccion = "Data Source=LAPTOP-JQ6UM2LL\\SQLEXPRESS;Initial Catalog=ArchivosFotos;Integrated Security=True";
        private DataTable dataTable = new DataTable();
        /// <summary>
        /// /////////////////////////////////////////////////////////////
        /// </summary>
        string NombreUusario = "";
        string contrasena = "";
        string email = " ";
        public Boolean Coneccion()
        {
           try
           {
                SqlConnection cnn = new SqlConnection(this.coneccion);
                
                return true;


            }
            catch
           
           {
                return false;


           }
        }

       
        
        public  void Verificar_Uusario()
        {
            string tabla = "AutenticacionUsuario";
            string Nom = "select NombreUsuario,Contraseña,Email from  " + tabla + "where NombreUsuario=" + NombreUusario + "and Contraseña=" + "'" + contrasena  +"Email=" + "'" + email ;
            SqlDataAdapter da = new SqlDataAdapter(Nom, coneccion );
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
            
        }
    }
}