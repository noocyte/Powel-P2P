using MediatR;
using MediatrAPI.Repositories;
using MediatrAPI.Requests;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class PostValueRequestHandler : IRequestHandler<PostValueRequest, IEnumerable<string>>
    {
        public PostValueRequestHandler(IValueRepository repository)
        {
            Repository = repository;
        }

        public IValueRepository Repository { get; }

        public async Task<IEnumerable<string>> Handle(PostValueRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(5, cancellationToken);
            return Repository.StoreValue(request.Value);
        }
    }
}
