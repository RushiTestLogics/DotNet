﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirstExamp.Models;

public partial class YcpOct23Context : DbContext
{
    public YcpOct23Context()
    {
    }

    public YcpOct23Context(DbContextOptions<YcpOct23Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__Departme__0148CAAE9B4631C6");

            entity.Property(e => e.DeptNo).ValueGeneratedNever();
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__Employee__AF2D66D379CCD3EC");

            entity.Property(e => e.EmpNo).ValueGeneratedNever();
            entity.Property(e => e.Basic).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.DeptNoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DeptNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Departments");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
