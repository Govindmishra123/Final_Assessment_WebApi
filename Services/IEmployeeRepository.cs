using System.Collections.Generic;
using FinalAssessment_GovindMishra.Models;

namespace FinalAssessment_GovindMishra.Services
{
    public interface IEmployeeRepository
    {
         int CreateEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployeeDetails();
        public Employee GetEmployee(int id);
        int DeleteEmployee(int id);
        int UpdateEmployee(Employee employee);
    }
}