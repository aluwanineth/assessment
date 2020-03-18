using Assessment.Core.Dtos.Response.GatewayResponses.Repositories;
using Assessment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Interfaces.Gateways.Repositories
{
    public interface IEntryRepository : IRepository<Entities.Entry>
    {
        Task<Response> Create(string name, string phoneNumber, int phoneBookId);
    }
}
