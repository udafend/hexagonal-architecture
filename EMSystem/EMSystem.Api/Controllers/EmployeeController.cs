using EMSystem.Domain.Ports.Incoming.Commands;
using EMSystem.Domain.Ports.Incoming.Commands.Requests;
using EMSystem.Domain.Ports.Incoming.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Create a department
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("Create")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(typeof(CreateEmployeeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateEmployeeRequest model)
        {
            var command = new CreateEmployeeCommand(model);
            var result = await _mediator.Send(command);
            if (result is null)
            {
                return BadRequest("Failed");

            }
            return Ok(result);
        }
    }
}

