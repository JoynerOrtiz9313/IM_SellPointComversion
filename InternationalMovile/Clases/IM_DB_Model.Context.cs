﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IM_DB_Entities : DbContext
    {
        public IM_DB_Entities()
            : base("name=IM_DB_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Clases_Productos> Clases_Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Nombres_Productos> Nombres_Productos { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Productos_V> Productos_V { get; set; }
        public DbSet<Tipos_ID_Cliente> Tipos_ID_Cliente { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
    }
}
