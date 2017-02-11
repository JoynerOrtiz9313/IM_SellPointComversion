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
        Clases.VentaInmediata venta;
        Clases.Productos Movil_Nuevo;
        //  Clases.Ventas venta;
        Clases.Clientes cliente;
        Clases.Facturas fact;
        Clases.Clases_Productos cp;
        Clases.Nombres_Productos NP;
        Clases.Users Vendedor;
        string NCF = string.Empty;

        private void GarantiaMovil_Load(object sender, EventArgs e)
        {
            Cargar_CmbProductos();
        }

        void Cargar_CmbProductos()
        {

            DB = new Clases.IM_DB_Entities();
            CmbNuevoNombreMovil.DataSource = DB.Nombres_Productos.ToList();
            CmbNuevoNombreMovil.DisplayMember = "Descripcion";
            CmbNuevoNombreMovil.ValueMember = "ID_Nombre_Productos";
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

            Buscando = true;
            Program.wait(2);
            try
            {
                if (TxtCodigoTelCliente.Text.Trim() == "")
                {
                    button1_Click(sender, e);
                    Buscando = false;
                    return;
                }

                venta = new Clases.VentaInmediata();
                venta = DB.VentaInmediata.Where(p => p.IMEI == TxtCodigoTelCliente.Text).First();

                //venta = new Clases.Ventas();
                cliente = new Clases.Clientes();
                fact = new Clases.Facturas();
                cp = new Clases.Clases_Productos();
                NP = new Clases.Nombres_Productos();


                NP = DB.Nombres_Productos.Where(np => np.ID_Nombre_Productos == venta.id_Nombre_Producto).FirstOrDefault();
                //cp = DB.Clases_Productos.Where(clase => clase.ID_CLase == Movil_Cliente.Clase).FirstOrDefault();
                //venta = DB.Ventas.Where(v => v.Producto == Movil_Cliente.ID_Producto).FirstOrDefault();
                fact = DB.Facturas.Where(f => f.ID_Factura == venta.factura).FirstOrDefault();
                cliente = DB.Clientes.Where(c => c.RNC == fact.Cliente).FirstOrDefault();
                string IDVendedor = fact.vendedor;

                LblCliente.Text = cliente.Nombre;
                LblFecha.Text = fact.Fecha.ToString();
                LblClase.Text = cp.Descripcion;
                LblFechaVencimiento.Text = fact.Fecha.AddDays(15).ToString();
                LblNombreProd.Text = NP.Descripcion;
                LblNumeroFactura.Text = fact.ID_Factura.ToString();
                LblVendedor.Text = IDVendedor;
                Buscando = false;

            }
            catch (Exception es)
            {
                MensajeInfo(es.Message);
                TxtCodigoTelCliente.Text = "";
                TxtCodigoTelCliente.Focus();
                Buscando = false;
                return;
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
            #region Old
            /*
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
            }*/
            #endregion
        }

        private void CmdIntercambiar_Click(object sender, EventArgs e)
        {
            bool ventaEncontrada = venta.Id_Venta != null;

            if (!ventaEncontrada)
            {
                Program.MensageInfo("No ha elegido ningun equipo");
                return;
            }

            //DB = new Clases.IM_DB_Entities();


            try
            {

                if (venta.id_Nombre_Producto != (int)CmbNuevoNombreMovil.SelectedValue)
                {
                    cambioIMEI();
                    cambioNombreMovil();
                    anularfactura();
                    addNotacredito();
                    Guardar_NCF();
                    cambioPorOtroMovil();                    
                }
                else
                {
                    cambioIMEI();
                }


                MensajeInfo("Intercambiado con exito");
                //-------------VENTA ALTERADA------------------------

                #region old
                /* var _ProdToDelete = DB.Productos.Where(p => p.ID_Producto == Movil_Nuevo.ID_Producto).First();
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
                */
                #endregion


                /*
                 * GuardarArchivo("MOD_Factura cliente_" + LblCliente.Text + "_" + DateTime.Now.ToString("ddMMyyyy_hhmm"),
                    "<span style='font-weight: bold'> " + Construir__Factura(DB.Ventas.Where(_v => _v.Facturas.ID_Factura == _factNumb).ToList(), LblCliente.Text) + "</span>"
                    );
                 */
                button1_Click(sender, e);

            }
            catch (Exception es)
            {

                Program.MensajeError(es.Message);
            }
        }

        void cambioPorOtroMovil()
        {
            int id_nueva_fact = getSiguiente_Factura();
            var Nueva_Fact = facturaParaSustituir(fact);

            Nueva_Fact.Cant_Articulos = DB.VentaInmediata.Where(x => x.factura == fact.ID_Factura).Count(); //Se le asigna la cantidad nueva de artuculos en caso que esta cambie
            Nueva_Fact.ID_Factura = id_nueva_fact; // SE LE ASIGNA NUMERO DE FACTURA A LA NUEVA

            DB.Facturas.Add(Nueva_Fact);

            DB.VentaInmediata.Where(x => x.factura == fact.ID_Factura).ToList().ForEach(
                item => item.factura = id_nueva_fact);// todos los articulos de la antigua factura deben heredar el id de factura nuevo

            DB.SaveChanges();

        }

        void addNotacredito() {
            var NC = new Clases.Nota_Credito();
            NC.Anio_Mes = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0');
            NC.Dia = DateTime.Now.Day.ToString().PadLeft(2, '0');
            NC.Id_Cliente = fact.Cliente;
            NC.Numero_NCF = getSiguienteNCF_NotaCredito();
            NC.NCF_Modificado = fact.NCF;
            NC.Id_Tipo_NCF = 1;
            NC.Monto = fact.Monto;
            NC.Itebis = fact.Monto * (decimal)0.18;
            NC.Tipo_Cliente = cliente.TipoID;

            DB.Nota_Credito.Add(NC);

            DB.SaveChanges();
        }

        void cambioIMEI()
        {
            venta.IMEI = TxtCodigoNuevoTelefono.Text;
            DB.SaveChanges();
        }

        void anularfactura()
        {
            fact.Anulada = true;
            DB.SaveChanges();
        }

        void cambioNombreMovil()
        {
            venta.id_Nombre_Producto = (int)CmbNuevoNombreMovil.SelectedValue;
            DB.SaveChanges();
        }

        Clases.Facturas facturaParaSustituir(Clases.Facturas referencia)
        {

            var _db = new Clases.IM_DB_Entities();
            var prefijo = _db.Parametros_Generales.Where(x => x.NombreParametro.ToLower().Contains(referencia.TipoNCF.ToLower())).First().Valor;
            var fact = new Clases.Facturas()
            {
                Anulada = false,
                Cant_Articulos = referencia.Cant_Articulos,
                Cliente = referencia.Cliente,
                Fecha = DateTime.Now,
                ID_Factura = getSiguiente_Factura(),
                Monto = referencia.Monto,
                Monto_Factura = referencia.Monto_Factura,
                NCF = Refresh_NCF(prefijo),
                vendedor = referencia.vendedor,
                TipoPago = referencia.TipoPago,
                TipoNCF = referencia.TipoNCF,
                 ReferenciaDePago = ""
            };

            return fact;

        }


        string Refresh_NCF(string refe)
        {
            DB = new Clases.IM_DB_Entities();
            var NCF_Count = DB.NCFs.Where(x => x.Numero_NCF.Contains(refe)).Count();
            var valor = refe + (NCF_Count + 1).ToString().PadLeft(9, '0');

            NCF = valor;

            return valor;
        }

        void Guardar_NCF() {

            if (NCF != string.Empty)
            {
                Clases.NCFs ncf = new Clases.NCFs();
                ncf = DB.NCFs.Where(x => x.Numero_NCF == fact.NCF).First();
                ncf.Numero_NCF = NCF;
                DB.NCFs.Add(ncf);

                DB.SaveChanges();
                NCF = string.Empty;
            }
        }

        private string getSiguienteNCF_NotaCredito()
        {

            DB = new Clases.IM_DB_Entities();
            string prefijo = DB.Parametros_Generales.Where(x => x.NombreParametro.ToLower().Contains("nota de credito")).First().Valor;
            int sig_Numero = DB.Nota_Credito.Count() + 1;

            return prefijo + sig_Numero.ToString().PadLeft(9, '0');

        }

        private int getSiguiente_Factura()
        {

            DB = new Clases.IM_DB_Entities();
            int sig_Numero = DB.Facturas.Count() + 1;

            return sig_Numero;

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
                //LblNuevoNombreMovil.Text = "-";
                LblNumeroFactura.Text = "-";
                LblVendedor.Text = "-";
                NCF = string.Empty;
                TxtCodigoNuevoTelefono.Text = "";
                TxtCodigoTelCliente.Text = "";

                venta = new Clases.VentaInmediata();
                cliente = new Clases.Clientes();
                fact = new Clases.Facturas();
                cp = new Clases.Clases_Productos();
                NP = new Clases.Nombres_Productos();
                DB = new Clases.IM_DB_Entities();

                TxtCodigoTelCliente.Focus();


            }
            catch (Exception)
            {
                return;
            }
        }


    }
}
