﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessoriesStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccessoriesEntitiesBD : DbContext
    {
        public AccessoriesEntitiesBD()
            : base("name=AccessoriesEntitiesBD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<CPU> CPUs { get; set; }
        public virtual DbSet<GPU> GPUs { get; set; }
        public virtual DbSet<HDDSSD> HDDSSDs { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }
        public virtual DbSet<PowerSupply> PowerSupplies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RAM> RAMs { get; set; }
        public virtual DbSet<Specialist> Specialists { get; set; }
    }
}
