namespace OrionApp.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public double? SubTotalAmount { get; set; }
        public double? DiscountAmount { get; set; }
        public double TotalAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentStatus { get; set; } // e.g., Paid, Unpaid, Refunded
        public string? TransactionId { get; set; } // Unique identifier for the transaction
        public string? SaleStatus { get; set; } // e.g., Completed, Pending, Cancelled
        public string? ShippingAddress { get; set; } // Address where the product is shipped
        public string? ShippingMethod { get; set; } // e.g., Standard, Express
        public double? ShippingCost { get; set; } // Cost of shipping  
        public string? TrackingNumber { get; set; } // Tracking number for the shipment
        public string? ShippingCompany { get; set; } // Name of the shipping company
        public string? InvoiceNumber { get; set; } // Unique invoice number for the sale
        public string? BillingAddress { get; set; } // Address for billing purposes
        public int EmployeeId { get; set; } // Employee who handled the sale
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
