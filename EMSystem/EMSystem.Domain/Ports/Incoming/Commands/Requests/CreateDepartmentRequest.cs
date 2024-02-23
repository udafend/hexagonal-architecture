namespace EMSystem.Domain.Ports.Incoming.Commands.Requests
{
	public class CreateDepartmentRequest
	{
        public string Name { get;  set; }
        public string Location { get;  set; }
        public decimal Budget { get;  set; }
        public bool IsOwnsPrinter { get;  set; }
    }
}

