using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class HistoriaClinica
    {
        public int HistoriaClinicaId { get; set; }
        public int ClienteId { get; set; }
        public int TurnoId { get; set; }
        public string Diagnostico { get; set; }
        public string Imagen { get; set; }
        public Cliente Clientes { get; set; }
    }
}