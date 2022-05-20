using FinalAssessment_GovindMishra.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalAssessment_GovindMishra.Infrastructure
{
    public class InfoDbContext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
        public DbSet<Department> departments { get; set; }

        public InfoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        //binding between department and employee
        {
            new DepartmentMapper(modelbuilder.Entity<Department>());
            new EmployeeMapper(modelbuilder.Entity<Employee>());
        }

    }
}