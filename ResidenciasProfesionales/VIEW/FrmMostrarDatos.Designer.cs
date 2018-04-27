namespace ResidenciasProfesionales.VIEW
{
    partial class FrmMostrarDatos
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
            this.panelAsesor = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreAsesor = new System.Windows.Forms.Label();
            this.cbxAsesor = new System.Windows.Forms.ComboBox();
            this.lblCarreraAsesor = new System.Windows.Forms.Label();
            this.lblTelefonoAsesor = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCorreoAsesor = new System.Windows.Forms.Label();
            this.lblNumeroAsesorados = new System.Windows.Forms.Label();
            this.lblEstatusAsesor = new System.Windows.Forms.Label();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.lblNumeroSS = new System.Windows.Forms.Label();
            this.lblTipoSS = new System.Windows.Forms.Label();
            this.pbFotografía = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblNoControl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarreraAlumno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.panelAsesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografía)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAsesor
            // 
            this.panelAsesor.Controls.Add(this.lblUsuario);
            this.panelAsesor.Controls.Add(this.pictureBox1);
            this.panelAsesor.Controls.Add(this.btnCancelar);
            this.panelAsesor.Controls.Add(this.lblNombreAsesor);
            this.panelAsesor.Controls.Add(this.cbxAsesor);
            this.panelAsesor.Controls.Add(this.lblCarreraAsesor);
            this.panelAsesor.Controls.Add(this.lblTelefonoAsesor);
            this.panelAsesor.Controls.Add(this.btnAceptar);
            this.panelAsesor.Controls.Add(this.lblCorreoAsesor);
            this.panelAsesor.Controls.Add(this.lblNumeroAsesorados);
            this.panelAsesor.Controls.Add(this.lblEstatusAsesor);
            this.panelAsesor.Location = new System.Drawing.Point(12, 220);
            this.panelAsesor.Name = "panelAsesor";
            this.panelAsesor.Size = new System.Drawing.Size(460, 205);
            this.panelAsesor.TabIndex = 22;
            this.panelAsesor.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(47, 154);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreAsesor
            // 
            this.lblNombreAsesor.AutoSize = true;
            this.lblNombreAsesor.Location = new System.Drawing.Point(129, 18);
            this.lblNombreAsesor.Name = "lblNombreAsesor";
            this.lblNombreAsesor.Size = new System.Drawing.Size(45, 13);
            this.lblNombreAsesor.TabIndex = 10;
            this.lblNombreAsesor.Text = "Asesor: ";
            // 
            // cbxAsesor
            // 
            this.cbxAsesor.FormattingEnabled = true;
            this.cbxAsesor.Location = new System.Drawing.Point(180, 15);
            this.cbxAsesor.Name = "cbxAsesor";
            this.cbxAsesor.Size = new System.Drawing.Size(277, 21);
            this.cbxAsesor.TabIndex = 18;
            this.cbxAsesor.SelectedIndexChanged += new System.EventHandler(this.cbxAsesor_SelectedIndexChanged);
            // 
            // lblCarreraAsesor
            // 
            this.lblCarreraAsesor.AutoSize = true;
            this.lblCarreraAsesor.Location = new System.Drawing.Point(129, 41);
            this.lblCarreraAsesor.Name = "lblCarreraAsesor";
            this.lblCarreraAsesor.Size = new System.Drawing.Size(47, 13);
            this.lblCarreraAsesor.TabIndex = 11;
            this.lblCarreraAsesor.Text = "Carrera: ";
            // 
            // lblTelefonoAsesor
            // 
            this.lblTelefonoAsesor.AutoSize = true;
            this.lblTelefonoAsesor.Location = new System.Drawing.Point(38, 109);
            this.lblTelefonoAsesor.Name = "lblTelefonoAsesor";
            this.lblTelefonoAsesor.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonoAsesor.TabIndex = 12;
            this.lblTelefonoAsesor.Text = "Telefono: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 179);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCorreoAsesor
            // 
            this.lblCorreoAsesor.AutoSize = true;
            this.lblCorreoAsesor.Location = new System.Drawing.Point(49, 132);
            this.lblCorreoAsesor.Name = "lblCorreoAsesor";
            this.lblCorreoAsesor.Size = new System.Drawing.Size(44, 13);
            this.lblCorreoAsesor.TabIndex = 13;
            this.lblCorreoAsesor.Text = "Correo: ";
            // 
            // lblNumeroAsesorados
            // 
            this.lblNumeroAsesorados.AutoSize = true;
            this.lblNumeroAsesorados.Location = new System.Drawing.Point(129, 83);
            this.lblNumeroAsesorados.Name = "lblNumeroAsesorados";
            this.lblNumeroAsesorados.Size = new System.Drawing.Size(121, 13);
            this.lblNumeroAsesorados.TabIndex = 15;
            this.lblNumeroAsesorados.Text = "Asesorados a su cargo: ";
            // 
            // lblEstatusAsesor
            // 
            this.lblEstatusAsesor.AutoSize = true;
            this.lblEstatusAsesor.Location = new System.Drawing.Point(128, 62);
            this.lblEstatusAsesor.Name = "lblEstatusAsesor";
            this.lblEstatusAsesor.Size = new System.Drawing.Size(48, 13);
            this.lblEstatusAsesor.TabIndex = 14;
            this.lblEstatusAsesor.Text = "Estatus: ";
            // 
            // panelAlumno
            // 
            this.panelAlumno.Controls.Add(this.lblSemestre);
            this.panelAlumno.Controls.Add(this.lblNumeroSS);
            this.panelAlumno.Controls.Add(this.lblTipoSS);
            this.panelAlumno.Controls.Add(this.pbFotografía);
            this.panelAlumno.Controls.Add(this.btnCerrar);
            this.panelAlumno.Controls.Add(this.btnAnterior);
            this.panelAlumno.Controls.Add(this.btnAsignar);
            this.panelAlumno.Controls.Add(this.btnSiguiente);
            this.panelAlumno.Controls.Add(this.lblNoControl);
            this.panelAlumno.Controls.Add(this.lblNombre);
            this.panelAlumno.Controls.Add(this.lblCarreraAlumno);
            this.panelAlumno.Controls.Add(this.lblTelefono);
            this.panelAlumno.Controls.Add(this.lblCorreo);
            this.panelAlumno.Controls.Add(this.lblEstatus);
            this.panelAlumno.Location = new System.Drawing.Point(12, 12);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(460, 205);
            this.panelAlumno.TabIndex = 21;
            this.panelAlumno.Visible = false;
            // 
            // lblNumeroSS
            // 
            this.lblNumeroSS.AutoSize = true;
            this.lblNumeroSS.Location = new System.Drawing.Point(245, 131);
            this.lblNumeroSS.MaximumSize = new System.Drawing.Size(0, 50);
            this.lblNumeroSS.Name = "lblNumeroSS";
            this.lblNumeroSS.Size = new System.Drawing.Size(67, 13);
            this.lblNumeroSS.TabIndex = 22;
            this.lblNumeroSS.Text = "Número SS: ";
            // 
            // lblTipoSS
            // 
            this.lblTipoSS.AutoSize = true;
            this.lblTipoSS.Location = new System.Drawing.Point(245, 109);
            this.lblTipoSS.MaximumSize = new System.Drawing.Size(0, 50);
            this.lblTipoSS.Name = "lblTipoSS";
            this.lblTipoSS.Size = new System.Drawing.Size(51, 13);
            this.lblTipoSS.TabIndex = 21;
            this.lblTipoSS.Text = "Tipo SS: ";
            // 
            // pbFotografía
            // 
            this.pbFotografía.BackColor = System.Drawing.Color.Gray;
            this.pbFotografía.Location = new System.Drawing.Point(14, 16);
            this.pbFotografía.Name = "pbFotografía";
            this.pbFotografía.Size = new System.Drawing.Size(80, 80);
            this.pbFotografía.TabIndex = 20;
            this.pbFotografía.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(357, 179);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(3, 179);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 23);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(109, 179);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 23);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(215, 179);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Location = new System.Drawing.Point(110, 17);
            this.lblNoControl.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(65, 13);
            this.lblNoControl.TabIndex = 4;
            this.lblNoControl.Text = "No. control: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(125, 39);
            this.lblNombre.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblCarreraAlumno
            // 
            this.lblCarreraAlumno.AutoSize = true;
            this.lblCarreraAlumno.Location = new System.Drawing.Point(128, 61);
            this.lblCarreraAlumno.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblCarreraAlumno.Name = "lblCarreraAlumno";
            this.lblCarreraAlumno.Size = new System.Drawing.Size(47, 13);
            this.lblCarreraAlumno.TabIndex = 6;
            this.lblCarreraAlumno.Text = "Carrera: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(39, 109);
            this.lblTelefono.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(50, 153);
            this.lblCorreo.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(44, 13);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo: ";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(128, 83);
            this.lblEstatus.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(48, 13);
            this.lblEstatus.TabIndex = 9;
            this.lblEstatus.Text = "Estatus: ";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(37, 131);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(57, 13);
            this.lblSemestre.TabIndex = 23;
            this.lblSemestre.Text = "Semestre: ";
            // 
            // FrmMostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 436);
            this.Controls.Add(this.panelAsesor);
            this.Controls.Add(this.panelAlumno);
            this.Name = "FrmMostrarDatos";
            this.Text = "FrmMostrarDatos";
            this.panelAsesor.ResumeLayout(false);
            this.panelAsesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografía)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAsesor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreAsesor;
        private System.Windows.Forms.ComboBox cbxAsesor;
        private System.Windows.Forms.Label lblCarreraAsesor;
        private System.Windows.Forms.Label lblTelefonoAsesor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCorreoAsesor;
        private System.Windows.Forms.Label lblNumeroAsesorados;
        private System.Windows.Forms.Label lblEstatusAsesor;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNoControl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarreraAlumno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbFotografía;
        private System.Windows.Forms.Label lblNumeroSS;
        private System.Windows.Forms.Label lblTipoSS;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSemestre;
    }
}