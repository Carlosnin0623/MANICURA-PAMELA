using Capa_de_Entidad;
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

namespace Salon.Clientes
{
    public partial class AñadirProducto : Form
    {
        public Productos.Productosc Padre;
        public AñadirProducto(Productos.Productosc Padre1)
        {
            InitializeComponent();
            Padre = Padre1;
        }

        private void Closeagregclient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea insertar el producto "+ txtNombreProducto.Text+"?", "Añadir producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //Crear objeto de producto con los valores del formulario
                    EProducto producto = new EProducto();

                    producto.NombreProducto = txtNombreProducto.Text;
                    producto.Precio = Convert.ToDecimal(txtPrecioProducto.Text);
                    producto.Proveedor = txtProveedor.Text;

                    

                    //Llamar a la capa de negocio
                    string Resultado = NProducto.AgregarProducto(producto);

                    if(Resultado.Equals("Ok"))
                    {
                        MessageBox.Show("Se ha insertado el producto: \""+txtNombreProducto.Text+"\" correctamente en la base de datos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cuando se haga el insert, se cerrara el form de añadir productos y se va refrescar el datagrid de productos
                        Padre.ListarProd();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El producto: \""+txtNombreProducto.Text+"\" ya existe en la base de datos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
