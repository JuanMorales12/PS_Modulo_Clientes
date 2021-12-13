using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericsRepository _repository;
        private readonly IClienteQuery _query;

        public ClienteService(IGenericsRepository repository, IClienteQuery query)
        {
            _repository = repository;
            _query = query;
        }
        public ClienteDTO CreateCliente(ClienteDTO cliente)
        {
            var entity = new Cliente
            {
                TipoId = cliente.TipoId,
                PlanId = cliente.PlanId,
                PartidoId = cliente.PartidoId,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                DNI = cliente.DNI,
                NumeroCelular = cliente.NumeroCelular,
                Mail = cliente.Mail,
                Contraseña = cliente.Contraseña
            };
            _repository.Add<Cliente>(entity);
            return cliente;
        }
        public IList<ClienteDTO> GetAll()
        {
            return _query.GetAll();
        }
        public ClienteDTO GetById(int clienteId)
        {
            var cliente = _query.GetById(clienteId);
            var ClienteDTO = new ClienteDTO
            {
                ClienteId = cliente.ClienteId,
                TipoId = cliente.TipoId,
                PlanId = cliente.PlanId,
                PartidoId = cliente.PartidoId,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                DNI = cliente.DNI,
                NumeroCelular = cliente.NumeroCelular,
                Mail = cliente.Mail,
                Contraseña = cliente.Contraseña
            };
            return ClienteDTO; 
        }

    }
}
