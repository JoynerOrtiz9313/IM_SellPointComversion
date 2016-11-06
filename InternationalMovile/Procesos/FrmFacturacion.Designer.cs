namespace InternationalMovile.Procesos
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.TxtID_Prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstProds_A_Vender = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.LblProdSeleccionado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecioProds = new System.Windows.Forms.TextBox();
            this.CmbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ChkPreciosPreferenciales = new System.Windows.Forms.CheckBox();
            this.CmdFacturar = new System.Windows.Forms.Button();
            this.CmdCotizacion = new System.Windows.Forms.Button();
            this.CmdQuitarProd = new System.Windows.Forms.Button();
            this.CmdAgregarProd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TxtID_Prod
            // 
            this.TxtID_Prod.Location = new System.Drawing.Point(78, 16);
            this.TxtID_Prod.Name = "TxtID_Prod";
            this.TxtID_Prod.Size = new System.Drawing.Size(178, 20);
            this.TxtID_Prod.TabIndex = 0;
            this.TxtID_Prod.TextChanged += new System.EventHandler(this.TxtID_Prod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Equipo";
            // 
            // LstProds_A_Vender
            // 
            this.LstProds_A_Vender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Descripcion,
            this.Clase,
            this.Precio});
            this.LstProds_A_Vender.FullRowSelect = true;
            this.LstProds_A_Vender.GridLines = true;
            this.LstProds_A_Vender.Location = new System.Drawing.Point(12, 147);
            this.LstProds_A_Vender.Name = "LstProds_A_Vender";
            this.LstProds_A_Vender.Size = new System.Drawing.Size(507, 147);
            this.LstProds_A_Vender.TabIndex = 2;
            this.LstProds_A_Vender.UseCompatibleStateImageBehavior = false;
            this.LstProds_A_Vender.View = System.Windows.Forms.View.Details;
            this.LstProds_A_Vender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstProds_A_Vender_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID Equipo";
            this.ID.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion ";
            this.Descripcion.Width = 201;
            // 
            // Clase
            // 
            this.Clase.Text = "Clase";
            this.Clase.Width = 50;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionado";
            // 
            // LblProdSeleccionado
            // 
            this.LblProdSeleccionado.AutoSize = true;
            this.LblProdSeleccionado.Location = new System.Drawing.Point(87, 73);
            this.LblProdSeleccionado.Name = "LblProdSeleccionado";
            this.LblProdSeleccionado.Size = new System.Drawing.Size(10, 13);
            this.LblProdSeleccionado.TabIndex = 1;
            this.LblProdSeleccionado.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio";
            // 
            // TxtPrecioProds
            // 
            this.TxtPrecioProds.Location = new System.Drawing.Point(78, 101);
            this.TxtPrecioProds.Name = "TxtPrecioProds";
            this.TxtPrecioProds.Size = new System.Drawing.Size(91, 20);
            this.TxtPrecioProds.TabIndex = 1;
            this.TxtPrecioProds.TextChanged += new System.EventHandler(this.TxtPrecioProds_TextChanged);
            this.TxtPrecioProds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrecioProds_KeyDown);
            this.TxtPrecioProds.Leave += new System.EventHandler(this.TxtPrecioProds_Leave);
            // 
            // CmbClientes
            // 
            this.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClientes.FormattingEnabled = true;
            this.CmbClientes.Location = new System.Drawing.Point(307, 15);
            this.CmbClientes.Name = "CmbClientes";
            this.CmbClientes.Size = new System.Drawing.Size(133, 21);
            this.CmbClientes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(27, 127);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(45, 17);
            this.l.TabIndex = 6;
            this.l.Text = "Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(75, 127);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(17, 17);
            this.LblTotal.TabIndex = 7;
            this.LblTotal.Text = "0";
            // 
            // ChkPreciosPreferenciales
            // 
            this.ChkPreciosPreferenciales.AutoSize = true;
            this.ChkPreciosPreferenciales.Location = new System.Drawing.Point(491, 12);
            this.ChkPreciosPreferenciales.Name = "ChkPreciosPreferenciales";
            this.ChkPreciosPreferenciales.Size = new System.Drawing.Size(130, 17);
            this.ChkPreciosPreferenciales.TabIndex = 8;
            this.ChkPreciosPreferenciales.Text = "Precios preferenciales";
            this.ChkPreciosPreferenciales.UseVisualStyleBackColor = true;
            this.ChkPreciosPreferenciales.CheckedChanged += new System.EventHandler(this.ChkPreciosPreferenciales_CheckedChanged);
            this.ChkPreciosPreferenciales.Click += new System.EventHandler(this.ChkPreciosPreferenciales_Click);
            this.ChkPreciosPreferenciales.Enter += new System.EventHandler(this.ChkPreciosPreferenciales_Enter);
            this.ChkPreciosPreferenciales.Leave += new System.EventHandler(this.ChkPreciosPreferenciales_Leave);
            this.ChkPreciosPreferenciales.MouseEnter += new System.EventHandler(this.ChkPreciosPreferenciales_MouseEnter);
            // 
            // CmdFacturar
            // 
            this.CmdFacturar.Image = ((System.Drawing.Image)(resources.GetObject("CmdFacturar.Image")));
            this.CmdFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdFacturar.Location = new System.Drawing.Point(525, 257);
            this.CmdFacturar.Name = "CmdFacturar";
            this.CmdFacturar.Size = new System.Drawing.Size(96, 37);
            this.CmdFacturar.TabIndex = 3;
            this.CmdFacturar.Text = "&Facturar";
            this.CmdFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdFacturar.UseVisualStyleBackColor = true;
            this.CmdFacturar.Click += new System.EventHandler(this.CmdFacturar_Click);
            // 
            // CmdCotizacion
            // 
            this.CmdCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("CmdCotizacion.Image")));
            this.CmdCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCotizacion.Location = new System.Drawing.Point(525, 214);
            this.CmdCotizacion.Name = "CmdCotizacion";
            this.CmdCotizacion.Size = new System.Drawing.Size(96, 37);
            this.CmdCotizacion.TabIndex = 3;
            this.CmdCotizacion.Text = "&Cotización";
            this.CmdCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCotizacion.UseVisualStyleBackColor = true;
            this.CmdCotizacion.Click += new System.EventHandler(this.CmdCotizacion_Click);
            // 
            // CmdQuitarProd
            // 
            this.CmdQuitarProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmdQuitarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdQuitarProd.Image = global::InternationalMovile.Properties.Resources.bot_no;
            this.CmdQuitarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdQuitarProd.Location = new System.Drawing.Point(378, 88);
            this.CmdQuitarProd.Name = "CmdQuitarProd";
            this.CmdQuitarProd.Size = new System.Drawing.Size(103, 53);
            this.CmdQuitarProd.TabIndex = 3;
            this.CmdQuitarProd.Text = "Quitar";
            this.CmdQuitarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdQuitarProd.UseVisualStyleBackColor = false;
            this.CmdQuitarProd.Click += new System.EventHandler(this.CmdQuitarProd_Click);
            // 
            // CmdAgregarProd
            // 
            this.CmdAgregarProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmdAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAgregarProd.Image = global::InternationalMovile.Properties.Resources.bot_add;
            this.CmdAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAgregarProd.Location = new System.Drawing.Point(220, 88);
            this.CmdAgregarProd.Name = "CmdAgregarProd";
            this.CmdAgregarProd.Size = new System.Drawing.Size(112, 50);
            this.CmdAgregarProd.TabIndex = 3;
            this.CmdAgregarProd.Text = "Agregar";
            this.CmdAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAgregarProd.UseVisualStyleBackColor = false;
            this.CmdAgregarProd.Click += new System.EventHandler(this.CmdAgregarProd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(648, 299);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ChkPreciosPreferenciales);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbClientes);
            this.Controls.Add(this.CmdFacturar);
            this.Controls.Add(this.CmdCotizacion);
            this.Controls.Add(this.CmdQuitarProd);
            this.Controls.Add(this.CmdAgregarProd);
            this.Controls.Add(this.LstProds_A_Vender);
            this.Controls.Add(this.LblProdSeleccionado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrecioProds);
            this.Controls.Add(this.TxtID_Prod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(664, 338);
            this.MinimumSize = new System.Drawing.Size(664, 338);
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.Enter += new System.EventHandler(this.FrmFacturacion_Enter);
            this.MouseEnter += new System.EventHandler(this.ChkPreciosPreferenciales_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID_Prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LstProds_A_Vender;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Clase;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProdSeleccionado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecioProds;
        private System.Windows.Forms.Button CmdAgregarProd;
        private System.Windows.Forms.Button CmdQuitarProd;
        private System.Windows.Forms.Button CmdCotizacion;
        private System.Windows.Forms.Button CmdFacturar;
        private System.Windows.Forms.ComboBox CmbClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.CheckBox ChkPreciosPreferenciales;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}