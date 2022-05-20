﻿// <auto-generated />
using FinalAssessment_GovindMishra.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FinalAssessment_GovindMishra.Migrations
{
    [DbContext(typeof(InfoDbContext))]
    partial class InfoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FinalAssessment_GovindMishra.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("DeptHead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DeptId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("FinalAssessment_GovindMishra.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .HasColumnType("integer");

                    b.Property<int>("EmpAge")
                        .HasColumnType("integer");

                    b.Property<string>("EmpEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmpID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("FinalAssessment_GovindMishra.Models.Employee", b =>
                {
                    b.HasOne("FinalAssessment_GovindMishra.Models.Department", "department")
                        .WithMany("employee")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("FinalAssessment_GovindMishra.Models.Department", b =>
                {
                    b.Navigation("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
