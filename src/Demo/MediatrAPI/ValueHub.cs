using MediatR;
using MediatrAPI.Requests;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MediatrAPI
{
    public class ValueHub : Hub
    {
        private readonly IMediator _mediator;

        public ValueHub(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task SendValue(string value)
        {
            await _mediator.Send(new PostValueRequest(value));
        }
    }
}
