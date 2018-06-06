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
        private readonly IValueRepository _repository;
        private readonly IMediator _mediator;

        public PostValueRequestHandler(IValueRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<IEnumerable<string>> Handle(PostValueRequest request, CancellationToken cancellationToken)
        {
            var response = _repository.StoreValue(request.Value);
            await _mediator.Publish(new NewValueAddedNotification(request.Value));
            return response;
        }
    }
}
