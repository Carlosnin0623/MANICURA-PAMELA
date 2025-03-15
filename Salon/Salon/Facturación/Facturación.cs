using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Facturación
{
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
        }

        private void btnAgregfactu_Click(object sender, EventArgs e)
        {
            AñadirFactura añadirFactura = new AñadirFactura();
            añadirFactura.ShowDialog();
        }
    }
}
