﻿// <auto-generated />
using FluentAPI_002;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentAPI_002.Migrations
{
    [DbContext(typeof(SchoolContextb))]
    [Migration("20230219125942_CreateFulentAPI")]
    partial class CreateFulentAPI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FluentAPI_002.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("FluentAPI_002.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CurrentGradeId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("CurrentGradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FluentAPI_002.Student", b =>
                {
                    b.HasOne("FluentAPI_002.Grade", "Grades")
                        .WithMany("Students")
                        .HasForeignKey("CurrentGradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("FluentAPI_002.Grade", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
