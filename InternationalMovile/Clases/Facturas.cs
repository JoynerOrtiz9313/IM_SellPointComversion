//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternationalMovile.Clases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturas
    {
        public Facturas()
        {
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int ID_Factura { get; set; }
        public string Cliente { get; set; }
        public int Cant_Articulos { get; set; }
        public decimal Monto_Factura { get; set; }
        public System.DateTime Fecha { get; set; }
        public string vendedor { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
