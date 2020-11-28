using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows;

namespace ProyectoAplicacionFotos.Fotos
{
    public class Class_Fotos : Conexion
    {
        private DataTable dataTable = new DataTable();
        public DataTable Mostrar_Fotos() //
        {
            try
            {
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "MostrarFotos";
               
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(dataTable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar");
            }
            return dataTable;

        }


        public Boolean Modificar_Foto(int pID, String pURL, String pNombreArchivo, String pTipoArchivo, int pTamaño, String pResolucion, String pTipoFoto)
        {
            try
            {
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "ModificarFotos"; //Nombre de Nuestro Procedimiento Almacenado
                coneccion.CommandTimeout = 10;
                coneccion.Parameters.AddWithValue("@ID", pID);
                coneccion.Parameters.AddWithValue("@URL", pURL);
                coneccion.Parameters.AddWithValue("@NombreArchivo", pNombreArchivo);
                coneccion.Parameters.AddWithValue("@TipoArchivo", pTipoArchivo);
                coneccion.Parameters.AddWithValue("@Tamaño", pTamaño);
                coneccion.Parameters.AddWithValue("@Resolucion", pResolucion);
                coneccion.Parameters.AddWithValue("@TipoFoto", pTipoFoto);
                coneccion.ExecuteNonQuery();
                conectado.Close();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al modificar");
                return false;
            }


        }

        public Boolean Eliminar_Fotos(int pID)
        {
            try
            {
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "EliminarFotos"; //Nombre de Nuestro Procedimiento Almacenado
                coneccion.CommandTimeout = 10;
                coneccion.Parameters.AddWithValue("@id", pID);
                coneccion.ExecuteNonQuery();
                conectado.Close();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar");
                return false;
            }
        }

        public Boolean Agregar_Fotos(int pID, String pURL, String pNombreArchivo, String pTipoArchivo, int pTamaño, String pResolucion, String pTipoFoto)
        {
            try
            {
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "AgregarFotos"; //Nombre de Nuestro Procedimiento Almacenado
                coneccion.CommandTimeout = 10;
                coneccion.Parameters.AddWithValue("@ID", pID);
                coneccion.Parameters.AddWithValue("@URL", pURL);
                coneccion.Parameters.AddWithValue("@NombreArchivo", pNombreArchivo);
                coneccion.Parameters.AddWithValue("@TipoArchivo", pTipoArchivo);
                coneccion.Parameters.AddWithValue("@Tamaño", pTamaño);
                coneccion.Parameters.AddWithValue("@Resolucion", pResolucion);
                coneccion.Parameters.AddWithValue("@TipoFoto", pTipoFoto);
                coneccion.ExecuteNonQuery();
                conectado.Close();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al Registrar");
                return false;
            }

        }
    }
}