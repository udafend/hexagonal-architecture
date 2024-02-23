using EMSystem.Domain.Ports.Incoming.Commands.Requests;
using EMSystem.Domain.Ports.Incoming.Commands.Responses;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Commands
{
	public record CreateDepartmentCommand(CreateDepartmentRequest createDepartmentRequest) :IRequest<CreateDepartmentResponse>;
	
}

