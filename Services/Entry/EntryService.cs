using Assessment.Core.Dtos.Requests.Entry;
using Assessment.Core.Dtos.Response;
using Assessment.Core.Interfaces;
using Assessment.Core.Interfaces.Entry;
using Assessment.Core.Interfaces.Gateways.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Services.Entry
{
    public sealed class EntryService : ICreateEntry
    {
        private readonly IEntryRepository _entryRepository;

        public EntryService(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;
        }

        public async Task<bool> Handle(CreateEntryRequest message, IOutputPort<ServiceResponse> outputPort)
        {
            var response = await _entryRepository.Create(message.Name, message.PhoneNumber, message.PhoneBookId);
            outputPort.Handle(response.Success ? new ServiceResponse(response.Id, true) : new ServiceResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }
    }
}
