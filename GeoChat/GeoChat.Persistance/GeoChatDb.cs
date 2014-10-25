using System.Collections.Generic;
using System.Data.Entity;
using GeoChat.Models;

namespace GeoChat.Persistance
{
    public class GeoChatDb : DbContext
    {
        public DbSet<GeoMessage> GeoMessages { get; set; }
        public DbSet<GeoLocation> GeoLocations { get; set; }
        public DbSet<GeoThread> GeoThreads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GeoMessage>().HasRequired(m => m.Author);
            modelBuilder.Entity<GeoMessage>().HasRequired(m => m.Location);
            modelBuilder.Entity<GeoMessage>().HasRequired(m => m.Text);

            modelBuilder.Entity<GeoThread>().HasMany(m => m.GeoMessages).WithRequired(t => t.Thread);
            modelBuilder.Entity<GeoThread>().HasRequired(m => m.Location);
            modelBuilder.Entity<GeoThread>().HasRequired(m => m.Name);
        }
    }
}
