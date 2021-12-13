using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IHistoriaClinicaQuery _query;

        public HistoriaClinicaService(IGenericsRepository repository, IHistoriaClinicaQuery query)
        {
            _repository = repository;
            _query = query;

        }

        public HistoriaClinicaDTO CreateHistoriaClinica(HistoriaClinicaDTO historiaClinica)
        {

            var entity = new HistoriaClinica
            {
                HistoriaClinicaId = historiaClinica.HistoriaClinicaId,
                ClienteId = historiaClinica.ClienteId,
                TurnoId = historiaClinica.TurnoId,
                Diagnostico = historiaClinica.Diagnostico,
                Imagen = historiaClinica.Imagen,
            };

            _repository.Add<HistoriaClinica>(entity);

            return historiaClinica;
        }

        public IList<HistoriaClinicaDTO> GetAll()
        {
            return _query.GetAll();
        }
        public HistoriaClinicaDTO GetById(int historiaClinicaId)
        {
            var historiaclinica = _query.GetById(historiaClinicaId);
            var HistoriaClinicaDTO = new HistoriaClinicaDTO
            {
                HistoriaClinicaId = historiaclinica.HistoriaClinicaId,
                ClienteId = historiaclinica.ClienteId,
                TurnoId = historiaclinica.TurnoId,
                Diagnostico = historiaclinica.Diagnostico,
                Imagen = historiaclinica.Imagen
            };
            return HistoriaClinicaDTO;
        }
    }
}
