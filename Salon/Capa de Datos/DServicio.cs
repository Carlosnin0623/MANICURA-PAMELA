using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_Entidad;

namespace Capa_de_Datos
{
    public class DServicio
    {

        //Metodo para listar los servicios
        public DataTable ListarServicios()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Listar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                {
                    Sqlcon.Close();
                }
            }

        }


        //Metodo para buscar Producto

        public DataTable BuscarServicio(EServicio servicio)
        {
            SqlDataReader Resultado;

            DataTable tabla = new DataTable();

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Buscar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = servicio.NombreServicio;
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }



        public string InsertarServicios(EServicio Servicio)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Insertar_Sin_Foto", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = Servicio.NombreServicio;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Servicio.Precio;


                //Parametro de salida

                //El 2 indica que el campo NVARCHAR tendrá un máximo de 2 caracteres (puede ser "Si" o "No" en este caso).
                SqlParameter paramEncontrado = new SqlParameter("@Encontrado", SqlDbType.NVarChar, 2);
                paramEncontrado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramEncontrado);

                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                comando.ExecuteNonQuery();

                //Obtenemos el resultado del parametro de salida
                string Encontrado = paramEncontrado.Value.ToString();

                if (Encontrado == "Si")
                    Resultado = "Existe";
                else
                    Resultado = "Ok";

            }
            catch (Exception ex)
            {
                Resultado = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Resultado;

        }


        public string ActualizarServicios(EServicio servicio)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Actualizar_sin_Foto", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@ServicioId", SqlDbType.Int).Value = servicio.Id;
                comando.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = servicio.NombreServicio;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = servicio.Precio;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = servicio.Estado;

                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Resultado = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Resultado;
        }


        public string Servicio_ActualizarExiste(EServicio servicio)
        {
            string Resultado = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Servicios_Actualizar_Existe", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = servicio.NombreServicio;
                SqlParameter paramEncontrado = new SqlParameter("@Encontrado", SqlDbType.NVarChar, 2);
                paramEncontrado.ParameterName = "@Encontrado";

                paramEncontrado.SqlDbType = SqlDbType.NVarChar;
                paramEncontrado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramEncontrado);
                sqlcon.Open();
                comando.ExecuteNonQuery();
                Resultado = Convert.ToString(paramEncontrado.Value);

            }
            catch (Exception ex)
            {
                Resultado = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return Resultado;
        }

    }
}
