namespace ResidenciasProfesionales.VIEW
{
    partial class FrmVistaPrincipalCoordinador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrincipalCoordinador));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.pbCerrarSesion = new System.Windows.Forms.Button();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.btnReporteResidencias = new System.Windows.Forms.Button();
            this.btnAprobacionInformes = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlTop.Controls.Add(this.pnlCerrarSesion);
            this.pnlTop.Controls.Add(this.btnReporteResidencias);
            this.pnlTop.Controls.Add(this.btnAprobacionInformes);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(776, 69);
            this.pnlTop.TabIndex = 5;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCerrarSesion.Controls.Add(this.pbCerrarSesion);
            this.pnlCerrarSesion.Controls.Add(this.lblCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(696, 0);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(80, 69);
            this.pnlCerrarSesion.TabIndex = 5;
            // 
            // pbCerrarSesion
            // 
            this.pbCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCerrarSesion.BackgroundImage")));
            this.pbCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pbCerrarSesion.Location = new System.Drawing.Point(27, 8);
            this.pbCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarSesion.Name = "pbCerrarSesion";
            this.pbCerrarSesion.Size = new System.Drawing.Size(26, 27);
            this.pbCerrarSesion.TabIndex = 3;
            this.pbCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pbCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(4, 42);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(72, 15);
            this.lblCerrarSesion.TabIndex = 4;
            this.lblCerrarSesion.Text = "Cerrar sesión";
            // 
            // btnReporteResidencias
            // 
            this.btnReporteResidencias.BackColor = System.Drawing.Color.White;
            this.btnReporteResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteResidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteResidencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnReporteResidencias.Location = new System.Drawing.Point(207, 20);
            this.btnReporteResidencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteResidencias.Name = "btnReporteResidencias";
            this.btnReporteResidencias.Size = new System.Drawing.Size(174, 30);
            this.btnReporteResidencias.TabIndex = 2;
            this.btnReporteResidencias.Text = "Reporte de residencias";
            this.btnReporteResidencias.UseVisualStyleBackColor = false;
            this.btnReporteResidencias.Click += new System.EventHandler(this.btnReporteResidencias_Click);
            // 
            // btnAprobacionInformes
            // 
            this.btnAprobacionInformes.BackColor = System.Drawing.Color.White;
            this.btnAprobacionInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobacionInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobacionInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAprobacionInformes.Location = new System.Drawing.Point(25, 20);
            this.btnAprobacionInformes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprobacionInformes.Name = "btnAprobacionInformes";
            this.btnAprobacionInformes.Size = new System.Drawing.Size(176, 30);
            this.btnAprobacionInformes.TabIndex = 1;
            this.btnAprobacionInformes.Text = "Aprobacion de Informes";
            this.btnAprobacionInformes.UseVisualStyleBackColor = false;
            this.btnAprobacionInformes.Click += new System.EventHandler(this.btnAprobacionInformes_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.LightGray;
            this.pbLogo.Image = global::ResidenciasProfesionales.Properties.Resources.ITSUR_Logo;
            this.pbLogo.Location = new System.Drawing.Point(232, 96);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 248);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // FrmVistaPrincipalCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmVistaPrincipalCoordinador";
            this.Text = "FrmVistaPrincipalCoordinador";
            this.pnlTop.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Button pbCerrarSesion;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Button btnReporteResidencias;
        private System.Windows.Forms.Button btnAprobacionInformes;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}