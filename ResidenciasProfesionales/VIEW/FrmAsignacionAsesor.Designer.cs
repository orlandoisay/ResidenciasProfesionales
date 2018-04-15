namespace ResidenciasProfesionales.VIEW
{
    partial class FrmAsignacionAsesor
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
            this.pestaniasAsig_Mod = new System.Windows.Forms.TabControl();
            this.paginaAsignarAsesor = new System.Windows.Forms.TabPage();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblAlumnoAsignar = new System.Windows.Forms.Label();
            this.btnMostrarAsignar = new System.Windows.Forms.Button();
            this.tablaAsignarAsesor = new System.Windows.Forms.DataGridView();
            this.noControlAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAsignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginaModificarAsesor = new System.Windows.Forms.TabPage();
            this.btnCambiarAsesor = new System.Windows.Forms.Button();
            this.btnMostrarModificar = new System.Windows.Forms.Button();
            this.lblAlumnoModificar = new System.Windows.Forms.Label();
            this.tablaModificarAsesor = new System.Windows.Forms.DataGridView();
            this.noControlModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asesorModificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pestaniasAsig_Mod.SuspendLayout();
            this.paginaAsignarAsesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignarAsesor)).BeginInit();
            this.paginaModificarAsesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModificarAsesor)).BeginInit();
            this.SuspendLayout();
            // 
            // pestaniasAsig_Mod
            // 
            this.pestaniasAsig_Mod.Controls.Add(this.paginaAsignarAsesor);
            this.pestaniasAsig_Mod.Controls.Add(this.paginaModificarAsesor);
            this.pestaniasAsig_Mod.Location = new System.Drawing.Point(12, 12);
            this.pestaniasAsig_Mod.Name = "pestaniasAsig_Mod";
            this.pestaniasAsig_Mod.SelectedIndex = 0;
            this.pestaniasAsig_Mod.Size = new System.Drawing.Size(710, 432);
            this.pestaniasAsig_Mod.TabIndex = 2;
            // 
            // paginaAsignarAsesor
            // 
            this.paginaAsignarAsesor.Controls.Add(this.btnAsignar);
            this.paginaAsignarAsesor.Controls.Add(this.lblAlumnoAsignar);
            this.paginaAsignarAsesor.Controls.Add(this.btnMostrarAsignar);
            this.paginaAsignarAsesor.Controls.Add(this.tablaAsignarAsesor);
            this.paginaAsignarAsesor.Location = new System.Drawing.Point(4, 22);
            this.paginaAsignarAsesor.Name = "paginaAsignarAsesor";
            this.paginaAsignarAsesor.Padding = new System.Windows.Forms.Padding(3);
            this.paginaAsignarAsesor.Size = new System.Drawing.Size(702, 406);
            this.paginaAsignarAsesor.TabIndex = 0;
            this.paginaAsignarAsesor.Text = "Asignar asesor";
            this.paginaAsignarAsesor.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(490, 377);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 23);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblAlumnoAsignar
            // 
            this.lblAlumnoAsignar.AutoSize = true;
            this.lblAlumnoAsignar.Location = new System.Drawing.Point(6, 382);
            this.lblAlumnoAsignar.Name = "lblAlumnoAsignar";
            this.lblAlumnoAsignar.Size = new System.Drawing.Size(59, 13);
            this.lblAlumnoAsignar.TabIndex = 2;
            this.lblAlumnoAsignar.Text = "ALUMNO: ";
            // 
            // btnMostrarAsignar
            // 
            this.btnMostrarAsignar.Location = new System.Drawing.Point(596, 377);
            this.btnMostrarAsignar.Name = "btnMostrarAsignar";
            this.btnMostrarAsignar.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarAsignar.TabIndex = 1;
            this.btnMostrarAsignar.Text = "Mostrar datos";
            this.btnMostrarAsignar.UseVisualStyleBackColor = true;
            this.btnMostrarAsignar.Click += new System.EventHandler(this.btnMostrarAsignar_Click);
            // 
            // tablaAsignarAsesor
            // 
            this.tablaAsignarAsesor.AllowUserToAddRows = false;
            this.tablaAsignarAsesor.AllowUserToDeleteRows = false;
            this.tablaAsignarAsesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAsignarAsesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControlAsignar,
            this.nombreAsignar});
            this.tablaAsignarAsesor.Location = new System.Drawing.Point(3, 3);
            this.tablaAsignarAsesor.Name = "tablaAsignarAsesor";
            this.tablaAsignarAsesor.ReadOnly = true;
            this.tablaAsignarAsesor.Size = new System.Drawing.Size(696, 368);
            this.tablaAsignarAsesor.TabIndex = 0;
            this.tablaAsignarAsesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignarAsesor_CellClick);
            this.tablaAsignarAsesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAsignarAsesor_CellContentClick);
            // 
            // noControlAsignar
            // 
            this.noControlAsignar.HeaderText = "No. control";
            this.noControlAsignar.Name = "noControlAsignar";
            this.noControlAsignar.ReadOnly = true;
            this.noControlAsignar.Width = 84;
            // 
            // nombreAsignar
            // 
            this.nombreAsignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreAsignar.HeaderText = "Nombre";
            this.nombreAsignar.Name = "nombreAsignar";
            this.nombreAsignar.ReadOnly = true;
            // 
            // paginaModificarAsesor
            // 
            this.paginaModificarAsesor.Controls.Add(this.btnCambiarAsesor);
            this.paginaModificarAsesor.Controls.Add(this.btnMostrarModificar);
            this.paginaModificarAsesor.Controls.Add(this.lblAlumnoModificar);
            this.paginaModificarAsesor.Controls.Add(this.tablaModificarAsesor);
            this.paginaModificarAsesor.Location = new System.Drawing.Point(4, 22);
            this.paginaModificarAsesor.Name = "paginaModificarAsesor";
            this.paginaModificarAsesor.Padding = new System.Windows.Forms.Padding(3);
            this.paginaModificarAsesor.Size = new System.Drawing.Size(702, 406);
            this.paginaModificarAsesor.TabIndex = 1;
            this.paginaModificarAsesor.Text = "Modificar asesor";
            this.paginaModificarAsesor.UseVisualStyleBackColor = true;
            // 
            // btnCambiarAsesor
            // 
            this.btnCambiarAsesor.Location = new System.Drawing.Point(490, 377);
            this.btnCambiarAsesor.Name = "btnCambiarAsesor";
            this.btnCambiarAsesor.Size = new System.Drawing.Size(100, 23);
            this.btnCambiarAsesor.TabIndex = 3;
            this.btnCambiarAsesor.Text = "Cambiar asesor";
            this.btnCambiarAsesor.UseVisualStyleBackColor = true;
            this.btnCambiarAsesor.Click += new System.EventHandler(this.btnCambiarAsesor_Click);
            // 
            // btnMostrarModificar
            // 
            this.btnMostrarModificar.Location = new System.Drawing.Point(596, 377);
            this.btnMostrarModificar.Name = "btnMostrarModificar";
            this.btnMostrarModificar.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarModificar.TabIndex = 2;
            this.btnMostrarModificar.Text = "Mostrar datos";
            this.btnMostrarModificar.UseVisualStyleBackColor = true;
            this.btnMostrarModificar.Click += new System.EventHandler(this.btnMostrarModificar_Click);
            // 
            // lblAlumnoModificar
            // 
            this.lblAlumnoModificar.AutoSize = true;
            this.lblAlumnoModificar.Location = new System.Drawing.Point(6, 382);
            this.lblAlumnoModificar.Name = "lblAlumnoModificar";
            this.lblAlumnoModificar.Size = new System.Drawing.Size(59, 13);
            this.lblAlumnoModificar.TabIndex = 1;
            this.lblAlumnoModificar.Text = "ALUMNO: ";
            // 
            // tablaModificarAsesor
            // 
            this.tablaModificarAsesor.AllowUserToAddRows = false;
            this.tablaModificarAsesor.AllowUserToDeleteRows = false;
            this.tablaModificarAsesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaModificarAsesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControlModificar,
            this.nombreModificar,
            this.asesorModificar});
            this.tablaModificarAsesor.Location = new System.Drawing.Point(3, 3);
            this.tablaModificarAsesor.Name = "tablaModificarAsesor";
            this.tablaModificarAsesor.ReadOnly = true;
            this.tablaModificarAsesor.Size = new System.Drawing.Size(696, 368);
            this.tablaModificarAsesor.TabIndex = 0;
            this.tablaModificarAsesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaModificarAsesor_CellClick);
            // 
            // noControlModificar
            // 
            this.noControlModificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.noControlModificar.HeaderText = "No. control";
            this.noControlModificar.Name = "noControlModificar";
            this.noControlModificar.ReadOnly = true;
            this.noControlModificar.Width = 84;
            // 
            // nombreModificar
            // 
            this.nombreModificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreModificar.HeaderText = "Nombre";
            this.nombreModificar.Name = "nombreModificar";
            this.nombreModificar.ReadOnly = true;
            // 
            // asesorModificar
            // 
            this.asesorModificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asesorModificar.HeaderText = "Asesor/a";
            this.asesorModificar.Name = "asesorModificar";
            this.asesorModificar.ReadOnly = true;
            // 
            // FrmAsignacionAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.pestaniasAsig_Mod);
            this.Name = "FrmAsignacionAsesor";
            this.Text = "FrmAsignarAsesor";
            this.pestaniasAsig_Mod.ResumeLayout(false);
            this.paginaAsignarAsesor.ResumeLayout(false);
            this.paginaAsignarAsesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsignarAsesor)).EndInit();
            this.paginaModificarAsesor.ResumeLayout(false);
            this.paginaModificarAsesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModificarAsesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pestaniasAsig_Mod;
        private System.Windows.Forms.TabPage paginaAsignarAsesor;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblAlumnoAsignar;
        private System.Windows.Forms.Button btnMostrarAsignar;
        private System.Windows.Forms.DataGridView tablaAsignarAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControlAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAsignar;
        private System.Windows.Forms.TabPage paginaModificarAsesor;
        private System.Windows.Forms.Button btnCambiarAsesor;
        private System.Windows.Forms.Button btnMostrarModificar;
        private System.Windows.Forms.Label lblAlumnoModificar;
        private System.Windows.Forms.DataGridView tablaModificarAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControlModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn asesorModificar;
    }
}