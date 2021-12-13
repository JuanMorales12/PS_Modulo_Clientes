using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.API.Controllers
{
    [Route("api/HistoriaClinica")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {
        private readonly IHistoriaClinicaService _service;
        public HistoriaClinicaController(IHistoriaClinicaService service)
        {
            _service = service;   
        }

        [HttpPost]
        public HistoriaClinicaDTO Post(HistoriaClinicaDTO historiaClinica)
        {
            return _service.CreateHistoriaClinica(historiaClinica);
        }

        [HttpGet]
        public IList<HistoriaClinicaDTO> GetHistoriasClinica()
        {
            return _service.GetAll();
        }

        [HttpGet("{historiaClinicaId:int}")]
        public HistoriaClinicaDTO GetHistoriaClinicaById(int historiaClinicaId)
        {
            return _service.GetById(historiaClinicaId);
        }
    }
}
