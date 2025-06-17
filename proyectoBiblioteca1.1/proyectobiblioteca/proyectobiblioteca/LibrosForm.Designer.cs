namespace proyectobiblioteca
{
    partial class LibrosForm
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
            txtTitulo = new TextBox();
            label2 = new Label();
            dgvLibros = new DataGridView();
            txtAño = new TextBox();
            txtISBN = new TextBox();
            txtEditorial = new TextBox();
            txtAutor = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 66);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Titulo";
            txtTitulo.Size = new Size(200, 23);
            txtTitulo.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(121, 9);
            label2.Name = "label2";
            label2.Size = new Size(263, 40);
            label2.TabIndex = 33;
            label2.Text = "REGISTRO LIBROS";
            // 
            // dgvLibros
            // 
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(12, 214);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(518, 150);
            dgvLibros.TabIndex = 32;
            dgvLibros.MouseClick += dgvLibros_MouseClick;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(12, 182);
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "Año Publicacion";
            txtAño.Size = new Size(200, 23);
            txtAño.TabIndex = 31;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(12, 153);
            txtISBN.Name = "txtISBN";
            txtISBN.PlaceholderText = "ISBN";
            txtISBN.Size = new Size(200, 23);
            txtISBN.TabIndex = 30;
            txtISBN.Leave += txtISBN_Leave;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(12, 124);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.PlaceholderText = "Editorial";
            txtEditorial.Size = new Size(200, 23);
            txtEditorial.TabIndex = 29;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(12, 95);
            txtAutor.Name = "txtAutor";
            txtAutor.PlaceholderText = "Autor";
            txtAutor.Size = new Size(200, 23);
            txtAutor.TabIndex = 28;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(246, 116);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 37);
            btnLimpiar.TabIndex = 37;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(246, 167);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 38);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(246, 66);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(124, 37);
            btnRegistrar.TabIndex = 35;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // LibrosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(542, 379);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(dgvLibros);
            Controls.Add(txtAño);
            Controls.Add(txtISBN);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Name = "LibrosForm";
            Text = "LibrosForm";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private DataGridView dgvLibros;
        private TextBox txtAño;
        private TextBox txtISBN;
        private TextBox txtEditorial;
        private TextBox txtAutor;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnRegistrar;
    }
}