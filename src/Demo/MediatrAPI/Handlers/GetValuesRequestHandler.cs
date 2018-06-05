using MediatR;
using MediatrAPI.Repositories;
using MediatrAPI.Requests;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrAPI.Handlers
{
    public class GetValuesRequestHandler : IRequestHandler<GetValuesRequest, IEnumerable<string>>
    {
        public GetValuesRequestHandler(IValueRepository repository)
        {
            Repository = repository;
        }

        private IValueRepository Repository { get; }

        public async Task<IEnumerable<string>> Handle(GetValuesRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(5, cancellationToken);
            return Repository.GetValues();
        }
    }
}
