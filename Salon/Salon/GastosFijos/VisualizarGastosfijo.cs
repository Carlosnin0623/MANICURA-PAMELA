using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Entidad;
using Capa_de_Negocio;

namespace Salon.GastosFijos
{
    public partial class VisualizarGastosfijo : Form
    {
        public string PeriodoGastosFijos;


        public VisualizarGastosfijo(string periodo)
        {
            InitializeComponent();
            PeriodoGastosFijos = periodo;
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

        public void ListarGastosFijos()
        {
            try
            {
                EGastoFijos GastosFijos = new EGastoFijos();
                GastosFijos.CodigoPeriodoFijo = PeriodoGastosFijos;

                DgvDatosGastosfijosmost.DataSource = NGastosFijos.ListarGastosFijos(GastosFijos);

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualizarGastosfijo_Load(object sender, EventArgs e)
        {
            ListarGastosFijos();
            DgvDatosGastosfijosmost.ReadOnly = true;
        }
    }
}
