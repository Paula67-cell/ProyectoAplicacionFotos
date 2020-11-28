using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows;

namespace ProyectoAplicacionFotos
{
    public class Clase_Etiqueta : Conexion 
    {
        
            private DataTable dataTable = new DataTable();

            public DataTable Mostrar_Etiquetas()
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
                    coneccion.CommandText = "MostrarEtiqueta";
                    adapter = new SqlDataAdapter(coneccion);
                    adapter.Fill(dataTable);
                    conectado.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                return dataTable;

            }


            public Boolean Modificar_Etiquetas(int pID, String pNombreEtiqueta, String pTotalFotos, String pSugerencias)
            {
                try
                {
                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "ModificarEtiquetas"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.Parameters.AddWithValue("@ID", pID);
                    coneccion.Parameters.AddWithValue("@NombreEtiqueta", pNombreEtiqueta);
                    coneccion.Parameters.AddWithValue("@TotalFotos", pTotalFotos);
                    coneccion.Parameters.AddWithValue("@Sugerencias", pSugerencias);
                
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    return false;
                }


            }

            public Boolean Eliminar_Etiquetas(int pID)
            {
                try
                {
                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "EliminarEtiqueta"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@ID", pID);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    return false;
                }
            }

            public Boolean Agregar_Etiquetas(int pID, String pNombreEtiqueta, String pTotalFotos, String pSugerencias)
            {
                try
                {
                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "AgregarEtiquetas"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@ID", pID);
                    //coneccion.Parameters.AddWithValue("@CodigoFotos", pCodigoFotos);
                    coneccion.Parameters.AddWithValue("@NombreEtiqueta", pNombreEtiqueta);
                    coneccion.Parameters.AddWithValue("@TotalFotos", pTotalFotos);
                    coneccion.Parameters.AddWithValue("@Sugerencias", pSugerencias);
                  // Ponerlo en el orden suyo en este caso va de segundo
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    return false;
                }

            }
        }
    }
