using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebApp01.Models;

public partial class AspDotNetCoreContext : DbContext
{
    public AspDotNetCoreContext()
    {
    }

    public AspDotNetCoreContext(DbContextOptions<AspDotNetCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultCS");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__students__3213E83FD8F654DA");

            entity.ToTable("students");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Std)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("std");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
