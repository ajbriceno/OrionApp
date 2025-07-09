namespace OrionApp.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string? StoreName { get; set; }
        public string? StoreLocation { get; set; }
        public string? StoreManager { get; set; }
        public string? StoreContact { get; set; }
        public string? StoreEmail { get; set; }
        public string? StorePhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
