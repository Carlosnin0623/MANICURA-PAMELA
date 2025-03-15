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

    public partial class ActualizarServicio: Form
    {
        public Servicio Padre;
        private string NombreAnt;

        public ActualizarServicio(Servicio padre, string Idserv, string Nombreserv, string Precioserv, string Estadoserv)
        {
            InitializeComponent();
            Padre = padre;
            txtidserv.Text = Idserv;
            NombreAnt = Nombreserv;
            txtNombreServicio.Text = Nombreserv;
            txtPrecioServicio.Text = Precioserv;
            cbEstadoServ.Text = Estadoserv;
        }

        private void cbEstadoServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleccionando el estado y asigarle el valor de su estado correspondiente
            int indice = 0;
            string valor = "";
            indice = cbEstadoServ.SelectedIndex;
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

        private void Closeactserv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                string Resultado = "";
                EServicio servicio = new EServicio();
                servicio.Id = Convert.ToInt32(txtidserv.Text);
                servicio.NombreAnterior = NombreAnt;
                servicio.NombreServicio = txtNombreServicio.Text;
                servicio.Precio = Convert.ToDecimal(txtPrecioServicio.Text);
                servicio.Estado = Convert.ToBoolean(txtnumestado.Text);

                DialogResult dialogResult = MessageBox.Show("¿Desea actualizar el producto?", "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //llamamos a la capa de negocio
                    Resultado = NServicio.ActualizarServicio(servicio);

                    if (Resultado == "Existe")
                    {
                        MessageBox.Show("No se puede actualizar el registro a: \"" + txtNombreServicio.Text + "\" porque ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Perfecto, el registro se ha actualizado correctamente a la base de datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cuando se actualice el producto, se va a cerrar el formulario de actualizar producto y se va a refrescar el datagrid de producto
                        Padre.ListarServicio();
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
