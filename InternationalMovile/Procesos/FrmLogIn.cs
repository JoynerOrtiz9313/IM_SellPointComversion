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
    public partial class FrmLogIn : Form
    {

        Clases.IM_DB_Entities DB;

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                if (DB.Users.ToList().Count <= 0)
                {
                    MessageBox.Show("No hay ningún usuario registrado," +
                        " favor Registre un administrador",
                        "No hay usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Mantenimientos.FrmMantUsuarios frm = new Mantenimientos.FrmMantUsuarios();
                    frm.SetAdmin();
                    frm.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void CmdLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();

                var usr = from us in DB.Users
                          where us.Login_Name == TxtUserLog.Text
                          && us.Login_Pass == TxtPassLog.Text
                          select us;

                Clases.Users user = new Clases.Users()
                {
                    Nombre = usr.Select(u => u.Nombre).FirstOrDefault(),
                    Login_Name = usr.Select(u => u.Login_Name).FirstOrDefault(),
                    Login_Pass = usr.Select(u => u.Login_Pass).FirstOrDefault(),
                    Telefono_Local = usr.Select(u => u.Telefono_Local).FirstOrDefault(),
                    Telefono_Movil = usr.Select(u => u.Telefono_Movil).FirstOrDefault(),
                    Direccion = usr.Select(u => u.Direccion).FirstOrDefault(),
                    Cedula = usr.Select(u => u.Cedula).FirstOrDefault(),
                    Cargo = usr.Select(u => u.Cargo).FirstOrDefault(),
                    Usr_ID = usr.Select(u => u.Usr_ID).FirstOrDefault()
                };

                

                if (user.Usr_ID != 0)
                {
                    MessageBox.Show("Bienvenido!", "Hola " + user.Nombre, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    FrmPrincipal frm = new FrmPrincipal();
                    
                    Program.frmLog = this;
                    Program.LoggedUser = user;

                    TxtPassLog.Text = "";
                    TxtUserLog.Text = "";

                    this.Hide();
                    frm.Show();

                }
                else {
                    MessageBox.Show("Usuario no encontrado.\nIntentelo de nuevo","No encontrado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    TxtPassLog.Text = "";
                    TxtUserLog.Focus();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void CmdCancelLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassLog_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                    CmdLogIn_Click(sender, e);
            }
            catch (Exception)
            {
                return;
            }
        }

    }
}
