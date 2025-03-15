using Salon.Nomina;
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
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void Closemenu_Click(object sender, EventArgs e)
        {
            ConsultarEmp consultarEmp = new ConsultarEmp();
            consultarEmp.ShowDialog();
        }

        private void Closeagregarusuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
