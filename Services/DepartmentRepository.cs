using System.Collections.Generic;
using System.Linq;
using FinalAssessment_GovindMishra.Infrastructure;
using FinalAssessment_GovindMishra.Models;

namespace FinalAssessment_GovindMishra.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //Implementing Di(Dependency Injection)
        InfoDbContext context;

        public DepartmentRepository(InfoDbContext _context)
        {
            context = _context;
        }
        public int CreateDepartment(Department department)
        {
            context.Add(department); // Saves in local memory
            return context.SaveChanges(); // Finally save the record in backend
        }

        public int DeleteDepartment(int id)
        {
            var data = context.departments.FirstOrDefault(t => t.DeptId == id);
            context.Remove(data);
            return context.SaveChanges();
        }
    }
}