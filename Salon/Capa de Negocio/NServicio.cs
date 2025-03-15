using Capa_de_Datos;
using Capa_de_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Negocio
{
    public class NServicio
    {
        //Metodo de listar productos
        public static DataTable ListarServicio()
        {
            DServicio Datos = new DServicio();
            return Datos.ListarServicios();
        }

        //Metodo de buscar servicios
        public static DataTable BuscarServicio(EServicio servicio)
        {
            DServicio Datos = new DServicio();
            return Datos.BuscarServicio(servicio);
           
        }

        // Metodo para insertar servicio
        public static string AgregarServicio(EServicio servicio)
        {
            DServicio Datos = new DServicio();

            return Datos.InsertarServicios(servicio);
        }

        // Metodo para actualizar servicio
        public static string ActualizarServicio(EServicio servicio)
        {
            // Creamos la instancia para usar los metodos correspondientes

            DServicio Datos = new DServicio();

            //Si nombre anterior es igual al nombre del producto hacer el update
            if (servicio.NombreAnterior == servicio.NombreServicio)
            {
                return Datos.ActualizarServicios(servicio);
            }
            //De lo contrario verificar en la base de datos
            else
            {

                string Resultado = Datos.Servicio_ActualizarExiste(servicio);
                if (Resultado.Equals("Si"))
                {
                    return "Existe";
                }
                else
                {
                    return Datos.ActualizarServicios(servicio);
                }

            }


        }


    }
}
