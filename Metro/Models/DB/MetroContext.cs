using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Metro.Models.DB
{
    public partial class MetroContext : DbContext
    {

        public DbSet<Human> Human { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Weapon> Weapon { get; set; }

        public MetroContext()
        {
        }

        public MetroContext(DbContextOptions<MetroContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Metro;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
