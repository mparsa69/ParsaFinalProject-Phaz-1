﻿// <auto-generated />
using System;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Infrastructures.Database.SqlServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App.Domain.Core.AdministratorAgg.Entities.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.SecondaryCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("SecondaryCategories");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.ThirdCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("SecondaryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SecondaryCategoryId");

                    b.ToTable("ThirdCategories");
                });

            modelBuilder.Entity("App.Domain.Core.CustomerAgg.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("App.Domain.Core.ExpertAgg.Entities.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("App.Domain.Core.ExpertAgg.Entities.ExpertSkill", b =>
                {
                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<int>("ThirdCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ExpertId", "ThirdCategoryId");

                    b.HasIndex("ThirdCategoryId");

                    b.ToTable("ExpertSkills");
                });

            modelBuilder.Entity("App.Domain.Core.OrderAgg.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("ThirdCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ThirdCategoryId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.SuggestionAgg.Entities.Suggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertId")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SuggestionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExpertId");

                    b.HasIndex("OrderId");

                    b.ToTable("Suggestions");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.SecondaryCategory", b =>
                {
                    b.HasOne("App.Domain.Core.BaseService.Entities.MainCategory", "MainCategory")
                        .WithMany("secondaryCategories")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.ThirdCategory", b =>
                {
                    b.HasOne("App.Domain.Core.BaseService.Entities.SecondaryCategory", "SecondaryCategory")
                        .WithMany("ThirdCategories")
                        .HasForeignKey("SecondaryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SecondaryCategory");
                });

            modelBuilder.Entity("App.Domain.Core.ExpertAgg.Entities.ExpertSkill", b =>
                {
                    b.HasOne("App.Domain.Core.ExpertAgg.Entities.Expert", "Expert")
                        .WithMany("ExpertSkills")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Core.BaseService.Entities.ThirdCategory", "ThirdCategory")
                        .WithMany("ExpertSkills")
                        .HasForeignKey("ThirdCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");

                    b.Navigation("ThirdCategory");
                });

            modelBuilder.Entity("App.Domain.Core.OrderAgg.Entities.Order", b =>
                {
                    b.HasOne("App.Domain.Core.CustomerAgg.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Core.BaseService.Entities.ThirdCategory", "ThirdCategory")
                        .WithMany("Orders")
                        .HasForeignKey("ThirdCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ThirdCategory");
                });

            modelBuilder.Entity("App.Domain.Core.SuggestionAgg.Entities.Suggestion", b =>
                {
                    b.HasOne("App.Domain.Core.ExpertAgg.Entities.Expert", "Expert")
                        .WithMany("Suggestions")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Core.OrderAgg.Entities.Order", "Order")
                        .WithMany("Suggestions")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.MainCategory", b =>
                {
                    b.Navigation("secondaryCategories");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.SecondaryCategory", b =>
                {
                    b.Navigation("ThirdCategories");
                });

            modelBuilder.Entity("App.Domain.Core.BaseService.Entities.ThirdCategory", b =>
                {
                    b.Navigation("ExpertSkills");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.CustomerAgg.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("App.Domain.Core.ExpertAgg.Entities.Expert", b =>
                {
                    b.Navigation("ExpertSkills");

                    b.Navigation("Suggestions");
                });

            modelBuilder.Entity("App.Domain.Core.OrderAgg.Entities.Order", b =>
                {
                    b.Navigation("Suggestions");
                });
#pragma warning restore 612, 618
        }
    }
}
