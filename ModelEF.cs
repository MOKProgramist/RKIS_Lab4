using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RKIS_Lab4
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Mall> Mall { get; set; }
        public virtual DbSet<Pavilion> Pavilion { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Tenants> Tenants { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mall>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Pavilion)
                .WithRequired(e => e.Mall)
                .HasForeignKey(e => e.ID_mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Mall)
                .HasForeignKey(e => e.ID_Mall);

            modelBuilder.Entity<Pavilion>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Pavilion)
                .HasForeignKey(e => new { e.Num_pav, e.ID_Mall });

            modelBuilder.Entity<Tenants>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Tenants)
                .HasForeignKey(e => e.ID_tenan);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Rent)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.ID_workers);
        }
    }
}
