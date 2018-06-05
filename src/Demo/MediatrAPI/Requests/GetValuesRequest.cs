using MediatR;
using System.Collections.Generic;

namespace MediatrAPI.Requests
{
    public class GetValuesRequest : IRequest<IEnumerable<string>>
    {
    }
}
