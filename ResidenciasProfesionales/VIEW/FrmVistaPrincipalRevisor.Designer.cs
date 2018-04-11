namespace ResidenciasProfesionales.VIEW
{
    partial class FrmVistaPrincipalRevisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaPrincipalRevisor));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.pbCerrarSesion = new System.Windows.Forms.Button();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.btnLiberacion = new System.Windows.Forms.Button();
            this.btnAprobacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.LightGray;
            this.pbLogo.Image = global::ResidenciasProfesionales.Properties.Resources.ITSUR_Logo;
            this.pbLogo.Location = new System.Drawing.Point(232, 96);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(276, 248);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlTop.Controls.Add(this.pnlCerrarSesion);
            this.pnlTop.Controls.Add(this.btnLiberacion);
            this.pnlTop.Controls.Add(this.btnAprobacion);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(776, 69);
            this.pnlTop.TabIndex = 2;
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
            this.pnlCerrarSesion.Click += new System.EventHandler(this.pnlCerrarSesion_Click);
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
            // btnLiberacion
            // 
            this.btnLiberacion.BackColor = System.Drawing.Color.White;
            this.btnLiberacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLiberacion.Location = new System.Drawing.Point(207, 20);
            this.btnLiberacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLiberacion.Name = "btnLiberacion";
            this.btnLiberacion.Size = new System.Drawing.Size(174, 30);
            this.btnLiberacion.TabIndex = 2;
            this.btnLiberacion.Text = "Liberación de informes";
            this.btnLiberacion.UseVisualStyleBackColor = false;
            this.btnLiberacion.Click += new System.EventHandler(this.btnLiberacion_Click);
            // 
            // btnAprobacion
            // 
            this.btnAprobacion.BackColor = System.Drawing.Color.White;
            this.btnAprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAprobacion.Location = new System.Drawing.Point(25, 20);
            this.btnAprobacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprobacion.Name = "btnAprobacion";
            this.btnAprobacion.Size = new System.Drawing.Size(176, 30);
            this.btnAprobacion.TabIndex = 1;
            this.btnAprobacion.Text = "Aprobación de informes";
            this.btnAprobacion.UseVisualStyleBackColor = false;
            this.btnAprobacion.Click += new System.EventHandler(this.btnAprobacion_Click);
            // 
            // FrmVistaPrincipalRevisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmVistaPrincipalRevisor";
            this.Text = "Vista principal";
            this.Resize += new System.EventHandler(this.FrmVistaPrincipalRevisor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Button pbCerrarSesion;
        private System.Windows.Forms.Button btnLiberacion;
        private System.Windows.Forms.Button btnAprobacion;
        private System.Windows.Forms.Panel pnlCerrarSesion;
    }
}