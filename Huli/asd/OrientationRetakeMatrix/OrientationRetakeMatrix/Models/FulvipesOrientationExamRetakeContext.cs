using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrientationRetakeMatrix.Models
{
    public partial class FulvipesOrientationExamRetakeContext : DbContext
    {
        public virtual DbSet<Matrices> Matrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FulvipesOrientationExamRetake;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matrices>(entity =>
            {
                entity.ToTable("matrices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.M3).HasColumnName("m3");

                entity.Property(e => e.M4).HasColumnName("m4");

                entity.Property(e => e.M5).HasColumnName("m5");

                entity.Property(e => e.M6).HasColumnName("m6");

                entity.Property(e => e.M7).HasColumnName("m7");

                entity.Property(e => e.M8).HasColumnName("m8");

                entity.Property(e => e.M9).HasColumnName("m9");

                entity.Property(e => e.UsableMatrix).HasColumnName("usable_matrix");
            });
        }
    }
}
