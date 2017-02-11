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
    public partial class FrmClientes : Form
    {
        Clases.IM_DB_Entities DB;
        Clases.Clientes esteCliente;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                bool existe = false; 
                try
                {
                 existe = DB.Clientes.Where(cl => cl.Cedula_RNC == esteCliente.Cedula_RNC).Any();
                }
                catch (Exception) {
                    existe = false;
                }
                    
                    if (existe)
                {

                    var cliente = DB.Clientes.Where(cl => cl.Cedula_RNC == esteCliente.Cedula_RNC).First();

                    cliente.Cedula_RNC = TxtIDCliente.Text;
                    cliente.Comentario = TxtCommentario.Text;
                    cliente.Correo = TxtCorreo.Text;
                    cliente.Direccion = TxtDireccion.Text;
                    cliente.Nombre = TxtNombre.Text;
                    cliente.Telefono1 = TxtTelefono1.Text;
                    cliente.Telefono2 = TxtTelefono2.Text;
                    cliente.TipoID = (int)CmbTipoID.SelectedValue;
                    //cliente.RNC = TxtRnc.Text;

                    DB.SaveChanges();
                }
                else
                {

                    DB.Clientes.Add(new Clases.Clientes()
                    {
                        Cedula_RNC = TxtIDCliente.Text,
                        TipoID = 1,
                        Comentario = TxtCommentario.Text.Trim() == "" ? null : TxtCommentario.Text,
                        Correo = TxtCorreo.Text.Trim() == "" ? null : TxtCorreo.Text,
                        Direccion = TxtDireccion.Text.Trim() == "" ? null : TxtDireccion.Text,
                        Nombre = TxtNombre.Text.Trim() == "" ? null : TxtNombre.Text,
                        Telefono1 = TxtTelefono1.Text.Trim() == "" ? null : TxtTelefono1.Text,
                        Telefono2 = TxtTelefono2.Text.Trim() == "" ? null : TxtTelefono2.Text,
                        //RNC = TxtRnc.Text.Trim() == "" ? null : TxtRnc.Text,

                    });
                    DB.SaveChanges();
                }
                MessageBox.Show("Registro Guardado!", "Listo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Refresh();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Limpiar() {

            try
            {
                TxtCommentario.Text = "";
                TxtNombre.Text = "";
                TxtTelefono1.Text = "";
                TxtTelefono2.Text = "";
                TxtDireccion.Text = "";
                TxtIDCliente.Text = "";
                TxtCorreo.Text = "";
                
            }
            catch (Exception es)
            {
                
                throw es;
            }

        }

        void LlegarList()
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                var Clientes = DB.Clientes.Select(cl => cl).ToList();
                LstClientes.Items.Clear();

                foreach (var cliente in Clientes)
                {
                    LstClientes.Items.Add(cliente.Cedula_RNC.PadRight(15,' '), 0);
                    LstClientes.Items[LstClientes.Items.Count - 1].SubItems.Add(cliente.Nombre);
                    LstClientes.Items[LstClientes.Items.Count - 1].SubItems.Add(cliente.Telefono1);
                    LstClientes.Items[LstClientes.Items.Count - 1].SubItems.Add(cliente.Correo);
                    LstClientes.Items[LstClientes.Items.Count - 1].Tag = cliente;
                }

            }
            catch (Exception es)
            {

                throw es;
            }
        }

        void LlenarTiposID()
        {

            try
            {
                DB = new Clases.IM_DB_Entities();
                var clases = DB.Tipos_ID_Cliente.Select(id => id).ToList();

                CmbTipoID.DataSource = clases;
                CmbTipoID.DisplayMember = "Descripcion";
                CmbTipoID.ValueMember = "ID_TipoID";
            }
            catch (Exception es)
            {

                throw es;
            }

        }

        void _Refresh()
        {
            try
            {
               
                LlegarList();
                LlenarTiposID();
                Limpiar();
                tabControl1.SelectTab(0);
            }
            catch (Exception es)
            {

                throw es;
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                _Refresh();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                TxtIDCliente.Enabled = true;
                tabControl1.SelectTab(1);
                TxtIDCliente.Focus();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstClientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                esteCliente = (Clases.Clientes)LstClientes.SelectedItems[0].Tag;
                
                TxtCorreo.Text = esteCliente.Correo;
                TxtDireccion.Text = esteCliente.Direccion;
                TxtNombre.Text = esteCliente.Nombre;
                TxtIDCliente.Text = esteCliente.Cedula_RNC;
                TxtTelefono1.Text = esteCliente.Telefono1;
                TxtTelefono2.Text = esteCliente.Telefono2;
                TxtCommentario.Text = esteCliente.Comentario;
                CmbTipoID.SelectedValue = esteCliente.TipoID;

                TxtIDCliente.Enabled = false;
                tabControl1.SelectTab(1);


            }
            catch (Exception)
            {
                return;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
