using System.ComponentModel.DataAnnotations;

namespace EMSystem.Domain.Entities
{
	public class Department : BaseEntity
	{
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; private set; }
        public string Location { get; private set; }
        [Range(0, double.MaxValue)]
        public decimal Budget { get; private set; }
        public bool IsOwnsPrinter { get; private set; }

        public Department()
		{
            Employees = new HashSet<Employee>();
        }

        public Department(string name, string location, decimal budget, bool isownsPrinter)
        {
            Name = name;
            Location = location;
            Budget = budget;
            IsOwnsPrinter = isownsPrinter;
        }

        public virtual ICollection<Employee> Employees { get; set; }

        public void SetBudgetAndIsOwnsPrinter(decimal budget,bool isownsPrinter)
        {
            Budget = budget;
            IsOwnsPrinter = isownsPrinter;
        }
    }
}

