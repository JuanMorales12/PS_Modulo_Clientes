﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PS.Template.AccessData;

namespace PS.Template.AccessData.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    partial class TemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PS.Template.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Contraseña")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("DNI")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("NumeroCelular")
                        .HasMaxLength(20)
                        .HasColumnType("bigint");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("PartidoId");

                    b.HasIndex("PlanId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TurnoId")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("HistoriaClinica");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Partido", b =>
                {
                    b.Property<int>("PartidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PartidoId");

                    b.ToTable("Partido");

                    b.HasData(
                        new
                        {
                            PartidoId = 1,
                            Nombre = "Berazategui"
                        },
                        new
                        {
                            PartidoId = 2,
                            Nombre = "Florencio Varela"
                        },
                        new
                        {
                            PartidoId = 3,
                            Nombre = "Quilmes"
                        });
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Descuento")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("NombrePlan")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("PrecioPlan")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.HasKey("PlanId");

                    b.ToTable("Plan");

                    b.HasData(
                        new
                        {
                            PlanId = 1,
                            Descripcion = "Descuento del 15% en especialidades comunes",
                            Descuento = 15.0,
                            NombrePlan = "Basico",
                            PrecioPlan = 1500.0
                        },
                        new
                        {
                            PlanId = 2,
                            Descripcion = "Descuento del 35% en todo tipo de especialidades",
                            Descuento = 35.0,
                            NombrePlan = "Premium",
                            PrecioPlan = 3500.0
                        });
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("PS.Template.Domain.Entities.Partido", "Partidos")
                        .WithMany("Clientes")
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PS.Template.Domain.Entities.Plan", "Planes")
                        .WithMany("Clientes")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partidos");

                    b.Navigation("Planes");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.HistoriaClinica", b =>
                {
                    b.HasOne("PS.Template.Domain.Entities.Cliente", "Clientes")
                        .WithOne("HistoriaClinicas")
                        .HasForeignKey("PS.Template.Domain.Entities.HistoriaClinica", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("HistoriaClinicas");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Partido", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Plan", b =>
                {
                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
