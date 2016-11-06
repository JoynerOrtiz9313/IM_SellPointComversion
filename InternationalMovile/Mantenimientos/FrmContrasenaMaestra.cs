using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalMovile.Mantenimientos
{
    public partial class FrmContrasenaMaestra : Form
    {
        public FrmContrasenaMaestra()
        {
            InitializeComponent();
        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == Program.ContraMaestra) {
                Program.PreciosPreferenciales = !Program.PreciosPreferenciales;
                this.Close();
            }
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                    CmdAceptar_Click(sender, e);
            }
            catch (Exception)
            {
            }
        }
    }
}
