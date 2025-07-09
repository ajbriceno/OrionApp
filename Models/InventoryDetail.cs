namespace OrionApp.Models
{
    public class InventoryDetail
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public DateTime MovementDate { get; set; }
        public string? MovementType { get; set; } // "Entrada", "Salida", "Ajuste", etc.
        public double Quantity { get; set; }
        public string? Reference { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}