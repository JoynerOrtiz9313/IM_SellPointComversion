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
    public partial class FrmNombreProds : Form
    {
        Clases.IM_DB_Entities DB;
        Clases.Nombres_Productos NP;
        public FrmNombreProds()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                TxtID_NombreProd.Enabled = false;
                TxtNombreProd.Focus();
                tabControl1.SelectTab(1);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _Refresh()
        {

            DB = new Clases.IM_DB_Entities();
            Limpiar();
            LlenarList();
            tabControl1.SelectTab(0);
        }

        void LlenarList()
        {

            DB = new Clases.IM_DB_Entities();
            LstNombresProds.Items.Clear();

            foreach (var item in DB.Nombres_Productos.ToList().OrderBy(p=>p.Descripcion))
            {
                LstNombresProds.Items.Add(item.ID_Nombre_Productos.ToString().PadRight(20, ' '), 0);
                LstNombresProds.Items[LstNombresProds.Items.Count - 1].SubItems.Add(item.Descripcion);
                LstNombresProds.Items[LstNombresProds.Items.Count - 1].Tag = item;
            }

        }

        void Limpiar()
        {
            TxtID_NombreProd.Text = "";
            TxtNombreProd.Text = "";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB = new Clases.IM_DB_Entities();

            try
            {
                if (TxtID_NombreProd.Text != "")
                {

                    var _np = DB.Nombres_Productos.Where(_n => _n.ID_Nombre_Productos == NP.ID_Nombre_Productos).First();
                    _np.Descripcion = TxtNombreProd.Text.ToUpper();
                    DB.SaveChanges();
                    _Refresh();
                }
                else
                {

                    Clases.Nombres_Productos Np = new Clases.Nombres_Productos();
                    Np.Descripcion = TxtNombreProd.Text.Trim() == "" ? null : TxtNombreProd.Text.ToUpper();
                    DB.Nombres_Productos.Add(Np);
                    DB.SaveChanges();
                    _Refresh();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmNombreProds_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void LstNombresProds_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                NP = (Clases.Nombres_Productos)LstNombresProds.SelectedItems[0].Tag;

                TxtID_NombreProd.Text = NP.ID_Nombre_Productos.ToString();
                TxtID_NombreProd.Enabled = false;

                TxtNombreProd.Text = NP.Descripcion;
                tabControl1.SelectTab(1);

            }
            catch (Exception)
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar este registro?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    #region Eliminar registro
                    DB = new Clases.IM_DB_Entities();
                    var _np = DB.Nombres_Productos.Where(p => p.ID_Nombre_Productos == NP.ID_Nombre_Productos).First();

                    DB.Nombres_Productos.Remove(_np);
                    DB.SaveChanges();

                    tabControl1.SelectTab(1);
                    _Refresh();
                    #endregion
                }
                else {
                    return;
                }
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }
    }
}
