using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalZhGyakorlas.F1Model;

public partial class F1DriversContext : DbContext
{
    public F1DriversContext()
    {
    }

    public F1DriversContext(DbContextOptions<F1DriversContext> options)
        : base(options)
    {
    }

    public virtual DbSet<F1Driver> F1Drivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:softeng-projekt.database.windows.net,1433;Initial Catalog=f1_drivers;Persist Security Info=False;User ID=gipszjakab;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<F1Driver>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("PK__F1_Drive__F1B1CD24D3A38623");

            entity.ToTable("F1_Drivers");

            entity.Property(e => e.DriverId).HasColumnName("DriverID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Team).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
