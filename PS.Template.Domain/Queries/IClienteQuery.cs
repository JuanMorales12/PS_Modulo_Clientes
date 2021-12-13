using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Queries
{
    public interface IClienteQuery
    {
        IList<ClienteDTO>GetAll();
        Cliente GetById(int clienteId);

    }
}
