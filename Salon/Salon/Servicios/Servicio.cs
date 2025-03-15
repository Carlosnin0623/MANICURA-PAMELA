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
using Salon.Productos;

namespace Salon.Servicios
{
    public partial class Servicio: Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void btnAgregaremp_Click(object sender, EventArgs e)
        {
            AñadirServicio añadirServicio = new AñadirServicio(this);
            añadirServicio.ShowDialog();
        }

        public void ListarServicio()
        {
            try
            {
                DgvDatosServicios.DataSource = NServicio.ListarServicio();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            DgvDatosServicios.ReadOnly = true;
            ListarServicio();
        }

        // Metodo para buscar Servicio

        public void BuscarServicio(EServicio servicio)
        {
            try
            {
                DgvDatosServicios.DataSource = NServicio.BuscarServicio(servicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarServicio_TextChanged(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();

            servicio.NombreServicio = txtBuscarServicio.Text;

            BuscarServicio(servicio);
        }

        private void DgvDatosServicios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == DgvDatosServicios.Columns["editar"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Cargar la imagen
                Image editImage = Properties.Resources.editardef1;

                // Dibujar la imagen centrada
                int imageX = e.CellBounds.Left + (e.CellBounds.Width - editImage.Width) / 2;
                int imageY = e.CellBounds.Top + (e.CellBounds.Height - editImage.Height) / 2;
                e.Graphics.DrawImage(editImage, new Point(imageX, imageY));

                e.Handled = true;
            }
        }

        private void DgvDatosServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDatosServicios.Columns[e.ColumnIndex].Name == "editar")
            {
                {
                    DataGridViewRow filaseleccionada = DgvDatosServicios.SelectedRows[0];
                    string Idserv = filaseleccionada.Cells["Id"].Value.ToString();
                    string Nombreserv = filaseleccionada.Cells["NombreServicio"].Value.ToString();
                    string Precioserv = filaseleccionada.Cells["Precio"].Value.ToString();
                    string Estadoserv = filaseleccionada.Cells["Estado"].Value.ToString();

                    ActualizarServicio actualizarServicio = new ActualizarServicio(this, Idserv, Nombreserv, Precioserv, Estadoserv);
                    actualizarServicio.ShowDialog();
                }
            }
        }
    }
}
