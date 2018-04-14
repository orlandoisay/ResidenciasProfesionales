namespace ResidenciasProfesionales.VIEW
{
    partial class FrmAsignacionRevisores
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.pPanelV2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnAsignarContinuar = new System.Windows.Forms.Button();
            this.letreroIns = new System.Windows.Forms.Label();
            this.dgvTablaCarga = new System.Windows.Forms.DataGridView();
            this.cAceptar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cRevisorr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbCarreraAS = new System.Windows.Forms.Label();
            this.lbNombreAS = new System.Windows.Forms.Label();
            this.letrero = new System.Windows.Forms.Label();
            this.letreroNombreA = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSemestre = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNoControl = new System.Windows.Forms.Label();
            this.letreroSemestre = new System.Windows.Forms.Label();
            this.letreroCarrera = new System.Windows.Forms.Label();
            this.letreroNombre = new System.Windows.Forms.Label();
            this.letreroNoControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAsesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevisor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pPanel.SuspendLayout();
            this.pPanelV2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNoControl,
            this.cAlumno,
            this.cAsesor,
            this.cRevisor,
            this.cRevisor2});
            this.dgvTabla.Location = new System.Drawing.Point(22, 57);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(899, 395);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(737, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(832, 21);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 30);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // pPanel
            // 
            this.pPanel.BackColor = System.Drawing.Color.White;
            this.pPanel.Controls.Add(this.dgvTabla);
            this.pPanel.Controls.Add(this.btnFinalizar);
            this.pPanel.Controls.Add(this.btnEditar);
            this.pPanel.Location = new System.Drawing.Point(1, 1);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(22, 22);
            this.pPanel.TabIndex = 3;
            this.pPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pPanel_Paint);
            // 
            // pPanelV2
            // 
            this.pPanelV2.BackColor = System.Drawing.Color.White;
            this.pPanelV2.Controls.Add(this.btnCancelar);
            this.pPanelV2.Controls.Add(this.btnAsignar);
            this.pPanelV2.Controls.Add(this.btnAsignarContinuar);
            this.pPanelV2.Controls.Add(this.letreroIns);
            this.pPanelV2.Controls.Add(this.dgvTablaCarga);
            this.pPanelV2.Controls.Add(this.pictureBox2);
            this.pPanelV2.Controls.Add(this.lbCarreraAS);
            this.pPanelV2.Controls.Add(this.lbNombreAS);
            this.pPanelV2.Controls.Add(this.letrero);
            this.pPanelV2.Controls.Add(this.letreroNombreA);
            this.pPanelV2.Controls.Add(this.label18);
            this.pPanelV2.Controls.Add(this.pictureBox1);
            this.pPanelV2.Controls.Add(this.lbSemestre);
            this.pPanelV2.Controls.Add(this.lbCarrera);
            this.pPanelV2.Controls.Add(this.lbNombre);
            this.pPanelV2.Controls.Add(this.lbNoControl);
            this.pPanelV2.Controls.Add(this.letreroSemestre);
            this.pPanelV2.Controls.Add(this.letreroCarrera);
            this.pPanelV2.Controls.Add(this.letreroNombre);
            this.pPanelV2.Controls.Add(this.letreroNoControl);
            this.pPanelV2.Controls.Add(this.label1);
            this.pPanelV2.Location = new System.Drawing.Point(1, 29);
            this.pPanelV2.Name = "pPanelV2";
            this.pPanelV2.Size = new System.Drawing.Size(905, 503);
            this.pPanelV2.TabIndex = 4;
            this.pPanelV2.Paint += new System.Windows.Forms.PaintEventHandler(this.pPanelV2_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(32, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 31);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(832, 422);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 31);
            this.btnAsignar.TabIndex = 23;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnAsignarContinuar
            // 
            this.btnAsignarContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarContinuar.Location = new System.Drawing.Point(661, 422);
            this.btnAsignarContinuar.Name = "btnAsignarContinuar";
            this.btnAsignarContinuar.Size = new System.Drawing.Size(165, 31);
            this.btnAsignarContinuar.TabIndex = 22;
            this.btnAsignarContinuar.Text = "Asignar y continuar";
            this.btnAsignarContinuar.UseVisualStyleBackColor = true;
            // 
            // letreroIns
            // 
            this.letreroIns.AutoSize = true;
            this.letreroIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroIns.Location = new System.Drawing.Point(470, 29);
            this.letreroIns.Name = "letreroIns";
            this.letreroIns.Size = new System.Drawing.Size(224, 20);
            this.letreroIns.TabIndex = 21;
            this.letreroIns.Text = "Revisores disponobles(elige 2)";
            // 
            // dgvTablaCarga
            // 
            this.dgvTablaCarga.AllowUserToAddRows = false;
            this.dgvTablaCarga.AllowUserToDeleteRows = false;
            this.dgvTablaCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAceptar,
            this.cRevisorr,
            this.cCargaActual});
            this.dgvTablaCarga.Location = new System.Drawing.Point(465, 61);
            this.dgvTablaCarga.Name = "dgvTablaCarga";
            this.dgvTablaCarga.ReadOnly = true;
            this.dgvTablaCarga.Size = new System.Drawing.Size(444, 344);
            this.dgvTablaCarga.TabIndex = 20;
            // 
            // cAceptar
            // 
            this.cAceptar.HeaderText = "";
            this.cAceptar.Name = "cAceptar";
            this.cAceptar.ReadOnly = true;
            // 
            // cRevisorr
            // 
            this.cRevisorr.HeaderText = "Revisor";
            this.cRevisorr.Name = "cRevisorr";
            this.cRevisorr.ReadOnly = true;
            // 
            // cCargaActual
            // 
            this.cCargaActual.HeaderText = "Carga actual";
            this.cCargaActual.Name = "cCargaActual";
            this.cCargaActual.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(32, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lbCarreraAS
            // 
            this.lbCarreraAS.AutoSize = true;
            this.lbCarreraAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarreraAS.Location = new System.Drawing.Point(263, 360);
            this.lbCarreraAS.Name = "lbCarreraAS";
            this.lbCarreraAS.Size = new System.Drawing.Size(52, 16);
            this.lbCarreraAS.TabIndex = 17;
            this.lbCarreraAS.Text = "label11";
            // 
            // lbNombreAS
            // 
            this.lbNombreAS.AutoSize = true;
            this.lbNombreAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAS.Location = new System.Drawing.Point(263, 330);
            this.lbNombreAS.Name = "lbNombreAS";
            this.lbNombreAS.Size = new System.Drawing.Size(52, 16);
            this.lbNombreAS.TabIndex = 16;
            this.lbNombreAS.Text = "label12";
            // 
            // letrero
            // 
            this.letrero.AutoSize = true;
            this.letrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letrero.Location = new System.Drawing.Point(173, 356);
            this.letrero.Name = "letrero";
            this.letrero.Size = new System.Drawing.Size(62, 20);
            this.letrero.TabIndex = 13;
            this.letrero.Text = "Carrera";
            // 
            // letreroNombreA
            // 
            this.letreroNombreA.AutoSize = true;
            this.letreroNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNombreA.Location = new System.Drawing.Point(170, 326);
            this.letreroNombreA.Name = "letreroNombreA";
            this.letreroNombreA.Size = new System.Drawing.Size(65, 20);
            this.letreroNombreA.TabIndex = 12;
            this.letreroNombreA.Text = "Nombre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Asesor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbSemestre
            // 
            this.lbSemestre.AutoSize = true;
            this.lbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemestre.Location = new System.Drawing.Point(263, 187);
            this.lbSemestre.Name = "lbSemestre";
            this.lbSemestre.Size = new System.Drawing.Size(45, 16);
            this.lbSemestre.TabIndex = 8;
            this.lbSemestre.Text = "label9";
            // 
            // lbCarrera
            // 
            this.lbCarrera.AutoSize = true;
            this.lbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarrera.Location = new System.Drawing.Point(263, 158);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(45, 16);
            this.lbCarrera.TabIndex = 7;
            this.lbCarrera.Text = "label8";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(263, 128);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(45, 16);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "label7";
            // 
            // lbNoControl
            // 
            this.lbNoControl.AutoSize = true;
            this.lbNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoControl.Location = new System.Drawing.Point(263, 98);
            this.lbNoControl.Name = "lbNoControl";
            this.lbNoControl.Size = new System.Drawing.Size(45, 16);
            this.lbNoControl.TabIndex = 5;
            this.lbNoControl.Text = "label6";
            // 
            // letreroSemestre
            // 
            this.letreroSemestre.AutoSize = true;
            this.letreroSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroSemestre.Location = new System.Drawing.Point(152, 183);
            this.letreroSemestre.Name = "letreroSemestre";
            this.letreroSemestre.Size = new System.Drawing.Size(78, 20);
            this.letreroSemestre.TabIndex = 4;
            this.letreroSemestre.Text = "Semestre";
            // 
            // letreroCarrera
            // 
            this.letreroCarrera.AutoSize = true;
            this.letreroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroCarrera.Location = new System.Drawing.Point(173, 154);
            this.letreroCarrera.Name = "letreroCarrera";
            this.letreroCarrera.Size = new System.Drawing.Size(62, 20);
            this.letreroCarrera.TabIndex = 3;
            this.letreroCarrera.Text = "Carrera";
            // 
            // letreroNombre
            // 
            this.letreroNombre.AutoSize = true;
            this.letreroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNombre.Location = new System.Drawing.Point(170, 124);
            this.letreroNombre.Name = "letreroNombre";
            this.letreroNombre.Size = new System.Drawing.Size(65, 20);
            this.letreroNombre.TabIndex = 2;
            this.letreroNombre.Text = "Nombre";
            // 
            // letreroNoControl
            // 
            this.letreroNoControl.AutoSize = true;
            this.letreroNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNoControl.Location = new System.Drawing.Point(150, 95);
            this.letreroNoControl.Name = "letreroNoControl";
            this.letreroNoControl.Size = new System.Drawing.Size(88, 20);
            this.letreroNoControl.TabIndex = 1;
            this.letreroNoControl.Text = "No. Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // cNoControl
            // 
            this.cNoControl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cNoControl.DataPropertyName = "NoControl";
            this.cNoControl.HeaderText = "Num. Control";
            this.cNoControl.Name = "cNoControl";
            this.cNoControl.ReadOnly = true;
            this.cNoControl.Width = 93;
            // 
            // cAlumno
            // 
            this.cAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAlumno.DataPropertyName = "Alumno";
            this.cAlumno.HeaderText = "Alumno";
            this.cAlumno.Name = "cAlumno";
            this.cAlumno.ReadOnly = true;
            // 
            // cAsesor
            // 
            this.cAsesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAsesor.DataPropertyName = "Asesor";
            this.cAsesor.HeaderText = "Asesor";
            this.cAsesor.Name = "cAsesor";
            this.cAsesor.ReadOnly = true;
            // 
            // cRevisor
            // 
            this.cRevisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRevisor.DataPropertyName = "Revisor1";
            this.cRevisor.HeaderText = "Revisor";
            this.cRevisor.Name = "cRevisor";
            this.cRevisor.ReadOnly = true;
            // 
            // cRevisor2
            // 
            this.cRevisor2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRevisor2.DataPropertyName = "Revisor2";
            this.cRevisor2.HeaderText = "Revisor";
            this.cRevisor2.Name = "cRevisor2";
            this.cRevisor2.ReadOnly = true;
            // 
            // FrmAsignacionRevisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 544);
            this.Controls.Add(this.pPanel);
            this.Controls.Add(this.pPanelV2);
            this.Name = "FrmAsignacionRevisores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignacionRevisores";
            this.Load += new System.EventHandler(this.FrmAsignacionRevisores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pPanel.ResumeLayout(false);
            this.pPanelV2.ResumeLayout(false);
            this.pPanelV2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.Panel pPanelV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSemestre;
        private System.Windows.Forms.Label lbCarrera;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNoControl;
        private System.Windows.Forms.Label letreroSemestre;
        private System.Windows.Forms.Label letreroCarrera;
        private System.Windows.Forms.Label letreroNombre;
        private System.Windows.Forms.Label letreroNoControl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnAsignarContinuar;
        private System.Windows.Forms.Label letreroIns;
        private System.Windows.Forms.DataGridView dgvTablaCarga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargaActual;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbCarreraAS;
        private System.Windows.Forms.Label lbNombreAS;
        private System.Windows.Forms.Label letrero;
        private System.Windows.Forms.Label letreroNombreA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisor2;
    }
}