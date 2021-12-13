using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class PartidoConfiguration : IEntityTypeConfiguration<Partido>
    {
        public void Configure(EntityTypeBuilder<Partido> builder)
        {
            builder.HasKey(par => par.PartidoId);
            builder.Property(par => par.PartidoId)
                   .ValueGeneratedOnAdd();

            builder.Property(par => par.Nombre)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.HasData(
                new Partido { PartidoId = 1, Nombre = "Berazategui" },
                new Partido { PartidoId = 2, Nombre = "Florencio Varela" },
                new Partido { PartidoId = 3, Nombre = "Quilmes" }
                            );
        } 
    }
}
