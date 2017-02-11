namespace InternationalMovile.Procesos
{
    partial class FormadePago
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
            this.BImprimir = new System.Windows.Forms.Button();
            this.Bguardar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columfpago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columCambio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columReferenciap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(21, 149);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(75, 23);
            this.BImprimir.TabIndex = 0;
            this.BImprimir.Text = "Imprimir";
            this.BImprimir.UseVisualStyleBackColor = true;
            // 
            // Bguardar
            // 
            this.Bguardar.Location = new System.Drawing.Point(124, 149);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.Size = new System.Drawing.Size(75, 23);
            this.Bguardar.TabIndex = 1;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columfpago,
            this.columTotal,
            this.columMonto,
            this.columCambio,
            this.columReferenciap});
            this.listView1.Location = new System.Drawing.Point(14, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 113);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columfpago
            // 
            this.columfpago.Text = "Forma de Pago";
            this.columfpago.Width = 100;
            // 
            // columTotal
            // 
            this.columTotal.Text = "Total";
            // 
            // columMonto
            // 
            this.columMonto.Text = "Monto";
            // 
            // columCambio
            // 
            this.columCambio.Text = "Cambio";
            // 
            // columReferenciap
            // 
            this.columReferenciap.Text = "Referencia de Pago";
            this.columReferenciap.Width = 120;
            // 
            // FormadePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 190);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Bguardar);
            this.Controls.Add(this.BImprimir);
            this.Name = "FormadePago";
            this.Text = "FormadePago";
            this.Load += new System.EventHandler(this.FormadePago_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.Button Bguardar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columfpago;
        private System.Windows.Forms.ColumnHeader columTotal;
        private System.Windows.Forms.ColumnHeader columMonto;
        private System.Windows.Forms.ColumnHeader columCambio;
        private System.Windows.Forms.ColumnHeader columReferenciap;
    }
}