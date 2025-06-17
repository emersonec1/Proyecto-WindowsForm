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
    public partial class LibrosForm : Form
    {
        BibliotecaEmersonContext db = new BibliotecaEmersonContext();
        Helper h = new Helper();
        int IdLibro = 0;
        private int RolActivo;
        public LibrosForm(int idRol)
        {
            InitializeComponent();
            CargarLibros();
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
            if (txtTitulo.Text.Trim() == "")
                error += "Debe ingresar el Titulo del Libro\n";
            if (txtAutor.Text.Trim() == "")
                error += "Debe ingresar el Autor\n";
            if (txtEditorial.Text.Trim() == "")
                error += "Debe ingresar la Editorial\n";
            if (txtISBN.Text.Trim() == "")
                error += "Debe ingresar el ISBN\n";
            if (txtAño.Text.Trim() == "")
                error += "Debe ingresar el Año de Publicación del Libro\n";
            if (error != "")
                MessageBox.Show(error, "Error Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (IdLibro == 0) //crear/registrar
                {
                    Libro libro = new Libro();
                    libro.Titulo = txtTitulo.Text;
                    libro.Autor = txtAutor.Text;
                    libro.Editorial = txtEditorial.Text;
                    libro.Isbn = txtISBN.Text;
                    libro.AñoPublicacion = int.Parse(txtAño.Text);
                    db.Libros.Add(libro);
                    MessageBox.Show("Libro Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Libro libro = db.Libros.Find(IdLibro);
                    libro.Titulo = txtTitulo.Text;
                    libro.Autor = txtAutor.Text;
                    libro.Editorial = txtEditorial.Text;
                    libro.Isbn = txtISBN.Text;
                    libro.AñoPublicacion = int.Parse(txtAño.Text);
                    MessageBox.Show("Libro Registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                db.SaveChanges();
                Limpiar();
                CargarLibros();
            }
        }
        private void CargarLibros()
        {
            var Libro = (from libro in db.Libros
                         select new
                         {
                             libro.IdLibro,
                             libro.Titulo,
                             libro.Autor,
                             libro.Editorial,
                             libro.Isbn,
                             libro.AñoPublicacion,
                             libro.Prestamos,
                         }).ToList();
            dgvLibros.DataSource = Libro;
            dgvLibros.Columns[0].Visible = false;
            dgvLibros.Columns[6].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtISBN.Text = "";
            txtAño.Text = "";
            IdLibro = 0;
            btnRegistrar.Text = "Registrar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdLibro > 0)
            {
                var resp = MessageBox.Show($"¿Desea eliminar el libro {txtTitulo.Text}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //si presiona sí, permite eliminar el regitro
                if (resp == DialogResult.Yes)
                {
                    var prestamo = db.Prestamos.FirstOrDefault(p => p.IdLibro == IdLibro);
                    if (prestamo != null)
                    {
                        MessageBox.Show("No se puede eliminar el Libro porque esta asignado a un prestamo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    var Libro = db.Libros.Find(IdLibro);
                    db.Libros.Remove(Libro);
                    db.SaveChanges();
                    Limpiar();
                    CargarLibros();

                    }
                }
            }
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {


            if (txtISBN.Text.Trim() != "")
            {
                var ISBN = db.Libros.FirstOrDefault(x => x.Isbn == txtISBN.Text);
                if (ISBN != null)
                {
                    MessageBox.Show("El ISBN ya se encuentra registrado");
                    txtISBN.Text = "";
                }
            }
        }
        private void dgvLibros_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                IdLibro = int.Parse(dgvLibros.CurrentRow.Cells[0].Value.ToString());
                txtTitulo.Text = dgvLibros.CurrentRow.Cells[1].Value.ToString();
                txtAutor.Text = dgvLibros.CurrentRow.Cells[2].Value.ToString();
                txtEditorial.Text = dgvLibros.CurrentRow.Cells[3].Value.ToString();
                txtISBN.Text = dgvLibros.CurrentRow.Cells[4].Value.ToString();
                txtAño.Text = dgvLibros.CurrentRow.Cells[5].Value.ToString();
                btnRegistrar.Text = "Editar";
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }
    }
}
