﻿// <auto-generated />
using System;
using KontakHomeWpf.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KontakHomeWpf.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KontakHomeWpf.Model.Box", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BaseCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BaseCategoryId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.DictionaryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PropName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.ToTable("DictionaryProducts");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContacttId")
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContacttId");

                    b.HasIndex("DeliveryyId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoxId")
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("categoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoxId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Category", b =>
                {
                    b.HasOne("KontakHomeWpf.Model.Category", "BaseCategory")
                        .WithMany()
                        .HasForeignKey("BaseCategoryId");

                    b.Navigation("BaseCategory");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.DictionaryProduct", b =>
                {
                    b.HasOne("KontakHomeWpf.Model.Product", "product")
                        .WithMany("Properts")
                        .HasForeignKey("productId");

                    b.Navigation("product");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Order", b =>
                {
                    b.HasOne("KontakHomeWpf.Model.Contact", "Contactt")
                        .WithMany()
                        .HasForeignKey("ContacttId");

                    b.HasOne("KontakHomeWpf.Model.Delivery", "Deliveryy")
                        .WithMany()
                        .HasForeignKey("DeliveryyId");

                    b.Navigation("Contactt");

                    b.Navigation("Deliveryy");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Product", b =>
                {
                    b.HasOne("KontakHomeWpf.Model.Box", null)
                        .WithMany("Products")
                        .HasForeignKey("BoxId");

                    b.HasOne("KontakHomeWpf.Model.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryId");

                    b.HasOne("KontakHomeWpf.Model.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId");

                    b.Navigation("category");

                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Box", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KontakHomeWpf.Model.Product", b =>
                {
                    b.Navigation("Properts");
                });
#pragma warning restore 612, 618
        }
    }
}
