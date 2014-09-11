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

        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
    #endregion
}
