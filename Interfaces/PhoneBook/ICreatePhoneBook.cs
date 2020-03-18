using Assessment.Core.Dtos.Requests.PhoneBook;
using Assessment.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Interfaces.PhoneBook
{
    public interface ICreatePhoneBook : IRequestHandler<CreatePhoneBookRequest, ServiceResponse>
    {
    }
}
