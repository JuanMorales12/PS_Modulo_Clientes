using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;

namespace PS.Template.AccessData.Queries
{
    public class ClienteQuery : IClienteQuery
    {
        private readonly TemplateDbContext _context;
        public ClienteQuery(TemplateDbContext context)
        {
            _context = context;
        }
        public IList<ClienteDTO> GetAll()
        {
            var clientes = _context.Cliente
                 .Select(c => new ClienteDTO
                 {
                     ClienteId = c.ClienteId,
                     TipoId = c.TipoId,
                     PlanId = c.PlanId,
                     PartidoId = c.PartidoId,
                     Nombre = c.Nombre,
                     Apellido = c.Apellido,
                     DNI = c.DNI,
                     NumeroCelular = c.NumeroCelular,
                     Mail = c.Mail,
                     Contraseña = c.Contraseña,
                 })
                 .ToList();        
            return clientes;
        }
        public Cliente GetById(int clienteId)
        {
            var cliente = _context.Cliente
                .Where(c => c.ClienteId == clienteId)
                .Select(c => c).FirstOrDefault();
            return cliente;
        }
    }
}
