using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using elso_feladat.Models;

namespace elso_feladat.Data
{
    public partial class RendelesDbContext : DbContext
    {
        public RendelesDbContext()
        {
        }

        public RendelesDbContext(DbContextOptions<RendelesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cim> Cim { get; set; } = null!;
        public virtual DbSet<Rendeles> Rendeles { get; set; } = null!;
        public virtual DbSet<RendelesTetel> RendelesTetel { get; set; } = null!;
        public virtual DbSet<Termek> Termek { get; set; } = null!;
        public virtual DbSet<TermekKategoria> TermekKategoria { get; set; } = null!;
        public virtual DbSet<Ugyfel> Ugyfel { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=szoftver-2.database.windows.net;Initial Catalog=Szoftver_2;Persist Security Info=True;User ID=EW7AI2;Password=Miskey0123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rendeles>(entity =>
            {
                entity.Property(e => e.RendelesDatum).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SzallitasiCim)
                    .WithMany(p => p.Rendeles)
                    .HasForeignKey(d => d.SzallitasiCimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RENDELES_CIM");

                entity.HasOne(d => d.Ugyfel)
                    .WithMany(p => p.Rendeles)
                    .HasForeignKey(d => d.UgyfelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RENDELES_UGYFEL");
            });

            modelBuilder.Entity<RendelesTetel>(entity =>
            {
                entity.HasKey(e => e.TetelId)
                    .HasName("PK__RENDELES__18F19F74EDA08431");

                entity.HasOne(d => d.Rendeles)
                    .WithMany(p => p.RendelesTetel)
                    .HasForeignKey(d => d.RendelesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RENDELES_TETEL_RENDELES");

                entity.HasOne(d => d.Termek)
                    .WithMany(p => p.RendelesTetel)
                    .HasForeignKey(d => d.TermekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RENDELES_TETEL_TERMEK");
            });

            modelBuilder.Entity<Termek>(entity =>
            {
                entity.HasOne(d => d.Kategoria)
                    .WithMany(p => p.Termek)
                    .HasForeignKey(d => d.KategoriaId)
                    .HasConstraintName("FK_TERMEK_TERMEK_KATEGORIA");
            });

            modelBuilder.Entity<TermekKategoria>(entity =>
            {
                entity.HasKey(e => e.KategoriaId)
                    .HasName("PK__TERMEK_K__37D210ECFED4EE40");

                entity.HasOne(d => d.SzuloKategoria)
                    .WithMany(p => p.InverseSzuloKategoria)
                    .HasForeignKey(d => d.SzuloKategoriaId)
                    .HasConstraintName("FK_TERMEK_KATEGORIA_SzuloKategoria");
            });

            modelBuilder.Entity<Ugyfel>(entity =>
            {
                entity.HasOne(d => d.Lakcim)
                    .WithMany(p => p.Ugyfel)
                    .HasForeignKey(d => d.LakcimId)
                    .HasConstraintName("FK_UGYFEL_CIM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
