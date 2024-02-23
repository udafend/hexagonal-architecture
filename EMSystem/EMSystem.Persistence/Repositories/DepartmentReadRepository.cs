using EMSystem.Domain.Entities;
using EMSystem.Domain.Ports.Outgoing.Abtractions;
using EMSystem.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Persistence.Repositories
{
	public class DepartmentReadRepository : IDepartmentReadRepository
    {
        private readonly EMSystemDbContext _eMSystemDbContext;
        public DepartmentReadRepository(EMSystemDbContext eMSystemDbContext)
        {
            _eMSystemDbContext = eMSystemDbContext;
        }

        public Department GetById(Guid id)
        {
            return _eMSystemDbContext.Departments.Where(d => d.Id.Equals(id)).FirstOrDefault();
        }
        public async Task<List<Department>> GetDepartments(int minEmployees)
        {
            return await _eMSystemDbContext.Departments.Where(d => d.Employees.Count >= minEmployees).Include(e=>e.Employees).ToListAsync();
        }
    }
}

