﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20231216213201_I")]
    partial class I
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("WinFormsApp1.Employee", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("username");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("WinFormsApp1.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("students");
                });

            modelBuilder.Entity("WinFormsApp1.Subject", b =>
                {
                    b.Property<string>("student_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<float>("gpa")
                        .HasColumnType("REAL");

                    b.Property<int>("weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("student_id", "name");

                    b.ToTable("subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
