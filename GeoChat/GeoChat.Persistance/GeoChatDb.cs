using System.Collections.Generic;
using System.Data.Entity;
using GeoChat.Models;

namespace GeoChat.Persistance
{
    public class GeoChatDb : DbContext
    {
        public GeoChatDb()
            : base("GeoChatDb")
        { }
        public DbSet<GeoMessage> GeoMessages { get; set; }
        public DbSet<GeoLocation> GeoLocations { get; set; }
        public DbSet<GeoThread> GeoThreads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GeoMessage>().HasRequired(m => m.Location).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<GeoThread>().HasMany(m => m.GeoMessages).WithRequired(t => t.Thread).WillCascadeOnDelete(false);
            modelBuilder.Entity<GeoThread>().HasRequired(m => m.Location).WithMany().WillCascadeOnDelete(false);
        }
    }
}
