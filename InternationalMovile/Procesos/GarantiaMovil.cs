using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InternationalMovile.Procesos
{
    public partial class GarantiaMovil : Form
    {
        bool Buscando = false;
        public GarantiaMovil()
        {
            InitializeComponent();
        }

        Clases.IM_DB_Entities DB = new Clases.IM_DB_Entities();
        Clases.Productos_V Movil_Cliente;
        Clases.Productos Movil_Nuevo;
        Clases.Ventas venta;
        Clases.Clientes cliente;
        Clases.Facturas fact;
        Clases.Clases_Productos cp;
        Clases.Nombres_Productos NP;
        Clases.Users Vendedor;

        private void GarantiaMovil_Load(object sender, EventArgs e)
        {

        }

        private void LblClase_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblFechaVencimiento_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void LblNombreProd_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ChIntercambiar_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = ChIntercambiar.Checked;
        }



        private void TxtCodigoTelCliente_TextChanged(object sender, EventArgs e)
        {
            if (Buscando)
                return;

            if (TxtCodigoTelCliente.Text.Length >= 9)
            {
                Buscando = true;
                Program.wait(2);
                try
                {
                    Movil_Cliente = new Clases.Productos_V();
                    Movil_Cliente = DB.Productos_V.Where(p => p.ID_Producto == TxtCodigoTelCliente.Text).First();

                    venta = new Clases.Ventas();
                    cliente = new Clases.Clientes();
                    fact = new Clases.Facturas();
                    cp = new Clases.Clases_Productos();
                    NP = new Clases.Nombres_Productos();


                    NP = DB.Nombres_Productos.Where(np => np.ID_Nombre_Productos == Movil_Cliente.NombreProducto).FirstOrDefault();
                    cp = DB.Clases_Productos.Where(clase => clase.ID_CLase == Movil_Cliente.Clase).FirstOrDefault();
                    venta = DB.Ventas.Where(v => v.Producto == Movil_Cliente.ID_Producto).FirstOrDefault();
                    fact = DB.Facturas.Where(f => f.ID_Factura == venta.Factura).FirstOrDefault();
                    cliente = DB.Clientes.Where(c => c.Cedula_RNC == fact.Cliente).FirstOrDefault();
                    int IDVendedor = int.Parse(fact.vendedor);
                    Vendedor = DB.Users.Where(u => u.Usr_ID == IDVendedor).FirstOrDefault();

                    LblCliente.Text = cliente.Nombre;
                    LblFecha.Text = fact.Fecha.ToString();
                    LblClase.Text = cp.Descripcion;
                    LblFechaVencimiento.Text = fact.Fecha.AddDays(15).ToString();
                    LblNombreProd.Text = NP.Descripcion;
                    LblNumeroFactura.Text = fact.ID_Factura.ToString();
                    LblVendedor.Text = Vendedor.Nombre;
                    Buscando = false;

                }
                catch (Exception)
                {
                    MensajeInfo("Producto no encontrado en ventas");
                    TxtCodigoTelCliente.Text = "";
                    TxtCodigoTelCliente.Focus();
                    return;
                }


            }
        }

        void MensajeError(string Mensaje)
        {

            MessageBox.Show(Mensaje, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void MensajeInfo(string Mensaje)
        {

            MessageBox.Show(Mensaje, "Info!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TxtCodigoNuevoTelefono_TextChanged(object sender, EventArgs e)
        {
            if (Buscando)
                return;

            if (TxtCodigoNuevoTelefono.Text.Length >= 9)
            {
                Buscando = true;
                Program.wait(2);
                try
                {
                    Movil_Nuevo = new Clases.Productos();
                    Movil_Nuevo = DB.Productos.Where(p => p.ID_Producto == TxtCodigoNuevoTelefono.Text).First();

                    Clases.Clases_Productos _cp = new Clases.Clases_Productos();
                    Clases.Nombres_Productos _NP = new Clases.Nombres_Productos();

                    _NP = DB.Nombres_Productos.Where(np => np.ID_Nombre_Productos == Movil_Nuevo.NombreProducto).FirstOrDefault();
                    _cp = DB.Clases_Productos.Where(clase => clase.ID_CLase == Movil_Nuevo.Clase).FirstOrDefault();
                    //venta = DB.Ventas.Where(v => v.Producto == Movil_Cliente.ID_Producto).FirstOrDefault();
                    //fact = DB.Facturas.Where(f => f.ID_Factura == venta.Factura).FirstOrDefault();
                    //cliente = DB.Clientes.Where(c => c.Cedula_RNC == fact.Cliente).FirstOrDefault();
                    LblNuevoNombreMovil.Text = _NP.Descripcion;
                    LblNuevaClaseMovil.Text = _cp.Descripcion;
                    Buscando = false;
                }
                catch (Exception)
                {
                    //MensajeInfo("Producto no encontrado en inventario");
                    TxtCodigoNuevoTelefono.Text = "";
                    TxtCodigoNuevoTelefono.Focus();
                    return;
                }
            }
        }

        private void CmdIntercambiar_Click(object sender, EventArgs e)
        {
            DB = new Clases.IM_DB_Entities();
            try
            {
                var _ModVenta = DB.Ventas.Where(_v => _v.ID_Venta == venta.ID_Venta).First();
                _ModVenta.Producto = Movil_Nuevo.ID_Producto;
                var _ProdToDelete = DB.Productos.Where(p => p.ID_Producto == Movil_Nuevo.ID_Producto).First();
                DB.Productos.Remove(_ProdToDelete);
                var _ProdToDelete2 = DB.Productos_V.Where(p => p.ID_Producto == Movil_Cliente.ID_Producto).First();
                DB.Productos_V.Remove(_ProdToDelete2);

                DB.Productos_V.Add(
                    new Clases.Productos_V
                    {
                        Clase = Movil_Nuevo.Clase,
                        Fecha_Ingreso = DateTime.Today,
                        ID_Producto = Movil_Nuevo.ID_Producto,
                        NombreProducto = Movil_Nuevo.NombreProducto,
                        Precio_Costo = Movil_Cliente.Precio_Costo
                    }
                    );

                DB.SaveChanges();
                MensajeInfo("Intercambiado con exito");
                //-------------VENTA ALTERADA------------------------
                int _factNumb = int.Parse(LblNumeroFactura.Text);
                GuardarArchivo("MOD_Factura cliente_" + LblCliente.Text + "_" + DateTime.Now.ToString("ddMMyyyy_hhmm"),
                    "<span style='font-weight: bold'> "+ Construir__Factura(DB.Ventas.Where(_v => _v.Facturas.ID_Factura == _factNumb).ToList(), LblCliente.Text) + "</span>"
                    );
            }
            catch (Exception es)
            {

                Program.MensajeError(es.Message);

            }
        }

        string Construir__Factura(List<Clases.Ventas> Ventas, string Cliente)
        {

            string Factura = "";
            DB = new Clases.IM_DB_Entities();
            List<Clases.Productos_V> prods = new List<Clases.Productos_V>();

            try
            {
                foreach (var item in Ventas)
                {
                    var prod = DB.Productos_V.Where(pr => pr.ID_Producto == item.Producto).FirstOrDefault();
                    prod.Precio_Costo = item.Precio_Venta;
                    prods.Add(prod);
                }

                var Modelos = prods.Select(p => p.NombreProducto).Distinct().ToList<int>();
                var Clases = prods.Select(p => p.Clase).Distinct().ToList<int>();

                Factura = "\t \t \t \t" + Program.NombreEmpresa + " \r\n";
                Factura += "\t \t " + Program.DireccionEmpresa + "\r\n";
                Factura += "\t \t \t Tel:" + Program.Telefono1_Empresa + " Tel2:" + Program.Telefono2_Empresa;
                Factura += "\r\n";
                Factura += "================================================================\r\n";

                Factura += "Detalle de compra del cliente: " + Cliente + "\r\n";
                Factura += "================================================================\r\n";
                Factura += "Fact No." + Ventas[0].Factura + "\r\n";

                foreach (var mod in Modelos)
                {
                    foreach (var cla in Clases)
                    {
                        int cantidad = prods.Where(p => p.NombreProducto == mod && p.Clase == cla).ToList().Count;
                        decimal precio = prods.Where(p => p.NombreProducto == mod && p.Clase == cla).First().Precio_Costo;

                        var m = DB.Nombres_Productos.Where(np => np.ID_Nombre_Productos == mod).First();
                        var c = DB.Clases_Productos.Where(np => np.ID_CLase == cla).First();

                        Factura += "\r\n" + m.Descripcion + " Clase: " + c.Descripcion +
                            " Cantidad: " + cantidad.ToString()
                            + " Precio (c/u): " + precio.ToString("0.00")
                            + "\r\n";
                        Factura += "-----------------------------------------------------------\r\n";

                        //int cont = 0;

                        var all = prods.Where(p => p.NombreProducto == m.ID_Nombre_Productos && p.Clase == cla)
                            .Select(s => s.ID_Producto).ToList();

                        Factura += String.Join(", ", all.ToArray());

                        #region commented
                        //foreach (var pro in
                        //    prods.Where(p => p.NombreProducto == m.ID_Nombre_Productos)
                        //    .ToList<Clases.Productos>())
                        //{
                        //    cont++;
                        //    Factura += pro.ID_Producto.PadRight(16, ' ');

                        //    if (cont == 3)
                        //    {
                        //        Factura += "\n"; cont = 0;
                        //    }

                        //}
                        #endregion

                        Factura += "\r\n---------------------------------------------------------";
                        Factura += "\r\n";
                    }
                }

                Factura += string.Format("Total monto factura: RD${0}",
                    Ventas.Sum(v => v.Precio_Venta).ToString("0.00")
                    );

                Factura += "\r\n"; Factura += "\r\n";
                Factura += "\t \t" + Program.MensajePieFactura;

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
            return Factura;
        }


        void GuardarArchivo(string FileName, string Content)
        {

            try
            {
                string DirFact = Application.StartupPath + @"\Facturas";

                if (!Directory.Exists(DirFact))
                    Directory.CreateDirectory(DirFact);

                FileStream F = File.Create(DirFact + @"\" + FileName + ".doc");
                string _File = F.Name;
                F.Close();

                StreamWriter writer = new StreamWriter(_File);
                writer.Write(Content);
                writer.Close();

                Clases.Venta.Imprimir(_File);

            }
            catch (Exception es)
            {
                throw es;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LblClase.Text = "-";
                LblCliente.Text = "-";
                LblFechaVencimiento.Text = "-";
                LblFecha.Text = "-";
                LblNombreProd.Text = "-";
                LblNuevaClaseMovil.Text = "-";
                LblNuevoNombreMovil.Text = "-";
                LblNumeroFactura.Text = "-";
                LblVendedor.Text = "-";

                TxtCodigoNuevoTelefono.Text = "";
                TxtCodigoTelCliente.Text = "";
                TxtCodigoTelCliente.Focus();
            }
            catch (Exception)
            {
                return;
            }
        }


    }
}
