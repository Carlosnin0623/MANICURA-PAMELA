using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.GastosFijos
{
    public partial class GastoFijo: Form
    {
        public GastoFijo()
        {
            InitializeComponent();
        }

 
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarGastosfijo visualizarGastosfijo = new VisualizarGastosfijo();
            visualizarGastosfijo.ShowDialog();
        }

        private void btnGenerarPeriodos_Click(object sender, EventArgs e)
        {
            GenerarPeriodosGastosfijos generarPeriodosGastosfijos= new GenerarPeriodosGastosfijos();
            generarPeriodosGastosfijos.ShowDialog();
        }
    }
}
