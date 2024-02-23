using System;
using EMSystem.Domain.Entities;

namespace EMSystem.Domain.Ports.Outgoing.Abtractions
{
	public interface IDepartmentReadRepository
	{
		Department GetById(Guid id);
		Task<List<Department>> GetDepartments(int minEmployees);

    }
}

