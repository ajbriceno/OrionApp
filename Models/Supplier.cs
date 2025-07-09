namespace OrionApp.Models;

public class Supplier
{
    public int Id { get; set; }
    public string? SupName { get; set; }
    public string? SupDescription { get; set; }
    public string? SupContactName { get; set; }
    public string? SupContactEmail { get; set; }
    public string? SupContactPhone { get; set; }
    public string? SupAddress { get; set; }
    public string? SupCity { get; set; }
    public string? SupState { get; set; }
    public string? SupZipCode { get; set; } 
    public string? SupCountry { get; set; }
    public string? SupWebsite { get; set; }
    public string? SupMainPhone { get; set; }
    public string? SupPaymentDate { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 
    public bool IsActive { get; set; } = true;
}