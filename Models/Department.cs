namespace OrionApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? DeptName { get; set; }
        public string? DeptLocation { get; set; }
        public string? DeptManager { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
