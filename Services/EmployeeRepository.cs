using System.Collections.Generic;
using System.Linq;
using FinalAssessment_GovindMishra.Infrastructure;
using FinalAssessment_GovindMishra.Models;

namespace FinalAssessment_GovindMishra.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        InfoDbContext context;                                //Dependency Injection
        public EmployeeRepository(InfoDbContext _context)
        {
            context = _context;
        }
        public int CreateEmployee(Employee employee)
        {
            context.Add(employee); // Saves in local memory
            return context.SaveChanges(); // Finally save the record in backend
        }

        public int DeleteEmployee(int id)
        {
            var employeeToDelete = context.employee.Find(id);
            context.Remove(employeeToDelete);
            return context.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            return context.employee.Find(id);
        }

        public IEnumerable<Employee> GetAllEmployeeDetails()
        {
            return context.employee.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = context.employee.Find(employee.EmpID);
            employeeToUpdate.EmpName = employee.EmpName;
            employeeToUpdate.EmpAge = employee.EmpAge;
            employeeToUpdate.EmpEmail = employee.EmpEmail;
            context.Update(employeeToUpdate);
            return context.SaveChanges();
        }
    }
}