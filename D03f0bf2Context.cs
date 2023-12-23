using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace appportal;

public partial class D03f0bf2Context : DbContext
{
    public D03f0bf2Context()
    {
    }

    public D03f0bf2Context(DbContextOptions<D03f0bf2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Name=MySql");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Email");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Content).HasColumnType("int(11)");
            entity.Property(e => e.Name).HasColumnType("int(11)");
            entity.Property(e => e.Sender).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
