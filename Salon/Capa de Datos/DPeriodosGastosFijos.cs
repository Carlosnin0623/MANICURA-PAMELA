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
    public class DPeriodosGastosFijos
    {
        public DataTable ListarPeriodosGastosFijos()
        {
            SqlDataReader Resultado;

            DataTable tabla = new DataTable();

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Periodos_Gastos_Fijos_Listar", Sqlcon);
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


        public DataTable BuscarPeriodosGastosFijos(EPeriodosGastosFijos PeriodosGastosFijos)
        {
            SqlDataReader Resultado;

            DataTable tabla = new DataTable();

            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                //Obteniendo la cadena de conexion
                Sqlcon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Periodos_Gastos_Fijos_Buscar", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IdPeriodoGastosFijos", SqlDbType.NVarChar).Value = PeriodosGastosFijos.IdPeriodosGastosFijos;
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

    }
}
