using System;
namespace EMSystem.Domain.Entities
{
	public class SpecialDepartment : Department
	{
		public override ICollection<Employee> Employees
		{
			get
			{
				return base.Employees.Where(e => e.Salary > 100).ToList();
			}
			set
			{
				base.Employees = value;
			}
		}
	}
}

