﻿namespace ResidenciasProfesionales.VIEW
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
            ((System.ComponentModel.ISupportInitialize)(this.spnCalificacionFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // spnCalificacionFinal
            // 
            this.spnCalificacionFinal.Enabled = false;
            this.spnCalificacionFinal.Location = new System.Drawing.Point(127, 426);
            this.spnCalificacionFinal.Name = "spnCalificacionFinal";
            this.spnCalificacionFinal.Size = new System.Drawing.Size(45, 20);
            this.spnCalificacionFinal.TabIndex = 13;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(522, 423);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(200, 23);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // lblCalificacionFinal
            // 
            this.lblCalificacionFinal.AutoSize = true;
            this.lblCalificacionFinal.Location = new System.Drawing.Point(12, 429);
            this.lblCalificacionFinal.Name = "lblCalificacionFinal";
            this.lblCalificacionFinal.Size = new System.Drawing.Size(118, 13);
            this.lblCalificacionFinal.TabIndex = 11;
            this.lblCalificacionFinal.Text = "CALIFICACIÓN FINAL: ";
            // 
            // tablaDocumentos
            // 
            this.tablaDocumentos.AllowUserToAddRows = false;
            this.tablaDocumentos.AllowUserToDeleteRows = false;
            this.tablaDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documento,
            this.entregado});
            this.tablaDocumentos.Location = new System.Drawing.Point(12, 203);
            this.tablaDocumentos.Name = "tablaDocumentos";
            this.tablaDocumentos.Size = new System.Drawing.Size(710, 155);
            this.tablaDocumentos.TabIndex = 10;
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
            // FrmControlDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
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
    }
}