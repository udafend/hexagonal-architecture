using EMSystem.Domain.Ports.Incoming.Queries.Responses;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Queries.Handlers
{
	public sealed class GetDepartmentsByEmployeesCountQueryHandler : IRequestHandler<GetDepartmentsByEmployeesCountQuery, GetDepartmentsByEmployeesCountResponse>
	{
        private readonly IDepartmentReadRepository _departmentReadRepository;
        public GetDepartmentsByEmployeesCountQueryHandler(IDepartmentReadRepository departmentReadRepository)
        {
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<GetDepartmentsByEmployeesCountResponse> Handle(GetDepartmentsByEmployeesCountQuery request, CancellationToken cancellationToken)
        {
            GetDepartmentsByEmployeesCountResponse response = new GetDepartmentsByEmployeesCountResponse();
            var result = await _departmentReadRepository.GetDepartments(request.minEmployees);
            response.Departments = result;
            return response;
        }
    }
}

