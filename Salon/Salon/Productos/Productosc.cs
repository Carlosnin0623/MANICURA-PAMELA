using Capa_de_Entidad;
using Capa_de_Negocio;
using Salon.Clientes;
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
    public partial class Productosc : Form
    {
        public Productosc()
        {
            InitializeComponent();
        }



        public void ListarProd()
        {
            try
            {
                DgvDatosProductos.DataSource = NProducto.ListarProducto();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarProd(EProducto producto)
        {
            try
            {
                DgvDatosProductos.DataSource = NProducto.BuscarProducto(producto);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Productosc_Load(object sender, EventArgs e)
        {
            DgvDatosProductos.ReadOnly = true;
            ListarProd();
        }

        private void btnAgregProd_Click(object sender, EventArgs e)
        {
            AñadirProducto añadirProducto = new AñadirProducto(this);
            añadirProducto.ShowDialog();
        }

        private void DgvDatosProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Añadiendo el boton de editar al datagridview
            if (e.ColumnIndex == DgvDatosProductos.Columns["editar"].Index && e.RowIndex >= 0)
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

        private void DgvDatosProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && DgvDatosProductos.Columns[e.ColumnIndex].Name == "editar")
            {
                {
                    DataGridViewRow filaseleccionada = DgvDatosProductos.SelectedRows[0];
                    string Idprod = filaseleccionada.Cells["Id"].Value.ToString();
                    string Nombreprod = filaseleccionada.Cells["NombreProducto"].Value.ToString();
                    string Precioprod = filaseleccionada.Cells["Precio"].Value.ToString();
                    string Proveedorprod = filaseleccionada.Cells["Proveedor"].Value.ToString();
                    string Estadoprod = filaseleccionada.Cells["Estado"].Value.ToString();

                    ActualizarProducto actualizarProducto = new ActualizarProducto(this,Idprod, Nombreprod, Precioprod, Proveedorprod, Estadoprod);
                    actualizarProducto.ShowDialog();
                }
            }
        }

        private void DgvDatosProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvDatosProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {   
            EProducto producto = new EProducto();
            producto.NombreProducto= txtBuscarProd.Text;
            
            BuscarProd(producto);
        }
    }
}

