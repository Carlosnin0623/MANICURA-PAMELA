using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_de_Entidad;

namespace Capa_de_Datos
{
    public class DGastosFijos
    {
       public DataTable ListarGastosFijos(EGastoFijos GastosFijos)
        {
            SqlDataReader Resultado;

            DataTable tabla = new DataTable();

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gastos_Fijos_Listar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@CodigoPeriodoFijo", SqlDbType.NVarChar).Value = GastosFijos.CodigoPeriodoFijo;
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


        public DataTable BuscarGastosFijos(EGastoFijos GastoFijo)
        {
            SqlDataReader Resultado;

            DataTable tabla = new DataTable();

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gastos_Fijos_Buscar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = GastoFijo.Nombre;
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


        public string InsertarGastosFijos(EGastoFijos GastoFijo)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gastos_Fijos_Insertar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@CodigoPeriodoFijo", SqlDbType.NVarChar).Value = GastoFijo.CodigoPeriodoFijo;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = GastoFijo.Nombre;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = GastoFijo.Descripcion;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = GastoFijo.Precio;
              
                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                Resultado = comando.ExecuteNonQuery() > 1 ? "ok" : "no";
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


        public string ActualizarGastosFijos(EGastoFijos GastoFijo)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gastos_Fijos_Actualizar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@IdGastoFijo", SqlDbType.Int).Value = GastoFijo.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = GastoFijo.Nombre;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = GastoFijo.Descripcion;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = GastoFijo.Precio;

                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                Resultado = comando.ExecuteNonQuery() > 1 ? "ok" : "no";
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


        public string EliminarGastosFijos(EGastoFijos GastoFijo)
        {
            string Resultado = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Gastos_Fijos_Eliminar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;

                //Parametros de entrada
                comando.Parameters.Add("@IdGastoFijo", SqlDbType.Int).Value = GastoFijo.Id;

                sqlcon.Open();
                //Ejecutamos el procedimiento almacenado
                Resultado = comando.ExecuteNonQuery() > 1 ? "ok" : "no";
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
