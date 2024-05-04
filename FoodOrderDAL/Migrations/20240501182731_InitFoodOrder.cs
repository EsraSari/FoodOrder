using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodOrderDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitFoodOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    IsAllergen = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    ProductDetailID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMenu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMenu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductMenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMenu_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockAmount = table.Column<int>(type: "int", nullable: false),
                    StockStatus = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stocks_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CountyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Counties_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactTypeID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContactInformations_ContactTypes_ContactTypeID",
                        column: x => x.ContactTypeID,
                        principalTable: "ContactTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactInformations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressInformations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    CountyID = table.Column<int>(type: "int", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddressInformations_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AddressInformations_Counties_CountyID",
                        column: x => x.CountyID,
                        principalTable: "Counties",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AddressInformations_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AddressInformations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: true),
                    OrderStateID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: false),
                    OrderNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AddressInformations_AddressID",
                        column: x => x.AddressID,
                        principalTable: "AddressInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ContactInformations_ContactID",
                        column: x => x.ContactID,
                        principalTable: "ContactInformations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStates_OrderStateID",
                        column: x => x.OrderStateID,
                        principalTable: "OrderStates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentMethods_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menu_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "AddedDate", "CategoryName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6645), "Yiyecek", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6645), true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6647), "İçecek", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6647), true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "AddedDate", "CountryName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6448), "Türkiye", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6448), true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6452), "Almanya", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6452), true },
                    { 3, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6454), "Fransa", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6455), true },
                    { 4, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6456), "İngiltere", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6457), true },
                    { 5, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6459), "İtalya", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6459), true },
                    { 6, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6460), "İspanya", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6461), true },
                    { 7, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6462), "Türkiye", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6463), true },
                    { 8, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6464), "Ukrayna", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6465), true },
                    { 9, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6467), "Polonya", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6467), true },
                    { 10, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6469), "Romanya", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6469), true },
                    { 11, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6471), "Hollanda", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6471), true }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "AddedDate", "Gender", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6557), "Kadın", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6558), true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6560), "Erkek", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6560), true }
                });

            migrationBuilder.InsertData(
                table: "OrderStates",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "OrderState", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5811), "Hazırlanıyor", true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5813), new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5814), "Teslim Edildi", true },
                    { 3, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(5816), "İptal Edildi", true }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "PaymentName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6070), "Kredi/Banka Kartı", true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6073), "Nakit", true }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "AddedDate", "CityName", "CountryID", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6158), "İstanbul", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6158), true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6160), "Ankara", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6161), true },
                    { 3, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6162), "İzmir", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6163), true },
                    { 4, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6165), "Bursa", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6165), true },
                    { 5, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6167), "Antalya", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6167), true },
                    { 6, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6169), "Adana", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6169), true },
                    { 7, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6171), "Konya", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6171), true },
                    { 8, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6173), "Kayseri", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6174), true },
                    { 9, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6175), "Mersin", 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6176), true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "AddedDate", "CategoryID", "ModifiedDate", "PreparationTime", "Price", "ProductDetailID", "ProductName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6730), 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6730), 5, 15m, 0, "Patates", true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6732), 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6733), 0, 10m, 0, "Kola", true },
                    { 3, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6735), 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6736), 0, 0m, 0, "Ketçap", true },
                    { 4, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6738), 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6738), 0, 0m, 0, "Mayonez", true }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "ID", "AddedDate", "CityID", "CountyName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6292), 1, "Kağıthane", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6292), true },
                    { 2, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6295), 1, "Şişli", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6295), true },
                    { 3, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6297), 1, "Beşiktaş", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6297), true },
                    { 4, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6299), 1, "Beyoğlu", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6299), true },
                    { 5, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6301), 1, "Kadıköy", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6302), true },
                    { 6, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6303), 1, "Üsküdar", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6304), true },
                    { 7, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6328), 1, "Fatih", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6328), true },
                    { 8, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6330), 1, "Bakırköy", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6331), true },
                    { 9, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6332), 1, "Maltepe", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6333), true },
                    { 10, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6334), 1, "Ataşehir", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6335), true },
                    { 11, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6336), 1, "Büyükçekmece", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6337), true },
                    { 12, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6338), 1, "Sarıyer", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6339), true },
                    { 13, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6340), 1, "Kartal", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6341), true },
                    { 14, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6343), 1, "Şile", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6343), true },
                    { 15, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6345), 1, "Çatalca", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6345), true },
                    { 16, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6347), 1, "Adalar", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6348), true },
                    { 17, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6349), 2, "Altındağ", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6350), true },
                    { 18, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6351), 2, "Ayaş", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6352), true },
                    { 19, new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6353), 2, "Bala", new DateTime(2024, 5, 1, 21, 27, 30, 686, DateTimeKind.Local).AddTicks(6354), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformations_CityID",
                table: "AddressInformations",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformations_CountryID",
                table: "AddressInformations",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformations_CountyID",
                table: "AddressInformations",
                column: "CountyID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformations_CustomerID",
                table: "AddressInformations",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_ContactTypeID",
                table: "ContactInformations",
                column: "ContactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_CustomerID",
                table: "ContactInformations",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CityID",
                table: "Counties",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderID",
                table: "Customers",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserName",
                table: "Customers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ItemID",
                table: "OrderDetails",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressID",
                table: "Orders",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ContactID",
                table: "Orders",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStateID",
                table: "Orders",
                column: "OrderStateID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodID",
                table: "Orders",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMenu_MenuID",
                table: "ProductMenu",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMenu_ProductID",
                table: "ProductMenu",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_MenuID",
                table: "Stocks",
                column: "MenuID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductID",
                table: "Stocks",
                column: "ProductID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductMenu");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AddressInformations");

            migrationBuilder.DropTable(
                name: "ContactInformations");

            migrationBuilder.DropTable(
                name: "OrderStates");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
