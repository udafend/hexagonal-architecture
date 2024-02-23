using EMSystem.Domain.Entities;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using EMSystem.Persistence.Contexts;

namespace EMSystem.Persistence.Repositories
{
	public class DepartmentCommandRepository : IDepartmentCommandRepository
    {
        private readonly EMSystemDbContext _eMSystemDbContext;
        public DepartmentCommandRepository(EMSystemDbContext eMSystemDbContext)
		{
            _eMSystemDbContext = eMSystemDbContext;
		}

        public async Task AddAsync(Department department)
        {
            await _eMSystemDbContext.AddAsync(department);
        }

        public async Task SaveChangesAsync()
        {
            await _eMSystemDbContext.SaveChangesAsync();
        }

        public void Update(Department department)
        {
             _eMSystemDbContext.Update(department);
        }
    }
}

