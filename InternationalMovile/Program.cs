using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;


namespace InternationalMovile
{
    static class Program
    {

        public static Procesos.FrmLogIn frmLog;
        public static Clases.Users LoggedUser;
        public static List<Clases.Parametros_Generales> Parametros_Empresa;


        public static string NombreEmpresa = "";
        public static string DireccionEmpresa = "";
        public static string MensajePieFactura = "";
        public static string RNCEmpresa = "";
        public static string Telefono1_Empresa = "";
        public static string Telefono2_Empresa = "";
        public static string ContraMaestra = "";
        public static bool PreciosPreferenciales = false;
        //public static string NombreEmpresa = "";
        //public static string NombreEmpresa = "";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //CargarParametros();
            Application.Run(new Procesos.FrmLogIn());
        }

        public static void wait(int seconds)
        {

            try
            {
                var hasta = DateTime.Now.AddSeconds(seconds);

                while (DateTime.Now < hasta)
                {
                    Application.DoEvents();
                }
            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }

        }

        public static void MensajeError(string p)
        {
            MessageBox.Show(p, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
        public static void Imprimir(string FilePath)
        {

            try
            {
                Process miProceso = new Process();
                miProceso.StartInfo.Verb = "Print";
                miProceso.StartInfo.CreateNoWindow = true;
                miProceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                miProceso.StartInfo.FileName = FilePath;
                miProceso.Start();
                miProceso.WaitForExit();
                miProceso.Close();
            }
            catch (Exception es)
            {
                throw es;
            }

        }
        */

 


        public static void MensageInfo(string mens)
        {

            try
            {
                MessageBox.Show(mens, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception es)
            {

                throw es;
            }

        }

        static void CargarParametros()
        {

            Clases.IM_DB_Entities DB = new Clases.IM_DB_Entities();
            try
            {
                Parametros_Empresa = DB.Parametros_Generales.ToList();
                NombreEmpresa = Parametros_Empresa.Where(pa => pa.NombreParametro == "Nombre_Empresa").First().Valor;
                DireccionEmpresa = Parametros_Empresa.Where(pa => pa.NombreParametro == "Direccion").First().Valor;
                MensajePieFactura = Parametros_Empresa.Where(pa => pa.NombreParametro == "Mensaje_Pie_Factura").First().Valor;
                RNCEmpresa = Parametros_Empresa.Where(pa => pa.NombreParametro == "RNC").First().Valor;
                Telefono1_Empresa = Parametros_Empresa.Where(pa => pa.NombreParametro == "Telefono1").First().Valor;
                Telefono2_Empresa = Parametros_Empresa.Where(pa => pa.NombreParametro == "Telefono2").First().Valor;
                ContraMaestra = Parametros_Empresa.Where(pa => pa.NombreParametro == "ContrasenaEspecial").First().Valor;
            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }

        }

    }
}
