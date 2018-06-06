using MediatR;
using MediatrAPI.Notifications;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class SearchNewValueAddedHandler : INotificationHandler<NewValueAddedNotification>
    {
        public Task Handle(NewValueAddedNotification notification, CancellationToken cancellationToken)
        {
            // post value to Azure Search
            return Task.FromResult(0);
        }
    }
}
