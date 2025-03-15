using DrakeUI.Framework;
using Salon.Productos;
using Salon.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Facturación
{
    public partial class AñadirFactura : Form
    {
        public AñadirFactura()
        {
            InitializeComponent();
        }

        private void DgvDatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirFactura_Load(object sender, EventArgs e)
        {
            //Aqui estamos obteniendo la fecha actual 
            DateTime fechasolo = DateTime.Today;
            //Aqui le estamos asignando la fecha actual al textbox de fecha de factura
            txtFechafact.Text = fechasolo.ToString("yyyy-MM-dd");
            txtFechafact.ReadOnly = true;
            txtProducto.ReadOnly = true;
            txtServicio.ReadOnly = true;
            txtPrecioProducto.ReadOnly = true;
            txtPrecioServicio.ReadOnly = true;
            numericUpDown1.Enabled = false;
        }



        private void Closeagregfactu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            MostrarServicios mostrarServicios = new MostrarServicios();
            mostrarServicios.ShowDialog();
        }


        private void btnProducto_Click(object sender, EventArgs e)
        {
            MostrarProductos mostrarProductos = new MostrarProductos();
            mostrarProductos.ShowDialog();
            txtProducto.Text = mostrarProductos.Producto;
            txtPrecioProducto.Text = mostrarProductos.Precioprod;

        }



        public void ObtenerTotal()
        {
            float totalneto = 0;
            int contador = 0;

            //Primero vamos a contar la cantidad de filas que tenemos en el datagrid
            contador = DgvDatosFacturar.RowCount;

            for (int i = 0; i < contador; i++)
            {
                totalneto += float.Parse(DgvDatosFacturar.Rows[i].Cells[12].Value.ToString());
            }

            txtTotalneto.Text = totalneto.ToString();
        }



        private void DgvDatosFacturar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Añadiendo el boton de editar al datagridview
            if (e.ColumnIndex == DgvDatosFacturar.Columns["Editar"].Index && e.RowIndex >= 0)
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


            //Añadiendo el boton de borrar al datagridview
            if (e.ColumnIndex == DgvDatosFacturar.Columns["borrar"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Cargar la imagen
                Image editImage = Properties.Resources.borrardef1;

                // Dibujar la imagen centrada
                int imageX = e.CellBounds.Left + (e.CellBounds.Width - editImage.Width) / 2;
                int imageY = e.CellBounds.Top + (e.CellBounds.Height - editImage.Height) / 2;
                e.Graphics.DrawImage(editImage, new Point(imageX, imageY));

                e.Handled = true;
            }
        }


        private void DgvDatosFacturar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text.Equals(string.Empty) && txtProducto.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debes seleccionar un producto o un servicio para agregarlo a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtCliente.Text.Equals(string.Empty))
            {
                MessageBox.Show("El campo cliente es obligatorio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                DataGridViewRow file = new DataGridViewRow();
                file.CreateCells(DgvDatosFacturar);
                file.Cells[9].Value = txtVendedor.Text;
                file.Cells[3].Value = txtServicio.Text;
                file.Cells[6].Value = txtProducto.Text;
                file.Cells[4].Value = txtPrecioServicio.Text;
                file.Cells[8].Value = txtPrecioProducto.Text;
                file.Cells[9].Value = txtCliente.Text;
                file.Cells[7].Value = numericUpDown1.Value;
                file.Cells[11].Value = txtFechafact.Text;

                if (!string.IsNullOrWhiteSpace(txtProducto.Text) && numericUpDown1.Value < 1)
                {
                    MessageBox.Show("La cantidad del producto no puede ser igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                else if (txtServicio.Text.Equals(string.Empty) && txtPrecioServicio.Text.Equals(string.Empty))
                {
                    file.Cells[12].Value = (float.Parse(txtPrecioProducto.Text) * (float)numericUpDown1.Value);
                }

                else if (txtProducto.Text.Equals(string.Empty) && txtPrecioProducto.Text.Equals(string.Empty))
                {
                    file.Cells[12].Value = txtPrecioServicio.Text;
                }
                else
                {
                    //Aqui estamos haciendo el calculo del precio del producto por la cantidad mas el precio del servicio
                    file.Cells[12].Value = (float.Parse(txtPrecioProducto.Text) * (float)numericUpDown1.Value) + float.Parse(txtPrecioServicio.Text);
                }

                Limpiarcampos();
                //Pasando los datos al datagrid view 
                DgvDatosFacturar.Rows.Add(file);

                ObtenerTotal();
            }
        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {

        }

        public void Limpiarcampos()
        {
            txtProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtServicio.Text = "";
            txtPrecioServicio.Text = "";
            numericUpDown1.Enabled = false;
            numericUpDown1.Value = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarcampos();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        private void DgvDatosFacturar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDatosFacturar.Columns[e.ColumnIndex].Name == "borrar")
            {

                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DgvDatosFacturar.Rows.Remove(DgvDatosFacturar.CurrentRow);
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Aqui le pasamos el metodo obtener total para que me actualice el total
                ObtenerTotal();
            }

        }
    }
}
    

