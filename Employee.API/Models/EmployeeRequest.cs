using Employee.API.Enums;

namespace Employee.API.Models
{ 
    public class EmployeeRequest
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool Activity { get; set; }
    }
}