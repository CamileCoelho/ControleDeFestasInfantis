﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteKeeper.Infra.Orm.Compartilhado;

#nullable disable

namespace NoteKeeper.Infra.Orm.Migrations
{
    [DbContext(typeof(NoteKeeperDbContext))]
    partial class NoteKeeperDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NoteKeeper.Dominio.ModuloCategoria.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TBCategoria", (string)null);
                });

            modelBuilder.Entity("NoteKeeper.Dominio.ModuloNota.Nota", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Arquivada")
                        .HasColumnType("bit");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tema")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CategoriaId1");

                    b.ToTable("TBNota", (string)null);
                });

            modelBuilder.Entity("NoteKeeper.Dominio.ModuloNota.Nota", b =>
                {
                    b.HasOne("NoteKeeper.Dominio.ModuloCategoria.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCategoria_TBNota");

                    b.HasOne("NoteKeeper.Dominio.ModuloCategoria.Categoria", null)
                        .WithMany("Notas")
                        .HasForeignKey("CategoriaId1");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("NoteKeeper.Dominio.ModuloCategoria.Categoria", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}