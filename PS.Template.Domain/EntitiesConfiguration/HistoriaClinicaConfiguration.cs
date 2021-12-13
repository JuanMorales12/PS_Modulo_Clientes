using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class HistoriaClinicaConfiguration : IEntityTypeConfiguration<HistoriaClinica>
    {
        public void Configure(EntityTypeBuilder<HistoriaClinica> builder)
        {
            builder.HasKey(hc => hc.HistoriaClinicaId);
            builder.Property(hc => hc.HistoriaClinicaId)
                    .ValueGeneratedOnAdd();

            builder.Property(hc => hc.TurnoId)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.Property(hc => hc.Diagnostico)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.Property(hc => hc.Imagen)
                   .IsRequired(true)
                   .HasMaxLength(255);
       
        }
    }
}
