﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sharaawy_DAL.DataBase;

#nullable disable

namespace Sharaawy_DAL.Migrations
{
    [DbContext(typeof(SharaawyContext))]
    partial class SharaawyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sharaawy_DAL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Degree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<decimal>("MinDegree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.CrsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CrsId")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int?>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("TraineeId");

                    b.ToTable("CrsResults");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CrsId")
                        .HasColumnType("int");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Course", b =>
                {
                    b.HasOne("Sharaawy_DAL.Entities.Department", "Dept")
                        .WithMany("Courses")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.CrsResult", b =>
                {
                    b.HasOne("Sharaawy_DAL.Entities.Course", "Crs")
                        .WithMany("CrsResults")
                        .HasForeignKey("CrsId");

                    b.HasOne("Sharaawy_DAL.Entities.Trainee", "Trainee")
                        .WithMany("CrsResults")
                        .HasForeignKey("TraineeId");

                    b.Navigation("Crs");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Instructor", b =>
                {
                    b.HasOne("Sharaawy_DAL.Entities.Course", "Crs")
                        .WithMany("Instructors")
                        .HasForeignKey("CrsId");

                    b.HasOne("Sharaawy_DAL.Entities.Department", "Dept")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptId");

                    b.Navigation("Crs");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Trainee", b =>
                {
                    b.HasOne("Sharaawy_DAL.Entities.Department", "Dept")
                        .WithMany("Trainees")
                        .HasForeignKey("DeptId");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Course", b =>
                {
                    b.Navigation("CrsResults");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("Sharaawy_DAL.Entities.Trainee", b =>
                {
                    b.Navigation("CrsResults");
                });
#pragma warning restore 612, 618
        }
    }
}
