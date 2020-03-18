using Assessment.Core.Dtos.Response;
using Assessment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Dtos.Requests.PhoneBook
{
    public class CreatePhoneBookRequest : IRequest<ServiceResponse>
    {
        public string Name { get; set; }
       
        public CreatePhoneBookRequest(string name)
        {
            Name = name;
        }
    }
}