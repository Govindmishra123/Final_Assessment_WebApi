using FinalAssessment_GovindMishra.Models;
using FinalAssessment_GovindMishra.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessment_GovindMishra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController:ControllerBase
    {
        //Applying Dependency Injection (DI)
        IDepartmentRepository departmentRepository;
        public DepartmentController(IDepartmentRepository _departmentRepository)
        {
            departmentRepository = _departmentRepository;
        }

        [HttpPost]
        [Route("CreateDep")]

        public IActionResult CreateDep(Department department)
        {
            departmentRepository.CreateDepartment(department);
            return Ok("Created");
        }

        [HttpDelete]
        [Route("Delete")]

        public IActionResult Delete(int id)
        {
            departmentRepository.DeleteDepartment(id);
            return Ok();
        }
    }
}