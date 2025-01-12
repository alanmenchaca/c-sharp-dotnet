﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_ef;

#nullable disable

namespace dotnet_ef.Migrations
{
    [DbContext(typeof(TasksManagerContext))]
    partial class TasksManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotnet_ef.models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2e32"),
                            CategoryName = "Pending Activities",
                            Description = "Activities that are pending",
                            Weight = 20
                        },
                        new
                        {
                            CategoryId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2ef2"),
                            CategoryName = "Personal Activities",
                            Description = "Activities that are personal",
                            Weight = 50
                        });
                });

            modelBuilder.Entity("dotnet_ef.models.Tasks", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Task", (string)null);

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2e17"),
                            CategoryId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2e32"),
                            CreatedAt = new DateTime(2025, 1, 5, 8, 30, 52, 0, DateTimeKind.Local),
                            Description = "Description of Task 1",
                            Priority = 1,
                            Title = "Task 1"
                        },
                        new
                        {
                            TaskId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2e22"),
                            CategoryId = new Guid("118eefa8-c6d3-4d20-a591-537931bd2ef2"),
                            CreatedAt = new DateTime(2025, 1, 5, 8, 30, 52, 0, DateTimeKind.Local),
                            Description = "Description of Task 2",
                            Priority = 0,
                            Title = "Task 2"
                        });
                });

            modelBuilder.Entity("dotnet_ef.models.Tasks", b =>
                {
                    b.HasOne("dotnet_ef.models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("dotnet_ef.models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
