using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Negocio;

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
            try
            {
                if (DgvDatosGastosFijos.RowCount > 0)
                {
                    DataGridViewRow filaseleccionada = new DataGridViewRow();
                    filaseleccionada = DgvDatosGastosFijos.SelectedRows[0];
                    string Periodo = filaseleccionada.Cells["IdPeriodosGastosFijos"].Value.ToString();

                    VisualizarGastosfijo GastoFijo = new VisualizarGastosfijo(Periodo);
                    GastoFijo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar al menos un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          

        private void btnGenerarPeriodos_Click(object sender, EventArgs e)
        {
            GenerarPeriodosGastosfijos generarPeriodosGastosfijos= new GenerarPeriodosGastosfijos();
            generarPeriodosGastosfijos.ShowDialog();
        }

        public void ListarPeriodoGastosFijos()
        {
            try
            {
                DgvDatosGastosFijos.DataSource = NPeriodosGastosFijos.ListarPeriodosGastosFijos();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void GastoFijo_Load(object sender, EventArgs e)
        {
            ListarPeriodoGastosFijos();
            DgvDatosGastosFijos.ReadOnly = true;
        }
    }
}
