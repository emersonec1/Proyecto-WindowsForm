namespace proyectobiblioteca
{
    public partial class Form1 : Form
    {
        Form formActivo;
        Button btnActivo;
        public Form1()
        {
            InitializeComponent();
            lblTitulo.Text = $"Bienvenido {LoginForm.nombre}";
            if (LoginForm.idRol != 1) 
                //si el idrol que tenga el usuario que logea en el programa es diferente a 1 (administrador) le oculte los siguientes botones
            {
                btnUsuarios.Visible = false;

            }
        }
        private void abrirForm(Form formHijo, object sender, string nombre)
        {
            //si tenemos un formulario activo, que lo cierre
            if (formActivo != null)
                formActivo.Close();
            //asignamos al form activo el hijo
            formActivo = formHijo;
            //le añadimos propiedades
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            //se muestra el formulario hijo en el centro
            panelContent.Controls.Add(formHijo);
            panelContent.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            lblTitulo.Text = nombre;
            botonActivado(sender);
        }
        private void botonActivado(object sender)
        {
            if (sender != null)
            {
                //verificamos si hay botón activo
                if(btnActivo != (Button)sender)
                {
                    botonDesactivado();
                    //backColor cambia el color de fondo
                    btnActivo = (Button)sender;
                    btnActivo.BackColor = Color.MediumSeaGreen;
                    //forecolor cambia el color de letra
                    btnActivo.ForeColor = Color.Black;
                }
            }
        }
        private void botonDesactivado()
        {
            //recorremos todos los elementos del panel menú (botones)
            foreach (Control btn in panelizq.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.MediumSpringGreen;
                    btn.ForeColor = Color.Black;
                }
            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new UsuarioForm(), sender, "Gestión de Usuarios");
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            abrirForm(new LectoresForm(LoginForm.idRol), sender, "Gestión de Lectores");

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            abrirForm(new LibrosForm(LoginForm.idRol), sender, "Gestión de Libros");

        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            abrirForm(new PrestamoForm(LoginForm.idUsuario, LoginForm.idRol), sender, "Registro de Prestamo");
        }
    }
}

