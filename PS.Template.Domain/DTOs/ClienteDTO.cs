using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTOs
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }
        public int TipoId { get; set; }
        public int PlanId { get; set; }
        public int PartidoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public long NumeroCelular { get; set; }
        public string Mail { get; set; }
        public int Contraseña { get; set; }
    }
}
