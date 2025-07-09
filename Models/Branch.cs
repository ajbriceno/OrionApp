namespace OrionApp.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string? BranchName { get; set; }
        public string? BranchLocation { get; set; }
        public string? BranchManager { get; set; }
        public string? BranchContact { get; set; }  
        public string? BranchEmail { get; set; }
        public string? BranchPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
