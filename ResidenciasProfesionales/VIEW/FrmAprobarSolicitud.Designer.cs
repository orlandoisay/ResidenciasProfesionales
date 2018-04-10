namespace ResidenciasProfesionales.VIEW
{
    partial class FrmAprobarSolicitud
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTablaCarga = new System.Windows.Forms.DataGridView();
            this.cAceptar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cEstatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCargaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pPanelV2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCarga)).BeginInit();
            this.SuspendLayout();
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
            this.pPanel.TabIndex = 4;
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
            // 
            // cNoControl
            // 
            this.cNoControl.HeaderText = "Num. Control";
            this.cNoControl.Name = "cNoControl";
            this.cNoControl.ReadOnly = true;
            // 
            // cAlumno
            // 
            this.cAlumno.HeaderText = "Alumno";
            this.cAlumno.Name = "cAlumno";
            this.cAlumno.ReadOnly = true;
            // 
            // cAsesor
            // 
            this.cAsesor.HeaderText = "Asesor";
            this.cAsesor.Name = "cAsesor";
            this.cAsesor.ReadOnly = true;
            // 
            // cRevisor
            // 
            this.cRevisor.HeaderText = "Revisor";
            this.cRevisor.Name = "cRevisor";
            this.cRevisor.ReadOnly = true;
            // 
            // cRevisor2
            // 
            this.cRevisor2.HeaderText = "Revisor";
            this.cRevisor2.Name = "cRevisor2";
            this.cRevisor2.ReadOnly = true;
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
            // 
            // pPanelV2
            // 
            this.pPanelV2.BackColor = System.Drawing.Color.White;
            this.pPanelV2.Controls.Add(this.btnGuardar);
            this.pPanelV2.Controls.Add(this.dgvTablaCarga);
            this.pPanelV2.Location = new System.Drawing.Point(1, 29);
            this.pPanelV2.Name = "pPanelV2";
            this.pPanelV2.Size = new System.Drawing.Size(641, 348);
            this.pPanelV2.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(235, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 31);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvTablaCarga
            // 
            this.dgvTablaCarga.AllowUserToAddRows = false;
            this.dgvTablaCarga.AllowUserToDeleteRows = false;
            this.dgvTablaCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAceptar,
            this.cEstatus,
            this.cCargaActual});
            this.dgvTablaCarga.Location = new System.Drawing.Point(11, 29);
            this.dgvTablaCarga.Name = "dgvTablaCarga";
            this.dgvTablaCarga.ReadOnly = true;
            this.dgvTablaCarga.Size = new System.Drawing.Size(619, 255);
            this.dgvTablaCarga.TabIndex = 20;
            // 
            // cAceptar
            // 
            this.cAceptar.HeaderText = "";
            this.cAceptar.Name = "cAceptar";
            this.cAceptar.ReadOnly = true;
            // 
            // cEstatus
            // 
            this.cEstatus.HeaderText = "Estatus";
            this.cEstatus.Name = "cEstatus";
            this.cEstatus.ReadOnly = true;
            this.cEstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cCargaActual
            // 
            this.cCargaActual.HeaderText = "Alumno";
            this.cCargaActual.Name = "cCargaActual";
            this.cCargaActual.ReadOnly = true;
            // 
            // FrmAprobarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 380);
            this.Controls.Add(this.pPanelV2);
            this.Controls.Add(this.pPanel);
            this.Name = "FrmAprobarSolicitud";
            this.Text = "Aprobación de solicitud";
            this.Load += new System.EventHandler(this.FrmAprobarSolicitud_Load);
            this.pPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pPanelV2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevisor2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pPanelV2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTablaCarga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cAceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargaActual;
    }
}