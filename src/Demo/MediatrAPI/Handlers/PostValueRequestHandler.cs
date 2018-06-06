using MediatR;
using MediatrAPI.Notifications;
using MediatrAPI.Repositories;
using MediatrAPI.Requests;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class PostValueRequestHandler : IRequestHandler<PostValueRequest, IEnumerable<string>>
    {
        public PostValueRequestHandler(IValueRepository repository, IMediator mediator)
        {
            Repository = repository;
            Mediator = mediator;
        }

        private IValueRepository Repository { get; }
        private IMediator Mediator { get; }

        public async Task<IEnumerable<string>> Handle(PostValueRequest request, CancellationToken cancellationToken)
        {
            var response = Repository.StoreValue(request.Value);
            await Mediator.Publish(new NewValueAddedNotification(request.Value));
            return response;
        }
    }
}
