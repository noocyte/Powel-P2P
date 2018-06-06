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
        private readonly IValueRepository _repository;

        public GetValuesRequestHandler(IValueRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<string>> Handle(GetValuesRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(5, cancellationToken);
            return _repository.GetValues();
        }
    }
}
