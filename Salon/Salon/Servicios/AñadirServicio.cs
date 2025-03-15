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

namespace Salon.Servicios
{
    public partial class AñadirServicio: Form
    {
        private Servicio Padre;
        public AñadirServicio(Servicio Padre1)
        {
            InitializeComponent();
            Padre = Padre1;
        }

        private void AñadirServicio_Load(object sender, EventArgs e)
        {

        }

        private void Closeagreservicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            try
            {
            // DialLogResult nos permite mostrar una ventana emergente que nos preguntara si queremos insertar el servicio */
                DialogResult dialogResult = MessageBox.Show("¿Desea insertar el producto " + txtNombreServ.Text + "?", "Añadir producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //Crear objeto de producto con los valores del formulario
                    EServicio servicio = new EServicio();

                    servicio.NombreServicio = txtNombreServ.Text;
                    servicio.Precio = Convert.ToDecimal(txtPrecioServ.Text);
                  

                    //Llamar a la capa de negocio
                    string Resultado = NServicio.AgregarServicio(servicio);

                    if (Resultado.Equals("Ok"))
                    {
                        MessageBox.Show("Se ha insertado el servicio: \"" + txtNombreServ.Text + "\" correctamente en la base de datos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cuando se haga el insert, se cerrara el form de añadir productos y se va refrescar el datagrid de productos
                        Padre.ListarServicio();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El producto: \"" + txtNombreServ.Text + "\" ya existe en la base de datos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
