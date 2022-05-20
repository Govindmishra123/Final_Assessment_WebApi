using System.Collections.Generic;
using FinalAssessment_GovindMishra.Models;

namespace FinalAssessment_GovindMishra.Services
{
    public interface IDepartmentRepository
    {
         int CreateDepartment(Department department);
        int DeleteDepartment(int id);
    }
}