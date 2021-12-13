using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasKey(pla => pla.PlanId);
            builder.Property(pla => pla.PlanId)
                    .ValueGeneratedOnAdd();

            builder.Property(pla => pla.NombrePlan)
                   .IsRequired(true)
                   .HasMaxLength(20);

            builder.Property(pla => pla.Descripcion)
                   .IsRequired(true)
                   .HasMaxLength(255);

            builder.Property(pla => pla.Descuento)
                   .IsRequired(true)
                   .HasMaxLength(10);

            builder.Property(pla => pla.PrecioPlan)
                   .IsRequired(true)
                   .HasMaxLength(10);

            builder.HasData(
                new Plan { PlanId = 1, NombrePlan = "Basico", Descripcion = "Descuento del 15% en especialidades comunes", Descuento = 15, PrecioPlan = 1500},
                new Plan { PlanId = 2, NombrePlan = "Premium", Descripcion = "Descuento del 35% en todo tipo de especialidades" , Descuento = 35, PrecioPlan = 3500 }
                            );
        }
    }
}
