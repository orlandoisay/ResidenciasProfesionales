namespace ResidenciasProfesionales.VIEW
{
    partial class FrmLiberacionFinalDetalle
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
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtSemestre = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNoControl = new System.Windows.Forms.Label();
            this.pbFotografía = new System.Windows.Forms.PictureBox();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.spnCal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografía)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.Location = new System.Drawing.Point(327, 373);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(82, 35);
            this.btnEvaluar.TabIndex = 45;
            this.btnEvaluar.Text = "Liberar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarios.Location = new System.Drawing.Point(18, 182);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(391, 128);
            this.txtComentarios.TabIndex = 44;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(14, 160);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(80, 17);
            this.lblComentarios.TabIndex = 43;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // txtSemestre
            // 
            this.txtSemestre.AutoSize = true;
            this.txtSemestre.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemestre.Location = new System.Drawing.Point(206, 122);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(18, 17);
            this.txtSemestre.TabIndex = 42;
            this.txtSemestre.Text = "--";
            // 
            // txtCarrera
            // 
            this.txtCarrera.AutoSize = true;
            this.txtCarrera.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(206, 102);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(18, 17);
            this.txtCarrera.TabIndex = 41;
            this.txtCarrera.Text = "--";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(206, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(18, 17);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.Text = "--";
            // 
            // txtNoControl
            // 
            this.txtNoControl.AutoSize = true;
            this.txtNoControl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoControl.Location = new System.Drawing.Point(206, 62);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(18, 17);
            this.txtNoControl.TabIndex = 39;
            this.txtNoControl.Text = "--";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(134, 122);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(62, 17);
            this.lblSemestre.TabIndex = 38;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(143, 102);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(50, 17);
            this.lblCarrera.TabIndex = 37;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(138, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoControl.Location = new System.Drawing.Point(119, 62);
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(74, 17);
            this.lblNoControl.TabIndex = 35;
            this.lblNoControl.Text = "No. Control:";
            // 
            // pbFotografía
            // 
            this.pbFotografía.BackColor = System.Drawing.Color.Gray;
            this.pbFotografía.Location = new System.Drawing.Point(18, 63);
            this.pbFotografía.Name = "pbFotografía";
            this.pbFotografía.Size = new System.Drawing.Size(80, 80);
            this.pbFotografía.TabIndex = 34;
            this.pbFotografía.TabStop = false;
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblSolicitud.Location = new System.Drawing.Point(12, 9);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(284, 32);
            this.lblSolicitud.TabIndex = 33;
            this.lblSolicitud.Text = "Liberación de informe final";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(12, 335);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(73, 17);
            this.lblCalificacion.TabIndex = 46;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // spnCal
            // 
            this.spnCal.AllowDrop = true;
            this.spnCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spnCal.Location = new System.Drawing.Point(91, 336);
            this.spnCal.Name = "spnCal";
            this.spnCal.Size = new System.Drawing.Size(40, 20);
            this.spnCal.TabIndex = 47;
            // 
            // FrmLiberacionFinalDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 420);
            this.Controls.Add(this.spnCal);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNoControl);
            this.Controls.Add(this.pbFotografía);
            this.Controls.Add(this.lblSolicitud);
            this.Name = "FrmLiberacionFinalDetalle";
            this.Text = "Liberación de informe final";
            this.Load += new System.EventHandler(this.FrmLiberacionFinalDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografía)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label txtSemestre;
        private System.Windows.Forms.Label txtCarrera;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtNoControl;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNoControl;
        private System.Windows.Forms.PictureBox pbFotografía;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.NumericUpDown spnCal;
    }
}