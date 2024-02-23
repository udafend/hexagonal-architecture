using EMSystem.Domain.Entities;

namespace EMSystem.Domain.Ports.Outgoing.Abtractions
{
	public interface IEmployeeCommandRepository
	{
		Task AddAsync(Employee employee);
        Task SaveChangesAsync();
    }
}

