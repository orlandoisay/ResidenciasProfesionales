namespace ResidenciasProfesionales.VIEW
{
    partial class FrmControlDocumentacion
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
            this.spnCalificacionFinal = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblCalificacionFinal = new System.Windows.Forms.Label();
            this.tablaDocumentos = new System.Windows.Forms.DataGridView();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.tablaAlumnos = new System.Windows.Forms.DataGridView();
            this.noControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtaComentario = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spnCalificacionFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // spnCalificacionFinal
            // 
            this.spnCalificacionFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spnCalificacionFinal.Enabled = false;
            this.spnCalificacionFinal.Location = new System.Drawing.Point(677, 364);
            this.spnCalificacionFinal.Name = "spnCalificacionFinal";
            this.spnCalificacionFinal.Size = new System.Drawing.Size(45, 20);
            this.spnCalificacionFinal.TabIndex = 13;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(522, 407);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(200, 23);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblCalificacionFinal
            // 
            this.lblCalificacionFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalificacionFinal.AutoSize = true;
            this.lblCalificacionFinal.Location = new System.Drawing.Point(562, 367);
            this.lblCalificacionFinal.Name = "lblCalificacionFinal";
            this.lblCalificacionFinal.Size = new System.Drawing.Size(118, 13);
            this.lblCalificacionFinal.TabIndex = 11;
            this.lblCalificacionFinal.Text = "CALIFICACIÓN FINAL: ";
            this.lblCalificacionFinal.Click += new System.EventHandler(this.lblCalificacionFinal_Click);
            // 
            // tablaDocumentos
            // 
            this.tablaDocumentos.AllowUserToAddRows = false;
            this.tablaDocumentos.AllowUserToDeleteRows = false;
            this.tablaDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documento,
            this.entregado});
            this.tablaDocumentos.Location = new System.Drawing.Point(12, 203);
            this.tablaDocumentos.Name = "tablaDocumentos";
            this.tablaDocumentos.Size = new System.Drawing.Size(710, 155);
            this.tablaDocumentos.TabIndex = 10;
            this.tablaDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDocumentos_CellClick);
            // 
            // documento
            // 
            this.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            // 
            // entregado
            // 
            this.entregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.entregado.HeaderText = "Entregado";
            this.entregado.Name = "entregado";
            this.entregado.Width = 62;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(12, 178);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(59, 13);
            this.lblNombreAlumno.TabIndex = 9;
            this.lblNombreAlumno.Text = "ALUMNO: ";
            // 
            // tablaAlumnos
            // 
            this.tablaAlumnos.AllowUserToAddRows = false;
            this.tablaAlumnos.AllowUserToDeleteRows = false;
            this.tablaAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControl,
            this.nombre,
            this.asesor});
            this.tablaAlumnos.Location = new System.Drawing.Point(12, 11);
            this.tablaAlumnos.Name = "tablaAlumnos";
            this.tablaAlumnos.ReadOnly = true;
            this.tablaAlumnos.Size = new System.Drawing.Size(710, 155);
            this.tablaAlumnos.TabIndex = 8;
            this.tablaAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAlumnos_CellClick);
            // 
            // noControl
            // 
            this.noControl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.noControl.HeaderText = "No. control";
            this.noControl.Name = "noControl";
            this.noControl.ReadOnly = true;
            this.noControl.Width = 84;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // asesor
            // 
            this.asesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asesor.HeaderText = "Asesor";
            this.asesor.Name = "asesor";
            this.asesor.ReadOnly = true;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(12, 367);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(145, 13);
            this.lblComentario.TabIndex = 14;
            this.lblComentario.Text = "COMENTARIO (OPCIONAL):";
            // 
            // txtaComentario
            // 
            this.txtaComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaComentario.Location = new System.Drawing.Point(12, 388);
            this.txtaComentario.Name = "txtaComentario";
            this.txtaComentario.Size = new System.Drawing.Size(480, 56);
            this.txtaComentario.TabIndex = 15;
            this.txtaComentario.Text = "";
            // 
            // FrmControlDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.txtaComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.spnCalificacionFinal);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblCalificacionFinal);
            this.Controls.Add(this.tablaDocumentos);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.tablaAlumnos);
            this.Name = "FrmControlDocumentacion";
            this.Text = "FrmControlDocumentacion";
            ((System.ComponentModel.ISupportInitialize)(this.spnCalificacionFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spnCalificacionFinal;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblCalificacionFinal;
        private System.Windows.Forms.DataGridView tablaDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn entregado;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.DataGridView tablaAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn asesor;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.RichTextBox txtaComentario;
    }
}