using Assessment.Core.Dtos.Response;
using Assessment.Core.Interfaces;

namespace Assessment.Core.Dtos.Requests.Entry
{
    public class CreateEntryRequest : IRequest<ServiceResponse>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneBookId { get; set; }
        public CreateEntryRequest(string name, string phoneNumber, int phoneBookId)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PhoneBookId = phoneBookId;
        }
    }
}