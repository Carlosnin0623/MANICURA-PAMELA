using Capa_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Productos
{
    public partial class MostrarProductos : Form
    {
        public string Producto;
        public string Precioprod;

        public MostrarProductos()
        {
            InitializeComponent();
        }

        public void ListarPro()
        {
            try
            {
                DgvDatosProductosm.DataSource = NProducto.ListarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarProductos_Load(object sender, EventArgs e)
        {   
            DgvDatosProductosm.ReadOnly = true;
            this.ListarPro();
        }

        private void CloseMostrarpro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(DgvDatosProductosm.SelectedRows.Count > 0)
            {
                DataGridViewRow filaseleccionada= DgvDatosProductosm.SelectedRows[0];
                Producto = filaseleccionada.Cells["NombreProducto"].Value.ToString(); 
                Precioprod= filaseleccionada.Cells["Precio"].Value.ToString();
                this.Close();
            }
        }

        private void DgvDatosProductosm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
