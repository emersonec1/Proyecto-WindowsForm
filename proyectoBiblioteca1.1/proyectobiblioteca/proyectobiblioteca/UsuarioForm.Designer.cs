namespace proyectobiblioteca
{
    partial class UsuarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbRol = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            dgvUsuario = new DataGridView();
            label2 = new Label();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            txtReContraseña = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(36, 74);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(193, 23);
            cbRol.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(36, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(193, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(307, 74);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(193, 23);
            txtCorreo.TabIndex = 3;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(307, 103);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(193, 23);
            txtContraseña.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 56);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 6;
            label1.Text = "Seleccione Rol";
            // 
            // dgvUsuario
            // 
            dgvUsuario.BackgroundColor = Color.White;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(36, 223);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(464, 99);
            dgvUsuario.TabIndex = 7;
            dgvUsuario.MouseClick += dgvUsuario_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(130, 9);
            label2.Name = "label2";
            label2.Size = new Size(290, 40);
            label2.TabIndex = 8;
            label2.Text = "REGISTRO USUARIO";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(36, 176);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(99, 41);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(401, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 43);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtReContraseña
            // 
            txtReContraseña.Location = new Point(307, 132);
            txtReContraseña.Name = "txtReContraseña";
            txtReContraseña.PasswordChar = '*';
            txtReContraseña.PlaceholderText = "Reingrese Contraseña";
            txtReContraseña.Size = new Size(193, 23);
            txtReContraseña.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(228, 176);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 43);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(535, 352);
            Controls.Add(btnLimpiar);
            Controls.Add(txtReContraseña);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(dgvUsuario);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cbRol);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRol;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label label1;
        private DataGridView dgvUsuario;
        private Label label2;
        private Button btnRegistrar;
        private Button btnEliminar;
        private TextBox txtReContraseña;
        private Button btnLimpiar;
    }
}