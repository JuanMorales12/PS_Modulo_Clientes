using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string NombrePlan { get; set; }
        public string Descripcion { get; set; }
        public double Descuento { get; set; }
        public double PrecioPlan { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
    }
}
