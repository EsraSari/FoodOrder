using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodOrderDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitFoodOrders : Migration
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
                name: "ItemTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.ID);
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
                    CommDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ItemTypeID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ItemTypes_ItemTypeID",
                        column: x => x.ItemTypeID,
                        principalTable: "ItemTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menu_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Menu",
                        principalColumn: "ID");
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
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "AddedDate", "CategoryName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8608), "Yiyecek", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8609), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8612), "İçecek", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8613), true }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ID", "AddedDate", "ContactType", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8977), "Cep Telefonu", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8978), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8981), "E-mail", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8982), true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "AddedDate", "CountryName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8283), "Türkiye", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8284), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8287), "Almanya", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8287), true },
                    { 3, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8290), "Fransa", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8291), true },
                    { 4, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8294), "İngiltere", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8294), true },
                    { 5, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8297), "İtalya", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8298), true },
                    { 6, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8301), "İspanya", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8301), true },
                    { 7, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8304), "Türkiye", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8305), true },
                    { 8, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8308), "Ukrayna", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8309), true },
                    { 9, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8311), "Polonya", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8312), true },
                    { 10, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8315), "Romanya", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8316), true },
                    { 11, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8318), "Hollanda", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8319), true }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "AddedDate", "Gender", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8452), "Kadın", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8453), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8456), "Erkek", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8457), true }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ID", "AddedDate", "ItemName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(9137), "Ürün", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(9138), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(9141), "Menü", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(9141), true }
                });

            migrationBuilder.InsertData(
                table: "OrderStates",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "OrderState", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7409), "Hazırlanıyor", true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7413), "Teslim Edildi", true },
                    { 3, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7417), "İptal Edildi", true }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "ID", "AddedDate", "ModifiedDate", "PaymentName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7728), "Kredi/Banka Kartı", true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7731), "Nakit", true }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "AddedDate", "CityName", "CountryID", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7896), "İstanbul", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7897), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7900), "Ankara", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7901), true },
                    { 3, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7904), "İzmir", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7905), true },
                    { 4, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7907), "Bursa", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7908), true },
                    { 5, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7911), "Antalya", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7912), true },
                    { 6, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7914), "Adana", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7915), true },
                    { 7, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7918), "Konya", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7919), true },
                    { 8, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7922), "Kayseri", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7922), true },
                    { 9, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7925), "Mersin", 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(7926), true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "AddedDate", "CategoryID", "ModifiedDate", "PreparationTime", "Price", "ProductDetailID", "ProductName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8751), 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8752), 5, 15m, 0, "Patates", true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8755), 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8756), 0, 10m, 0, "Kola", true },
                    { 3, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8760), 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8761), 0, 0m, 0, "Ketçap", true },
                    { 4, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8764), 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8765), 0, 0m, 0, "Mayonez", true }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "ID", "AddedDate", "CityID", "CountyName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8071), 1, "Kağıthane", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8071), true },
                    { 2, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8075), 1, "Şişli", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8075), true },
                    { 3, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8079), 1, "Beşiktaş", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8080), true },
                    { 4, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8082), 1, "Beyoğlu", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8083), true },
                    { 5, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8086), 1, "Kadıköy", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8087), true },
                    { 6, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8090), 1, "Üsküdar", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8091), true },
                    { 7, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8094), 1, "Fatih", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8095), true },
                    { 8, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8098), 1, "Bakırköy", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8099), true },
                    { 9, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8102), 1, "Maltepe", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8102), true },
                    { 10, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8105), 1, "Ataşehir", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8106), true },
                    { 11, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8109), 1, "Büyükçekmece", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8110), true },
                    { 12, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8113), 1, "Sarıyer", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8114), true },
                    { 13, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8117), 1, "Kartal", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8117), true },
                    { 14, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8120), 1, "Şile", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8121), true },
                    { 15, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8124), 1, "Çatalca", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8125), true },
                    { 16, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8128), 1, "Adalar", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8129), true },
                    { 17, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8131), 2, "Altındağ", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8132), true },
                    { 18, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8135), 2, "Ayaş", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8136), true },
                    { 19, new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8139), 2, "Bala", new DateTime(2024, 5, 7, 19, 53, 35, 961, DateTimeKind.Local).AddTicks(8139), true }
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
                name: "IX_OrderDetails_ItemTypeID",
                table: "OrderDetails",
                column: "ItemTypeID");

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
                name: "ItemTypes");

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
