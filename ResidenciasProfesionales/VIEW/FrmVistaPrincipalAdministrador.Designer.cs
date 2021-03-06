﻿namespace ResidenciasProfesionales.VIEW
{
    partial class FrmVistaPrincipalAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrincipalAdministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnControlDocumentacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteResidencia = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbxAsesores = new System.Windows.Forms.ComboBox();
            this.panelSeleccion = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnControlDocumentacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReporteResidencia);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnControlDocumentacion
            // 
            this.btnControlDocumentacion.BackColor = System.Drawing.Color.White;
            this.btnControlDocumentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlDocumentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlDocumentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnControlDocumentacion.Location = new System.Drawing.Point(10, 20);
            this.btnControlDocumentacion.Name = "btnControlDocumentacion";
            this.btnControlDocumentacion.Size = new System.Drawing.Size(175, 30);
            this.btnControlDocumentacion.TabIndex = 2;
            this.btnControlDocumentacion.Text = "Control de documentación";
            this.btnControlDocumentacion.UseVisualStyleBackColor = false;
            this.btnControlDocumentacion.Click += new System.EventHandler(this.btnControlDocumentacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 69);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(25, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(30, 35);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cerrar sesión";
            this.label1.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnReporteResidencia
            // 
            this.btnReporteResidencia.BackColor = System.Drawing.Color.White;
            this.btnReporteResidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteResidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnReporteResidencia.Location = new System.Drawing.Point(191, 20);
            this.btnReporteResidencia.Name = "btnReporteResidencia";
            this.btnReporteResidencia.Size = new System.Drawing.Size(175, 30);
            this.btnReporteResidencia.TabIndex = 0;
            this.btnReporteResidencia.Text = "Reporte de residencias";
            this.btnReporteResidencia.UseVisualStyleBackColor = false;
            this.btnReporteResidencia.Click += new System.EventHandler(this.btnReporteResidencia_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.ITSUR_Logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(251, 132);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 248);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // cbxAsesores
            // 
            this.cbxAsesores.FormattingEnabled = true;
            this.cbxAsesores.Location = new System.Drawing.Point(3, 25);
            this.cbxAsesores.Name = "cbxAsesores";
            this.cbxAsesores.Size = new System.Drawing.Size(226, 21);
            this.cbxAsesores.TabIndex = 2;
            // 
            // panelSeleccion
            // 
            this.panelSeleccion.Controls.Add(this.btnRegistrar);
            this.panelSeleccion.Controls.Add(this.btnVer);
            this.panelSeleccion.Controls.Add(this.lblAsesor);
            this.panelSeleccion.Controls.Add(this.cbxAsesores);
            this.panelSeleccion.Location = new System.Drawing.Point(12, 75);
            this.panelSeleccion.Name = "panelSeleccion";
            this.panelSeleccion.Size = new System.Drawing.Size(233, 134);
            this.panelSeleccion.TabIndex = 3;
            this.panelSeleccion.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRegistrar.Location = new System.Drawing.Point(5, 93);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(223, 30);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar documentación";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnVer.Location = new System.Drawing.Point(5, 57);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(223, 30);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver documentación";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Location = new System.Drawing.Point(3, 9);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(39, 13);
            this.lblAsesor.TabIndex = 4;
            this.lblAsesor.Text = "Asesor";
            // 
            // FrmVistaPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.panelSeleccion);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVistaPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentanaPrincipalAdministrador";
            this.Load += new System.EventHandler(this.FrmVistaPrincipalAdministrador_Load);
            this.Resize += new System.EventHandler(this.FrmVistaPrincipalAsesor_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelSeleccion.ResumeLayout(false);
            this.panelSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteResidencia;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnControlDocumentacion;
        private System.Windows.Forms.ComboBox cbxAsesores;
        private System.Windows.Forms.Panel panelSeleccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblAsesor;
    }
}