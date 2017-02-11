using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternationalMovile.Clases;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace InternationalMovile.Procesos
{
    public partial class FrmFacturacionIM : Form
    {
        IM_DB_Entities DB = new IM_DB_Entities();
        List<VentaInmediata> Ventas = new List<VentaInmediata>();
        bool Ocupado = false;

        public FrmFacturacionIM()
        {
            InitializeComponent();
        }

        private void Bfacturar_Click(object sender, EventArgs e)
        {
            Refrescar_Numero_Factura();
            Facturar();
            
        }

        void Facturar()
        {

            DB = new IM_DB_Entities();
            var fact = new Facturas()
            {
                ID_Factura = Refrescar_Numero_Factura(),
                Cliente = LblRNC_Cliente.Text.Trim(),
                Cant_Articulos = Ventas.Count,
                Monto_Factura = decimal.Parse(Ventas.Sum(x => x.precio).ToString()),
                Fecha = DtFechaVenta.Value,
                vendedor = Program.LoggedUser.Nombre,
                NCF = LblNcf.Text,
                TipoNCF = CmbTipoDeNcf.Text.Replace("NCF_", ""),
                TipoPago = "1", //FALTA DEFINIR
                ReferenciaDePago = string.Empty, //FALTA DEFINIR
                Monto = decimal.Parse(Ventas.Sum(x => x.precio).ToString())

            };
            DB.Facturas.Add(fact);
            //DB.SaveChanges();
            foreach (var _venta in Ventas)
            {
                _venta.factura = int.Parse(fact.ID_Factura.ToString());
                DB.VentaInmediata.Add(_venta);
            }

            Clientes cli = new Clientes();
            Tipos_ID_Cliente tipocliente = new Tipos_ID_Cliente();
            cli = DB.Clientes.Where(x => x.Cedula_RNC == CmbClientes.SelectedValue).First();
            tipocliente = DB.Tipos_ID_Cliente.Where(x => x.ID_TipoID == cli.TipoID).First();

            NCFs NCF = new NCFs()
            {
                Numero_NCF = LblNcf.Text,
                NCF_Modificado = "",
                Id_Tipo_NCF = 1,
                Id_Cliente = CmbTipoDeNcf.Text.ToLower().Contains("consumidor final") ? "" : CmbClientes.SelectedValue.ToString(),
                Anio_Mes = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2,'0'),
                Dia = DateTime.Now.Day.ToString().PadLeft(2, '0'),
                Itebis = fact.Monto * (decimal)0.18,
                Monto = fact.Monto,
                Tipo_Cliente = tipocliente.Descripcion.Contains("RNC") ? 1 : 2,
            };

            DB.NCFs.Add(NCF);

            DB.SaveChanges();
            //FuncionImprimir
            Program.MensageInfo("Venta realizada, Imprimiendo...");
            Limpiar();
        }

        void Limpiar()
        {
            Ventas.Clear();
            RefrescarListVentas();
            TxtImei.Text = string.Empty; ;
            TxtPrecio.Text = string.Empty;
            LblSubtotal.Text = string.Empty;
            LblItbis.Text = string.Empty; ;
            LblTotal.Text = string.Empty;
            LblNofactura.Text = Refrescar_Numero_Factura().ToString();
            LblNcf.Text = Refresh_NCF(CmbTipoDeNcf.SelectedValue.ToString().Trim());
        }

        int Refrescar_Numero_Factura()
        {
            DB = new Clases.IM_DB_Entities();
            var TieneData = DB.Facturas.Count() > 0;
            var proxima_factura = TieneData ? DB.Facturas.Max(x => x.ID_Factura) + 1 : 1;
            LblNofactura.Text = proxima_factura.ToString();

            return proxima_factura;
        }

        private void FrmFactutacionIM_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar_Numero_Factura();
                Cargar_CmbClientes();
                CmbClientes.SelectedIndex = -1;
                Cargar_CmbProductos();
                Cargar_CmbTipoDeNCF();
                // Usre Get_RNC() to get RNC in bill
            }
            catch (Exception es)
            {
                MensajeError(es.Message);
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
        void Cargar_CmbClientes()
        {

            DB = new Clases.IM_DB_Entities();
            CmbClientes.SelectedIndex = -1;
            CmbClientes.DataSource = DB.Clientes.ToList();
            CmbClientes.DisplayMember = "Nombre";
            CmbClientes.ValueMember = "Cedula_RNC";
        }
        void Cargar_CmbProductos()
        {

            DB = new Clases.IM_DB_Entities();
            CmbProductos.DataSource = DB.Nombres_Productos.ToList();
            CmbProductos.DisplayMember = "Descripcion";
            CmbProductos.ValueMember = "ID_Nombre_Productos";
        }
        void Cargar_CmbTipoDeNCF()
        {

            DB = new Clases.IM_DB_Entities();
            CmbTipoDeNcf.DataSource = DB.Parametros_Generales.Where(p => p.NombreParametro.Contains("NCF_")).ToList();
            CmbTipoDeNcf.DisplayMember = "NombreParametro";
            CmbTipoDeNcf.ValueMember = "Valor";

            CmbTipoDeNcf.SelectedIndex = 0;
            LblNcf.Text = Refresh_NCF(CmbTipoDeNcf.SelectedValue.ToString());

        }


        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            DB = new Clases.IM_DB_Entities();
            try
            {
                if (CmbClientes.SelectedIndex == -1) return;
                var idCliente = CmbClientes.SelectedValue.ToString();
                var Ncliente = DB.Clientes.Where(x => x.Cedula_RNC.Trim() == idCliente.Trim())
                                                .First();
                LblRNC_Cliente.Text = Ncliente.RNC;
            }
            catch (Exception) { }
        }

        void AddVenta()
        {
            DB = new IM_DB_Entities();
            var _NombreProdID = int.Parse(CmbProductos.SelectedValue.ToString());
            var _IMEI = TxtImei.Text;
            var _precio = decimal.Parse(TxtPrecio.Text);

            var _venta = new VentaInmediata()
            {
                factura = int.Parse(LblNofactura.Text),
                id_Nombre_Producto = _NombreProdID,
                IMEI = _IMEI,
                precio = decimal.Parse(TxtPrecio.Text),
                fecha = DateTime.Now
            };

            Ventas.Add(_venta);
            RefrescarListVentas();

        }

        void RefrescarListVentas()
        {

            LstVerVentas.Items.Clear();

            var ids = Ventas.Select(v => v.id_Nombre_Producto).Distinct();

            foreach (var v in ids)
            {
                /*
                var cultureInfo = Thread.CurrentThread.CurrentCulture;
                var numberFormatInfo = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
                numberFormatInfo.CurrencySymbol = "$";
                */
                var _Nombreprod = DB.Nombres_Productos.Where(x => x.ID_Nombre_Productos == v).First().Descripcion;
                var _Cantidad = Ventas.Where(x => x.id_Nombre_Producto == v).ToList().Count;
                decimal _Precio = (decimal)Ventas.Where(x => x.id_Nombre_Producto == v).First().precio;
                decimal _FormatoTotal = decimal.Parse((_Precio * _Cantidad).ToString());
                var encabezado = string.Format("{0}  ||     CANTIDAD: {1} ||    PRECIO: {2} ||       TOTAL: {3}"
                                , _Nombreprod, _Cantidad, _Precio.ToString("C"), _FormatoTotal.ToString("C"));

                var all = Ventas.Where(p => p.id_Nombre_Producto == v)
                           .Select(s => s.IMEI).ToList();

                LstVerVentas.Items.Add(encabezado);
                LstVerVentas.Items.Add(String.Join(", ", all.ToArray()));
                LstVerVentas.Items.Add("");

            }

        }

        private void TxtImei_TextChanged(object sender, EventArgs e)
        {
            if (!PuedeAgregarProducto()) return;
            Ocupado = true;
            Program.wait(1);
            if (Productovendido(TxtImei.Text.Trim()))
            {
                goto i;
            }
            if (ProductoYaEnLista(TxtImei.Text.Trim()))
            {
                RefrescarListVentas();
                goto i;
            }

            AddVenta();
        i:
            CalcularTotales();
            Ocupado = false;
            TxtImei.Text = "";
            TxtImei.Focus();
        }

        void CalcularTotales()
        {

            decimal Total = (decimal)Ventas.Sum(x => x.precio);
            double ITBIS = (double)Total * 0.18;
            decimal Descuentos = decimal.Parse(0.ToString()); //Planificar descuentos facturas si aplican

            LblSubtotal.Text = (Total - Descuentos).ToString("C");
            LblItbis.Text = ITBIS.ToString("C");
            LblTotal.Text = (Total + (decimal)ITBIS).ToString("C");

        }

        bool PuedeAgregarProducto()
        {

            if (Ocupado) return false;
            if (TxtPrecio.Text.Trim() == "") return false;
            if (TxtImei.Text.Trim() == "") return false;
            if (CmbProductos.SelectedIndex < 0) return false;

            return true;

        }

        bool Productovendido(string _imei)
        {

            DB = new IM_DB_Entities();
            bool respuesta = DB.VentaInmediata.Any(x => x.IMEI == _imei);

            if (respuesta)
                Program.MensageInfo("Este IMEI ya se ha vendido.");

            return respuesta;
        }

        bool ProductoYaEnLista(string _imei)
        {
            DB = new IM_DB_Entities();
            bool respuesta = Ventas.Any(x => x.IMEI == _imei);

            if (respuesta)
            {
                DialogResult eliminar = MessageBox.Show("Producto ya está en lista, desea quitarlo?", "Eliminar Producto"
                                                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (eliminar == DialogResult.Yes)
                {

                    var todelete = Ventas.Where(x => x.IMEI == _imei).First();
                    Ventas.Remove(todelete);
                }
            }
            return respuesta;
        }

        private void CmbTipoDeNcf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblNcf.Text = Refresh_NCF(CmbTipoDeNcf.SelectedValue.ToString());
        }

        string Get_RNC()
        {
            DB = new Clases.IM_DB_Entities();
            var RNC_Value = DB.Parametros_Generales.Where(p => p.NombreParametro == "RNC").First().Valor;
            return RNC_Value;
        }

        string Refresh_NCF(string refe)
        {
            DB = new Clases.IM_DB_Entities();
            var NCF_Count = DB.NCFs.Where(x => x.Numero_NCF.Contains(refe)).Count();
            var valor = CmbTipoDeNcf.SelectedValue + (NCF_Count + 1).ToString().PadLeft(9, '0');

            return valor;
        }
    }


}
