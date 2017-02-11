namespace InternationalMovile.Procesos
{
    partial class FrmFacturacionIM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbClientes = new System.Windows.Forms.ComboBox();
            this.LblRNC_Cliente = new System.Windows.Forms.Label();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.TxtImei = new System.Windows.Forms.TextBox();
            this.LblNcf = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblItbis = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblNofactura = new System.Windows.Forms.Label();
            this.Bfacturar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbTipoDeNcf = new System.Windows.Forms.ComboBox();
            this.LstVerVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RNC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMEI(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio:";
            // 
            // DtFechaVenta
            // 
            this.DtFechaVenta.Location = new System.Drawing.Point(382, 3);
            this.DtFechaVenta.Name = "DtFechaVenta";
            this.DtFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.DtFechaVenta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NCF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ITBIS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "NO.Factura:";
            // 
            // CmbClientes
            // 
            this.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClientes.FormattingEnabled = true;
            this.CmbClientes.Location = new System.Drawing.Point(71, 24);
            this.CmbClientes.Name = "CmbClientes";
            this.CmbClientes.Size = new System.Drawing.Size(226, 21);
            this.CmbClientes.TabIndex = 12;
            this.CmbClientes.SelectedIndexChanged += new System.EventHandler(this.CmbClientes_SelectedIndexChanged);
            // 
            // LblRNC_Cliente
            // 
            this.LblRNC_Cliente.AutoSize = true;
            this.LblRNC_Cliente.Location = new System.Drawing.Point(71, 58);
            this.LblRNC_Cliente.Name = "LblRNC_Cliente";
            this.LblRNC_Cliente.Size = new System.Drawing.Size(21, 13);
            this.LblRNC_Cliente.TabIndex = 13;
            this.LblRNC_Cliente.Text = "##";
            // 
            // CmbProductos
            // 
            this.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(74, 82);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(223, 21);
            this.CmbProductos.TabIndex = 14;
            // 
            // TxtImei
            // 
            this.TxtImei.Location = new System.Drawing.Point(71, 114);
            this.TxtImei.Name = "TxtImei";
            this.TxtImei.Size = new System.Drawing.Size(226, 20);
            this.TxtImei.TabIndex = 17;
            this.TxtImei.TextChanged += new System.EventHandler(this.TxtImei_TextChanged);
            // 
            // LblNcf
            // 
            this.LblNcf.AutoSize = true;
            this.LblNcf.Location = new System.Drawing.Point(415, 90);
            this.LblNcf.Name = "LblNcf";
            this.LblNcf.Size = new System.Drawing.Size(21, 13);
            this.LblNcf.TabIndex = 16;
            this.LblNcf.Text = "##";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(413, 114);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 15;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(52, 314);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(21, 13);
            this.LblSubtotal.TabIndex = 18;
            this.LblSubtotal.Text = "##";
            // 
            // LblItbis
            // 
            this.LblItbis.AutoSize = true;
            this.LblItbis.Location = new System.Drawing.Point(52, 337);
            this.LblItbis.Name = "LblItbis";
            this.LblItbis.Size = new System.Drawing.Size(21, 13);
            this.LblItbis.TabIndex = 19;
            this.LblItbis.Text = "##";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(52, 359);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(21, 13);
            this.LblTotal.TabIndex = 20;
            this.LblTotal.Text = "##";
            // 
            // LblNofactura
            // 
            this.LblNofactura.AutoSize = true;
            this.LblNofactura.Location = new System.Drawing.Point(415, 72);
            this.LblNofactura.Name = "LblNofactura";
            this.LblNofactura.Size = new System.Drawing.Size(21, 13);
            this.LblNofactura.TabIndex = 21;
            this.LblNofactura.Text = "##";
            // 
            // Bfacturar
            // 
            this.Bfacturar.AccessibleDescription = "0oo";
            this.Bfacturar.Location = new System.Drawing.Point(418, 318);
            this.Bfacturar.Name = "Bfacturar";
            this.Bfacturar.Size = new System.Drawing.Size(164, 50);
            this.Bfacturar.TabIndex = 22;
            this.Bfacturar.Text = "Facturar";
            this.Bfacturar.UseVisualStyleBackColor = true;
            this.Bfacturar.Click += new System.EventHandler(this.Bfacturar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tipo de NCF:";
            // 
            // CmbTipoDeNcf
            // 
            this.CmbTipoDeNcf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDeNcf.FormattingEnabled = true;
            this.CmbTipoDeNcf.Location = new System.Drawing.Point(403, 47);
            this.CmbTipoDeNcf.Name = "CmbTipoDeNcf";
            this.CmbTipoDeNcf.Size = new System.Drawing.Size(141, 21);
            this.CmbTipoDeNcf.TabIndex = 24;
            this.CmbTipoDeNcf.SelectedIndexChanged += new System.EventHandler(this.CmbTipoDeNcf_SelectedIndexChanged);
            // 
            // LstVerVentas
            // 
            this.LstVerVentas.ImeMode = System.Windows.Forms.ImeMode.On;
            this.LstVerVentas.Location = new System.Drawing.Point(16, 159);
            this.LstVerVentas.Name = "LstVerVentas";
            this.LstVerVentas.Size = new System.Drawing.Size(497, 108);
            this.LstVerVentas.TabIndex = 25;
            // 
            // FrmFacturacionIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 380);
            this.Controls.Add(this.LstVerVentas);
            this.Controls.Add(this.CmbTipoDeNcf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Bfacturar);
            this.Controls.Add(this.LblNofactura);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblItbis);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblNcf);
            this.Controls.Add(this.TxtImei);
            this.Controls.Add(this.CmbProductos);
            this.Controls.Add(this.LblRNC_Cliente);
            this.Controls.Add(this.CmbClientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtFechaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFacturacionIM";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FrmFactutacionIM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtFechaVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbClientes;
        private System.Windows.Forms.Label LblRNC_Cliente;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.TextBox TxtImei;
        private System.Windows.Forms.Label LblNcf;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblItbis;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblNofactura;
        private System.Windows.Forms.Button Bfacturar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbTipoDeNcf;
        private System.Windows.Forms.ListBox LstVerVentas;
    }
}