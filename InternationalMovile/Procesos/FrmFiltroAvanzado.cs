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
    public partial class FrmFiltroAvanzado : Form
    {

        Clases.IM_DB_Entities DB;
        List<articuloVendido> Vendidos = new List<articuloVendido>();

        public FrmFiltroAvanzado()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void LlenarCombos()
        {

            try
            {
                DB = new Clases.IM_DB_Entities();
                var Modelos = DB.Nombres_Productos.ToList();

                CmbModelo_Buscar.DataSource = Modelos;
                CmbModelo_Buscar.DisplayMember = "Descripcion";
                CmbModelo_Buscar.ValueMember = "ID_Nombre_Productos";

                var Clases = DB.Clases_Productos.ToList();

                CmbClase_Buscar.DataSource = Clases;
                CmbClase_Buscar.DisplayMember = "Descripcion";
                CmbClase_Buscar.ValueMember = "ID_Clase";

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }

        }

        void Buscar()
        {

            try
            {
                if (RdActivo.Checked)
                    BringActivos();
                else
                    BringVendidos();
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }

        }

        private void BringVendidos()
        {
            DB = new Clases.IM_DB_Entities();
            try
            {
                int model = Convert.ToInt16(CmbModelo_Buscar.SelectedValue.ToString());
                int clase = Convert.ToInt16(CmbClase_Buscar.SelectedValue.ToString());

                var ListaVendidos = DB.Productos_V.ToList();

                if (ChkModelo.Checked)
                    ListaVendidos = ListaVendidos.Where(Prod => Prod.NombreProducto == model).ToList();

                if (ChkClase.Checked)
                    ListaVendidos = ListaVendidos.Where(Prod => Prod.Clase == clase).ToList();


                if (ChkUsarFechas.Checked)
                {
                    //var venta = DB.Productos_V.

                    ListaVendidos = ListaVendidos.Where(prod => prod.Fecha_Ingreso >= DtDesde.Value
                        && prod.Fecha_Ingreso <= DtHasta.Value).ToList();
                }
                GridFiltroAvanzado.DataSource = ListaVendidos;
                LblCantidad.Text = ListaVendidos.Count.ToString();
                LblSum.Text = ListaVendidos.Sum(pr => pr.Precio_Costo).ToString("0.00");
            }
            catch (Exception es)
            {
                throw es;
            }

        }

        private void BringActivos()
        {
            DB = new Clases.IM_DB_Entities();
            try
            {
                int model = Convert.ToInt16(CmbModelo_Buscar.SelectedValue.ToString());
                int clase = Convert.ToInt16(CmbClase_Buscar.SelectedValue.ToString());

                var ListaVendidos = DB.Productos.ToList();

                if (ChkModelo.Checked)
                    ListaVendidos = ListaVendidos.Where(Prod => Prod.NombreProducto == model).ToList();

                if (ChkClase.Checked)
                    ListaVendidos = ListaVendidos.Where(Prod => Prod.Clase == clase).ToList();

                GridFiltroAvanzado.DataSource = ListaVendidos;
                LblCantidad.Text = ListaVendidos.Count.ToString();
                LblSum.Text = ListaVendidos.Sum(pr => pr.Precio_Costo).ToString("0.00");
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        private void CmdBuscarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                TxtID_Buscar.Text = "";
                Buscar();
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

        private void FrmFiltroAvanzado_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            TxtID_Buscar.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtID_Buscar.Text = "";
            LblCantidad.Text = "";
            LblSum.Text = "";

            RdActivo.Checked = true;
            GridFiltroAvanzado.DataSource = null;
            LlenarCombos();
        }

        List<articuloVendido> llenar_List_Prods_Vendidos()
        {
            var IDF = int.Parse(TxtFactura_Buscar.Text.ToString());
            var lst = DB.VentaInmediata.Where(v => v.factura == IDF).ToList();
            Vendidos = new List<articuloVendido>();

            foreach (var item in lst)
            {
                DB = new Clases.IM_DB_Entities();
                articuloVendido a = new articuloVendido();
                a.IMEI = item.IMEI;
                a.Precio = (decimal)item.precio;
                a.Producto = DB.Nombres_Productos.Where(x => x.ID_Nombre_Productos == item.id_Nombre_Producto).First().Descripcion;

                Vendidos.Add(a);
            }

            return Vendidos;

        }

        private void CmdBuscarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                var IDF = int.Parse(TxtFactura_Buscar.Text.ToString());
                var factura = DB.Facturas.Where(f => f.ID_Factura == IDF).First();
                string NombreUsuario = factura.vendedor;
                //var Usuario = DB.Users.Where(u=>u.Usr_ID == idVendedor).First();

                GridVentasPorFactura.DataSource = llenar_List_Prods_Vendidos();
                GridVentasPorFactura.ReadOnly = true;

                LblMontoFact.Text = factura.Monto_Factura.ToString("C") + " de " +
                factura.Cant_Articulos.ToString() + " articulos";

                LblVendedor.Text = NombreUsuario;

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

        protected class articuloVendido
        {

            public string Producto { get; set; }
            public string IMEI { get; set; }
            public decimal Precio { get; set; }

        }


        // List<object> BuscarVentas(string ID_Fact) {

        //     try
        //     {

        //         //var fact = DB.Facturas.Where(f => f.ID_Factura = IDF).FirstOrDefault();

        ////         return DB.Ventas.Where(ven => ven.Factura == IDF).ToList<Clases.Venta>();

        //     }
        //     catch (Exception es)
        //     {
        //         throw es;
        //     }

        // }

        private void RdVendido_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = RdVendido.Checked;
        }

        private void TxtID_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtID_Buscar.Text.Length >= 9)
            {
                DB = new Clases.IM_DB_Entities();
                Program.wait(2);
                try
                {
                    if (RdActivo.Checked)
                    {

                        GridFiltroAvanzado.DataSource = DB.Productos.Where(p => p.ID_Producto == TxtID_Buscar.Text.Trim()).ToList();
                    }
                    else
                    {
                        GridFiltroAvanzado.DataSource = DB.Productos_V.Where(p => p.ID_Producto == TxtID_Buscar.Text.Trim()).ToList();
                    }
                }
                catch (Exception es)
                {
                    Program.MensajeError(es.Message);

                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LblMontoFact_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LblVendedor_Click(object sender, EventArgs e)
        {

        }

        private void BAnular_Click(object sender, EventArgs e)
        {
            anularFactura();
        }

        bool anularFactura()
        {
            DB = new Clases.IM_DB_Entities();
            int IDFact = int.Parse(TxtFactura_Buscar.Text);
            var fact = DB.Facturas.Where(x => x.ID_Factura == IDFact).First();

            fact.Anulada = true;
            try
            {
                DB.SaveChanges();
                Program.MensageInfo("Anulada!");
            }
            catch (Exception es)
            {
                Program.MensajeError(es.InnerException.ToString());
                return false;

            }
            return true;
        }




    }
}
