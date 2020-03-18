using Assessment.Core.Dtos.Response.GatewayResponses.Repositories;
using Assessment.Core.Dtos.Responses.PhoneBook;
using Assessment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Interfaces.Gateways.Repositories
{
    public interface IPhoneBookRepository : IRepository<Entities.PhoneBook>
    {
        Task<Response> Create(string name);
        Task<IEnumerable<PhoneBookDto>> GetPhoneBooks();
        Task<IEnumerable<PhoneBookDto>> GetPhoneBookEntryByName(int phoneId, string name);
    }
}
