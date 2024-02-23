using System.ComponentModel.DataAnnotations;

namespace EMSystem.Domain.Entities
{
	public class Employee : BaseEntity
	{
        public string Name { get; private set; }
        [Range(0, double.MaxValue)]
        public decimal Salary { get; private set; }
        public DateTime? DateOfBirth { get; private set; }

        public Guid DepartmentId { get; private set; }
        public Department Department { get; set; }

        public Employee( string name, decimal salary, DateTime? dateOfBirth, Guid departmentId)
        {
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            DepartmentId = departmentId;
            
        }
    }
}

