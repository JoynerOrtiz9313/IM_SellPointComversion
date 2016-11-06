namespace InternationalMovile.Procesos
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.TxtUserLog = new System.Windows.Forms.TextBox();
            this.TxtPassLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmdCancelLog = new System.Windows.Forms.Button();
            this.CmdLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUserLog
            // 
            this.TxtUserLog.Location = new System.Drawing.Point(274, 268);
            this.TxtUserLog.Name = "TxtUserLog";
            this.TxtUserLog.Size = new System.Drawing.Size(171, 20);
            this.TxtUserLog.TabIndex = 0;
            // 
            // TxtPassLog
            // 
            this.TxtPassLog.Location = new System.Drawing.Point(274, 293);
            this.TxtPassLog.Name = "TxtPassLog";
            this.TxtPassLog.Size = new System.Drawing.Size(171, 20);
            this.TxtPassLog.TabIndex = 1;
            this.TxtPassLog.UseSystemPasswordChar = true;
            this.TxtPassLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassLog_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternationalMovile.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(237, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CmdCancelLog
            // 
            this.CmdCancelLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmdCancelLog.Image = global::InternationalMovile.Properties.Resources.bot_no;
            this.CmdCancelLog.Location = new System.Drawing.Point(379, 319);
            this.CmdCancelLog.Name = "CmdCancelLog";
            this.CmdCancelLog.Size = new System.Drawing.Size(120, 89);
            this.CmdCancelLog.TabIndex = 3;
            this.CmdCancelLog.Text = "Calcelar";
            this.CmdCancelLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdCancelLog.UseVisualStyleBackColor = false;
            this.CmdCancelLog.Click += new System.EventHandler(this.CmdCancelLog_Click);
            // 
            // CmdLogIn
            // 
            this.CmdLogIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CmdLogIn.Image = global::InternationalMovile.Properties.Resources.bot_ok;
            this.CmdLogIn.Location = new System.Drawing.Point(186, 319);
            this.CmdLogIn.Name = "CmdLogIn";
            this.CmdLogIn.Size = new System.Drawing.Size(136, 89);
            this.CmdLogIn.TabIndex = 2;
            this.CmdLogIn.Text = "Iniciar Session";
            this.CmdLogIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CmdLogIn.UseVisualStyleBackColor = false;
            this.CmdLogIn.Click += new System.EventHandler(this.CmdLogIn_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(690, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmdCancelLog);
            this.Controls.Add(this.CmdLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassLog);
            this.Controls.Add(this.TxtUserLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(706, 459);
            this.MinimumSize = new System.Drawing.Size(706, 459);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Session";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUserLog;
        private System.Windows.Forms.TextBox TxtPassLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdLogIn;
        private System.Windows.Forms.Button CmdCancelLog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}