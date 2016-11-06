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
    public partial class FrmMantUsuarios : Form
    {
        Clases.IM_DB_Entities DB;
        bool editando = false;

        Clases.Users usuarioSeleccionado;

        public FrmMantUsuarios()
        {
            InitializeComponent();
        }

        private void CmbCargos_MouseClick(object sender, MouseEventArgs e)
        {
            CargarCargos();
        }

        private void FrmMantUsuarios_Load(object sender, EventArgs e)
        {
            CargarCargos();
            CargarUsuarios();
        }

        void CargarUsuarios()
        {

            try
            {
                DB = new Clases.IM_DB_Entities();
                TxtCuenta.Enabled = true;
                GridUsuarios.DataSource = DB.Users.Select(usr => usr).ToList();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void CargarCargos()
        {

            try
            {

                DB = new Clases.IM_DB_Entities();
                CmbCargos.DataSource = DB.Cargos.ToList();
                CmbCargos.DisplayMember = "Descripcion";
                CmbCargos.ValueMember = "ID_Cargo";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetAdmin()
        {
            CargarCargos();
            CmbCargos.SelectedIndex = 0;
            CmbCargos.Enabled = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtCuenta.Enabled = true;
                tabControl1.SelectTab(1);
                TxtIDUsuario.Enabled = false;
                TxtCuenta.Focus();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();

                if (editando == false)
                {

                    DB.Users.Add(new Clases.Users()
                    {
                        Nombre = TxtNombre.Text.Trim() == "" ? null : TxtNombre.Text,
                        Cargo = (int)CmbCargos.SelectedValue,
                        Cedula = TxtCedulaUsuario.Text.Trim() == "" ? null : TxtCedulaUsuario.Text,
                        Direccion = TxtDireccionUsuario.Text.Trim() == "" ? null : TxtDireccionUsuario.Text,
                        Login_Name = TxtCuenta.Text.Trim() == "" ? null : TxtCuenta.Text,
                        Login_Pass = TxtContrasena.Text.Trim() == "" ? null : TxtContrasena.Text,
                        Telefono_Movil = TxtTelefonoUsuario.Text.Trim() == "" ? null : TxtTelefonoUsuario.Text,
                        Telefono_Local = TxtMovilUsuario.Text.Trim() == "" ? null : TxtMovilUsuario.Text
                    });

                    DB.SaveChanges();
                    CargarUsuarios();
                    tabControl1.SelectTab(0);

                }
                else
                {

                    var EdiUsu = DB.Users.Where(us => us.Login_Name == usuarioSeleccionado.Login_Name).First();

                    EdiUsu.Nombre = TxtNombre.Text.Trim() == "" ? null : TxtNombre.Text;
                    EdiUsu.Cargo = (int)CmbCargos.SelectedValue;
                    EdiUsu.Cedula = TxtCedulaUsuario.Text.Trim() == "" ? null : TxtCedulaUsuario.Text;
                    EdiUsu.Direccion = TxtDireccionUsuario.Text.Trim() == "" ? null : TxtDireccionUsuario.Text;
                    EdiUsu.Login_Name = TxtCuenta.Text.Trim() == "" ? null : TxtCuenta.Text;
                    EdiUsu.Login_Pass = TxtContrasena.Text.Trim() == "" ? null : TxtContrasena.Text;
                    EdiUsu.Telefono_Movil = TxtTelefonoUsuario.Text.Trim() == "" ? null : TxtTelefonoUsuario.Text;
                    EdiUsu.Telefono_Local = TxtMovilUsuario.Text.Trim() == "" ? null : TxtMovilUsuario.Text;

                    DB.SaveChanges();
                    MessageBox.Show("Tarea completada con exito", "Editado!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectTab(0);
                    CargarUsuarios();
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DB = new Clases.IM_DB_Entities();

            try
            {
                string param = GridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();

                var Usu = DB.Users.Where(us => us.Login_Name == param).First();

                usuarioSeleccionado = Usu;
                TxtCedulaUsuario.Text = usuarioSeleccionado.Cedula;
                TxtContrasena.Text = usuarioSeleccionado.Login_Pass;
                TxtCuenta.Text = usuarioSeleccionado.Login_Name;
                TxtDireccionUsuario.Text = usuarioSeleccionado.Direccion;
                TxtIDUsuario.Text = usuarioSeleccionado.Usr_ID.ToString();
                TxtMovilUsuario.Text = usuarioSeleccionado.Telefono_Movil;
                TxtNombre.Text = usuarioSeleccionado.Nombre;
                TxtTelefonoUsuario.Text = usuarioSeleccionado.Telefono_Local;

                TxtCuenta.Enabled = false;
                editando = true;
                tabControl1.SelectTab(1);

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

    }
}
