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
    public partial class FrmFacturacion : Form
    {

        Clases.IM_DB_Entities DB = new Clases.IM_DB_Entities();
        Clases.Productos EsteProducto = new Clases.Productos();
        List<Clases.Productos> Lista_Prod_A_Vender = new List<Clases.Productos>();

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        void Cargar_CmbClientes()
        {

            DB = new Clases.IM_DB_Entities();
            CmbClientes.DataSource = DB.Clientes.ToList();
            CmbClientes.DisplayMember = "Nombre";
            CmbClientes.ValueMember = "Cedula_RNC";

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_CmbClientes();
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

        private void CmdAgregarProd_Click(object sender, EventArgs e)
        {
            ListView _LstProds_A_Vender_virtual = new ListView();

            try
            {
                if (TxtID_Prod.Text.Trim() == "")
                {
                  //MensajeInfo("No hay producto que agregar!");
                    TxtID_Prod.Focus();
                    return;
                }

                EsteProducto = DB.Productos.Where(prod => prod.ID_Producto == TxtID_Prod.Text).First();

                if (Lista_Prod_A_Vender.Any(p => p.ID_Producto == TxtID_Prod.Text))
                {
                    TxtID_Prod.Text = "";
                    TxtID_Prod.Focus();
                    return;
                }

                if (EsteProducto != null)
                {
                    Lista_Prod_A_Vender.Add(EsteProducto);
                    //EsteProducto = new Clases.Productos();
                }

                if (LstProds_A_Vender.Items.Count > 0)
                {
                    _LstProds_A_Vender_virtual = LstProds_A_Vender;
                }

                if (_LstProds_A_Vender_virtual.Items.Count == 0)
                {
                    ActualizarListaProdVenta();
                }
                else {
                    ActualizarListaProdVenta(_LstProds_A_Vender_virtual,EsteProducto);
                }
                EsteProducto = new Clases.Productos();
                TxtID_Prod.Text = "";
                TxtID_Prod.Focus();

            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }
        }

        void ActualizarListaProdVenta()
        {
            try
            {
                LstProds_A_Vender.Items.Clear();

                if (Lista_Prod_A_Vender.Count == 0)
                {
                    return;
                }

                foreach (var item in Lista_Prod_A_Vender)
                {

                    Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == item.NombreProducto).First();

                    Clases.Clases_Productos cp = DB.Clases_Productos
                        .Where(c => c.ID_CLase == item.Clase).First();

                    LstProds_A_Vender.Items.Add(item.ID_Producto.PadRight(17, ' '), 0);
                    LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].SubItems.Add(nombre.Descripcion);
                    LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].SubItems.Add(cp.Descripcion);
                    LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].SubItems.Add(TxtPrecioProds.Text.Trim() == "" ? "0.00" : (decimal.Parse(TxtPrecioProds.Text)).ToString("c"));

                    LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].Tag = item;

                }

            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }
        }

        void ActualizarListaProdVenta(ListView _lstContingencia,Clases.Productos Prod)
        {
            try
            {
                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                 .Where(np => np.ID_Nombre_Productos == Prod.NombreProducto).First();

                Clases.Clases_Productos cp = DB.Clases_Productos
                    .Where(c => c.ID_CLase == Prod.Clase).First();

                LstProds_A_Vender = _lstContingencia;
                LstProds_A_Vender.Items.Add(Prod.ID_Producto, 0);
                LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count -1].SubItems.Add(nombre.Descripcion);
                LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].SubItems.Add(cp.Descripcion);
                LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].SubItems.Add(0.ToString("c"));

                LstProds_A_Vender.Items[LstProds_A_Vender.Items.Count - 1].Tag = Prod;

            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }
        }



        private void LstProds_A_Vender_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                EsteProducto = (Clases.Productos)LstProds_A_Vender.SelectedItems[0].Tag;
                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == EsteProducto.NombreProducto).First();

                LblProdSeleccionado.Text = nombre.Descripcion;
            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }
        }

        private void TxtPrecioProds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = decimal.Parse(TxtPrecioProds.Text);

            }
            catch (Exception)
            {
                TxtPrecioProds.Text = "";
            }
        }

        private void TxtPrecioProds_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtPrecioProds.Text == "")
                    return;

                if(!Program.PreciosPreferenciales)
                if (decimal.Parse(TxtPrecioProds.Text) <= EsteProducto.Precio_Costo)
                {
                    MensajeError("La ganancia no es suficiente para estos equipos. \nPara conseguir un precio especial necesita estar el sistema debe estar autorizado para esta acción");
                    return;
                }

                if (LstProds_A_Vender.Items.Count != 0)
                {

                    for (int i = 0; i < LstProds_A_Vender.Items.Count; i++)
                    {
                        if (((Clases.Productos)LstProds_A_Vender.Items[i].Tag).NombreProducto ==
                            EsteProducto.NombreProducto && 
                            ((Clases.Productos)LstProds_A_Vender.Items[i].Tag).Clase == EsteProducto.Clase)
                        {
                            LstProds_A_Vender.Items[i].SubItems[3].Text = TxtPrecioProds.Text;
                        }
                    }
                    LblTotal.Text = "0";

                    for (int i = 0; i < LstProds_A_Vender.Items.Count; i++)
                    {
                        LblTotal.Text = (decimal.Parse(LblTotal.Text) +
                                        decimal.Parse(LstProds_A_Vender.Items[i].SubItems[3].Text)).ToString("0.00");
                    }

                }
                //ActualizarListaProdVenta();

            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }
            finally {
                TxtPrecioProds.Text = "";

            }

        }

        void Limpiar()
        {

            try
            {
                Lista_Prod_A_Vender = new List<Clases.Productos>();
                ActualizarListaProdVenta();
                TxtID_Prod.Text = "";
                LblTotal.Text = "0.00";
                TxtID_Prod.Focus();
            }
            catch (Exception es)
            {
                MensajeError(es.Message);
            }

        }

        private void CmdFacturar_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(LblTotal.Text) <= 0)
            {
                MensajeInfo("El total de la factura esta en 0");
                return;
            }

            Clases.IM_DB_Entities DB = new Clases.IM_DB_Entities();
            Clases.Facturas fact;
            List<Clases.Ventas> ListaVentas = new List<Clases.Ventas>();


            try
            {
                if (Lista_Prod_A_Vender.Count > 0)
                {
                    fact = new Clases.Facturas()
                    {
                        Cant_Articulos = Lista_Prod_A_Vender.Count,
                        Cliente = (string)CmbClientes.SelectedValue,
                        Fecha = DateTime.Now,
                        Monto_Factura = decimal.Parse(LblTotal.Text),
                        vendedor = Program.LoggedUser.Usr_ID.ToString()
                    };

                    DB.Facturas.Add(fact);

                    foreach (ListViewItem prod in LstProds_A_Vender.Items)
                    {

                        ListaVentas.Add(
                        new Clases.Ventas()
                        {
                            Factura = fact.ID_Factura,
                            Precio_Venta = decimal.Parse(prod.SubItems[3].Text),
                            Producto = prod.SubItems[0].Text,
                        });
                    }

                    foreach (var item in ListaVentas)
                    {
                        DB.Ventas.Add(item);

                        Clases.Productos Prod = DB.Productos.Where(p => p.ID_Producto == item.Producto).First();

                        DB.Productos_V.Add(new Clases.Productos_V()
                        {
                            Clase = Prod.Clase,
                            Fecha_Ingreso = fact.Fecha,
                            ID_Producto = Prod.ID_Producto,
                            NombreProducto = Prod.NombreProducto,
                            Precio_Costo = Prod.Precio_Costo
                        });

                        //DB.Productos.Remove(Prod);
                    }

                }

                //DB.SaveChanges();

                GuardarArchivo("Factura_" + CmbClientes.Text + "_" + DateTime.Now.ToString("MMddyyyy_hhmm")
            , Construir__Factura(ListaVentas, CmbClientes.Text));

                foreach (var item in ListaVentas)
                {
                    Clases.Productos _Prod = DB.Productos.Where(p => p.ID_Producto == item.Producto).First();

                    DB.Productos.Remove(_Prod);
                }

                DB.SaveChanges();
                MensajeInfo("Facturado!");
                Limpiar();

            }
            catch (Exception es)
            {
                MensajeError(es.Message);
                //Limpiar();
            }
        }

        string Construir__Factura(List<Clases.Ventas> Ventas, string Cliente)
        {

            string Factura = "";
            DB = new Clases.IM_DB_Entities();
            List<Clases.Productos> prods = new List<Clases.Productos>();

            try
            {
                foreach (var item in Ventas)
                {
                    var prod = DB.Productos.Where(pr => pr.ID_Producto == item.Producto).FirstOrDefault();
                    prod.Precio_Costo = item.Precio_Venta;
                    prods.Add(prod);
                }

                var Modelos = prods.Select(p => p.NombreProducto).Distinct().ToList<int>();
                var Clases = prods.Select(p => p.Clase).Distinct().ToList<int>();

                Factura = "<span style='font-weight: bold'>"+"\t \t \t \t" + Program.NombreEmpresa + "<span> \r\n";
                Factura += "\t \t " + Program.DireccionEmpresa + "\r\n";
                Factura += "\t \t \t Tel:" + Program.Telefono1_Empresa + " Tel2:" + Program.Telefono2_Empresa;
                Factura += "\r\n";
                Factura += "================================================================\r\n";

                Factura += "Detalle de compra del cliente: " + Cliente +  "\t" +
                DateTime.Now.ToString("dd/MM/yyyy hh:mm")
                + "\r\n";

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
                            + " Precio (c/u): " + precio.ToString("c")
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

                Factura += string.Format("Total monto factura: {0}",
                    Ventas.Sum(v=>v.Precio_Venta).ToString("c")
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

        private void TxtID_Prod_TextChanged(object sender, EventArgs e)
        {
            if (TxtID_Prod.Text.Length >= 9)
            {
                Program.wait(1);
                CmdAgregarProd_Click(sender, e);
            }
        }

        private void CmdCotizacion_Click(object sender, EventArgs e)
        {

            List<Clases.Ventas> _ListaVentas = new List<Clases.Ventas>();

            if (LstProds_A_Vender.Items.Count < 1) {
                Program.MensageInfo("No hay productos disponibles");
                return;
            }

            foreach (ListViewItem prod in LstProds_A_Vender.Items)
            {
                _ListaVentas.Add(
                new Clases.Ventas()
                {
                    Factura = 0,
                    Precio_Venta = decimal.Parse(prod.SubItems[3].Text),
                    Producto = prod.SubItems[0].Text,
                });
            }

            GuardarArchivo("Cotizacion_" + CmbClientes.Text + "_" + DateTime.Now.ToString("MMddyyyy_hhmm")
            , Construir__Factura(_ListaVentas, CmbClientes.Text));
        }

        private void CmdQuitarProd_Click(object sender, EventArgs e)
        {
            try
            {
                //var pr = Lista_Prod_A_Vender.Where(p => p.ID_Producto == EsteProducto.ID_Producto).First();
                Lista_Prod_A_Vender.Remove(EsteProducto);
                ActualizarListaProdVenta();
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

        private void ChkPreciosPreferenciales_Leave(object sender, EventArgs e)
        {
            ChkPreciosPreferenciales.Checked = Program.PreciosPreferenciales;
        }

        private void ChkPreciosPreferenciales_Enter(object sender, EventArgs e)
        {
            ChkPreciosPreferenciales.Checked = Program.PreciosPreferenciales;
        }

        private void ChkPreciosPreferenciales_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmContrasenaMaestra frm = new Mantenimientos.FrmContrasenaMaestra();
            frm.ShowDialog();
        }

        private void ChkPreciosPreferenciales_MouseEnter(object sender, EventArgs e)
        {
            ChkPreciosPreferenciales.Checked = Program.PreciosPreferenciales;
        }

        private void ChkPreciosPreferenciales_CheckedChanged(object sender, EventArgs e)
        {
            ChkPreciosPreferenciales.Checked = Program.PreciosPreferenciales;
            return;
        }

        private void FrmFacturacion_Enter(object sender, EventArgs e)
        {
            ChkPreciosPreferenciales.Checked = Program.PreciosPreferenciales;
        }

        private void TxtPrecioProds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {

                TxtPrecioProds_Leave(sender, e);

            }
        }

        



    }
}
