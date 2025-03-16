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
    public class NPeriodosGastosFijos
    {
        public static DataTable ListarPeriodosGastosFijos()
        {
            DPeriodosGastosFijos Datos = new DPeriodosGastosFijos();
            return Datos.ListarPeriodosGastosFijos();
        }

        public static DataTable BuscarrPeriodosGastosFijos(EPeriodosGastosFijos PeriodosGastosFijos)
        {
            DPeriodosGastosFijos Datos = new DPeriodosGastosFijos();
            return Datos.BuscarPeriodosGastosFijos(PeriodosGastosFijos);
        }


    }
}
