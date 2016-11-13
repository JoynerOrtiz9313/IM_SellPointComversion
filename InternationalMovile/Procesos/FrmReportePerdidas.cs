using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalMovile.Procesos
{
    public partial class FrmReportePerdidas : Form
    {

        Clases.IM_DB_Entities DB;

        public FrmReportePerdidas()
        {
            InitializeComponent();
        }

        private void ChkOtroMotivo_CheckedChanged(object sender, EventArgs e)
        {
            TxtMotivo.Visible = ChkOtroMotivo.Checked;
            CmbMotivo.Enabled = !ChkOtroMotivo.Checked;
        }

        private void xtMontoPerdida_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = decimal.Parse(TxtMontoPerdida.Text);
            }
            catch (Exception)
            {
                TxtMontoPerdida.Text = "0";
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

        void ClearForm() {

            try
            {
                TxtMontoPerdida.Text = "0";
                TxtMotivo.Text = "";
                CmbMotivo.SelectedIndex = 0;
                ChkOtroMotivo.Checked = false;
                TxtComentario.Text = "";
                FrmReportePerdidas_Load(null, null);
            }
            catch (Exception es)
            {
                throw es;
            }

        }

        private void FrmReportePerdidas_Load(object sender, EventArgs e)
        {
            DB = new Clases.IM_DB_Entities();

            CmbUsuario.DataSource = DB.Users.ToList();
            CmbUsuario.DisplayMember = "Nombre";

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB = new Clases.IM_DB_Entities();
            Clases.GastosPerdidas GP = new Clases.GastosPerdidas();

            try
            {
                GP.FechaReporte = DtFechaReporte.Value;
                GP.Monto = decimal.Parse(TxtMontoPerdida.Text);
                GP.Motivo = ChkOtroMotivo.Checked ? TxtMotivo.Text : CmbMotivo.Text;
                GP.Usuario = CmbUsuario.Text;
                GP.Comentario = TxtComentario.Text;

                DB.GastosPerdidas.Add(GP);
                DB.SaveChanges();

                Program.MensageInfo("Almacenado con exito");

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
