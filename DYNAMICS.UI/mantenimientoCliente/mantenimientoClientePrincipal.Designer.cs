namespace DYNAMICS.UI.mantenimientoCliente
{
    partial class mantenimientoClientePrincipal
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
            this.gbfiltrar = new System.Windows.Forms.GroupBox();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnApellido = new System.Windows.Forms.Button();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.gbfiltrar.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfiltrar
            // 
            this.gbfiltrar.Controls.Add(this.btnNombre);
            this.gbfiltrar.Controls.Add(this.btnApellido);
            this.gbfiltrar.Location = new System.Drawing.Point(12, 95);
            this.gbfiltrar.Name = "gbfiltrar";
            this.gbfiltrar.Size = new System.Drawing.Size(598, 58);
            this.gbfiltrar.TabIndex = 7;
            this.gbfiltrar.TabStop = false;
            this.gbfiltrar.Text = "Filtros";
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(15, 19);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(65, 27);
            this.btnNombre.TabIndex = 6;
            this.btnNombre.Text = "Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnApellido
            // 
            this.btnApellido.Location = new System.Drawing.Point(86, 19);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(64, 27);
            this.btnApellido.TabIndex = 5;
            this.btnApellido.Text = "Apellido";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnAgregar);
            this.gbOpciones.Controls.Add(this.btnRefrescar);
            this.gbOpciones.Controls.Add(this.btnEditar);
            this.gbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(598, 77);
            this.gbOpciones.TabIndex = 6;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(86, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 27);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(15, 29);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(65, 27);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(155, 29);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 27);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgLista
            // 
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(12, 174);
            this.dgLista.Name = "dgLista";
            this.dgLista.Size = new System.Drawing.Size(598, 259);
            this.dgLista.TabIndex = 5;
            this.dgLista.TabStop = false;
            // 
            // mantenimientoClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.gbfiltrar);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.dgLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mantenimientoClientePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Cliente Principal";
            this.Load += new System.EventHandler(this.mantenimientoClientePrincipal_Load);
            this.gbfiltrar.ResumeLayout(false);
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbfiltrar;
        internal System.Windows.Forms.Button btnNombre;
        internal System.Windows.Forms.Button btnApellido;
        internal System.Windows.Forms.GroupBox gbOpciones;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnRefrescar;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.DataGridView dgLista;
    }
}