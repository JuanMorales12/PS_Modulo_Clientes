using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.DTOs
{
    public class HistoriaClinicaDTO
    {
        public int HistoriaClinicaId { get; set; }
        public int ClienteId { get; set; }
        public int TurnoId { get; set; }
        public string Diagnostico { get; set; }
        public string Imagen { get; set; }
    }
}
