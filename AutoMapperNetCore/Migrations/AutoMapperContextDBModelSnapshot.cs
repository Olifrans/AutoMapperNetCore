﻿// <auto-generated />
using System;
using AutoMapperNetCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoMapperNetCore.Migrations
{
    [DbContext(typeof(AutoMapperContextDB))]
    partial class AutoMapperContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoMapperNetCore.DestinoDTO.DetalhesCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClienteNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderQuantidade")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdutoNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DetalhesClientes");
                });

            modelBuilder.Entity("AutoMapperNetCore.OrigemDTO.DetalhesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderQuantidade")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DetalhesOrders");
                });

            modelBuilder.Entity("AutoMapperNetCore.OrigemDTO.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DetalhesOrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProdutoNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetalhesOrderId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("AutoMapperNetCore.OrigemDTO.Produto", b =>
                {
                    b.HasOne("AutoMapperNetCore.OrigemDTO.DetalhesOrder", null)
                        .WithMany("produtos")
                        .HasForeignKey("DetalhesOrderId");
                });

            modelBuilder.Entity("AutoMapperNetCore.OrigemDTO.DetalhesOrder", b =>
                {
                    b.Navigation("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
