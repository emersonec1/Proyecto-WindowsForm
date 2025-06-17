namespace proyectobiblioteca
{
    partial class LectoresForm
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
            btnLimpiar = new Button();
            txtDireccion = new TextBox();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            label2 = new Label();
            dgvLectores = new DataGridView();
            label1 = new Label();
            txtFono = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbSexo = new ComboBox();
            txtRun = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvLectores).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(182, 197);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 42);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(247, 99);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 24;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(334, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 42);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(26, 197);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(113, 42);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 9);
            label2.Name = "label2";
            label2.Size = new Size(299, 40);
            label2.TabIndex = 21;
            label2.Text = "REGISTRO LECTORES";
            // 
            // dgvLectores
            // 
            dgvLectores.BackgroundColor = Color.White;
            dgvLectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLectores.Location = new Point(12, 245);
            dgvLectores.Name = "dgvLectores";
            dgvLectores.Size = new Size(491, 150);
            dgvLectores.TabIndex = 20;
            dgvLectores.MouseClick += dgvLectores_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 139);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 19;
            label1.Text = "Seleccione Sexo";
            // 
            // txtFono
            // 
            txtFono.Location = new Point(247, 70);
            txtFono.Name = "txtFono";
            txtFono.PlaceholderText = "Fono";
            txtFono.Size = new Size(200, 23);
            txtFono.TabIndex = 18;
            txtFono.KeyPress += txtFono_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(26, 157);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(200, 23);
            txtCorreo.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(26, 128);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 15;
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "Binario" });
            cbSexo.Location = new Point(247, 157);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(200, 23);
            cbSexo.TabIndex = 26;
            // 
            // txtRun
            // 
            txtRun.Location = new Point(26, 70);
            txtRun.MaxLength = 12;
            txtRun.Name = "txtRun";
            txtRun.PlaceholderText = "Run";
            txtRun.Size = new Size(200, 23);
            txtRun.TabIndex = 27;
            txtRun.TextChanged += txtRun_TextChanged;
            txtRun.Leave += txtRun_Leave;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // LectoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(516, 417);
            Controls.Add(txtRun);
            Controls.Add(cbSexo);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDireccion);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(dgvLectores);
            Controls.Add(label1);
            Controls.Add(txtFono);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "LectoresForm";
            Text = "LectoresForm";
            ((System.ComponentModel.ISupportInitialize)dgvLectores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private TextBox txtDireccion;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Label label2;
        private DataGridView dgvLectores;
        private Label label1;
        private TextBox txtFono;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cbSexo;
        private TextBox txtRun;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}