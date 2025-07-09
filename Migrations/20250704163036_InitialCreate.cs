using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrionApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BranchName = table.Column<string>(type: "TEXT", nullable: true),
                    BranchLocation = table.Column<string>(type: "TEXT", nullable: true),
                    BranchManager = table.Column<string>(type: "TEXT", nullable: true),
                    BranchContact = table.Column<string>(type: "TEXT", nullable: true),
                    BranchEmail = table.Column<string>(type: "TEXT", nullable: true),
                    BranchPhone = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatName = table.Column<string>(type: "TEXT", nullable: false),
                    CatDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustDocType = table.Column<string>(type: "TEXT", nullable: true),
                    CustDocNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CustFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustLastName = table.Column<string>(type: "TEXT", nullable: true),
                    CustEmail = table.Column<string>(type: "TEXT", nullable: true),
                    CustPhone = table.Column<string>(type: "TEXT", nullable: true),
                    CustAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CustCity = table.Column<string>(type: "TEXT", nullable: true),
                    CustState = table.Column<string>(type: "TEXT", nullable: true),
                    CustZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    CustCountry = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeptName = table.Column<string>(type: "TEXT", nullable: true),
                    DeptLocation = table.Column<string>(type: "TEXT", nullable: true),
                    DeptManager = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpDocType = table.Column<string>(type: "TEXT", nullable: true),
                    EmpDocNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EmpFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    EmpLastName = table.Column<string>(type: "TEXT", nullable: true),
                    EmpEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmpPhone = table.Column<string>(type: "TEXT", nullable: true),
                    EmpAddress = table.Column<string>(type: "TEXT", nullable: true),
                    EmpCity = table.Column<string>(type: "TEXT", nullable: true),
                    EmpState = table.Column<string>(type: "TEXT", nullable: true),
                    EmpZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    EmpCountry = table.Column<string>(type: "TEXT", nullable: true),
                    EmpPosition = table.Column<string>(type: "TEXT", nullable: true),
                    EmpDepartment = table.Column<string>(type: "TEXT", nullable: true),
                    EmpSalary = table.Column<string>(type: "TEXT", nullable: true),
                    EmpHireDate = table.Column<string>(type: "TEXT", nullable: true),
                    EmpSupervisor = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdName = table.Column<string>(type: "TEXT", nullable: true),
                    ProdBrand = table.Column<string>(type: "TEXT", nullable: true),
                    ProdModel = table.Column<string>(type: "TEXT", nullable: true),
                    ProdSerialNum = table.Column<string>(type: "TEXT", nullable: true),
                    ProdPartNum = table.Column<string>(type: "TEXT", nullable: true),
                    ProdPriceUnit = table.Column<double>(type: "REAL", nullable: false),
                    ProdPriceRetail = table.Column<double>(type: "REAL", nullable: false),
                    ProdPriceWholesale = table.Column<double>(type: "REAL", nullable: false),
                    ProdMeasurementUnit = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    StoreId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PurchaseId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: true),
                    UnitPrice = table.Column<double>(type: "REAL", nullable: true),
                    TotalPrice = table.Column<double>(type: "REAL", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<double>(type: "REAL", nullable: true),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentStatus = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: true),
                    UnitPrice = table.Column<double>(type: "REAL", nullable: true),
                    Discount = table.Column<double>(type: "REAL", nullable: true),
                    TotalPrice = table.Column<double>(type: "REAL", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubTotalAmount = table.Column<double>(type: "REAL", nullable: true),
                    DiscountAmount = table.Column<double>(type: "REAL", nullable: true),
                    TotalAmount = table.Column<double>(type: "REAL", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentStatus = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionId = table.Column<string>(type: "TEXT", nullable: true),
                    SaleStatus = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingMethod = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingCost = table.Column<double>(type: "REAL", nullable: true),
                    TrackingNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingCompany = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BillingAddress = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true),
                    StoreLocation = table.Column<string>(type: "TEXT", nullable: true),
                    StoreManager = table.Column<string>(type: "TEXT", nullable: true),
                    StoreContact = table.Column<string>(type: "TEXT", nullable: true),
                    StoreEmail = table.Column<string>(type: "TEXT", nullable: true),
                    StorePhone = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupName = table.Column<string>(type: "TEXT", nullable: true),
                    SupDescription = table.Column<string>(type: "TEXT", nullable: true),
                    SupContactName = table.Column<string>(type: "TEXT", nullable: true),
                    SupContactEmail = table.Column<string>(type: "TEXT", nullable: true),
                    SupContactPhone = table.Column<string>(type: "TEXT", nullable: true),
                    SupAddress = table.Column<string>(type: "TEXT", nullable: true),
                    SupCity = table.Column<string>(type: "TEXT", nullable: true),
                    SupState = table.Column<string>(type: "TEXT", nullable: true),
                    SupZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    SupCountry = table.Column<string>(type: "TEXT", nullable: true),
                    SupWebsite = table.Column<string>(type: "TEXT", nullable: true),
                    SupMainPhone = table.Column<string>(type: "TEXT", nullable: true),
                    SupPaymentDate = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
