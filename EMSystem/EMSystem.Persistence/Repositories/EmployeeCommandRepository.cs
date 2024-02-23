using EMSystem.Domain.Entities;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using EMSystem.Persistence.Contexts;

namespace EMSystem.Persistence.Repositories
{
	public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public readonly EMSystemDbContext _eMSystemDbContext;
        public EmployeeCommandRepository(EMSystemDbContext eMSystemDbContext)
        {
            _eMSystemDbContext = eMSystemDbContext;
        }

        public async Task AddAsync(Employee employee)
        {
            await _eMSystemDbContext.AddAsync(employee);
        }

        public async Task SaveChangesAsync()
        {
            await _eMSystemDbContext.SaveChangesAsync();
        }
    }
}

