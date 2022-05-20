using System.Collections.Generic;

namespace FinalAssessment_GovindMishra.Models
{
    public class Department
    {
        public Department()
        {
            employee= new HashSet<Employee>();
        }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptHead { get; set; }

        //Navigation Property
        public IEnumerable<Employee> employee { get; set; }
    }
}