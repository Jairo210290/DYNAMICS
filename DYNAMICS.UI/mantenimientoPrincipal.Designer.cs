namespace DYNAMICS.UI
{
    partial class mantenimientoPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoCochesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMecanicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRevisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClienteToolStripMenuItem,
            this.mantenimientoCochesToolStripMenuItem,
            this.mantenimientoFacturaToolStripMenuItem,
            this.mantenimientoMecanicoToolStripMenuItem,
            this.mantenimientoRevisionToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // mantenimientoCochesToolStripMenuItem
            // 
            this.mantenimientoCochesToolStripMenuItem.Name = "mantenimientoCochesToolStripMenuItem";
            this.mantenimientoCochesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoCochesToolStripMenuItem.Text = "Mantenimiento Coches";
            // 
            // mantenimientoFacturaToolStripMenuItem
            // 
            this.mantenimientoFacturaToolStripMenuItem.Name = "mantenimientoFacturaToolStripMenuItem";
            this.mantenimientoFacturaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoFacturaToolStripMenuItem.Text = "Mantenimiento Factura";
            // 
            // mantenimientoMecanicoToolStripMenuItem
            // 
            this.mantenimientoMecanicoToolStripMenuItem.Name = "mantenimientoMecanicoToolStripMenuItem";
            this.mantenimientoMecanicoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoMecanicoToolStripMenuItem.Text = "Mantenimiento Mecanico";
            // 
            // mantenimientoRevisionToolStripMenuItem
            // 
            this.mantenimientoRevisionToolStripMenuItem.Name = "mantenimientoRevisionToolStripMenuItem";
            this.mantenimientoRevisionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mantenimientoRevisionToolStripMenuItem.Text = "Mantenimiento Revision";
            // 
            // mantenimientoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mantenimientoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMecanicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRevisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoCochesToolStripMenuItem;
    }
}

