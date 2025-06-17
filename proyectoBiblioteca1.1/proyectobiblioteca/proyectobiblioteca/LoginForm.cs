using GymProject;
using proyectobiblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectobiblioteca
{
    public partial class LoginForm : Form
    {
        BibliotecaEmersonContext db = new BibliotecaEmersonContext();
        Helper h = new Helper();
        public static int idRol;
        public static int idUsuario;
        public static string nombre;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Logear()
        {
            string error = "";
            if (txtCorreo.Text.Trim() == "")
                error = "Debe ingresar Email \n";
            else
                if (!h.ValidarEmail(txtCorreo.Text.Trim()))
                error = "Email no tiene el formato correcto \n";
            if (txtContraseña.Text.Trim() == "")
                error += "Debe ingresar Contraseña \n";
            if (error != "")
                MessageBox.Show(error, "Error Validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var Usuario = db.Usuarios.FirstOrDefault(x => x.Correo == txtCorreo.Text &&
                        x.Contraseña == txtContraseña.Text);
                if (Usuario != null)
                {
                    //asignar variables
                    idUsuario = Usuario.IdUsuario;
                    idRol = Usuario.IdRol;
                    nombre = Usuario.Nombre;
                    MessageBox.Show($"Bienvenido {Usuario.Nombre}", "Ingreso exitoso");
                    Form1 form = new Form1();
                    //abre el nuevo formulario
                    form.Show();
                    //oculta la ventana actual
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email y/o Contraseña incorrecta", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logear();
            }
        }
    }
}
