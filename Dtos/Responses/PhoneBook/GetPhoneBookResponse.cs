using Assessment.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Dtos.Responses.PhoneBook
{
    public class GetPhoneBookResponse : ResponseMessage
    {
        public IEnumerable<PhoneBookDto> PhoneBooks { get; }
        public GetPhoneBookResponse(IEnumerable<PhoneBookDto> phoneBooks, bool success = false, string message = null) : base(success, message)
        {
            PhoneBooks = phoneBooks;
        }
    }
}