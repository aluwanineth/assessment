using Assessment.Core.Dtos.Requests.PhoneBook;
using Assessment.Core.Dtos.Responses.PhoneBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Interfaces.PhoneBook
{
    public interface IGetPhoneBooks : IRequestHandler<GetPhoneBookRequest, GetPhoneBookResponse>
    {
    }
}
