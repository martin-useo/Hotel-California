﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_California___Data_manipulation_Layer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities_oui : DbContext
    {
        public Entities_oui()
            : base("name=Entities_oui")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Post_Type> Post_Type { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Booked_Rooms> Booked_Rooms { get; set; }
        public virtual DbSet<Task_Type> Task_Type { get; set; }
    }
}
