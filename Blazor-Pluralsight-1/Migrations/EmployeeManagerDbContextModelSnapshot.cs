﻿// <auto-generated />
using System;
using Blazor_Pluralsight_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor_Pluralsight_1.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    partial class EmployeeManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blazor_Pluralsight_1.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("Blazor_Pluralsight_1.Data.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DepartmentId = 2,
                            FirstName = "Anna",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            id = 2,
                            DepartmentId = 5,
                            FirstName = "Julia",
                            IsDeveloper = true,
                            LastName = "Developer"
                        },
                        new
                        {
                            id = 3,
                            DepartmentId = 5,
                            FirstName = "Thomas",
                            IsDeveloper = true,
                            LastName = "Huber"
                        },
                        new
                        {
                            id = 4,
                            DepartmentId = 1,
                            FirstName = "Sara",
                            IsDeveloper = false,
                            LastName = "Metroid"
                        },
                        new
                        {
                            id = 5,
                            DepartmentId = 4,
                            FirstName = "Ben",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            id = 6,
                            DepartmentId = 3,
                            FirstName = "Alex",
                            IsDeveloper = true,
                            LastName = "Rider"
                        },
                        new
                        {
                            id = 7,
                            DepartmentId = 5,
                            FirstName = "Sophie",
                            IsDeveloper = false,
                            LastName = "Ramos"
                        },
                        new
                        {
                            id = 8,
                            DepartmentId = 2,
                            FirstName = "Julien",
                            IsDeveloper = false,
                            LastName = "Russell"
                        },
                        new
                        {
                            id = 9,
                            DepartmentId = 4,
                            FirstName = "Yvonne",
                            IsDeveloper = false,
                            LastName = "Snider"
                        },
                        new
                        {
                            id = 10,
                            DepartmentId = 1,
                            FirstName = "Jasmin",
                            IsDeveloper = true,
                            LastName = "Curtis"
                        });
                });

            modelBuilder.Entity("Blazor_Pluralsight_1.Data.Models.Employee", b =>
                {
                    b.HasOne("Blazor_Pluralsight_1.Data.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Blazor_Pluralsight_1.Data.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
