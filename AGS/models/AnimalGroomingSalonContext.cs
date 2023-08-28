using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AGS.models;

public partial class AnimalGroomingSalonContext : DbContext
{
    public AnimalGroomingSalonContext()
    {
    }

    public AnimalGroomingSalonContext(DbContextOptions<AnimalGroomingSalonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cat> Cats { get; set; }

    public virtual DbSet<Dog> Dogs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;database=AnimalGroomingSalon;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cats__3214EC07E76C1EDA");

            entity.Property(e => e.Breed)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastShotRecord).HasColumnType("datetime");
            entity.Property(e => e.Lastname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dogs__3214EC0767CB93BF");

            entity.HasIndex(e => e.Breed, "UQ__Dogs__B38E3CF88FD694C8").IsUnique();

            entity.Property(e => e.Breed)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastShotRecord).HasColumnType("datetime");
            entity.Property(e => e.Lastname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC075451CA7C");

            entity.HasIndex(e => e.PartNbr, "UQ__Products__DAFC0C1E890A15FB").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PartNbr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PhotoPath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(11, 2)");
            entity.Property(e => e.Unit)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC078E84EF3B");

            entity.Property(e => e.Description)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(11, 2)");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendors__3214EC0759D093D9");

            entity.HasIndex(e => e.Code, "UQ__Vendors__A25C5AA760FE3A6E").IsUnique();

            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
