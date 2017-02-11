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

namespace InternationalMovile.Procesos
{
    public partial class FormadePago : Form
    {

        List<VentaInmediata> VentasAProcesar = new List<VentaInmediata>();

        public FormadePago( List<VentaInmediata> lstRef)
        {
            InitializeComponent();
            VentasAProcesar = lstRef;
        }

        private void FormadePago_Load(object sender, EventArgs e)
        {

        }
    }
}
