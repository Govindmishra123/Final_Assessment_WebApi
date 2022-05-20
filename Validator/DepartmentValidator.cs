using FinalAssessment_GovindMishra.Models;
using FluentValidation;

namespace FinalAssessment_GovindMishra.Validator
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        //Applying validation using Fluent Validation
        public DepartmentValidator()
        {
            RuleFor(t => t.DeptName).Length(5,25);
            RuleFor(t => t.DeptHead).Length(2,20);
        }
    }
}