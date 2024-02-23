using EMSystem.Domain.Entities;

namespace EMSystem.Domain.Ports.Outgoing.Abtractions
{
	public interface IDepartmentCommandRepository
	{
        Task AddAsync(Department department);
        Task SaveChangesAsync();
        void Update(Department department);
    }
}

