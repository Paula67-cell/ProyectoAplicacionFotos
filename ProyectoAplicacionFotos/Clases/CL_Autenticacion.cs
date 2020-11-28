using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Windows;

namespace ProyectoAplicacionFotos
{
    
    public class CL_Autenticacion : Conexion

    {
        private DataTable dataTable = new DataTable();
        

        DataSet ds = new DataSet();
        public Boolean  Usuario(string pNombreUsuario, string pPassword, string pEmail)
        {
           Boolean vBandera = false;
            try
            {
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();

                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "AgregarUsuario";
                coneccion.CommandTimeout = 10;
                coneccion.Parameters.AddWithValue("@NombreUsuario", pNombreUsuario);
                coneccion.Parameters.AddWithValue("@Password", pPassword);
                coneccion.Parameters.AddWithValue("@Email", pEmail);
              
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows[0][1].ToString().Equals(pNombreUsuario) && dataTable.Rows[0][2].ToString().Equals(pPassword) && dataTable.Rows[0][3].ToString().Equals(pEmail))
                    {
                        vBandera = true;
                    }
                    else
                    {
                        vBandera = false;
                    }
                }


                conectado.Close();

            
               


            }
            catch (Exception Ex)
            {
                MessageBox.Show("Esa cuenta ya existe");
            }

            return true;
        }
       
        

        }
            
    }


    
    