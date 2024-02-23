namespace EMSystem.Domain.Ports.Incoming.Commands.Requests
{
	public class CreateEmployeeRequest
	{
        public string Name { get;  set; }
        public decimal Salary { get;  set; }
        public DateTime? DateOfBirth { get;  set; }
        public Guid DepartmentId { get;  set; }
        
    }
}

