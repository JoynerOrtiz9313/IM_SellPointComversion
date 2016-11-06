namespace InternationalMovile.Mantenimientos
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LstProductos = new System.Windows.Forms.TabPage();
            this.TxtFiltroInventario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LstInventario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CmdQuitar = new System.Windows.Forms.Button();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.ListProductos_A_Ingresar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIngreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.CmbClase = new System.Windows.Forms.ComboBox();
            this.CmbNombre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID_Producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.LstProductos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.LstProductos);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // LstProductos
            // 
            this.LstProductos.Controls.Add(this.TxtFiltroInventario);
            this.LstProductos.Controls.Add(this.label6);
            this.LstProductos.Controls.Add(this.LstInventario);
            this.LstProductos.Location = new System.Drawing.Point(4, 22);
            this.LstProductos.Name = "LstProductos";
            this.LstProductos.Padding = new System.Windows.Forms.Padding(3);
            this.LstProductos.Size = new System.Drawing.Size(621, 254);
            this.LstProductos.TabIndex = 0;
            this.LstProductos.Text = "Productos activos";
            this.LstProductos.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroInventario
            // 
            this.TxtFiltroInventario.Location = new System.Drawing.Point(36, 35);
            this.TxtFiltroInventario.Name = "TxtFiltroInventario";
            this.TxtFiltroInventario.Size = new System.Drawing.Size(176, 20);
            this.TxtFiltroInventario.TabIndex = 2;
            this.TxtFiltroInventario.TextChanged += new System.EventHandler(this.TxtFiltroInventario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filtro";
            // 
            // LstInventario
            // 
            this.LstInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstInventario.FullRowSelect = true;
            this.LstInventario.GridLines = true;
            this.LstInventario.Location = new System.Drawing.Point(6, 61);
            this.LstInventario.Name = "LstInventario";
            this.LstInventario.Size = new System.Drawing.Size(608, 190);
            this.LstInventario.TabIndex = 6;
            this.LstInventario.UseCompatibleStateImageBehavior = false;
            this.LstInventario.View = System.Windows.Forms.View.Details;
            this.LstInventario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstInventario_MouseClick);
            this.LstInventario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstInventario_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Clase";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Costo";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha Ingreso";
            this.columnHeader5.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CmdQuitar);
            this.tabPage2.Controls.Add(this.CmdAgregar);
            this.tabPage2.Controls.Add(this.ListProductos_A_Ingresar);
            this.tabPage2.Controls.Add(this.dtFechaIngreso);
            this.tabPage2.Controls.Add(this.CmbClase);
            this.tabPage2.Controls.Add(this.CmbNombre);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtCosto);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TxtID_Producto);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CmdQuitar
            // 
            this.CmdQuitar.BackColor = System.Drawing.Color.White;
            this.CmdQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitar.Image = global::InternationalMovile.Properties.Resources.bot_no;
            this.CmdQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdQuitar.Location = new System.Drawing.Point(502, 128);
            this.CmdQuitar.Name = "CmdQuitar";
            this.CmdQuitar.Size = new System.Drawing.Size(96, 45);
            this.CmdQuitar.TabIndex = 6;
            this.CmdQuitar.Text = "Quitar";
            this.CmdQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdQuitar.UseVisualStyleBackColor = false;
            this.CmdQuitar.Click += new System.EventHandler(this.CmdQuitar_Click);
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.BackColor = System.Drawing.Color.White;
            this.CmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAgregar.Image = global::InternationalMovile.Properties.Resources.bot_add;
            this.CmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAgregar.Location = new System.Drawing.Point(385, 77);
            this.CmdAgregar.MaximumSize = new System.Drawing.Size(111, 45);
            this.CmdAgregar.MinimumSize = new System.Drawing.Size(111, 45);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(111, 45);
            this.CmdAgregar.TabIndex = 4;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAgregar.UseVisualStyleBackColor = false;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // ListProductos_A_Ingresar
            // 
            this.ListProductos_A_Ingresar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Descripcion,
            this.Clase,
            this.PrecioCosto,
            this.FechaIngreso});
            this.ListProductos_A_Ingresar.FullRowSelect = true;
            this.ListProductos_A_Ingresar.GridLines = true;
            this.ListProductos_A_Ingresar.Location = new System.Drawing.Point(6, 128);
            this.ListProductos_A_Ingresar.Name = "ListProductos_A_Ingresar";
            this.ListProductos_A_Ingresar.Size = new System.Drawing.Size(490, 120);
            this.ListProductos_A_Ingresar.TabIndex = 5;
            this.ListProductos_A_Ingresar.UseCompatibleStateImageBehavior = false;
            this.ListProductos_A_Ingresar.View = System.Windows.Forms.View.Details;
            this.ListProductos_A_Ingresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListProductos_A_Ingresar_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Clase
            // 
            this.Clase.Text = "Clase";
            this.Clase.Width = 50;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.Text = "Precio Costo";
            this.PrecioCosto.Width = 100;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Text = "Fecha Ingreso";
            this.FechaIngreso.Width = 110;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Location = new System.Drawing.Point(296, 51);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtFechaIngreso.TabIndex = 4;
            // 
            // CmbClase
            // 
            this.CmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClase.FormattingEnabled = true;
            this.CmbClase.Location = new System.Drawing.Point(63, 89);
            this.CmbClase.Name = "CmbClase";
            this.CmbClase.Size = new System.Drawing.Size(121, 21);
            this.CmbClase.TabIndex = 2;
            // 
            // CmbNombre
            // 
            this.CmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNombre.FormattingEnabled = true;
            this.CmbNombre.Location = new System.Drawing.Point(63, 51);
            this.CmbNombre.Name = "CmbNombre";
            this.CmbNombre.Size = new System.Drawing.Size(121, 21);
            this.CmbNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "FechaIngreso";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(262, 90);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(100, 20);
            this.TxtCosto.TabIndex = 3;
            this.TxtCosto.Leave += new System.EventHandler(this.TxtCosto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // TxtID_Producto
            // 
            this.TxtID_Producto.Location = new System.Drawing.Point(63, 15);
            this.TxtID_Producto.Name = "TxtID_Producto";
            this.TxtID_Producto.Size = new System.Drawing.Size(130, 20);
            this.TxtID_Producto.TabIndex = 0;
            this.TxtID_Producto.TextChanged += new System.EventHandler(this.TxtID_Producto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.Bot_Facturacion2;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo*";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.bot_ok;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::InternationalMovile.Properties.Resources.BOT_OFF;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(631, 320);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(647, 359);
            this.MinimumSize = new System.Drawing.Size(647, 359);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos en inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.LstProductos.ResumeLayout(false);
            this.LstProductos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LstProductos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtFiltroInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LstInventario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.ListView ListProductos_A_Ingresar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Clase;
        private System.Windows.Forms.ColumnHeader PrecioCosto;
        private System.Windows.Forms.ColumnHeader FechaIngreso;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.ComboBox CmbClase;
        private System.Windows.Forms.ComboBox CmbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdQuitar;
    }
}