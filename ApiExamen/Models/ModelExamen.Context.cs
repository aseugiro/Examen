﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiExamen.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExamenEntities : DbContext
    {
        public ExamenEntities()
            : base("name=ExamenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Area> Areas { get; set; }
        public DbSet<Empleado> Empleadoes { get; set; }
        public DbSet<Empleado_Habilidad> Empleado_Habilidad { get; set; }
    }
}
