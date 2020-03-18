using Assessment.Core.Dtos.Requests.PhoneBook;
using Assessment.Core.Dtos.Response;
using Assessment.Core.Dtos.Responses.PhoneBook;
using Assessment.Core.Interfaces;
using Assessment.Core.Interfaces.Gateways.Repositories;
using Assessment.Core.Interfaces.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Services.PhoneBook
{
    public sealed class PhoneBookService : ICreatePhoneBook, IGetPhoneBooks, IGetPhoneBookEntryByName
    {
        private readonly IPhoneBookRepository _phoneBookRepository;

        public PhoneBookService(IPhoneBookRepository phoneBookRepository)
        {
            _phoneBookRepository = phoneBookRepository;
        }
        public async Task<bool> Handle(CreatePhoneBookRequest message, IOutputPort<ServiceResponse> outputPort)
        {
            var response = await _phoneBookRepository.Create(message.Name);
            outputPort.Handle(response.Success ? new ServiceResponse(response.Id, true) : new ServiceResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }

        public async Task<bool> Handle(GetPhoneBookRequest message, IOutputPort<GetPhoneBookResponse> outputPort)
        {
            var response = await _phoneBookRepository.GetPhoneBooks();
            outputPort.Handle(new GetPhoneBookResponse(response, true, null));

            return true;
        }

        public async Task<bool> Handle(GetPhoneBookEntryByNameRequest message, IOutputPort<GetPhoneBookResponse> outputPort)
        {
            var response = await _phoneBookRepository.GetPhoneBookEntryByName(message.PhoneBookId,message.Name);
            outputPort.Handle(new GetPhoneBookResponse(response, true, null));

            return true;
        }
    }
}
