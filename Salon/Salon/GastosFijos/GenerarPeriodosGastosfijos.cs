using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.GastosFijos
{
    public partial class GenerarPeriodosGastosfijos : Form
    {
        public GenerarPeriodosGastosfijos()
        {
            InitializeComponent();
        }

        private void CloseGenerarGastoFijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
