using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;

            string mensaje = "Apellido y Nombre: " + apellido + " " + nombre + " " + "Edad: " + edad + " " + "Direccion: " + direccion;
            txtResultado.Text = mensaje;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
