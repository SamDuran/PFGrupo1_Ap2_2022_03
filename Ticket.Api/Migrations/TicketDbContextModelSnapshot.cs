﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticket.Api.DAL;

#nullable disable

namespace Ticket.Api.Migrations
{
    [DbContext(typeof(TicketDbContext))]
    partial class TicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Ticket.Api.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<int>("ConfiguracionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId")
                        .HasName("PK__Clientes__71ABD087B375C419");

                    b.HasIndex("ConfiguracionId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Ticket.Api.Models.Configuraciones", b =>
                {
                    b.Property<int>("ConfiguracionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorSchemeIndex")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RecordarEnDispositivo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Theme")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("Ticket.Api.Models.Estatus", b =>
                {
                    b.Property<int>("EstatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estatus1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("Estatus");

                    b.HasKey("EstatusId")
                        .HasName("PK__Estatus__DE10F58DA375F6EC");

                    b.ToTable("Estatus", (string)null);
                });

            modelBuilder.Entity("Ticket.Api.Models.Prioridades", b =>
                {
                    b.Property<int>("PrioridadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prioridad")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("PrioridadId")
                        .HasName("PK__Priorida__3939172E0518F8F3");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("Ticket.Api.Models.Respuestas", b =>
                {
                    b.Property<int>("RespuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Respuesta")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TicketId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RespuestaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TicketId");

                    b.ToTable("Respuestas");
                });

            modelBuilder.Entity("Ticket.Api.Models.Sistemas", b =>
                {
                    b.Property<int>("SistemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sistema")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("Sistema");

                    b.HasKey("SistemaId")
                        .HasName("PK__Sistemas__4C36BB868F17E7A9");

                    b.ToTable("Sistemas");
                });

            modelBuilder.Entity("Ticket.Api.Models.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Especificaciones")
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaFinalizado")
                        .HasColumnType("datetime");

                    b.Property<int?>("Orden")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrioridadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SistemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TipoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketId")
                        .HasName("PK__eTicket__712CC6070A90FFD9");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstatusId");

                    b.HasIndex("PrioridadId");

                    b.HasIndex("SistemaId");

                    b.HasIndex("TipoId");

                    b.ToTable("eTicket", (string)null);
                });

            modelBuilder.Entity("Ticket.Api.Models.Tipos", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("Tipo");

                    b.HasKey("TipoId")
                        .HasName("PK__Tipos__97099EB7224F755C");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("Ticket.Api.Models.Clientes", b =>
                {
                    b.HasOne("Ticket.Api.Models.Configuraciones", "Configuracion")
                        .WithMany()
                        .HasForeignKey("ConfiguracionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuracion");
                });

            modelBuilder.Entity("Ticket.Api.Models.Respuestas", b =>
                {
                    b.HasOne("Ticket.Api.Models.Clientes", "cliente")
                        .WithMany("Respuestas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Ticket.Api.Models.Tickets", "Ticket")
                        .WithMany("Respuestas")
                        .HasForeignKey("TicketId");

                    b.Navigation("Ticket");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Ticket.Api.Models.Tickets", b =>
                {
                    b.HasOne("Ticket.Api.Models.Clientes", "Cliente")
                        .WithMany("Tickets")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("FK__eTicket__Cliente__1CF15040");

                    b.HasOne("Ticket.Api.Models.Estatus", "Estatus")
                        .WithMany("Tickets")
                        .HasForeignKey("EstatusId")
                        .HasConstraintName("FK__eTicket__Estatus__20C1E124");

                    b.HasOne("Ticket.Api.Models.Prioridades", "Prioridad")
                        .WithMany("Tickets")
                        .HasForeignKey("PrioridadId")
                        .HasConstraintName("FK__eTicket__Priorid__1FCDBCEB");

                    b.HasOne("Ticket.Api.Models.Sistemas", "Sistema")
                        .WithMany("Tickets")
                        .HasForeignKey("SistemaId")
                        .HasConstraintName("FK__eTicket__Sistema__1DE57479");

                    b.HasOne("Ticket.Api.Models.Tipos", "Tipo")
                        .WithMany("Tickets")
                        .HasForeignKey("TipoId")
                        .HasConstraintName("FK__eTicket__TipoId__1ED998B2");

                    b.Navigation("Cliente");

                    b.Navigation("Estatus");

                    b.Navigation("Prioridad");

                    b.Navigation("Sistema");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Ticket.Api.Models.Clientes", b =>
                {
                    b.Navigation("Respuestas");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Ticket.Api.Models.Estatus", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Ticket.Api.Models.Prioridades", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Ticket.Api.Models.Sistemas", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Ticket.Api.Models.Tickets", b =>
                {
                    b.Navigation("Respuestas");
                });

            modelBuilder.Entity("Ticket.Api.Models.Tipos", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
