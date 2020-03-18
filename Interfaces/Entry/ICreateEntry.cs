using Assessment.Core.Dtos.Requests.Entry;
using Assessment.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Interfaces.Entry
{
    public interface ICreateEntry : IRequestHandler<CreateEntryRequest, ServiceResponse>
    {
    }
}
