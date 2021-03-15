﻿// <auto-generated />
using System;
using Estoque.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estoque.Repository.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    [Migration("20210314191454_createDatabase")]
    partial class createDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estoque.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeAlteracao")
                        .HasColumnName("dataDeAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnName("dataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagem")
                        .HasColumnName("imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lixeira")
                        .HasColumnName("lixeira")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<double>("Valor")
                        .HasColumnName("valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}
