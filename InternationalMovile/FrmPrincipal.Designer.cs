namespace InternationalMovile
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDsClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombresProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claseProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarPerdidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdMantProducto = new System.Windows.Forms.PictureBox();
            this.CmdLlamarFactura = new System.Windows.Forms.PictureBox();
            this.CmdFiltros = new System.Windows.Forms.PictureBox();
            this.CmdGarantia = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reporteGastosYPeridasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMantProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdLlamarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdGarantia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.iDsClientesToolStripMenuItem,
            this.nombresProductosToolStripMenuItem,
            this.claseProductosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.ic_menu_refresh;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // iDsClientesToolStripMenuItem
            // 
            this.iDsClientesToolStripMenuItem.Name = "iDsClientesToolStripMenuItem";
            this.iDsClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDsClientesToolStripMenuItem.Text = "ID\'s Clientes";
            this.iDsClientesToolStripMenuItem.Click += new System.EventHandler(this.iDsClientesToolStripMenuItem_Click);
            // 
            // nombresProductosToolStripMenuItem
            // 
            this.nombresProductosToolStripMenuItem.Name = "nombresProductosToolStripMenuItem";
            this.nombresProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombresProductosToolStripMenuItem.Text = "Nombres Productos";
            this.nombresProductosToolStripMenuItem.Click += new System.EventHandler(this.nombresProductosToolStripMenuItem_Click);
            // 
            // claseProductosToolStripMenuItem
            // 
            this.claseProductosToolStripMenuItem.Name = "claseProductosToolStripMenuItem";
            this.claseProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.claseProductosToolStripMenuItem.Text = "Clase Productos";
            this.claseProductosToolStripMenuItem.Click += new System.EventHandler(this.claseProductosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem,
            this.filtroAvanzadoToolStripMenuItem,
            this.entradaInventarioToolStripMenuItem,
            this.garantiaToolStripMenuItem,
            this.reportarPerdidaToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.Bot_Facturacion2;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // filtroAvanzadoToolStripMenuItem
            // 
            this.filtroAvanzadoToolStripMenuItem.Name = "filtroAvanzadoToolStripMenuItem";
            this.filtroAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.filtroAvanzadoToolStripMenuItem.Text = "Filtro Avanzado";
            this.filtroAvanzadoToolStripMenuItem.Click += new System.EventHandler(this.filtroAvanzadoToolStripMenuItem_Click);
            // 
            // entradaInventarioToolStripMenuItem
            // 
            this.entradaInventarioToolStripMenuItem.Name = "entradaInventarioToolStripMenuItem";
            this.entradaInventarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.entradaInventarioToolStripMenuItem.Text = "Entrada Inventario";
            // 
            // garantiaToolStripMenuItem
            // 
            this.garantiaToolStripMenuItem.Name = "garantiaToolStripMenuItem";
            this.garantiaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.garantiaToolStripMenuItem.Text = "Garantia";
            this.garantiaToolStripMenuItem.Click += new System.EventHandler(this.garantiaToolStripMenuItem_Click);
            // 
            // reportarPerdidaToolStripMenuItem
            // 
            this.reportarPerdidaToolStripMenuItem.Name = "reportarPerdidaToolStripMenuItem";
            this.reportarPerdidaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reportarPerdidaToolStripMenuItem.Text = "Reportar Perdida";
            this.reportarPerdidaToolStripMenuItem.Click += new System.EventHandler(this.reportarPerdidaToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.BOT_OFF;
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.salirDelSistemaToolStripMenuItem.Text = "Log Off";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGastosYPeridasToolStripMenuItem,
            this.reporteExistenciaToolStripMenuItem,
            this.reporteVentasToolStripMenuItem,
            this.reporteGananciasToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rEPORTESToolStripMenuItem.Text = "Reportes";
            // 
            // CmdMantProducto
            // 
            this.CmdMantProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdMantProducto.BackColor = System.Drawing.Color.White;
            this.CmdMantProducto.Image = global::InternationalMovile.Properties.Resources.Bot_mantenimiento;
            this.CmdMantProducto.Location = new System.Drawing.Point(122, 192);
            this.CmdMantProducto.Name = "CmdMantProducto";
            this.CmdMantProducto.Size = new System.Drawing.Size(155, 157);
            this.CmdMantProducto.TabIndex = 1;
            this.CmdMantProducto.TabStop = false;
            this.CmdMantProducto.Click += new System.EventHandler(this.CmdMantProducto_Click);
            // 
            // CmdLlamarFactura
            // 
            this.CmdLlamarFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdLlamarFactura.BackColor = System.Drawing.Color.White;
            this.CmdLlamarFactura.Image = global::InternationalMovile.Properties.Resources.Bot_Facturacion;
            this.CmdLlamarFactura.Location = new System.Drawing.Point(345, 50);
            this.CmdLlamarFactura.Name = "CmdLlamarFactura";
            this.CmdLlamarFactura.Size = new System.Drawing.Size(174, 173);
            this.CmdLlamarFactura.TabIndex = 1;
            this.CmdLlamarFactura.TabStop = false;
            this.CmdLlamarFactura.Click += new System.EventHandler(this.CmdLlamarFactura_Click);
            // 
            // CmdFiltros
            // 
            this.CmdFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdFiltros.BackColor = System.Drawing.Color.White;
            this.CmdFiltros.Image = global::InternationalMovile.Properties.Resources.Bot_filtro1;
            this.CmdFiltros.Location = new System.Drawing.Point(363, 286);
            this.CmdFiltros.Name = "CmdFiltros";
            this.CmdFiltros.Size = new System.Drawing.Size(174, 173);
            this.CmdFiltros.TabIndex = 1;
            this.CmdFiltros.TabStop = false;
            this.CmdFiltros.Click += new System.EventHandler(this.CmdFiltros_Click);
            // 
            // CmdGarantia
            // 
            this.CmdGarantia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdGarantia.BackColor = System.Drawing.SystemColors.Control;
            this.CmdGarantia.Image = global::InternationalMovile.Properties.Resources.Bot_garantia;
            this.CmdGarantia.Location = new System.Drawing.Point(581, 194);
            this.CmdGarantia.Name = "CmdGarantia";
            this.CmdGarantia.Size = new System.Drawing.Size(174, 167);
            this.CmdGarantia.TabIndex = 1;
            this.CmdGarantia.TabStop = false;
            this.CmdGarantia.Click += new System.EventHandler(this.CmdGarantia_Click);
            // 
            // reporteGastosYPeridasToolStripMenuItem
            // 
            this.reporteGastosYPeridasToolStripMenuItem.Name = "reporteGastosYPeridasToolStripMenuItem";
            this.reporteGastosYPeridasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteGastosYPeridasToolStripMenuItem.Text = "Reporte Gastos y peridas";
            // 
            // reporteExistenciaToolStripMenuItem
            // 
            this.reporteExistenciaToolStripMenuItem.Name = "reporteExistenciaToolStripMenuItem";
            this.reporteExistenciaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteExistenciaToolStripMenuItem.Text = "Reporte existencia";
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteVentasToolStripMenuItem.Text = "Reporte ventas";
            // 
            // reporteGananciasToolStripMenuItem
            // 
            this.reporteGananciasToolStripMenuItem.Name = "reporteGananciasToolStripMenuItem";
            this.reporteGananciasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reporteGananciasToolStripMenuItem.Text = "Reporte Ganancias";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::InternationalMovile.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(830, 478);
            this.Controls.Add(this.CmdGarantia);
            this.Controls.Add(this.CmdFiltros);
            this.Controls.Add(this.CmdLlamarFactura);
            this.Controls.Add(this.CmdMantProducto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 496);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Movile - Seller assistant";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmdMantProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdLlamarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdGarantia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claseProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDsClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroAvanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombresProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.PictureBox CmdMantProducto;
        private System.Windows.Forms.PictureBox CmdLlamarFactura;
        private System.Windows.Forms.PictureBox CmdFiltros;
        private System.Windows.Forms.PictureBox CmdGarantia;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem reportarPerdidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGastosYPeridasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGananciasToolStripMenuItem;
    }
}

