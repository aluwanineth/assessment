using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Dtos.Response
{
    public class ServiceResponse : ResponseMessage
    {
        public string Id { get; }

        public IEnumerable<string> Errors { get; }

        public ServiceResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public ServiceResponse(string id, bool success = false, string message = null) : base(success, message)
        {
            Id = id;
        }
    }
}
