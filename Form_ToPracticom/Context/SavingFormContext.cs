using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repositories.Entity;
using Repositories.Interfase;

namespace Context;

public partial class SavingFormContext : DbContext, Icontext
{
    public SavingFormContext()
    {
    }

    public SavingFormContext(DbContextOptions<SavingFormContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-UT7PC9L;Initial Catalog=SavingFormFinul;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.ToTable("Child");

            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.Name).HasMaxLength(20);

            entity.HasOne(d => d.IdParentNavigation).WithMany(p => p.Children)
                .HasForeignKey(d => d.IdParent)
                .HasConstraintName("FK_Child_Parent");
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.ToTable("Parent");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Hmo)
                .HasMaxLength(50)
                .HasColumnName("HMO");
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.MaleOrFemale).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
