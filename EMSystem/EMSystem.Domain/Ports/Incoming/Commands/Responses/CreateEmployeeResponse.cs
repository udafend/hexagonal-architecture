namespace EMSystem.Domain.Ports.Incoming.Commands.Responses
{
	public class CreateEmployeeResponse
	{
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime? DateOfBirth { get; private set; }
        public Guid DepartmentId { get; private set; }
       
        public CreateEmployeeResponse(Guid id, string name, decimal salary, DateTime? dateOfBirth, Guid departmentId)
        {
            Id = id;
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            DepartmentId = departmentId;
        }
    }
}

