using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public interface IClienteService
    {
        ClienteDTO CreateCliente(ClienteDTO cliente);
        IList<ClienteDTO> GetAll();
        ClienteDTO GetById(int clienteId);
    }
}
