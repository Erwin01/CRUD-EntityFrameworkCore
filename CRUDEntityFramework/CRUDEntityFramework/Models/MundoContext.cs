using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUDEntityFramework.Models
{
    public partial class MundoContext : DbContext
    {
        public MundoContext()
        {
        }

        public MundoContext(DbContextOptions<MundoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Continentes> Continentes { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Presidentes> Presidentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Mundo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasIndex(e => e.ContinenteId);

                entity.HasOne(d => d.Continente)
                    .WithMany(p => p.Paises)
                    .HasForeignKey(d => d.ContinenteId);
            });

            modelBuilder.Entity<Presidentes>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.Property(e => e.Nombre).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
