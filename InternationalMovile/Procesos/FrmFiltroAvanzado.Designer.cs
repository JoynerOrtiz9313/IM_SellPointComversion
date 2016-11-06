namespace InternationalMovile.Procesos
{
    partial class FrmFiltroAvanzado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltroAvanzado));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChkModelo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkUsarFechas = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.DtHasta = new System.Windows.Forms.DateTimePicker();
            this.DtDesde = new System.Windows.Forms.DateTimePicker();
            this.ChkClase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSum = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdRefresh = new System.Windows.Forms.Button();
            this.CmdBuscarTodo = new System.Windows.Forms.Button();
            this.GridFiltroAvanzado = new System.Windows.Forms.DataGridView();
            this.CmbClase_Buscar = new System.Windows.Forms.ComboBox();
            this.CmbModelo_Buscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtID_Buscar = new System.Windows.Forms.TextBox();
            this.GrpEstado = new System.Windows.Forms.GroupBox();
            this.RdVendido = new System.Windows.Forms.RadioButton();
            this.RdActivo = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblMontoFact = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblVendedor = new System.Windows.Forms.Label();
            this.GridVentasPorFactura = new System.Windows.Forms.DataGridView();
            this.CmdBuscarFactura = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFactura_Buscar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFiltroAvanzado)).BeginInit();
            this.GrpEstado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentasPorFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChkModelo);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.ChkClase);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.CmdRefresh);
            this.tabPage1.Controls.Add(this.CmdBuscarTodo);
            this.tabPage1.Controls.Add(this.GridFiltroAvanzado);
            this.tabPage1.Controls.Add(this.CmbClase_Buscar);
            this.tabPage1.Controls.Add(this.CmbModelo_Buscar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.TxtID_Buscar);
            this.tabPage1.Controls.Add(this.GrpEstado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moviles";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ChkModelo
            // 
            this.ChkModelo.AutoSize = true;
            this.ChkModelo.Location = new System.Drawing.Point(150, 98);
            this.ChkModelo.Name = "ChkModelo";
            this.ChkModelo.Size = new System.Drawing.Size(15, 14);
            this.ChkModelo.TabIndex = 8;
            this.ChkModelo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkUsarFechas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Lbl);
            this.groupBox2.Controls.Add(this.DtHasta);
            this.groupBox2.Controls.Add(this.DtDesde);
            this.groupBox2.Location = new System.Drawing.Point(161, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de fechas";
            this.groupBox2.Visible = false;
            // 
            // ChkUsarFechas
            // 
            this.ChkUsarFechas.AutoSize = true;
            this.ChkUsarFechas.Location = new System.Drawing.Point(259, 19);
            this.ChkUsarFechas.Name = "ChkUsarFechas";
            this.ChkUsarFechas.Size = new System.Drawing.Size(86, 17);
            this.ChkUsarFechas.TabIndex = 2;
            this.ChkUsarFechas.Text = "Usar Fechas";
            this.ChkUsarFechas.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hasta";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(9, 26);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(38, 13);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "Desde";
            // 
            // DtHasta
            // 
            this.DtHasta.Location = new System.Drawing.Point(53, 44);
            this.DtHasta.Name = "DtHasta";
            this.DtHasta.Size = new System.Drawing.Size(200, 20);
            this.DtHasta.TabIndex = 0;
            // 
            // DtDesde
            // 
            this.DtDesde.Location = new System.Drawing.Point(53, 19);
            this.DtDesde.Name = "DtDesde";
            this.DtDesde.Size = new System.Drawing.Size(200, 20);
            this.DtDesde.TabIndex = 0;
            // 
            // ChkClase
            // 
            this.ChkClase.AutoSize = true;
            this.ChkClase.Location = new System.Drawing.Point(334, 98);
            this.ChkClase.Name = "ChkClase";
            this.ChkClase.Size = new System.Drawing.Size(15, 14);
            this.ChkClase.TabIndex = 6;
            this.ChkClase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSum);
            this.groupBox1.Controls.Add(this.LblCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(529, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadro de información";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSum.Location = new System.Drawing.Point(71, 48);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(16, 17);
            this.LblSum.TabIndex = 1;
            this.LblSum.Text = "0";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(71, 23);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(16, 17);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad:";
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRefresh.Image = global::InternationalMovile.Properties.Resources.ic_menu_refresh;
            this.CmdRefresh.Location = new System.Drawing.Point(681, 239);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(90, 62);
            this.CmdRefresh.TabIndex = 1;
            this.CmdRefresh.Text = "Refresh";
            this.CmdRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmdBuscarTodo
            // 
            this.CmdBuscarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdBuscarTodo.Image = global::InternationalMovile.Properties.Resources.search_high;
            this.CmdBuscarTodo.Location = new System.Drawing.Point(681, 141);
            this.CmdBuscarTodo.Name = "CmdBuscarTodo";
            this.CmdBuscarTodo.Size = new System.Drawing.Size(90, 98);
            this.CmdBuscarTodo.TabIndex = 1;
            this.CmdBuscarTodo.Text = "Buscar";
            this.CmdBuscarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdBuscarTodo.UseVisualStyleBackColor = true;
            this.CmdBuscarTodo.Click += new System.EventHandler(this.CmdBuscarTodo_Click);
            // 
            // GridFiltroAvanzado
            // 
            this.GridFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridFiltroAvanzado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFiltroAvanzado.Location = new System.Drawing.Point(12, 141);
            this.GridFiltroAvanzado.Name = "GridFiltroAvanzado";
            this.GridFiltroAvanzado.ReadOnly = true;
            this.GridFiltroAvanzado.Size = new System.Drawing.Size(663, 160);
            this.GridFiltroAvanzado.TabIndex = 1;
            // 
            // CmbClase_Buscar
            // 
            this.CmbClase_Buscar.FormattingEnabled = true;
            this.CmbClase_Buscar.Location = new System.Drawing.Point(334, 114);
            this.CmbClase_Buscar.Name = "CmbClase_Buscar";
            this.CmbClase_Buscar.Size = new System.Drawing.Size(99, 21);
            this.CmbClase_Buscar.TabIndex = 4;
            // 
            // CmbModelo_Buscar
            // 
            this.CmbModelo_Buscar.FormattingEnabled = true;
            this.CmbModelo_Buscar.Location = new System.Drawing.Point(150, 113);
            this.CmbModelo_Buscar.Name = "CmbModelo_Buscar";
            this.CmbModelo_Buscar.Size = new System.Drawing.Size(169, 21);
            this.CmbModelo_Buscar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clase/Condición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 98);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(18, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "ID";
            // 
            // TxtID_Buscar
            // 
            this.TxtID_Buscar.Location = new System.Drawing.Point(12, 114);
            this.TxtID_Buscar.Name = "TxtID_Buscar";
            this.TxtID_Buscar.Size = new System.Drawing.Size(126, 20);
            this.TxtID_Buscar.TabIndex = 1;
            this.TxtID_Buscar.TextChanged += new System.EventHandler(this.TxtID_Buscar_TextChanged);
            // 
            // GrpEstado
            // 
            this.GrpEstado.Controls.Add(this.RdVendido);
            this.GrpEstado.Controls.Add(this.RdActivo);
            this.GrpEstado.Location = new System.Drawing.Point(6, 18);
            this.GrpEstado.Name = "GrpEstado";
            this.GrpEstado.Size = new System.Drawing.Size(149, 76);
            this.GrpEstado.TabIndex = 0;
            this.GrpEstado.TabStop = false;
            this.GrpEstado.Text = "Estado";
            // 
            // RdVendido
            // 
            this.RdVendido.AutoSize = true;
            this.RdVendido.Location = new System.Drawing.Point(6, 42);
            this.RdVendido.Name = "RdVendido";
            this.RdVendido.Size = new System.Drawing.Size(69, 17);
            this.RdVendido.TabIndex = 0;
            this.RdVendido.TabStop = true;
            this.RdVendido.Text = "Vendidos";
            this.RdVendido.UseVisualStyleBackColor = true;
            this.RdVendido.CheckedChanged += new System.EventHandler(this.RdVendido_CheckedChanged);
            // 
            // RdActivo
            // 
            this.RdActivo.AutoSize = true;
            this.RdActivo.Checked = true;
            this.RdActivo.Location = new System.Drawing.Point(6, 19);
            this.RdActivo.Name = "RdActivo";
            this.RdActivo.Size = new System.Drawing.Size(60, 17);
            this.RdActivo.TabIndex = 0;
            this.RdActivo.TabStop = true;
            this.RdActivo.Text = "Activos";
            this.RdActivo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.GridVentasPorFactura);
            this.tabPage2.Controls.Add(this.CmdBuscarFactura);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtFactura_Buscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.LblMontoFact);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LblVendedor);
            this.groupBox3.Location = new System.Drawing.Point(307, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Atendida por:";
            // 
            // LblMontoFact
            // 
            this.LblMontoFact.AutoSize = true;
            this.LblMontoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoFact.Location = new System.Drawing.Point(125, 36);
            this.LblMontoFact.Name = "LblMontoFact";
            this.LblMontoFact.Size = new System.Drawing.Size(14, 20);
            this.LblMontoFact.TabIndex = 6;
            this.LblMontoFact.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Monto Factura";
            // 
            // LblVendedor
            // 
            this.LblVendedor.AutoSize = true;
            this.LblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendedor.Location = new System.Drawing.Point(116, 16);
            this.LblVendedor.Name = "LblVendedor";
            this.LblVendedor.Size = new System.Drawing.Size(14, 20);
            this.LblVendedor.TabIndex = 5;
            this.LblVendedor.Text = "-";
            // 
            // GridVentasPorFactura
            // 
            this.GridVentasPorFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVentasPorFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVentasPorFactura.Location = new System.Drawing.Point(6, 81);
            this.GridVentasPorFactura.Name = "GridVentasPorFactura";
            this.GridVentasPorFactura.Size = new System.Drawing.Size(781, 229);
            this.GridVentasPorFactura.TabIndex = 3;
            // 
            // CmdBuscarFactura
            // 
            this.CmdBuscarFactura.Image = global::InternationalMovile.Properties.Resources.search_high;
            this.CmdBuscarFactura.Location = new System.Drawing.Point(188, 25);
            this.CmdBuscarFactura.Name = "CmdBuscarFactura";
            this.CmdBuscarFactura.Size = new System.Drawing.Size(67, 50);
            this.CmdBuscarFactura.TabIndex = 2;
            this.CmdBuscarFactura.UseVisualStyleBackColor = true;
            this.CmdBuscarFactura.Click += new System.EventHandler(this.CmdBuscarFactura_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "No. Factura";
            // 
            // TxtFactura_Buscar
            // 
            this.TxtFactura_Buscar.Location = new System.Drawing.Point(6, 55);
            this.TxtFactura_Buscar.Name = "TxtFactura_Buscar";
            this.TxtFactura_Buscar.Size = new System.Drawing.Size(176, 20);
            this.TxtFactura_Buscar.TabIndex = 0;
            // 
            // FrmFiltroAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 354);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 393);
            this.MinimumSize = new System.Drawing.Size(829, 393);
            this.Name = "FrmFiltroAvanzado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.FrmFiltroAvanzado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFiltroAvanzado)).EndInit();
            this.GrpEstado.ResumeLayout(false);
            this.GrpEstado.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentasPorFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtID_Buscar;
        private System.Windows.Forms.GroupBox GrpEstado;
        private System.Windows.Forms.RadioButton RdVendido;
        private System.Windows.Forms.RadioButton RdActivo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbClase_Buscar;
        private System.Windows.Forms.ComboBox CmbModelo_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridFiltroAvanzado;
        private System.Windows.Forms.Button CmdRefresh;
        private System.Windows.Forms.Button CmdBuscarTodo;
        private System.Windows.Forms.Button CmdBuscarFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFactura_Buscar;
        private System.Windows.Forms.DataGridView GridVentasPorFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkClase;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.DateTimePicker DtHasta;
        private System.Windows.Forms.DateTimePicker DtDesde;
        private System.Windows.Forms.CheckBox ChkUsarFechas;
        private System.Windows.Forms.CheckBox ChkModelo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblMontoFact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblVendedor;
    }
}