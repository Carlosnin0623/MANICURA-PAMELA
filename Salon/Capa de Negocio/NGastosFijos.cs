using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_Datos;
using Capa_de_Entidad;

namespace Capa_de_Negocio
{
    public class NGastosFijos
    {
        public static DataTable ListarGastosFijos(EGastoFijos GastosFijos)
        {
            DGastosFijos Datos = new DGastosFijos();
            return Datos.ListarGastosFijos(GastosFijos);
        }


        public static DataTable BuscarGastosFijos(EGastoFijos GastosFijos)
        {
            DGastosFijos Datos = new DGastosFijos();
            return Datos.BuscarGastosFijos(GastosFijos);
        }


        public static string AgregarGastosFijos(EGastoFijos GastosFijos)
        {
            DGastosFijos Datos = new DGastosFijos();

            return Datos.InsertarGastosFijos(GastosFijos);
        }

        public static string ActualizarGastoFijo(EGastoFijos GastosFijos)
        {

            DGastosFijos Datos = new DGastosFijos();

            return Datos.ActualizarGastosFijos(GastosFijos);

        }


        public static string EliminarGastoFijo(EGastoFijos GastosFijos)
        {

            DGastosFijos Datos = new DGastosFijos();

            return Datos.EliminarGastosFijos(GastosFijos);

        }
    }

}
