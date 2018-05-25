namespace ResidenciasProfesionales.VIEW
{
    partial class FrmMostrarCalificaciones
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
            this.tablaCalificaciones = new System.Windows.Forms.DataGridView();
            this.noControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtaComentario = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCalificaciones
            // 
            this.tablaCalificaciones.AllowUserToAddRows = false;
            this.tablaCalificaciones.AllowUserToDeleteRows = false;
            this.tablaCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControl,
            this.nombre,
            this.estatus,
            this.calificacion});
            this.tablaCalificaciones.Location = new System.Drawing.Point(12, 12);
            this.tablaCalificaciones.Name = "tablaCalificaciones";
            this.tablaCalificaciones.ReadOnly = true;
            this.tablaCalificaciones.Size = new System.Drawing.Size(752, 150);
            this.tablaCalificaciones.TabIndex = 0;
            this.tablaCalificaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCalificaciones_CellClick);
            // 
            // noControl
            // 
            this.noControl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.noControl.HeaderText = "No. control";
            this.noControl.Name = "noControl";
            this.noControl.ReadOnly = true;
            this.noControl.Width = 84;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // calificacion
            // 
            this.calificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.calificacion.HeaderText = "Calificación";
            this.calificacion.Name = "calificacion";
            this.calificacion.ReadOnly = true;
            this.calificacion.Width = 86;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(12, 172);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 13);
            this.lblComentario.TabIndex = 1;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtaComentario
            // 
            this.txtaComentario.Location = new System.Drawing.Point(12, 188);
            this.txtaComentario.Name = "txtaComentario";
            this.txtaComentario.Size = new System.Drawing.Size(606, 56);
            this.txtaComentario.TabIndex = 2;
            this.txtaComentario.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(624, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(621, 172);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(624, 192);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(140, 23);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // FrmMostrarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 256);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtaComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.tablaCalificaciones);
            this.Name = "FrmMostrarCalificaciones";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCalificaciones;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.RichTextBox txtaComentario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCambiar;
    }
}