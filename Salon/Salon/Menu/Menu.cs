using Salon.Dashboard;
using Salon.Nomina;
using Salon.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Closemenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para abrir los formularios en el contenedor
        public void AbrirFormulario(Form formulario)
        {
            // Limpiar el panel antes de abrir un nuevo formulario
            if (Contenedormenu.Controls.Count > 0)
                Contenedormenu.Controls.RemoveAt(0);

            // Configurar el formulario para que no sea una ventana superior
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            // Añadir el formulario al panel
            Contenedormenu.Controls.Add(formulario);
            Contenedormenu.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Codigo para que la ventana se ajuste dinamicamente a cualquier pantalla


            Screen pantallaActual = Screen.FromControl(this);
            Rectangle resolucion = pantallaActual.WorkingArea;

            // Definir el tamaño máximo del formulario según la resolución de la pantalla actual
            this.MaximumSize = new Size(resolucion.Width, resolucion.Height);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados.Empleado empleados= new Empleados.Empleado();
            AbrirFormulario(empleados);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicio servicios = new Servicio();
            AbrirFormulario(servicios);
        }

     

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            Facturación.Facturación facturación = new Facturación.Facturación();
            AbrirFormulario(facturación);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            Rol.Roles Rol = new Rol.Roles();

            AbrirFormulario(Rol);
        }

        private void btnGastosFijos_Click(object sender, EventArgs e)
        {
            GastosFijos.GastoFijo GastoFijo = new GastosFijos.GastoFijo();
            AbrirFormulario(GastoFijo);
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {   
            Nomina.Nomina nomina = new Nomina.Nomina();

            AbrirFormulario(nomina);
        }

        private void Maxmenu_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Maxmenu.Image = Properties.Resources.copy_10532481;
            }
            else
            {
                this.WindowState= FormWindowState.Normal;
                Maxmenu.Image = Properties.Resources.icons8_cuadrado_23;
            }


            
        }

        private void Minmenu_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios.Usuarios usuarios = new Usuarios.Usuarios();
            AbrirFormulario(usuarios);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos.Productosc productosc=new Productos.Productosc();
            AbrirFormulario(productosc);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {   
            Dashboard.Dashboard dashboard=new Dashboard.Dashboard();
            AbrirFormulario(dashboard);
        }
    }
}
