namespace OrionApp.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public double StockCurrent { get; set; }
        public double StockMin { get; set; }
        public double StockMax { get; set; }
        public DateTime LastEntryDate { get; set; }
        public DateTime LastExitDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}