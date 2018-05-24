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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionRevisores));
            this.pPanel = new System.Windows.Forms.Panel();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAsesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevisor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.pPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pPanelV2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPanel
            // 
            this.pPanel.BackColor = System.Drawing.Color.White;
            this.pPanel.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.fondo;
            this.pPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPanel.Controls.Add(this.dgvTabla);
            this.pPanel.Controls.Add(this.btnFinalizar);
            this.pPanel.Controls.Add(this.btnEditar);
            this.pPanel.Location = new System.Drawing.Point(1, 1);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(690, 41);
            this.pPanel.TabIndex = 3;
            this.pPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pPanel_Paint);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNoControl,
            this.cAlumno,
            this.cAsesor,
            this.cRevisor,
            this.cRevisor2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvTabla.Location = new System.Drawing.Point(22, 57);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(899, 395);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // cNoControl
            // 
            this.cNoControl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cNoControl.DataPropertyName = "NoControl";
            this.cNoControl.HeaderText = "Num. Control";
            this.cNoControl.Name = "cNoControl";
            this.cNoControl.ReadOnly = true;
            this.cNoControl.Width = 122;
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
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalizar.Location = new System.Drawing.Point(832, 11);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 30);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnEditar.Location = new System.Drawing.Point(737, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pPanelV2
            // 
            this.pPanelV2.BackColor = System.Drawing.Color.White;
            this.pPanelV2.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.fondo;
            this.pPanelV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.pPanelV2.Size = new System.Drawing.Size(939, 512);
            this.pPanelV2.TabIndex = 4;
            this.pPanelV2.Paint += new System.Windows.Forms.PaintEventHandler(this.pPanelV2_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCancelar.Location = new System.Drawing.Point(796, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 31);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAsignar.Location = new System.Drawing.Point(650, 19);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 31);
            this.btnAsignar.TabIndex = 23;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnAsignarContinuar
            // 
            this.btnAsignarContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAsignarContinuar.Location = new System.Drawing.Point(731, 19);
            this.btnAsignarContinuar.Name = "btnAsignarContinuar";
            this.btnAsignarContinuar.Size = new System.Drawing.Size(165, 31);
            this.btnAsignarContinuar.TabIndex = 22;
            this.btnAsignarContinuar.Text = "Asignar y continuar";
            this.btnAsignarContinuar.UseVisualStyleBackColor = true;
            this.btnAsignarContinuar.Click += new System.EventHandler(this.btnAsignarContinuar_Click);
            // 
            // letreroIns
            // 
            this.letreroIns.AutoSize = true;
            this.letreroIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroIns.Location = new System.Drawing.Point(457, 58);
            this.letreroIns.Name = "letreroIns";
            this.letreroIns.Size = new System.Drawing.Size(224, 20);
            this.letreroIns.TabIndex = 21;
            this.letreroIns.Text = "Revisores disponobles(elige 2)";
            // 
            // dgvTablaCarga
            // 
            this.dgvTablaCarga.AllowUserToAddRows = false;
            this.dgvTablaCarga.AllowUserToDeleteRows = false;
            this.dgvTablaCarga.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaCarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTablaCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAceptar,
            this.cRevisorr,
            this.cCargaActual});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaCarga.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTablaCarga.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvTablaCarga.Location = new System.Drawing.Point(452, 90);
            this.dgvTablaCarga.Name = "dgvTablaCarga";
            this.dgvTablaCarga.Size = new System.Drawing.Size(444, 344);
            this.dgvTablaCarga.TabIndex = 20;
            // 
            // cAceptar
            // 
            this.cAceptar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAceptar.DataPropertyName = "boleana";
            this.cAceptar.FillWeight = 30F;
            this.cAceptar.HeaderText = "";
            this.cAceptar.Name = "cAceptar";
            // 
            // cRevisorr
            // 
            this.cRevisorr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRevisorr.DataPropertyName = "NombreCompleto";
            this.cRevisorr.HeaderText = "Revisor";
            this.cRevisorr.Name = "cRevisorr";
            // 
            // cCargaActual
            // 
            this.cCargaActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cCargaActual.DataPropertyName = "Carga";
            this.cCargaActual.HeaderText = "Carga actual";
            this.cCargaActual.Name = "cCargaActual";
            this.cCargaActual.Width = 116;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ResidenciasProfesionales.Properties.Resources.hombre;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(32, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lbCarreraAS
            // 
            this.lbCarreraAS.AutoSize = true;
            this.lbCarreraAS.BackColor = System.Drawing.Color.Transparent;
            this.lbCarreraAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarreraAS.Location = new System.Drawing.Point(260, 339);
            this.lbCarreraAS.Name = "lbCarreraAS";
            this.lbCarreraAS.Size = new System.Drawing.Size(59, 16);
            this.lbCarreraAS.TabIndex = 17;
            this.lbCarreraAS.Text = "label11";
            // 
            // lbNombreAS
            // 
            this.lbNombreAS.AutoSize = true;
            this.lbNombreAS.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAS.Location = new System.Drawing.Point(260, 309);
            this.lbNombreAS.Name = "lbNombreAS";
            this.lbNombreAS.Size = new System.Drawing.Size(59, 16);
            this.lbNombreAS.TabIndex = 16;
            this.lbNombreAS.Text = "label12";
            // 
            // letrero
            // 
            this.letrero.AutoSize = true;
            this.letrero.BackColor = System.Drawing.Color.Transparent;
            this.letrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letrero.Location = new System.Drawing.Point(170, 335);
            this.letrero.Name = "letrero";
            this.letrero.Size = new System.Drawing.Size(69, 20);
            this.letrero.TabIndex = 13;
            this.letrero.Text = "Carrera";
            // 
            // letreroNombreA
            // 
            this.letreroNombreA.AutoSize = true;
            this.letreroNombreA.BackColor = System.Drawing.Color.Transparent;
            this.letreroNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNombreA.Location = new System.Drawing.Point(167, 305);
            this.letreroNombreA.Name = "letreroNombreA";
            this.letreroNombreA.Size = new System.Drawing.Size(71, 20);
            this.letreroNombreA.TabIndex = 12;
            this.letreroNombreA.Text = "Nombre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 24);
            this.label18.TabIndex = 10;
            this.label18.Text = "Asesor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbSemestre
            // 
            this.lbSemestre.AutoSize = true;
            this.lbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemestre.Location = new System.Drawing.Point(263, 187);
            this.lbSemestre.Name = "lbSemestre";
            this.lbSemestre.Size = new System.Drawing.Size(51, 16);
            this.lbSemestre.TabIndex = 8;
            this.lbSemestre.Text = "label9";
            // 
            // lbCarrera
            // 
            this.lbCarrera.AutoSize = true;
            this.lbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarrera.Location = new System.Drawing.Point(263, 158);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(51, 16);
            this.lbCarrera.TabIndex = 7;
            this.lbCarrera.Text = "label8";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(263, 128);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 16);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "label7";
            // 
            // lbNoControl
            // 
            this.lbNoControl.AutoSize = true;
            this.lbNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoControl.Location = new System.Drawing.Point(263, 98);
            this.lbNoControl.Name = "lbNoControl";
            this.lbNoControl.Size = new System.Drawing.Size(51, 16);
            this.lbNoControl.TabIndex = 5;
            this.lbNoControl.Text = "label6";
            // 
            // letreroSemestre
            // 
            this.letreroSemestre.AutoSize = true;
            this.letreroSemestre.BackColor = System.Drawing.Color.Transparent;
            this.letreroSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroSemestre.Location = new System.Drawing.Point(152, 183);
            this.letreroSemestre.Name = "letreroSemestre";
            this.letreroSemestre.Size = new System.Drawing.Size(86, 20);
            this.letreroSemestre.TabIndex = 4;
            this.letreroSemestre.Text = "Semestre";
            // 
            // letreroCarrera
            // 
            this.letreroCarrera.AutoSize = true;
            this.letreroCarrera.BackColor = System.Drawing.Color.Transparent;
            this.letreroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroCarrera.Location = new System.Drawing.Point(173, 154);
            this.letreroCarrera.Name = "letreroCarrera";
            this.letreroCarrera.Size = new System.Drawing.Size(69, 20);
            this.letreroCarrera.TabIndex = 3;
            this.letreroCarrera.Text = "Carrera";
            // 
            // letreroNombre
            // 
            this.letreroNombre.AutoSize = true;
            this.letreroNombre.BackColor = System.Drawing.Color.Transparent;
            this.letreroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNombre.Location = new System.Drawing.Point(170, 124);
            this.letreroNombre.Name = "letreroNombre";
            this.letreroNombre.Size = new System.Drawing.Size(71, 20);
            this.letreroNombre.TabIndex = 2;
            this.letreroNombre.Text = "Nombre";
            // 
            // letreroNoControl
            // 
            this.letreroNoControl.AutoSize = true;
            this.letreroNoControl.BackColor = System.Drawing.Color.Transparent;
            this.letreroNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNoControl.Location = new System.Drawing.Point(150, 95);
            this.letreroNoControl.Name = "letreroNoControl";
            this.letreroNoControl.Size = new System.Drawing.Size(99, 20);
            this.letreroNoControl.TabIndex = 1;
            this.letreroNoControl.Text = "No. Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
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
            this.pPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn cAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargaActual;
    }
}