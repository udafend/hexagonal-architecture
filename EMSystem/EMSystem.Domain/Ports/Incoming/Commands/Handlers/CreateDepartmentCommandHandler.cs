using EMSystem.Domain.Entities;
using EMSystem.Domain.Ports.Incoming.Commands.Responses;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Commands.Handlers
{
	public sealed class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, CreateDepartmentResponse>
	{
        private readonly IDepartmentCommandRepository _departmentCommandRepository;
        

        public CreateDepartmentCommandHandler(IDepartmentCommandRepository departmentCommandRepository)
        {
            _departmentCommandRepository = departmentCommandRepository;
           
        }


        public async Task<CreateDepartmentResponse> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department(request.createDepartmentRequest.Name, request.createDepartmentRequest.Location, request.createDepartmentRequest.Budget, request.createDepartmentRequest.IsOwnsPrinter);
            await _departmentCommandRepository.AddAsync(department);
            await _departmentCommandRepository.SaveChangesAsync();
            var result = new CreateDepartmentResponse(department.Id, department.Name, department.Location, department.Budget,department.IsOwnsPrinter);
            
            return result;
        }
    }
}

