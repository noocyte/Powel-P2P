using MediatR;
using MediatrAPI.Repositories;
using MediatrAPI.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class GetValueRequestHandler : IRequestHandler<GetValueRequest, string>
    {
        public GetValueRequestHandler(IValueRepository repository)
        {
            Repository = repository;
        }

        private IValueRepository Repository { get; }

        public async Task<string> Handle(GetValueRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(5, cancellationToken);
            return Repository.GetValue(request.Id);
        }
    }
}
