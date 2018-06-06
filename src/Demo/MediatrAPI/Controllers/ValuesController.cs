using MediatR;
using MediatrAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatrAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var request = new GetValuesRequest();
            var response = await _mediator.Send(request);
            return new ActionResult<IEnumerable<string>>(response);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            var request = new GetValueRequest(id);
            var response = await _mediator.Send(request);
            return new ActionResult<string>(response);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<IEnumerable<string>>> Post([FromBody] string value)
        {
            var request = new PostValueRequest(value);
            var response = await _mediator.Send(request);
            return new ActionResult<IEnumerable<string>>(response);
        }
    }
}
