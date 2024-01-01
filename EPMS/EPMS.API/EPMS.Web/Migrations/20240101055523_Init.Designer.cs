﻿// <auto-generated />
using System;
using EPMS.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EPMS.Web.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20240101055523_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EPMS.Web.Models.AssignProject", b =>
                {
                    b.Property<string>("AssignId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AssignId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("AssignProjects");
                });

            modelBuilder.Entity("EPMS.Web.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EPMS.Web.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EPMS.Web.Models.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EPMS.Web.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EPMS.Web.Models.AssignProject", b =>
                {
                    b.HasOne("EPMS.Web.Models.Employee", "Employee")
                        .WithMany("AssignProjects")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("EPMS.Web.Models.Project", "Project")
                        .WithMany("AssignProjects")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("EPMS.Web.Models.Employee", b =>
                {
                    b.HasOne("EPMS.Web.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EPMS.Web.Models.User", b =>
                {
                    b.HasOne("EPMS.Web.Models.Employee", "Employee")
                        .WithMany("Users")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EPMS.Web.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EPMS.Web.Models.Employee", b =>
                {
                    b.Navigation("AssignProjects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EPMS.Web.Models.Project", b =>
                {
                    b.Navigation("AssignProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
