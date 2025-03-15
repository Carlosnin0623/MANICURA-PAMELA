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
    public class DProducto
    {
        //Metodo para listar los productos

        public DataTable ListarProducto()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_Listar", Sqlcon);
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

        //Metodo para buscar productos
        public DataTable BuscarProducto(EProducto producto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_Buscar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.NombreProducto;
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

        //Metodo para insertar productos

        public string InsertarProductos(EProducto producto)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_insertar_sin_fotos", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.NombreProducto;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
                comando.Parameters.Add("@Proveedor", SqlDbType.NVarChar).Value = producto.Proveedor;

                //Parametro de salida

                //El 2 indica que el campo NVARCHAR tendrá un máximo de 2 caracteres (puede ser "Si" o "No" en este caso).
                SqlParameter paramEncontrado = new SqlParameter("@Encontrado", SqlDbType.NVarChar, 2);
                paramEncontrado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramEncontrado);
                
                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                comando.ExecuteNonQuery();

                //Obtenemos el resultado del parametro de salida
                string Encontrado= paramEncontrado.Value.ToString();

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


        public string ActualizarProductos(EProducto producto)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_Actualizar_sin_Foto", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@ProductoId", SqlDbType.Int).Value = producto.Id;
                comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.NombreProducto;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
                comando.Parameters.Add("@Proveedor", SqlDbType.NVarChar).Value = producto.Proveedor;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = producto.Estado;

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


        public string Producto_ActualizarExiste(EProducto producto)
        {
            string Resultado = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Productos_Actualizar_Existe", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.NombreProducto;
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
