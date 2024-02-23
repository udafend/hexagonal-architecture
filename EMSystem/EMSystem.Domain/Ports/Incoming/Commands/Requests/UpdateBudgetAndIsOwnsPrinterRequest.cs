using System;
namespace EMSystem.Domain.Ports.Incoming.Commands.Requests
{
	public class UpdateBudgetAndIsOwnsPrinterRequest
	{
        public Guid Id { get; set; }
        public decimal Budget { get;  set; }
        public bool IsOwnsPrinter { get;  set; }
    }
}

