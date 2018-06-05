using MediatR;

namespace MediatrAPI.Requests
{
    public class GetValueRequest : IRequest<string>
    {
        public GetValueRequest(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
