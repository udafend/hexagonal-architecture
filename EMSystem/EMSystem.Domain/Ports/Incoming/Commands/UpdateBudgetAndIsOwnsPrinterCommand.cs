using EMSystem.Domain.Ports.Incoming.Commands.Requests;
using MediatR;

namespace EMSystem.Domain.Ports.Incoming.Commands
{
	public record UpdateBudgetAndIsOwnsPrinterCommand(UpdateBudgetAndIsOwnsPrinterRequest updateBudgetAndIsOwnsPrinterRequest): IRequest<bool>;
	
}

