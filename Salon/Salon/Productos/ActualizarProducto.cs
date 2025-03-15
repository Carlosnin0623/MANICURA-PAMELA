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
    public partial class ActualizarProducto : Form
    {
        private Productosc Padre;
        private string NombreAnt;

        public ActualizarProducto(Productosc Padre1, string Idprod, string NombreProd, string Precioprod, string Proveedorprod, string Estadoprod)
        {
            InitializeComponent();
            Padre = Padre1;
            txtidprod.Text = Idprod;
            NombreAnt = NombreProd;
            txtNombreProducto.Text =NombreProd;
            txtPrecioProducto.Text = Precioprod;
            txtProveedor.Text = Proveedorprod;
            cbEstadoProd.Text = Estadoprod;
            

        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {   

      
        }

        private void cbEstadoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleccionando el estado y asigarle el valor de su estado correspondiente
            int indice = 0;
            string valor = "";
            indice = cbEstadoProd.SelectedIndex;
            switch (indice)
            {
                //En caso de que el indice sea 0 el valor sera true y si es 1 es false
                case 0:
                    valor = "True";
                    break;

                case 1:
                    valor = "False";
                    break;
            }
            //En txtestadover se guardara el valor del estado
            txtnumestado.Text = valor.ToString();
        }

        private void Closeactprod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnumestado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string Resultado = "";
                EProducto producto = new EProducto();
                producto.Id= Convert.ToInt32(txtidprod.Text);
                producto.NombreAnterior = NombreAnt;
                producto.NombreProducto = txtNombreProducto.Text; 
                producto.Precio= Convert.ToDecimal(txtPrecioProducto.Text);
                producto.Proveedor = txtProveedor.Text;
                producto.Estado = Convert.ToBoolean(txtnumestado.Text);

                DialogResult dialogResult = MessageBox.Show("¿Desea actualizar el producto?", "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //llamamos a la capa de negocio
                    Resultado = NProducto.ActualizarProducto(producto);

                    if (Resultado == "Existe")
                    {
                        MessageBox.Show("No se puede actualizar el registro a: \"" + txtNombreProducto.Text + "\" porque ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Perfecto, el registro se ha actualizado correctamente a la base de datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cuando se actualice el producto, se va a cerrar el formulario de actualizar producto y se va a refrescar el datagrid de producto
                        Padre.ListarProd();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
