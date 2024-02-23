using EMSystem.Domain.Entities;

namespace EMSystem.Domain.Ports.Incoming.Commands.Responses
{
	public class CreateDepartmentResponse
	{
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public decimal Budget { get; private set; }
        public bool IsOwnsPrinter { get; private set; }

        public CreateDepartmentResponse(Guid id, string name, string location, decimal budget, bool isownsPrinter)
        {
            Id = id;
            Name = name;
            Location = location;
            Budget = budget;
            IsOwnsPrinter = isownsPrinter;
        }
    }
}

