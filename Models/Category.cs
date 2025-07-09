namespace OrionApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CatName { get; set; }
        public string? CatDescription { get; set; } 
        public DateTime CreatedAt { get; set; }   
        public DateTime UpdatedAt { get; set; }  
        public bool IsActive { get; set; } 
    }
}