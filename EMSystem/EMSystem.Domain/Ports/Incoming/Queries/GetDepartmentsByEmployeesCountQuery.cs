using EMSystem.Domain.Ports.Incoming.Queries.Responses;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Queries
{
	public record GetDepartmentsByEmployeesCountQuery(int minEmployees) : IRequest<GetDepartmentsByEmployeesCountResponse>;
	
}

