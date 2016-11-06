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
    public partial class FrmTiposID : Form
    {
        Clases.IM_DB_Entities DB;
        Clases.Tipos_ID_Cliente IDSeleccionado;

        public FrmTiposID()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(1);
                TxtIDTipoID.Enabled = false;
                TxtIDTipoID.Text = "";

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();


                if (TxtIDTipoID.Text != "")
                {
                    var _ID = DB.Tipos_ID_Cliente.Where(id => id.ID_TipoID == IDSeleccionado.ID_TipoID).First();
                    _ID.Descripcion = TxtDescripcionTipoID.Text;
                    DB.SaveChanges();;
                }
                else
                {
                    DB.Tipos_ID_Cliente.Add(new Clases.Tipos_ID_Cliente()
                    {
                        Descripcion = TxtDescripcionTipoID.Text.Trim() == "" ? null : TxtDescripcionTipoID.Text
                    });
                    DB.SaveChanges();
                }
                _Refresh();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _Refresh()
        {

            try
            {
                LstTiposID.Items.Clear();
                LlenarList();
                TxtIDTipoID.Enabled = false;
                tabControl1.SelectTab(0);
                TxtDescripcionTipoID.Text = "";
                TxtIDTipoID.Text = "";
            }
            catch (Exception es)
            {

                throw es;
            }
        }

        void LlenarList()
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                var TiposID = DB.Tipos_ID_Cliente.ToList();

                foreach (var tipoID in TiposID)
                {
                    LstTiposID.Items.Add(tipoID.ID_TipoID.ToString(), 0);
                    LstTiposID.Items[LstTiposID.Items.Count - 1].SubItems.Add(tipoID.Descripcion);
                    LstTiposID.Items[LstTiposID.Items.Count - 1].Tag = tipoID;
                }

            }
            catch (Exception es)
            {

                throw es;
            }
        }

        private void FrmTiposID_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstTiposID_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                IDSeleccionado = (Clases.Tipos_ID_Cliente)LstTiposID.SelectedItems[0].Tag;

                TxtIDTipoID.Text = IDSeleccionado.ID_TipoID.ToString();
                TxtDescripcionTipoID.Text = IDSeleccionado.Descripcion;
                TxtIDTipoID.Enabled = false;
                tabControl1.SelectTab(1);

            }
            catch (Exception)
            {

            }
        }
    }
}
