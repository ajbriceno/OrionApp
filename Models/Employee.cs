namespace OrionApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? EmpDocType { get; set; }
        public string? EmpDocNumber { get; set; }
        public string? EmpFirstName { get; set; }
        public string? EmpLastName { get; set; }
        public string? EmpEmail { get; set; }
        public string? EmpPhone { get; set; }
        public string? EmpAddress { get; set; }
        public string? EmpCity { get; set; }
        public string? EmpState { get; set; }
        public string? EmpZipCode { get; set; }
        public string? EmpCountry { get; set; }
        public string? EmpPosition { get; set; }
        public string? EmpDepartment { get; set; }
        public string? EmpSalary { get; set; }
        public string? EmpHireDate { get; set; }
        public string? EmpSupervisor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
