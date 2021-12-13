using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.Entities;
using PS.Template.Domain.EntitiesConfiguration;

namespace PS.Template.AccessData
{
    public class TemplateDbContext : DbContext
    {

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Partido> Partido { get; set; }
        public DbSet<Plan> Plan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new HistoriaClinicaConfiguration());
            modelBuilder.ApplyConfiguration(new PartidoConfiguration());
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
        }

    }
}
