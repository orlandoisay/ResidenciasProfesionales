namespace ResidenciasProfesionales.VIEW
{
    partial class FrmVistaPrincipalAsesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrincipalAsesor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLiberacionInformes = new System.Windows.Forms.Button();
            this.btnAprobacionInformes = new System.Windows.Forms.Button();
            this.btnControlDocumentacion = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLiberacionInformes);
            this.panel1.Controls.Add(this.btnAprobacionInformes);
            this.panel1.Controls.Add(this.btnControlDocumentacion);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 69);
            this.panel1.TabIndex = 0;
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
            // btnLiberacionInformes
            // 
            this.btnLiberacionInformes.BackColor = System.Drawing.Color.White;
            this.btnLiberacionInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberacionInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberacionInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLiberacionInformes.Location = new System.Drawing.Point(373, 20);
            this.btnLiberacionInformes.Name = "btnLiberacionInformes";
            this.btnLiberacionInformes.Size = new System.Drawing.Size(157, 30);
            this.btnLiberacionInformes.TabIndex = 2;
            this.btnLiberacionInformes.Text = "Liberación de informes";
            this.btnLiberacionInformes.UseVisualStyleBackColor = false;
            this.btnLiberacionInformes.Click += new System.EventHandler(this.btnLiberacionInformes_Click);
            // 
            // btnAprobacionInformes
            // 
            this.btnAprobacionInformes.BackColor = System.Drawing.Color.White;
            this.btnAprobacionInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobacionInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobacionInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAprobacionInformes.Location = new System.Drawing.Point(203, 20);
            this.btnAprobacionInformes.Name = "btnAprobacionInformes";
            this.btnAprobacionInformes.Size = new System.Drawing.Size(164, 30);
            this.btnAprobacionInformes.TabIndex = 1;
            this.btnAprobacionInformes.Text = "Aprobación de informes";
            this.btnAprobacionInformes.UseVisualStyleBackColor = false;
            this.btnAprobacionInformes.Click += new System.EventHandler(this.btnAprobacionInformes_Click);
            // 
            // btnControlDocumentacion
            // 
            this.btnControlDocumentacion.BackColor = System.Drawing.Color.White;
            this.btnControlDocumentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlDocumentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlDocumentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnControlDocumentacion.Location = new System.Drawing.Point(22, 20);
            this.btnControlDocumentacion.Name = "btnControlDocumentacion";
            this.btnControlDocumentacion.Size = new System.Drawing.Size(175, 30);
            this.btnControlDocumentacion.TabIndex = 0;
            this.btnControlDocumentacion.Text = "Control de documentación";
            this.btnControlDocumentacion.UseVisualStyleBackColor = false;
            this.btnControlDocumentacion.Click += new System.EventHandler(this.btnControlDocumentacion_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.ITSUR_Logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(232, 96);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 248);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // FrmVistaPrincipalAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVistaPrincipalAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentanaPrincipalAsesor";
            this.Resize += new System.EventHandler(this.FrmVistaPrincipalAsesor_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLiberacionInformes;
        private System.Windows.Forms.Button btnAprobacionInformes;
        private System.Windows.Forms.Button btnControlDocumentacion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}