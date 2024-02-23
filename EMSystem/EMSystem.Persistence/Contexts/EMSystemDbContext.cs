using EMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMSystem.Persistence.Contexts
{
	public class EMSystemDbContext : DbContext
	{
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public EMSystemDbContext(DbContextOptions<EMSystemDbContext> options): base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired();
                  
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                    
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

