using GymProject;
using Microsoft.VisualBasic.ApplicationServices;
using proyectobiblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectobiblioteca
{
    public partial class LectoresForm : Form
    {
        BibliotecaEmersonContext db = new BibliotecaEmersonContext();
        Helper h = new Helper();
        int IdLector = 0;
        private int RolActivo;

        public LectoresForm(int idRol)
        {
            InitializeComponent();
            CargarLectores();
            RolActivo = idRol; //igualamos el rol activo(del usuario logeado) al idRol
            if (RolActivo != 1) //si el Rol es distinto a 1 (administrador) que oculte el boton de Eliminar Registros para cualquier otro rol que no sea el 1.
            {
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (txtRun.Text.Trim() == "")
                error += "Debe ingresar el Run\n";
            if (txtNombre.Text.Trim() == "")
                error += "Debe ingresar el Nombre \n";
            if (txtApellido.Text.Trim() == "")
                error += "Debe ingresar el Apellido\n";
            if (txtCorreo.Text.Trim() == "")
                error += "Debe ingresar el Correo\n";
            else
                if (!h.ValidarEmail(txtCorreo.Text))
                error += "El Email no tiene el formato correcto";
            if (txtFono.Text.Trim() == "")
                error += "Debe ingresar el Numero de Telefono\n";
            if (txtDireccion.Text.Trim() == "")
                error += "Debe ingresar Direccion\n";
            if (cbSexo.Text.Trim() == "")
                error += "Debe seleccionar una opción de Sexo\n";
            if (error != "")
                MessageBox.Show(error, "Error Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (IdLector == 0)
                {
                    Lector l = new Lector();
                    l.Run = txtRun.Text;
                    l.Nombre = txtNombre.Text;
                    l.Apellido = txtApellido.Text;
                    l.Email = txtCorreo.Text;
                    l.Fono = int.Parse(txtFono.Text);
                    l.Direccion = txtDireccion.Text;
                    l.Sexo = cbSexo.Text;
                    db.Lectors.Add(l);
                    MessageBox.Show("Lector Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Lector l = db.Lectors.Find(IdLector);
                    l.Run = txtRun.Text;
                    l.Nombre = txtNombre.Text;
                    l.Apellido = txtApellido.Text;
                    l.Email = txtCorreo.Text;
                    l.Fono = int.Parse(txtFono.Text);
                    l.Direccion = txtDireccion.Text;
                    l.Sexo = cbSexo.Text;
                    db.SaveChanges();
                    MessageBox.Show("Lector registrado con éxito");
                }
                db.SaveChanges();
                Limpiar();
                CargarLectores();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtRun.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtFono.Text = "";
            txtDireccion.Text = "";
            cbSexo.SelectedIndex = -1;
            IdLector = 0;
            btnRegistrar.Text = "Registrar";
        }

        private void txtFono_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }

        private void txtRun_TextChanged(object sender, EventArgs e)
        {
            if (txtRun.Text.Trim() != "" && txtRun.Text.Length > 1)
            {
                txtRun.Text = h.FormatearRun(txtRun.Text);
                //ubicamos el cursor siempre al final del texto
                txtRun.Select(txtRun.Text.Length, 0);
            }
        }

        private void txtRun_Leave(object sender, EventArgs e)
        {
            if (txtRun.Text.Trim() != "")
            {
                if (!h.ValidarRun(txtRun.Text))
                {
                    MessageBox.Show("El Run ingresado no es válido");
                    txtRun.Text = "";
                }
                else
                {
                    //FirstOrDefault trae el primero que encuentre
                    var Lector = db.Lectors.FirstOrDefault(x => x.Run == txtRun.Text);
                    //Si el Run es distinto de null, signifca que el run ya esta registrado
                    if (Lector != null)
                    {
                        MessageBox.Show("El Lector ya se encuentra registrado");
                        txtRun.Text = "";
                    }
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdLector > 0)
            {
                var resp = MessageBox.Show($"¿Desea eliminar el Lector {txtNombre.Text}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //si presiona sí, permite eliminar el regitro
                if (resp == DialogResult.Yes)
                {
                    var prestamo = db.Prestamos.FirstOrDefault(p => p.IdLector == IdLector);
                    if (prestamo != null)
                    {
                        MessageBox.Show("No se puede eliminar el Lector porque esta asignado a un prestamo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    //Find permite buscar por la clave primaria
                    var Lector = db.Lectors.Find(IdLector);
                    db.Lectors.Remove(Lector);
                    db.SaveChanges();
                    Limpiar();
                    CargarLectores();

                    }
                }
            }
        }
        private void CargarLectores()
        {
            //ToList trae todos los elementos de una tabla
            var Lector = (from l in db.Lectors
                          select new
                          {
                              l.IdLector,
                              l.Run,
                              l.Nombre,
                              l.Apellido,
                              l.Email,
                              l.Fono,
                              l.Direccion,
                              l.Sexo,
                              l.Prestamos,
                          }).ToList();
            //añadimos a la grilla los lectores seleccionados
            dgvLectores.DataSource = Lector;
            dgvLectores.Columns[0].Visible = false;
            dgvLectores.Columns[8].Visible = false;
        }
        private void dgvLectores_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvLectores.CurrentRow != null)
            {
                IdLector = int.Parse(dgvLectores.CurrentRow.Cells[0].Value.ToString());
                txtRun.Text = dgvLectores.CurrentRow.Cells[1].Value?.ToString();
                txtNombre.Text = dgvLectores.CurrentRow.Cells[2].Value?.ToString();
                txtApellido.Text = dgvLectores.CurrentRow.Cells[3].Value?.ToString();
                txtCorreo.Text = dgvLectores.CurrentRow.Cells[4].Value?.ToString();
                txtFono.Text = dgvLectores.CurrentRow.Cells[5].Value?.ToString();
                txtDireccion.Text = dgvLectores.CurrentRow.Cells[6].Value?.ToString();
                cbSexo.Text = dgvLectores.CurrentRow.Cells[7].Value?.ToString();
                btnRegistrar.Text = "Editar";
            }
        }
    }
}
