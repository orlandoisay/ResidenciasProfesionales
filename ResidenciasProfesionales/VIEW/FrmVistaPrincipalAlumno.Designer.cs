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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAprobacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.LightGray;
            this.pbLogo.Location = new System.Drawing.Point(173, 53);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(289, 276);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAprobacion,
            this.btnCerrarSesión});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(636, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAprobacion
            // 
            this.btnAprobacion.Name = "btnAprobacion";
            this.btnAprobacion.Size = new System.Drawing.Size(91, 23);
            this.btnAprobacion.Text = "Ver solicitud";
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCerrarSesión.Size = new System.Drawing.Size(98, 23);
            this.btnCerrarSesión.Text = "Cerrar sesión";
            // 
            // FrmVistaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 341);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVistaPrincipalAlumno";
            this.Text = "FrmVistaPrincipalAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAprobacion;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesión;
    }
}