using EMSystem.Domain.Ports.Incoming.Commands;
using EMSystem.Domain.Ports.Incoming.Commands.Requests;
using EMSystem.Domain.Ports.Incoming.Commands.Responses;
using EMSystem.Domain.Ports.Incoming.Queries;
using EMSystem.Domain.Ports.Incoming.Queries.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
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
        [ProducesResponseType(typeof(CreateDepartmentResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateDepartmentRequest model)
        {
            var command = new CreateDepartmentCommand(model);
            var result = await _mediator.Send(command);
            if (result is null)
            {
                return BadRequest("Failed");
                
            }
            return Ok(result);
        }
        /// <summary>
        /// Create a department
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put([FromBody] UpdateBudgetAndIsOwnsPrinterRequest model)
        {
            var command = new UpdateBudgetAndIsOwnsPrinterCommand(model);
            var result = await _mediator.Send(command);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest("Failed");
           
        }

        /// <summary>
        /// Create a department
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet("{minEmployees}/GetDepartments")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(typeof(GetDepartmentsByEmployeesCountResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAll(int minEmployees)
        {
            var query = new GetDepartmentsByEmployeesCountQuery(minEmployees);
            var result = await _mediator.Send(query);
            if (result is null)
            {
                return BadRequest("Failed");

            }
            return Ok(result);
        }
    }
}

