namespace ResidenciasProfesionales.VIEW
{
    partial class FrmLiberacionInforme
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
            this.btnLiberar = new System.Windows.Forms.Button();
            this.dgvTablaCarga = new System.Windows.Forms.DataGridView();
            this.cAceptar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cNoCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pPanel.TabIndex = 5;
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
            this.pPanelV2.Controls.Add(this.btnLiberar);
            this.pPanelV2.Controls.Add(this.dgvTablaCarga);
            this.pPanelV2.Location = new System.Drawing.Point(1, 29);
            this.pPanelV2.Name = "pPanelV2";
            this.pPanelV2.Size = new System.Drawing.Size(525, 301);
            this.pPanelV2.TabIndex = 6;
            // 
            // btnLiberar
            // 
            this.btnLiberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberar.Location = new System.Drawing.Point(11, 12);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(75, 31);
            this.btnLiberar.TabIndex = 23;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            // 
            // dgvTablaCarga
            // 
            this.dgvTablaCarga.AllowUserToAddRows = false;
            this.dgvTablaCarga.AllowUserToDeleteRows = false;
            this.dgvTablaCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAceptar,
            this.cNoCont,
            this.cAlumn,
            this.cEstado});
            this.dgvTablaCarga.Location = new System.Drawing.Point(11, 49);
            this.dgvTablaCarga.Name = "dgvTablaCarga";
            this.dgvTablaCarga.ReadOnly = true;
            this.dgvTablaCarga.Size = new System.Drawing.Size(500, 216);
            this.dgvTablaCarga.TabIndex = 20;
            // 
            // cAceptar
            // 
            this.cAceptar.HeaderText = "";
            this.cAceptar.Name = "cAceptar";
            this.cAceptar.ReadOnly = true;
            // 
            // cNoCont
            // 
            this.cNoCont.HeaderText = "No. Control";
            this.cNoCont.Name = "cNoCont";
            this.cNoCont.ReadOnly = true;
            // 
            // cAlumn
            // 
            this.cAlumn.HeaderText = "Alumno";
            this.cAlumn.Name = "cAlumn";
            this.cAlumn.ReadOnly = true;
            // 
            // cEstado
            // 
            this.cEstado.HeaderText = "Estado";
            this.cEstado.Name = "cEstado";
            this.cEstado.ReadOnly = true;
            // 
            // FrmLiberacionInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 331);
            this.Controls.Add(this.pPanelV2);
            this.Controls.Add(this.pPanel);
            this.Name = "FrmLiberacionInforme";
            this.Text = "Liberación de informe";
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
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.DataGridView dgvTablaCarga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado;
    }
}