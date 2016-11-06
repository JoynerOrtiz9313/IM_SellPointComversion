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
    public partial class FrmClasesProd : Form
    {
        Clases.IM_DB_Entities DB;
        Clases.Clases_Productos EstaClase;

        public FrmClasesProd()
        {
            InitializeComponent();
        }

        private void FrmClasesProd_Load(object sender, EventArgs e)
        {
            LlenarList();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EstaClase = null;
                tabControl1.SelectTab(1);
                TxtIDProd.Text = "";
                TxtIDProd.Enabled = false;
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
                if (TxtIDProd.Text.Trim() == "")
                {
                    DB.Clases_Productos.Add(new Clases.Clases_Productos()
                    {
                        Descripcion = TxtDescripcionProd.Text.Trim() == "" ? null : TxtDescripcionProd.Text

                    });

                    DB.SaveChanges();
                    MessageBox.Show("Registro Guardado!", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {

                    var clase = DB.Clases_Productos.Where(cp => cp.ID_CLase == EstaClase.ID_CLase).First();
                    clase.Descripcion = TxtDescripcionProd.Text;
                    DB.SaveChanges();
                }
                TxtDescripcionProd.Text = "";
                TxtIDProd.Text = "";
                LstProds.Items.Clear();
                LlenarList();
                tabControl1.SelectTab(0);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LlenarList()
        {

            try
            {
                DB = new Clases.IM_DB_Entities();
                var Productos = DB.Clases_Productos.Select(prod => prod).ToList();

                foreach (var prod in Productos)
                {
                    LstProds.Items.Add(prod.ID_CLase.ToString(), 0);
                    LstProds.Items[LstProds.Items.Count - 1].SubItems.Add(prod.Descripcion);
                    LstProds.Items[LstProds.Items.Count - 1].Tag = prod;
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                DB = new Clases.IM_DB_Entities();
                if (TxtIDProd.Text.Trim() != "")
                {
                    var prod = DB.Clases_Productos.FirstOrDefault(x => x.ID_CLase == int.Parse(TxtIDProd.Text));

                    DB.Clases_Productos.Remove(prod);
                    MessageBox.Show("Registro Eliminado!", "Listo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TxtDescripcionProd.Text = "";
                TxtIDProd.Text = "";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstProds_Click(object sender, EventArgs e)
        {
            try
            {
                EstaClase = (Clases.Clases_Productos)LstProds.SelectedItems[0].Tag;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void LstProds_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(1);
                TxtIDProd.Text = EstaClase.ID_CLase.ToString();
                TxtDescripcionProd.Text = EstaClase.Descripcion;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
