using Microsoft.EntityFrameworkCore;
using VP_Lab_14.Models;
namespace VP_Lab_14.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
