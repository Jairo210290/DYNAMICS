namespace DYNAMICS.UI.mantenimientoCliente
{
    partial class mantenimientoClienteEditar
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
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbxDetallesCliente = new System.Windows.Forms.GroupBox();
            this.gpbxDetallesCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(113, 108);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(143, 20);
            this.txtTelefono2.TabIndex = 16;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(18, 115);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono2.TabIndex = 7;
            this.lblTelefono2.Text = "Teléfono 2";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(113, 83);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(143, 20);
            this.txtTelefono1.TabIndex = 15;
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Location = new System.Drawing.Point(18, 90);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono1.TabIndex = 8;
            this.lblTelefono1.Text = "Teléfono 1";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(143, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(206, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(125, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpbxDetallesCliente
            // 
            this.gpbxDetallesCliente.Controls.Add(this.lblNombre);
            this.gpbxDetallesCliente.Controls.Add(this.txtNombre);
            this.gpbxDetallesCliente.Controls.Add(this.txtTelefono2);
            this.gpbxDetallesCliente.Controls.Add(this.lblApellido);
            this.gpbxDetallesCliente.Controls.Add(this.lblTelefono2);
            this.gpbxDetallesCliente.Controls.Add(this.txtApellido);
            this.gpbxDetallesCliente.Controls.Add(this.txtTelefono1);
            this.gpbxDetallesCliente.Controls.Add(this.lblTelefono1);
            this.gpbxDetallesCliente.Location = new System.Drawing.Point(12, 22);
            this.gpbxDetallesCliente.Name = "gpbxDetallesCliente";
            this.gpbxDetallesCliente.Size = new System.Drawing.Size(269, 156);
            this.gpbxDetallesCliente.TabIndex = 21;
            this.gpbxDetallesCliente.TabStop = false;
            this.gpbxDetallesCliente.Text = "Detalles Cliente";
            // 
            // mantenimientoClienteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 237);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbxDetallesCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mantenimientoClienteEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.mantenimientoClienteEditar_Load);
            this.gpbxDetallesCliente.ResumeLayout(false);
            this.gpbxDetallesCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTelefono2;
        internal System.Windows.Forms.Label lblTelefono2;
        internal System.Windows.Forms.TextBox txtTelefono1;
        internal System.Windows.Forms.Label lblTelefono1;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.Label lblApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpbxDetallesCliente;
    }
}