using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Login
{
    public partial class Presentacion: Form
    {
        private bool isPasswordVisible = false;


        public Presentacion()
        {
            InitializeComponent();

            // Asegúrate de que `textBox2` y `pictureBox3` sean los controles existentes en el diseñador
            TxtClave.PasswordChar = '*'; // Establecer como contraseña inicialmente
            pictureBox3.Image = Properties.Resources.Ojo_cerrado; // Imagen inicial

            // Asignar evento al PictureBox
            pictureBox3.Click += TogglePasswordVisibility;

            this.Load += new EventHandler(Presentacion_Load); // Asigna el evento Load

        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            // Codigo para que la ventana se ajuste dinamicamente a cualquier pantalla


            Screen pantallaActual = Screen.FromControl(this);
            Rectangle resolucion = pantallaActual.WorkingArea;

            // Definir el tamaño máximo del formulario según la resolución de la pantalla actual
            this.MaximumSize = new Size(resolucion.Width, resolucion.Height);
        }


        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            TxtClave.PasswordChar = isPasswordVisible ? '\0' : '*';
            pictureBox3.Image = isPasswordVisible ? Properties.Resources.Ojo_abierto : Properties.Resources.Ojo_cerrado;
        }

        private void LabelClave_Click(object sender, EventArgs e)
        {

        }
    }
}
