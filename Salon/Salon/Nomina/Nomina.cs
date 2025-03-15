using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Nomina
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void btnTrabjarnom_Click(object sender, EventArgs e)
        {
            TrabajarNomina trabnomina = new TrabajarNomina();
            trabnomina.ShowDialog();

            
        }
    }
}
