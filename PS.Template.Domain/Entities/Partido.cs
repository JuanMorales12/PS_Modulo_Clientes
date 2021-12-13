using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class Partido
    {
        public int PartidoId { get; set; }
        public string Nombre { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
    }
}
