namespace OrionApp.Models;

public class Product
{
    public int Id { get; set; }
    public string? ProdName { get; set; }
    public string? ProdBrand { get; set; }
    public string? ProdModel { get; set; } 
    public string? ProdSerialNum { get; set; }
    public string? ProdPartNum  { get; set; } 
    public double ProdPriceUnit { get; set; }
    public double ProdPriceRetail { get; set; }
    public double ProdPriceWholesale { get; set; }
    public string? ProdMeasurementUnit { get; set; }
    public int CategoryId { get; set; }
    public int SupplierId { get; set; }
    public int StoreId { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; } 
    public bool IsActive { get; set; } = true;
}
