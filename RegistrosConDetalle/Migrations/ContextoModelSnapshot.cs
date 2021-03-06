﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrosConDetalle.DAL;

namespace RegistrosConDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("RegistrosConDetalle.Entidades.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrdenFecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("SedeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistrosConDetalle.Entidades.OrdenesDetalle", b =>
                {
                    b.Property<int>("OrdenDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenDetalleId");

                    b.HasIndex("OrdenId");

                    b.ToTable("OrdenesDetalles");
                });

            modelBuilder.Entity("RegistrosConDetalle.Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("RegistrosConDetalle.Entidades.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistrosConDetalle.Entidades.Ordenes", null)
                        .WithMany("OrdenesDetalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistrosConDetalle.Entidades.Ordenes", b =>
                {
                    b.Navigation("OrdenesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
