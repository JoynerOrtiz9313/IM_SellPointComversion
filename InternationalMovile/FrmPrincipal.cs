using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternationalMovile.Mantenimientos;
using InternationalMovile.Procesos;
using InternationalMovile.Clases;


namespace InternationalMovile
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Clases.IM_DB_Entities DB = new IM_DB_Entities();
            Clases.Cargos cargo = new Clases.Cargos();

            cargo = DB.Cargos.Where(c => c.ID_Cargo == Program.LoggedUser.Cargo).First();


            if (!cargo.Descripcion.Contains("Adm"))
            {
                this.menuStrip1.Enabled = false;
            }

            toolTip1.SetToolTip(CmdLlamarFactura, "Facturacion");
            toolTip1.SetToolTip(CmdFiltros, "Buscar");
            toolTip1.SetToolTip(CmdGarantia, "Garantia");
            toolTip1.SetToolTip(CmdMantProducto, "Entrada Inventario");
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr =MessageBox.Show("Seguro que desea salir del sistema?",
                "Seguro?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Program.frmLog.Show();
            }
            else {
                e.Cancel = true;
            }

        }

        private void claseProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClasesProd Frm = new FrmClasesProd();
           // Frm.MdiParent = this;
            Frm.ShowDialog();
        }

        private void iDsClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmTiposID frm = new FrmTiposID();
           // frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmClientes Frm = new FrmClientes();
            //Frm.MdiParent = this;
            Frm.ShowDialog();
        }

        private void nombresProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmNombreProds Frm = new FrmNombreProds();
            //Frm.MdiParent = this;
            Frm.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmInventario Frm = new FrmInventario();
            //Frm.MdiParent = this;
            Frm.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Procesos.FrmFacturacion Frm = new FrmFacturacion();
               // Frm.MdiParent = this;
                Frm.ShowDialog();
            }
            catch (Exception)
            {
                
            }
        }

        private void garantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarantiaMovil frm = new GarantiaMovil();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void filtroAvanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiltroAvanzado frm = new FrmFiltroAvanzado();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantUsuarios FrmUsers = new FrmMantUsuarios();
            FrmUsers.ShowDialog();
        }

        private void CmdLlamarFactura_Click(object sender, EventArgs e)
        {
            FrmFacturacion Frm = new FrmFacturacion();
            Frm.ShowDialog();
        }

        private void CmdGarantia_Click(object sender, EventArgs e)
        {
            GarantiaMovil Frm = new GarantiaMovil();
            Frm.ShowDialog();
        }

        private void CmdMantProducto_Click(object sender, EventArgs e)
        {
            FrmInventario Frm = new FrmInventario();
            Frm.ShowDialog();
        }

        private void CmdFiltros_Click(object sender, EventArgs e)
        {
            FrmFiltroAvanzado Frm = new FrmFiltroAvanzado();
            Frm.ShowDialog();
        }

        private void reportarPerdidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePerdidas Frm = new FrmReportePerdidas();
            Frm.ShowDialog();
        }

        
        
        
        
    }
}
