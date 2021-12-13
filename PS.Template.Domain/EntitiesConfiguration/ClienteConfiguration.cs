using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(cli => cli.ClienteId);
            builder.Property(cli => cli.ClienteId)
                   .ValueGeneratedOnAdd();

            builder.Property(cli => cli.TipoId)
                   .IsRequired(true)
                   .HasMaxLength(2);

            builder.Property(cli => cli.PlanId)
                   .IsRequired(true);

            builder.HasOne(Pla => Pla.Planes).WithMany(cli => cli.Clientes);

            builder.Property(cli => cli.PartidoId)
                   .IsRequired(true);

            builder.HasOne(Par => Par.Partidos).WithMany(cli => cli.Clientes);

            builder.Property(cli => cli.Nombre)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(cli => cli.Apellido)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(cli => cli.DNI)
                   .IsRequired(true)
                   .HasMaxLength(8);

            builder.Property(cli => cli.NumeroCelular)
                   .IsRequired(true)
                   .HasMaxLength(20);

            builder.Property(cli => cli.Mail)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(cli => cli.Contraseña)
                   .IsRequired(true)
                   .HasMaxLength(10);
        }
    }
}
