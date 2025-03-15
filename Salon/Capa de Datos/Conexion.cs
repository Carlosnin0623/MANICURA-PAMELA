using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Conexion
    {

     
            private string Nombre_base_de_datos;
            private string Servidor;
            private string Usuario;
            private string Clave;
            private Boolean Seguridad;
            private static Conexion Con = null;



            private Conexion()
            {
               this.Nombre_base_de_datos = "PampPink";
               this.Servidor = "1COMPU03";
               this.Usuario = "Admin";
               this.Clave = "Infernape100";
               this.Seguridad = true;

            }

            public SqlConnection CrearConexion()
            {

                SqlConnection Cadena = new SqlConnection();
                try
                {
                    string DB = string.Format("server='{0}'; database='{1}'; ", this.Servidor, this.Nombre_base_de_datos);
                    Cadena.ConnectionString = DB;


                    // Si es con la autenticacion de windows 
                    if (this.Seguridad)
                    {
                        Cadena.ConnectionString += "Integrated Security = SSPI";

                    }
                    else
                    {  // Si es con la autenticacion de windows Server
                        Cadena.ConnectionString += "User Id=" + this.Usuario + ";Password=" + this.Clave;
                    }

                }
                catch (Exception)
                {

                    Cadena = null;
                    throw;
                }
                return Cadena;

            }

            public static Conexion GetInstancia()
            {
                if (Con == null)
                {
                    Con = new Conexion();
                }

                return Con;
            }

        
    }
}
