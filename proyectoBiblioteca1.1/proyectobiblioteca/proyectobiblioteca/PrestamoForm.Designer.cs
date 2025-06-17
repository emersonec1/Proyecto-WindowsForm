namespace proyectobiblioteca
{
    partial class PrestamoForm
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
            label1 = new Label();
            dtpFechaInicioP = new DateTimePicker();
            dtpFechaFinP = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvSolicitud = new DataGridView();
            btnIngresar = new Button();
            cbUsuario = new ComboBox();
            cbLector = new ComboBox();
            cbLibro = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitud).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 40);
            label1.TabIndex = 0;
            label1.Text = "SOLICITUD PRESTAMO";
            // 
            // dtpFechaInicioP
            // 
            dtpFechaInicioP.Checked = false;
            dtpFechaInicioP.Location = new Point(260, 81);
            dtpFechaInicioP.Name = "dtpFechaInicioP";
            dtpFechaInicioP.ShowCheckBox = true;
            dtpFechaInicioP.Size = new Size(215, 23);
            dtpFechaInicioP.TabIndex = 4;
            dtpFechaInicioP.ValueChanged += dtpFechaInicioP_ValueChanged;
            // 
            // dtpFechaFinP
            // 
            dtpFechaFinP.Checked = false;
            dtpFechaFinP.Location = new Point(260, 178);
            dtpFechaFinP.Name = "dtpFechaFinP";
            dtpFechaFinP.ShowCheckBox = true;
            dtpFechaFinP.Size = new Size(215, 23);
            dtpFechaFinP.TabIndex = 5;
            dtpFechaFinP.Value = new DateTime(2025, 6, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 63);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha Inicio Prestamo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 160);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha Termino Prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 334);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // dgvSolicitud
            // 
            dgvSolicitud.BackgroundColor = Color.White;
            dgvSolicitud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitud.Location = new Point(28, 280);
            dgvSolicitud.Name = "dgvSolicitud";
            dgvSolicitud.Size = new Size(450, 95);
            dgvSolicitud.TabIndex = 10;
            dgvSolicitud.MouseClick += dgvSolicitud_MouseClick;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(25, 220);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(109, 45);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar Solicitud";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(25, 83);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(215, 23);
            cbUsuario.TabIndex = 12;
            // 
            // cbLector
            // 
            cbLector.FormattingEnabled = true;
            cbLector.Location = new Point(25, 128);
            cbLector.Name = "cbLector";
            cbLector.Size = new Size(215, 23);
            cbLector.TabIndex = 13;
            // 
            // cbLibro
            // 
            cbLibro.FormattingEnabled = true;
            cbLibro.Location = new Point(25, 178);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(215, 23);
            cbLibro.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 63);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 15;
            label5.Text = "Usuario Prestamista";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 110);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 16;
            label6.Text = "Seleccione Lector";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 160);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 17;
            label7.Text = "Seleccione Libro";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 45);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(192, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 45);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // PrestamoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(502, 403);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbLibro);
            Controls.Add(cbLector);
            Controls.Add(cbUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(dgvSolicitud);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFechaFinP);
            Controls.Add(dtpFechaInicioP);
            Controls.Add(label1);
            Name = "PrestamoForm";
            Text = "PrestamoForm";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFechaInicioP;
        private DateTimePicker dtpFechaFinP;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvSolicitud;
        private Button btnIngresar;
        private ComboBox cbUsuario;
        private ComboBox cbLector;
        private ComboBox cbLibro;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}