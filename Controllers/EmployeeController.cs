using FinalAssessment_GovindMishra.Models;
using FinalAssessment_GovindMishra.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessment_GovindMishra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        //Applying Dependency Injection (DI)
        IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [HttpPost]
        [Route("Create")]

        public IActionResult Create(Employee employee)
        {
            employeeRepository.CreateEmployee(employee);
            return Ok("Created");
        }


        [HttpGet]
        [Route("Search")]

        public IActionResult Search(int id)
        {
            return Ok(employeeRepository.GetEmployee(id));
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAllRecord()
        {
            return Ok(employeeRepository.GetAllEmployeeDetails());
        }

        [HttpDelete]
        [Route("Delete")]

        public IActionResult Delete(int id)
        {
            employeeRepository.DeleteEmployee(id);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]

        public IActionResult Update(Employee employee)
        {
            // employeeRepository.UpdateRecord(id);
            return Ok(employeeRepository.UpdateEmployee(employee));
        }
    }
}