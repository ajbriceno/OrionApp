namespace OrionApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustDocType { get; set; }
        public string? CustDocNumber { get; set; }
        public string? CustFirstName { get; set; }
        public string? CustLastName { get; set; }   
        public string? CustEmail { get; set; }
        public string? CustPhone { get; set; }
        public string? CustAddress { get; set; }
        public string? CustCity { get; set; }
        public string? CustState { get; set; }
        public string? CustZipCode { get; set; }
        public string? CustCountry { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
