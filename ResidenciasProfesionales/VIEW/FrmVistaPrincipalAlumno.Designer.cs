namespace ResidenciasProfesionales.VIEW
{
    partial class FrmVistaPrincipalAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrincipalAlumno));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerSolicitud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.ITSUR_Logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(231, 97);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 248);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVerSolicitud);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 69);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 69);
            this.panel2.TabIndex = 1;
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
            // 
            // btnVerSolicitud
            // 
            this.btnVerSolicitud.BackColor = System.Drawing.Color.White;
            this.btnVerSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnVerSolicitud.Location = new System.Drawing.Point(22, 20);
            this.btnVerSolicitud.Name = "btnVerSolicitud";
            this.btnVerSolicitud.Size = new System.Drawing.Size(175, 30);
            this.btnVerSolicitud.TabIndex = 0;
            this.btnVerSolicitud.Text = "Ver solicitud";
            this.btnVerSolicitud.UseVisualStyleBackColor = false;
            this.btnVerSolicitud.Click += new System.EventHandler(this.btnVerSolicitud_Click);
            // 
            // FrmVistaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVistaPrincipalAlumno";
            this.Text = "FrmVistaPrincipalAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerSolicitud;
    }
}