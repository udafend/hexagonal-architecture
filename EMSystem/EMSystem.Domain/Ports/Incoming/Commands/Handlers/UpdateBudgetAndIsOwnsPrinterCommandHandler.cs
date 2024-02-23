using EMSystem.Domain.Ports.Outgoing.Abtractions;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Commands.Handlers
{
	public sealed class UpdateBudgetAndIsOwnsPrinterCommandHandler:IRequestHandler<UpdateBudgetAndIsOwnsPrinterCommand,bool>
	{
        private readonly IDepartmentCommandRepository _departmentCommandRepository;
        private readonly IDepartmentReadRepository _departmentReadRepository;


        public UpdateBudgetAndIsOwnsPrinterCommandHandler(IDepartmentCommandRepository departmentCommandRepository, IDepartmentReadRepository departmentReadRepository)
        {
            _departmentCommandRepository = departmentCommandRepository;
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<bool> Handle(UpdateBudgetAndIsOwnsPrinterCommand request, CancellationToken cancellationToken)
        {
            var department = _departmentReadRepository.GetById(request.updateBudgetAndIsOwnsPrinterRequest.Id);
            department.SetBudgetAndIsOwnsPrinter(request.updateBudgetAndIsOwnsPrinterRequest.Budget, request.updateBudgetAndIsOwnsPrinterRequest.IsOwnsPrinter);
            _departmentCommandRepository.Update(department);
            await _departmentCommandRepository.SaveChangesAsync();
            return true;
        }
    }
}

