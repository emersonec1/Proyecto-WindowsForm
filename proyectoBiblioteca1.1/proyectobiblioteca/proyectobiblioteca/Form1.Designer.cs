namespace proyectobiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblTitulo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelizq = new Panel();
            btnPrestamo = new Button();
            btnLibros = new Button();
            btnLectores = new Button();
            btnUsuarios = new Button();
            panelContent = new Panel();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            panelizq.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.MediumAquamarine;
            panelTop.Controls.Add(lblTitulo);
            panelTop.Controls.Add(panel1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(764, 100);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(206, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido al Sistema";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 0;
            label1.Text = "BibliotecAPP";
            // 
            // panelizq
            // 
            panelizq.BackColor = Color.MediumAquamarine;
            panelizq.Controls.Add(btnPrestamo);
            panelizq.Controls.Add(btnLibros);
            panelizq.Controls.Add(btnLectores);
            panelizq.Controls.Add(btnUsuarios);
            panelizq.Dock = DockStyle.Left;
            panelizq.Location = new Point(0, 100);
            panelizq.Name = "panelizq";
            panelizq.Size = new Size(200, 426);
            panelizq.TabIndex = 1;
            // 
            // btnPrestamo
            // 
            btnPrestamo.BackColor = Color.MediumSpringGreen;
            btnPrestamo.Dock = DockStyle.Top;
            btnPrestamo.Location = new Point(0, 189);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(200, 63);
            btnPrestamo.TabIndex = 3;
            btnPrestamo.Text = "Prestamos";
            btnPrestamo.UseVisualStyleBackColor = false;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.MediumSpringGreen;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.Location = new Point(0, 126);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(200, 63);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnLectores
            // 
            btnLectores.BackColor = Color.MediumSpringGreen;
            btnLectores.Dock = DockStyle.Top;
            btnLectores.Location = new Point(0, 63);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(200, 63);
            btnLectores.TabIndex = 1;
            btnLectores.Text = "Lectores";
            btnLectores.UseVisualStyleBackColor = false;
            btnLectores.Click += btnLectores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.MediumSpringGreen;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(200, 63);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Honeydew;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 100);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(564, 426);
            panelContent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 526);
            Controls.Add(panelContent);
            Controls.Add(panelizq);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelizq.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelizq;
        private Panel panelContent;
        private Button btnPrestamo;
        private Button btnLibros;
        private Button btnLectores;
        private Button btnUsuarios;
        private Label lblTitulo;
        private Panel panel1;
        private Label label1;
    }
}
