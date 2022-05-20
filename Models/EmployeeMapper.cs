using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalAssessment_GovindMishra.Models
{
    public class EmployeeMapper
    {
        public EmployeeMapper(EntityTypeBuilder<Employee> typebuilder)
        {
            //Defining Constraints using FluentAPI
            typebuilder.HasKey(t => t.EmpID);
            typebuilder.Property(t => t.EmpAge).IsRequired();
            typebuilder.Property(t => t.EmpName).IsRequired();
            typebuilder.Property(t => t.EmpEmail).IsRequired();

            //Establishing One to many relation`
            typebuilder.HasOne(t => t.department)
                        .WithMany(t => t.employee)
                        .HasForeignKey(t => t.ID);
        }
    }
}