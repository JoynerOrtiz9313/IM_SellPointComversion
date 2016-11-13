namespace InternationalMovile.Procesos
{
    partial class FrmReportePerdidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePerdidas));
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.TxtMontoPerdida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMotivo = new System.Windows.Forms.ComboBox();
            this.ChkOtroMotivo = new System.Windows.Forms.CheckBox();
            this.DtFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Location = new System.Drawing.Point(12, 89);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(155, 79);
            this.TxtMotivo.TabIndex = 0;
            this.TxtMotivo.Visible = false;
            // 
            // TxtMontoPerdida
            // 
            this.TxtMontoPerdida.Location = new System.Drawing.Point(9, 202);
            this.TxtMontoPerdida.Name = "TxtMontoPerdida";
            this.TxtMontoPerdida.Size = new System.Drawing.Size(155, 20);
            this.TxtMontoPerdida.TabIndex = 0;
            this.TxtMontoPerdida.TextChanged += new System.EventHandler(this.xtMontoPerdida_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto";
            // 
            // CmbMotivo
            // 
            this.CmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMotivo.FormattingEnabled = true;
            this.CmbMotivo.Items.AddRange(new object[] {
            "Transporte",
            "Atraco",
            "Reparacion de equipo"});
            this.CmbMotivo.Location = new System.Drawing.Point(12, 55);
            this.CmbMotivo.Name = "CmbMotivo";
            this.CmbMotivo.Size = new System.Drawing.Size(152, 21);
            this.CmbMotivo.TabIndex = 2;
            // 
            // ChkOtroMotivo
            // 
            this.ChkOtroMotivo.AutoSize = true;
            this.ChkOtroMotivo.Location = new System.Drawing.Point(184, 59);
            this.ChkOtroMotivo.Name = "ChkOtroMotivo";
            this.ChkOtroMotivo.Size = new System.Drawing.Size(46, 17);
            this.ChkOtroMotivo.TabIndex = 3;
            this.ChkOtroMotivo.Text = "Otro";
            this.ChkOtroMotivo.UseVisualStyleBackColor = true;
            this.ChkOtroMotivo.CheckedChanged += new System.EventHandler(this.ChkOtroMotivo_CheckedChanged);
            // 
            // DtFechaReporte
            // 
            this.DtFechaReporte.Location = new System.Drawing.Point(252, 71);
            this.DtFechaReporte.Name = "DtFechaReporte";
            this.DtFechaReporte.Size = new System.Drawing.Size(200, 20);
            this.DtFechaReporte.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Gasto o perdida";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(181, 24);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(10, 13);
            this.LblID.TabIndex = 6;
            this.LblID.Text = "-";
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(252, 130);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(200, 55);
            this.TxtComentario.TabIndex = 7;
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(252, 201);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(200, 21);
            this.CmbUsuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comentario";
            // 
            // FrmReportePerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 238);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbUsuario);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.DtFechaReporte);
            this.Controls.Add(this.ChkOtroMotivo);
            this.Controls.Add(this.CmbMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMontoPerdida);
            this.Controls.Add(this.TxtMotivo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(490, 277);
            this.MinimumSize = new System.Drawing.Size(490, 277);
            this.Name = "FrmReportePerdidas";
            this.Text = "Gastos o Perdidas";
            this.Load += new System.EventHandler(this.FrmReportePerdidas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.TextBox TxtMontoPerdida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMotivo;
        private System.Windows.Forms.CheckBox ChkOtroMotivo;
        private System.Windows.Forms.DateTimePicker DtFechaReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.Label label4;
    }
}