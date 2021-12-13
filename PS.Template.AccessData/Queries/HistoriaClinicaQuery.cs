using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Template.AccessData.Queries
{
    public class HistoriaClinicaQuery : IHistoriaClinicaQuery
    {
        private readonly TemplateDbContext _context;
        public HistoriaClinicaQuery(TemplateDbContext context)
        {
            _context = context;
        }

        public IList<HistoriaClinicaDTO> GetAll()
        {
            var HistoriaClinica = _context.HistoriaClinica
               .Select(c => new HistoriaClinicaDTO
               {
                   HistoriaClinicaId = c.HistoriaClinicaId,
                   ClienteId = c.ClienteId,
                   TurnoId = c.TurnoId,
                   Diagnostico = c.Diagnostico,
                   Imagen = c.Imagen,
               })
               .ToList();
            return HistoriaClinica;
        }
        public HistoriaClinica GetById(int historiaId)
        {
            var HistoriaClinica = _context.HistoriaClinica
           .Where(c => c.HistoriaClinicaId == historiaId)
           .Select(c => c).FirstOrDefault();

            return HistoriaClinica;
        }
    }

}
