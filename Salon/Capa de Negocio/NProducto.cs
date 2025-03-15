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
    public class NProducto
    {   

        //Metodo de listar productos
        public static DataTable ListarProducto()
        {
            DProducto Datos = new DProducto();

            return Datos.ListarProducto();
        }

        //Metodo de buscar productos
        public static DataTable BuscarProducto(EProducto producto)
        {
            DProducto Datos = new DProducto();

            return Datos.BuscarProducto(producto);
        }

        //Metodo para insertar productos

        public static string AgregarProducto(EProducto producto)
        {
            DProducto Datos = new DProducto();

            return Datos.InsertarProductos(producto);
        }

        public static string ActualizarProducto(EProducto producto)
        {
             // Creamos la instancia para acceder a los metodos correspondientes
            DProducto Datos = new DProducto();

            //Si nombre anterior es igual al nombre del producto hacer el update
            if (producto.NombreAnterior == producto.NombreProducto)
            {
                return Datos.ActualizarProductos(producto);
            }
            //De lo contrario verificar en la base de datos
            else
            {
                
                string Resultado = Datos.Producto_ActualizarExiste(producto);
                if (Resultado.Equals("Si"))
                {
                    return "Existe";
                }
                else
                {
                    return Datos.ActualizarProductos(producto);
                }

            }
             
        }
    }
}
