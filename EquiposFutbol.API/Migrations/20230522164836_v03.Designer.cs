﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EquiposFutbol.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230522164836_v03")]
    partial class v03
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EquiposFutbol.Modelos.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombreEquipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("numeroJugadores")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("EquiposFutbol.Modelos.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("domicilio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("equipoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombreJugador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("equipoId");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("EquiposFutbol.Modelos.Jugador", b =>
                {
                    b.HasOne("EquiposFutbol.Modelos.Equipo", "equipo")
                        .WithMany("Jugadores")
                        .HasForeignKey("equipoId");

                    b.Navigation("equipo");
                });

            modelBuilder.Entity("EquiposFutbol.Modelos.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
