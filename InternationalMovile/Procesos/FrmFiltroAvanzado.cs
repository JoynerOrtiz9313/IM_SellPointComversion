﻿using System;
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

        private void CmdBuscarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                var IDF = int.Parse(TxtFactura_Buscar.Text.ToString());
                var factura = DB.Facturas.Where(f => f.ID_Factura == IDF).First();
                int idVendedor = int.Parse(factura.vendedor);
                var Usuario = DB.Users.Where(u=>u.Usr_ID == idVendedor).First();

                GridVentasPorFactura.DataSource = DB.Ventas.Where(v => v.Factura == IDF).ToList();
                GridVentasPorFactura.Columns[0].Visible = false;
                GridVentasPorFactura.Columns[1].Visible = false;
                GridVentasPorFactura.Columns[4].Visible = false;
                GridVentasPorFactura.ReadOnly = true;

                LblMontoFact.Text = factura.Monto_Factura.ToString("0.00") + " de " + 
                factura.Cant_Articulos.ToString() + " articulos";

                LblVendedor.Text = Usuario.Nombre;

            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
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

        
    }
}