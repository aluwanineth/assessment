﻿using Assessment.Core.Shared;
using System;

namespace Assessment.Core.Entities
{
    public class Entry : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneBookId { get; set; }
        public PhoneBook PhoneBook { get; set; }

        internal Entry() { }
        internal Entry(string name, string phoneNumber, int phoneBookId)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PhoneBookId = phoneBookId;
        }
    }
}

