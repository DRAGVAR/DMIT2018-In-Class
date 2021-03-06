﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Usings
using System.Data.Entity; // Needed for accessing Entity classes
using eRestraunt.Entities; // Needed for the DbContext base class
#endregion


namespace eRestraunt.DAL
{
    #region RestrauntContext : DbContext
    class RestrauntContext : DbContext
    {
        // Constructor that calls a base-class constructor to specify the
        // connection string we need to use
        public RestrauntContext() : base("name=EatIn") { }

        #region Table To Entity Mappings
        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        #endregion

        #region Over-ride OnModelCreating
        //
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                });
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
    #endregion
}
