using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sharaawy_DAL.Entities;

namespace Sharaawy_DAL.DataBase;

public partial class SharaawyContext : DbContext
{
    public SharaawyContext()
    {
    }

    public SharaawyContext(DbContextOptions<SharaawyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CrsResult> CrsResults { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Trainee> Trainees { get; set; }


    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Course>(entity =>
    //    {
    //        entity.ToTable("course");

    //        entity.HasIndex(e => e.DeptId, "IX_course_DeptID");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //        entity.Property(e => e.Degree).HasColumnType("decimal(18, 2)");
    //        entity.Property(e => e.DeptId).HasColumnName("DeptID");
    //        entity.Property(e => e.MinDegree).HasColumnType("decimal(18, 2)");

    //        entity.HasOne(d => d.Dept).WithMany(p => p.Courses)
    //            .HasForeignKey(d => d.DeptId)
    //            .OnDelete(DeleteBehavior.SetNull);
    //    });

    //    modelBuilder.Entity<CrsResult>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK_CourseResult");

    //        entity.ToTable("crsResult");

    //        entity.HasIndex(e => e.CrsId, "IX_CourseResult_Crs_id");

    //        entity.HasIndex(e => e.TraineeId, "IX_CourseResult_Trainee_id");

    //        entity.Property(e => e.CrsId).HasColumnName("Crs_id");
    //        entity.Property(e => e.TraineeId).HasColumnName("Trainee_id");

    //        entity.HasOne(d => d.Crs).WithMany(p => p.CrsResults)
    //            .HasForeignKey(d => d.CrsId)
    //            .OnDelete(DeleteBehavior.SetNull)
    //            .HasConstraintName("FK_CourseResult_course_Crs_id");

    //        entity.HasOne(d => d.Trainee).WithMany(p => p.CrsResults)
    //            .HasForeignKey(d => d.TraineeId)
    //            .OnDelete(DeleteBehavior.SetNull)
    //            .HasConstraintName("FK_CourseResult_trainee_Trainee_id");
    //    });

    //    modelBuilder.Entity<Department>(entity =>
    //    {
    //        entity.ToTable("department");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //    });

    //    modelBuilder.Entity<Instructor>(entity =>
    //    {
    //        entity.ToTable("instructor");

    //        entity.HasIndex(e => e.CrsId, "IX_instructor_CrsID");

    //        entity.HasIndex(e => e.DeptId, "IX_instructor_DeptID");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //        entity.Property(e => e.CrsId).HasColumnName("CrsID");
    //        entity.Property(e => e.DeptId).HasColumnName("DeptID");
    //        entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

    //        entity.HasOne(d => d.Crs).WithMany(p => p.Instructors)
    //            .HasForeignKey(d => d.CrsId)
    //            .OnDelete(DeleteBehavior.SetNull);

    //        entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
    //            .HasForeignKey(d => d.DeptId)
    //            .OnDelete(DeleteBehavior.SetNull);
    //    });

    //    modelBuilder.Entity<Trainee>(entity =>
    //    {
    //        entity.ToTable("trainee");

    //        entity.HasIndex(e => e.DeptId, "IX_trainee_DeptID");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //        entity.Property(e => e.DeptId).HasColumnName("DeptID");
    //        entity.Property(e => e.Grade).HasColumnType("decimal(18, 2)");

    //        entity.HasOne(d => d.Dept).WithMany(p => p.Trainees)
    //            .HasForeignKey(d => d.DeptId)
    //            .OnDelete(DeleteBehavior.SetNull);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
