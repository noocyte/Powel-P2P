using MediatR;
using System.Collections.Generic;

namespace MediatrAPI.Requests
{
    public class PostValueRequest : IRequest<IEnumerable<string>>
    {
        public PostValueRequest(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
