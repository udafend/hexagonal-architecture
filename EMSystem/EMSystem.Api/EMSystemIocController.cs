using EMSystem.Domain.Ports.Outgoing.Abtractions;
using EMSystem.Persistence.Contexts;
using EMSystem.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Api
{
	public static class EMSystemIocController
	{
        public static void Install(IServiceCollection services, ConfigurationManager configurationManager, string defaultDbConnectString)
        {

            services.AddDbContext<EMSystemDbContext>(options => options.UseSqlite(defaultDbConnectString));
            services.AddScoped<IDepartmentCommandRepository, DepartmentCommandRepository>();
            services.AddScoped<IDepartmentReadRepository, DepartmentReadRepository>();
            services.AddScoped<IEmployeeCommandRepository, EmployeeCommandRepository>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
              services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            }
           
        }
    }
}

