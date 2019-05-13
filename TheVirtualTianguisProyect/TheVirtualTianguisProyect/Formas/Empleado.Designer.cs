namespace TheVirtualTianguisProyect.Formas
{
    partial class Empleado
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
            this.components = new System.ComponentModel.Container();
            this.Perfil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Perfil.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Perfil
            // 
            this.Perfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(102, 26);
            this.Perfil.Opening += new System.ComponentModel.CancelEventHandler(this.Perfil_Opening);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.almacénToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem1
            // 
            this.perfilToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.perfilToolStripMenuItem1.Name = "perfilToolStripMenuItem1";
            this.perfilToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem1.Text = "Perfil";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenteToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem});
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // almacénToolStripMenuItem
            // 
            this.almacénToolStripMenuItem.Name = "almacénToolStripMenuItem";
            this.almacénToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.almacénToolStripMenuItem.Text = "Almacén";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            // 
            // gerenteToolStripMenuItem
            // 
            this.gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            this.gerenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenteToolStripMenuItem.Text = "Gerente";
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 373);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.Perfil.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Perfil;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
    }
}