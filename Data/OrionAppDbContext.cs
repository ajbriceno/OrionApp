using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using OrionApp.Models;

namespace OrionApp.Data;

public class OrionAppDbContext : DbContext
{
    public OrionAppDbContext(DbContextOptions<OrionAppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleDetail> SaleDetails { get; set; }  
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<InventoryDetail> InventoryDetails { get; set; }
    
}
