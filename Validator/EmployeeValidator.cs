using FinalAssessment_GovindMishra.Models;
using FluentValidation;

namespace FinalAssessment_GovindMishra.Validator
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        //Applying validation using Fluent Validation
        public EmployeeValidator()
        {
            RuleFor(t => t.EmpAge).InclusiveBetween(18,60);
            RuleFor(n=> n.EmpName).Length(2,20);
            RuleFor(e => e.EmpEmail).EmailAddress();
        }
    }
}