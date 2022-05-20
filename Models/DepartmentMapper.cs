using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalAssessment_GovindMishra.Models
{
    public class DepartmentMapper
    {
        public DepartmentMapper(EntityTypeBuilder<Department> typeBuilder)
        {
            //Defining Constraints using FluentAPI
            typeBuilder.HasKey(t => t.DeptId);
            typeBuilder.Property(t => t.DeptHead).IsRequired();
            typeBuilder.Property(t => t.DeptName).IsRequired();
        }
    }
}