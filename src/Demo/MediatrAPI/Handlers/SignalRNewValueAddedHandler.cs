using MediatR;
using MediatrAPI.Notifications;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class SignalRNewValueAddedHandler : INotificationHandler<NewValueAddedNotification>
    {
        private readonly IHubContext<ValueHub> _hubcontext;

        public SignalRNewValueAddedHandler(IHubContext<ValueHub> hubcontext)
        {
            _hubcontext = hubcontext;
        }
        public async Task Handle(NewValueAddedNotification notification, CancellationToken cancellationToken)
        {
            await _hubcontext.Clients.All.SendAsync("ReceiveValue", notification.NewValue);
        }
    }
}
