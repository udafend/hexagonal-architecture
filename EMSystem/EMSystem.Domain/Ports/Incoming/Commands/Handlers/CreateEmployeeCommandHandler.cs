using EMSystem.Domain.Entities;
using EMSystem.Domain.Ports.Incoming.Commands.Responses;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Commands.Handlers
{
	public sealed class CreateEmployeeCommandHandler:IRequestHandler<CreateEmployeeCommand, CreateEmployeeResponse>
	{
        private readonly IEmployeeCommandRepository _employeeCommandRepository;
        public CreateEmployeeCommandHandler(IEmployeeCommandRepository employeeCommandRepository)
		{
            _employeeCommandRepository = employeeCommandRepository;
		}

       
        public async Task<CreateEmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(request.CreateEmployeeRequest.Name, request.CreateEmployeeRequest.Salary, request.CreateEmployeeRequest.DateOfBirth, request.CreateEmployeeRequest.DepartmentId);
            await _employeeCommandRepository.AddAsync(employee);
            await _employeeCommandRepository.SaveChangesAsync();
            var result = new CreateEmployeeResponse(employee.Id, employee.Name, employee.Salary, employee.DateOfBirth, employee.DepartmentId);
            return result;
        }
    }
}

