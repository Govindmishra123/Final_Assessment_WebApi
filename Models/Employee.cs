namespace FinalAssessment_GovindMishra.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string EmpEmail { get; set; }

        //Navigation Property
        public Department department { get; set; }
    }
}