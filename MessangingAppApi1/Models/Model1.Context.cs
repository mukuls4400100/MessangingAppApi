﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessangingAppApi1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MessangingAppApiEntities1 : DbContext
    {
        public MessangingAppApiEntities1()
            : base("name=MessangingAppApiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<channel> channels { get; set; }
        public virtual DbSet<inviteUser> inviteUsers { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<reply> replies { get; set; }
        public virtual DbSet<tag> tags { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}