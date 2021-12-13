using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int TipoId { get; set; }
        public int PlanId { get; set; }
        public int PartidoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Imagen { get; set; }
        public int DNI { get; set; }
        public long NumeroCelular { get; set; }
        public string Mail { get; set; }
        public int Contraseña { get; set; }
        public Plan Planes { get; set; }
        public Partido Partidos { get; set; }
        public HistoriaClinica HistoriaClinicas { get; set; }
    }
}
