using GymProject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace proyectobiblioteca
{
    public partial class PrestamoForm : Form
    {
        BibliotecaEmersonContext db = new BibliotecaEmersonContext();
        Helper h = new Helper();
        int idPrestamo = 0;
        private int UsuarioActivo;
        private int RolActivo;
        public PrestamoForm(int idUsuario, int idRol)
        {
            InitializeComponent();
            UsuarioActivo = idUsuario;
            CargarDatos();
            CargarPrestamo();
            fechacorrecta();
            dtpFechaInicioP.MinDate = DateTime.Now;
            dtpFechaFinP.MinDate = DateTime.Now;
            cbUsuario.SelectedValue = UsuarioActivo; //selecciona automaticamente el usuario logeado
            cbUsuario.Enabled = false; //desactivar lista del cb ya que el dato se obtiene cuando el usuario se logea
            RolActivo = idRol; //igualamos el rol activo(del usuario logeado) al idRol
            if (RolActivo != 1) //si el Rol es distinto a 1 (administrador) que oculte el boton de Eliminar Registros para cualquier otro rol que no sea el 1.
            {
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;
            }
        }
        public void CargarDatos() //cargar datos ingresados en las otras tablas en los combobox del formulario prestamo
        {
            var usuario = db.Usuarios.ToList();
            cbUsuario.DataSource = usuario;
            cbUsuario.ValueMember = "IdUsuario";
            cbUsuario.DisplayMember = "Nombre";
            cbUsuario.SelectedIndex = -1;

            var lector = db.Lectors.ToList();
            cbLector.DataSource = lector;
            cbLector.ValueMember = "IdLector";
            cbLector.DisplayMember = "Nombre";
            cbLector.SelectedIndex = -1;

            var libro = db.Libros.ToList();
            cbLibro.DataSource = libro;
            cbLibro.ValueMember = "IdLibro";
            cbLibro.DisplayMember = "Titulo";
            cbLibro.SelectedIndex = -1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (cbUsuario.SelectedIndex == -1)
                error += "Debe seleccionar el Usuario\n";
            if (cbLector.SelectedIndex == -1)
                error += "Debe seleccionar el Lector\n";
            if (cbLibro.SelectedIndex == -1)
                error += "Debe seleccionar el Libro\n";
            if (!dtpFechaInicioP.Checked) //validar checkbox de los datetimepicker
                error += "Debe seleccionar la Fecha de Inicio del Préstamo\n";
            if (!dtpFechaFinP.Checked)
                error += "Debe seleccionar la Fecha de Fin del Préstamo\n";
            if (error != "")
                MessageBox.Show(error, "Error Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Prestamo p = new Prestamo();
                p.IdUsuario = int.Parse(cbUsuario.SelectedValue.ToString());
                p.IdLector = int.Parse(cbLector.SelectedValue.ToString());
                p.IdLibro = int.Parse(cbLibro.SelectedValue.ToString());
                p.FechaPrestamo = DateOnly.Parse(dtpFechaInicioP.Text);
                p.FechaDevolucion = DateOnly.Parse(dtpFechaFinP.Text);
                db.Prestamos.Add(p);
                MessageBox.Show("Solicitud Registrada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.SaveChanges();
            CargarPrestamo();
            Limpiar();
        }
        private void Limpiar()
        {
            cbLector.Text = "";
            cbLibro.Text = "";
            dtpFechaInicioP.Text = "";
            dtpFechaFinP.Text = "";
            idPrestamo = 0;
            btnIngresar.Text = "Ingresar Solicitud";
        }
        public void CargarPrestamo()
        {
            var prestamo = (from p in db.Prestamos
                            select new
                            {
                                p.IdPrestamo,
                                NombreUsuario = p.IdUsuarioNavigation.Nombre,
                                NombreLector = p.IdLectorNavigation.Nombre,
                                NombreLibro = p.IdLibroNavigation.Titulo,
                                p.FechaPrestamo,
                                p.FechaDevolucion,
                                p.IdLibro,
                                p.IdUsuario,
                                p.IdLector,
                            }).ToList();
            dgvSolicitud.DataSource = prestamo;
            dgvSolicitud.Columns[6].Visible = false;
            dgvSolicitud.Columns[7].Visible = false;
            dgvSolicitud.Columns[8].Visible = false;
        }

        private void dtpFechaInicioP_ValueChanged(object sender, EventArgs e)
        //funcion que al momento de cambiar el valor de la fecha de inicio, la fecha de fin no sea la misma que la de inicio, saltandose al dia siguiente.
        {
            fechacorrecta();
        }
        public void fechacorrecta()
        {
            dtpFechaFinP.MinDate = dtpFechaInicioP.Value.AddDays(1);

            if (dtpFechaFinP.Value < dtpFechaFinP.MinDate)
            {
                dtpFechaFinP.Value = dtpFechaFinP.MinDate;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPrestamo > 0)
            {
                var resp = MessageBox.Show($"¿Desea eliminar el Prestamo N°{idPrestamo}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    var prestamo = db.Prestamos.Find(idPrestamo);
                    db.Prestamos.Remove(prestamo);
                    db.SaveChanges();
                    CargarPrestamo();
                }
            }
        }

        private void dgvSolicitud_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvSolicitud.CurrentRow != null)
            {
                CargarDatos(); //referenciar al metodo para asegurar que los datos siempre esten cargados
                idPrestamo = int.Parse(dgvSolicitud.CurrentRow.Cells[0].Value.ToString());
                if (RolActivo == 1)
                    cbUsuario.SelectedValue = int.Parse(dgvSolicitud.CurrentRow.Cells[7].Value.ToString());
                else
                    cbUsuario.SelectedValue = UsuarioActivo;
                cbLector.SelectedValue = int.Parse(dgvSolicitud.CurrentRow.Cells[8].Value.ToString());
                cbLibro.SelectedValue = int.Parse(dgvSolicitud.CurrentRow.Cells[6].Value.ToString());

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
