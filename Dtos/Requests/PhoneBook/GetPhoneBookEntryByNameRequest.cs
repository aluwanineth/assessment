﻿using Assessment.Core.Dtos.Responses.PhoneBook;
using Assessment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Dtos.Requests.PhoneBook
{
    public class GetPhoneBookEntryByNameRequest : IRequest<GetPhoneBookResponse>
    {
        public int PhoneBookId { get; set; }
        public string Name { get; set; }

        public GetPhoneBookEntryByNameRequest(int phoneBookId, string name)
        {
            PhoneBookId = phoneBookId;
            Name = name;
        }
    }
}
