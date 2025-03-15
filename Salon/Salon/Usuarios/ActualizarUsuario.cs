using Salon.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Usuarios
{
    public partial class ActualizarUsuario : Form
    {
        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void Closemenu_Click(object sender, EventArgs e)
        {
            AñadirEmpleados añadirEmpleados = new AñadirEmpleados();
            añadirEmpleados.ShowDialog();
        }
    }
}
