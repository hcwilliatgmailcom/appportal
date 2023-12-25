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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=hcwilli.at;User ID=d03f0bf2;Password=CHGXdHiYiofWFQZE4rqF;Database=d03f0bf2");

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
