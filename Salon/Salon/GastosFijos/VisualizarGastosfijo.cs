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
    public partial class VisualizarGastosfijo : Form
    {
        public VisualizarGastosfijo()
        {
            InitializeComponent();
        }

        private void ClosevisualizarGastoFijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarGastosFijos_Click(object sender, EventArgs e)
        {
            AñadirGastoFijo añadirGastoFijo = new AñadirGastoFijo();
            añadirGastoFijo.ShowDialog();
        }
    }
}
