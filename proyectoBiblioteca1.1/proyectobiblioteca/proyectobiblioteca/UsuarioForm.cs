using GymProject;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UsuarioForm : Form
    {
        BibliotecaEmersonContext db = new BibliotecaEmersonContext();
        Helper h = new Helper();
        int idUsuario = 0;
        public UsuarioForm()
        {
            InitializeComponent();
            CargarRoles();
            CargarUsuarios();
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtReContraseña.Text = "";
            cbRol.SelectedIndex = -1;
            idUsuario = 0;
            btnRegistrar.Text = "Registrar";
        }
        private void CargarRoles()
        {
            var roles = db.Rols.ToList();
            cbRol.DataSource = roles;
            cbRol.DisplayMember = "NombreRol";
            cbRol.ValueMember = "IdRol";
            cbRol.SelectedIndex = -1;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (txtNombre.Text.Trim() == "")
                error += "Debe ingresar el Nombre\n";
            if (txtApellido.Text.Trim() == "")
                error += "Debe ingresar el Apellido\n";
            if (txtCorreo.Text.Trim() == "")
                error += "Debe ingresar el Correo\n";
            else
                if (!h.ValidarEmail(txtCorreo.Text))
                error += "El Correo no tiene el formato correcto \n";
            if (txtContraseña.Text.Trim() == "")
                error += "Debe ingresar la Contraseña\n";
            else
                if (txtContraseña.Text.Trim() != txtReContraseña.Text.Trim())
                error += "Las contraseñas no coinciden\n";
            if (cbRol.SelectedIndex == -1)
                error += "Debe seleccionar Rol\n";
            if (error != "")
                MessageBox.Show(error, "Error Validación",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (idUsuario == 0)
                {
                    Usuario u = new Usuario();
                    u.Nombre = txtNombre.Text;
                    u.Apellido = txtApellido.Text;
                    u.Correo = txtCorreo.Text;
                    u.Contraseña = txtContraseña.Text;
                    u.IdRol = int.Parse(cbRol.SelectedValue.ToString());
                    db.Usuarios.Add(u);
                    MessageBox.Show("Usuario Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Usuario u = db.Usuarios.Find(idUsuario);
                    u.Nombre = txtNombre.Text;
                    u.Apellido = txtApellido.Text;
                    u.Correo = txtCorreo.Text;
                    u.Contraseña = txtContraseña.Text;
                    u.IdRol = int.Parse(cbRol.SelectedValue.ToString());
                    MessageBox.Show("Usuario Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                db.SaveChanges();
                Limpiar();
                CargarUsuarios();
            }
        }
        private void CargarUsuarios()
        {
            var usuarios = (from u in db.Usuarios
                            select new
                            {
                                u.IdUsuario,
                                u.IdRol,
                                u.Nombre,
                                u.Apellido,
                                u.Correo,
                                Rol = u.IdRolNavigation.NombreRol,
                                u.Contraseña,
                            }).ToList();
            dgvUsuario.DataSource = usuarios;
            dgvUsuario.Columns[0].Visible = false;
            dgvUsuario.Columns[1].Visible = false;
            dgvUsuario.Columns[6].Visible = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if(dgvUsuario.CurrentRow != null)
            {

            idUsuario = int.Parse(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
            cbRol.SelectedValue = int.Parse(dgvUsuario.CurrentRow.Cells[1].Value.ToString());
            txtNombre.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            txtContraseña.Text = dgvUsuario.CurrentRow.Cells[6].Value.ToString();
            btnRegistrar.Text = "Editar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuario > 0)
            {
                var resp = MessageBox.Show($"¿Desea eliminar el usuario {txtNombre.Text}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    var prestamo = db.Prestamos.FirstOrDefault(p => p.IdUsuario == idUsuario);
                    if (prestamo != null)
                    {
                        MessageBox.Show("No se puede eliminar el Usuario porque esta asignado a un prestamo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    var usuario = db.Usuarios.Find(idUsuario);
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                    Limpiar();
                    CargarUsuarios();
                    }
                }
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            var Correo = db.Usuarios.FirstOrDefault(x => x.Correo == txtCorreo.Text);
            if (Correo != null)
            {
                MessageBox.Show("El Correo ya se encuentra registrado");
                txtCorreo.Text = "";
            }
        }
    }
}
