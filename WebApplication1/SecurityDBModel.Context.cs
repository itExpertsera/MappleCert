﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MappleDBContext : DbContext
    {
        public MappleDBContext()
            : base("name=MappleDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MappleUser> MappleUsers { get; set; }
        public virtual DbSet<CertificationList> CertificationLists { get; set; }
        public virtual DbSet<ContactU> ContactUS { get; set; }
    }
}
