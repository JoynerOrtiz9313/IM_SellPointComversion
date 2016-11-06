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
    public partial class FrmInventario : Form
    {

        Clases.IM_DB_Entities DB;
        bool editando = false;

        Clases.Productos SelectedProd = new Clases.Productos();
        List<Clases.Productos> Productos_A_Ingresar = new List<Clases.Productos>();

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        void Limpiar()
        {
            TxtCosto.Text = "0";
            TxtID_Producto.Text = "";
            Productos_A_Ingresar = new List<Clases.Productos>();
            LlenarListaProdsToAdd();
            TxtID_Producto.Focus();
            TxtID_Producto.Enabled = true;
        }

        void _Refresh()
        {

            try
            {
                LlenarCombos();
                editando = false;
                Limpiar();
                LlenarListaInventario();
                Productos_A_Ingresar = new List<Clases.Productos>();
                LlenarListaProdsToAdd();
                tabControl1.SelectTab(0);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        void LlenarCombos()
        {

            DB = new Clases.IM_DB_Entities();

            CmbClase.DataSource = DB.Clases_Productos.ToList();
            CmbClase.DisplayMember = "Descripcion";
            CmbClase.ValueMember = "ID_Clase";

            CmbNombre.DataSource = DB.Nombres_Productos.ToList();
            CmbNombre.DisplayMember = "Descripcion";
            CmbNombre.ValueMember = "ID_Nombre_Productos";


        }

        void LlenarListaInventario()
        {

            DB = new Clases.IM_DB_Entities();
            LstInventario.Items.Clear();

            foreach (var item in DB.Productos.ToList())
            {

                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == item.NombreProducto).First();

                Clases.Clases_Productos cp = DB.Clases_Productos
                    .Where(c => c.ID_CLase == item.Clase).First();

                LstInventario.Items.Add(item.ID_Producto, 0);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(nombre.Descripcion);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(cp.Descripcion);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(item.Precio_Costo.ToString("0.00"));
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(dtFechaIngreso.Value.Date.ToString());

                LstInventario.Items[LstInventario.Items.Count - 1].Tag = item;

            }

        }

        void LlenarListaInventario(string Codigo)
        {

            DB = new Clases.IM_DB_Entities();
            LstInventario.Items.Clear();

            foreach (var item in DB.Productos.Where(p=>p.ID_Producto.Contains(Codigo)).ToList())
            {

                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == item.NombreProducto).First();

                Clases.Clases_Productos cp = DB.Clases_Productos
                    .Where(c => c.ID_CLase == item.Clase).First();

                LstInventario.Items.Add(item.ID_Producto, 0);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(nombre.Descripcion);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(cp.Descripcion);
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(item.Precio_Costo.ToString("0.00"));
                LstInventario.Items[LstInventario.Items.Count - 1].SubItems.Add(dtFechaIngreso.Value.Date.ToString());

                LstInventario.Items[LstInventario.Items.Count - 1].Tag = item;

            }

        }


        
        void LlenarListaProdsToAdd()
        {

            DB = new Clases.IM_DB_Entities();
            ListProductos_A_Ingresar.Items.Clear();

            foreach (var item in Productos_A_Ingresar)
            {

                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == item.NombreProducto).First();

                Clases.Clases_Productos cp = DB.Clases_Productos
                    .Where(c => c.ID_CLase == item.Clase).First();

                ListProductos_A_Ingresar.Items.Add(item.ID_Producto, 0);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(nombre.Descripcion);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(cp.Descripcion);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(TxtCosto.Text);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(dtFechaIngreso.Value.Date.ToString());

                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].Tag = item;

            }

        }

        void AddProd(Clases.Productos p)
        {
            try
            {
                DB = new Clases.IM_DB_Entities();
                
                Clases.Nombres_Productos nombre = DB.Nombres_Productos
                    .Where(np => np.ID_Nombre_Productos == p.NombreProducto).First();

                Clases.Clases_Productos cp = DB.Clases_Productos
                    .Where(c => c.ID_CLase == p.Clase).First();

                ListProductos_A_Ingresar.Items.Add(p.ID_Producto, 0);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(nombre.Descripcion);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(cp.Descripcion);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(TxtCosto.Text);
                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].SubItems.Add(dtFechaIngreso.Value.Date.ToString());

                ListProductos_A_Ingresar.Items[ListProductos_A_Ingresar.Items.Count - 1].Tag = p;

            }
            catch (Exception es) {
                Program.MensajeError(es.Message);
                return;
            }

        }


        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            if (TxtID_Producto.Text == "")
            {

              //  MessageBox.Show("Favor Ingrese el ID!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtID_Producto.Focus();
                return;
            }
            else if (TxtCosto.Text.Trim() == "" || TxtCosto.Text.Trim() == "0") {
                Program.MensajeError("Verificar el precio de costo!");
                return;
            }

            if (TxtCosto.Text == "")
            {
                MessageBox.Show("Favor Ingrese el precio de costo!", "Info!",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCosto.Focus();
                return;
            }

            try
            {
                var prd = new Clases.Productos()

                        {
                            ID_Producto = TxtID_Producto.Text.Trim() == "" ? null : TxtID_Producto.Text,
                            Clase = (int)CmbClase.SelectedValue,
                            NombreProducto = (int)CmbNombre.SelectedValue,
                            Fecha_Ingreso = dtFechaIngreso.Value,
                            Precio_Costo = decimal.Parse(TxtCosto.Text),
                        };
                if (!Productos_A_Ingresar.Exists(p=>p.ID_Producto == prd.ID_Producto))
                    Productos_A_Ingresar.Add(prd);
                else {
                    Program.MensageInfo("Producto ya registrado");
                    return;
                }

                TxtID_Producto.Text = "";
                TxtID_Producto.Focus();

                AddProd(prd);
                //LlenarListaProdsToAdd();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DB = new Clases.IM_DB_Entities();
            try
            {
                
                if (editando)
                {
                    var pr = DB.Productos.Where(p => p.ID_Producto == SelectedProd.ID_Producto).First();
                    pr.Clase = (int)CmbClase.SelectedValue;
                    pr.Fecha_Ingreso = dtFechaIngreso.Value;
                    pr.ID_Producto = TxtID_Producto.Text;
                    pr.NombreProducto = (int)CmbNombre.SelectedValue;
                    pr.Precio_Costo = decimal.Parse(TxtCosto.Text);

                    DB.SaveChanges();
                    MessageBox.Show("Operacion realizada con éxito", "Producto modificado!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Refresh();
                    editando = false;
                    return;
                }

                foreach (var item in Productos_A_Ingresar)
                {
                    DB.Productos.Add(item);
                }

                DB.SaveChanges();
                MessageBox.Show("Operacion realizada con éxito", "Guardado(s)!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LstInventario_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SelectedProd = (Clases.Productos)LstInventario.SelectedItems[0].Tag;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ListProductos_A_Ingresar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SelectedProd = (Clases.Productos)ListProductos_A_Ingresar.SelectedItems[0].Tag;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editando = false;
            _Refresh();
            tabControl1.SelectTab(1);
        }

        private void TxtCosto_Leave(object sender, EventArgs e)
        {
            try
            {
                var x = decimal.Parse(TxtCosto.Text);
                TxtCosto.Text = x.ToString("0.00");
            }
            catch (Exception)
            {
                TxtCosto.Text = "";
            }
        }

        private void LstInventario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Limpiar();
                TxtID_Producto.Text = SelectedProd.ID_Producto.ToString();
                TxtID_Producto.Enabled = false;
                TxtCosto.Text = SelectedProd.Precio_Costo.ToString("0.00");
                TxtID_Producto.Text = SelectedProd.ID_Producto;
                CmbClase.SelectedValue = SelectedProd.Clase;
                CmbNombre.SelectedValue = SelectedProd.NombreProducto;

                tabControl1.SelectTab(1);
                editando = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtID_Producto_TextChanged(object sender, EventArgs e)
        {
            if (TxtID_Producto.Text.Length >= 9) {

                if (TxtCosto.Text.Trim() == "" || TxtCosto.Text.Trim() == 0.ToString())
                {
                    Program.MensajeError("Debe introducir el precio de costo"); 
                }

                Program.wait(1);
                DB = new Clases.IM_DB_Entities();

                if (DB.Productos.Any(p => p.ID_Producto.Trim() == TxtID_Producto.Text.Trim()))
                {
                    Program.MensageInfo("Este código ya existe en su inventario");
                    TxtID_Producto.Text = "";
                    TxtID_Producto.Focus();
                    return;
                }

                CmdAgregar_Click(sender, e);

            }
        }

        private void CmdQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedProd.ID_Producto != null)
                {
                    //SelectedProd = new Clases.Productos();
                    Productos_A_Ingresar.Remove(SelectedProd);
                    LlenarListaProdsToAdd();
                }
                else
                {
                    Program.MensageInfo("Seleccione algún producto por favor!");
                    return;

                }
            }
            catch (Exception es)
            {
                Program.MensajeError(es.Message);
            }
        }

        private void TxtFiltroInventario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtFiltroInventario.Text.Length >= 9)
                {
                    LlenarListaInventario(TxtFiltroInventario.Text);
                }
   
            }
            catch (Exception)
            { }
        }

    }
}
