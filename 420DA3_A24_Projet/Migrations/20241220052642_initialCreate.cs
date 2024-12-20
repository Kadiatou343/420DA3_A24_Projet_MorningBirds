using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _420DA3_A24_Projet.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    ContactFirstName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "AddressClient",
                columns: table => new
                {
                    AddressesId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressClient", x => new { x.AddressesId, x.ClientsId });
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Addresse = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CivicNumber = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    State = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    WarehouseId = table.Column<int>(name: "WarehouseId ", type: "int", nullable: false),
                    ContactFirstName = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    ContactTelephone = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    EmployeeWarehouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Warehouses_EmployeeWarehouseId",
                        column: x => x.EmployeeWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Warehouses_WarehouseId ",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    EmployeeWarehouseId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Warehouses_EmployeeWarehouseId",
                        column: x => x.EmployeeWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    CodeUPC = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    PictureName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SupplierCode = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AimQuanity = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    CreatorEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DestinationAdressId = table.Column<int>(type: "int", nullable: false),
                    FulfillerEmployeeId = table.Column<int>(type: "int", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true, defaultValueSql: "GETUTCDATE()"),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    SourceClientId = table.Column<int>(type: "int", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingOrders_Clients_SourceClientId",
                        column: x => x.SourceClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingOrders_Users_FulfillerEmployeeId",
                        column: x => x.FulfillerEmployeeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingOrders_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Products_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    ShippingService = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    ShippingOrderId = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_ShippingOrders_ShippingOrderId",
                        column: x => x.ShippingOrderId,
                        principalTable: "ShippingOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingOrderProduct",
                columns: table => new
                {
                    ShippingOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingOrderProduct", x => new { x.ShippingOrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShippingOrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingOrderProduct_ShippingOrders_ShippingOrderId",
                        column: x => x.ShippingOrderId,
                        principalTable: "ShippingOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "Addresse", "City", "CivicNumber", "Country", "DateDeleted", "DateModified", "PostalCode", "State", "ContactLastName" },
                values: new object[] { 1, "Commercial", "We Store You Sell Inc Entrepot 0001", "Montreal", "7777", "Canada", null, null, "H0E 1H1", "Quebec", "Destiny Street" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DateDeleted", "DateModified", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { 1, null, null, "Les supers utilisateurs", "Administrateur" },
                    { 2, null, null, "Boss of paperwork", "Employé de bureau" },
                    { 3, null, null, "Les masters du lourd", "Employé d'entrepôt" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "ContactEmail", "ContactFirstName", "ContactLastName", "ContactPhone", "DateDeleted", "DateModified", "SupplierName" },
                values: new object[,]
                {
                    { 1, "jonhytest@gmail.com", "Jonhy", "Test", "4503497684", null, null, "THE ULTIMATE SUPPLIER" },
                    { 2, "davisamel@gmail.com", "Amel", "Davis", "2903497684", null, null, "THE BEST SUPPLIER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateDeleted", "DateModified", "EmployeeWarehouseId", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { 1, null, null, null, "7761467A80A38D8429C0B80898FE3047F1E85E1C0CB2A9304FF72D028D39FF4D:8C68F80262A76FDB8E595A6212B3545A:100000:SHA256", "hunter" },
                    { 2, null, null, null, "4ECAA597B625B3FCA7E36442D4C6A3EB05AB9DFFC9F254EE483FBDBEB6D2910C:D761ED59218EDF8032D7F7882DE44EAE:100000:SHA256", "deiiidia" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "AddressId", "DateDeleted", "DateModified", "WarehouseName" },
                values: new object[] { 1, 1, null, null, "Entrepot For Bessy" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ClientName", "ContactEmail", "ContactFirstName", "ContactLastName", "ContactTelephone", "DateCreated", "DateDeleted", "DateModified", "EmployeeWarehouseId", "WarehouseId " },
                values: new object[,]
                {
                    { 1, "MISA DARK JARJAR", "darkjarjar@gmail.com", "Binks", "Jar Jar", "450450450", new DateTime(2024, 12, 20, 5, 26, 42, 468, DateTimeKind.Utc).AddTicks(6954), null, null, null, 1 },
                    { 2, "SUPREME KADI", "ilesmenar@gmail.com", "Iles", "Menar", "450450470", new DateTime(2024, 12, 20, 5, 26, 42, 468, DateTimeKind.Utc).AddTicks(6961), null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateDeleted", "DateModified", "EmployeeWarehouseId", "PasswordHash", "Username" },
                values: new object[] { 3, null, null, 1, "6A8EFEE80A6B9FE951105B1105A01E9BDC17BBA64ED70E36C6499713641CF6D4:172AAB90868D82E03834D8C43F6799B0:100000:SHA256", "maximus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AimQuanity", "ClientId", "CodeUPC", "DateDeleted", "DateModified", "Desc", "PictureName", "ProductName", "Quantity", "SupplierCode", "SupplierId", "Weight" },
                values: new object[,]
                {
                    { 1, 100, 1, "103833038446", null, null, "Une chaise sibole", "default", "Chaise", 50, "acode", 1, 50.0 },
                    { 2, 100, 2, "10212343521", null, null, "Une qui fait BOOM BOOM", "default", "Radio Stero", 30, "bcode", 2, 50.0 },
                    { 3, 100, 2, "10212343502", null, null, "Un bureau magnifique", "default", "Table de bureau", 20, "bcode", 2, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AddressClient_ClientsId",
                table: "AddressClient",
                column: "ClientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_EmployeeWarehouseId",
                table: "Clients",
                column: "EmployeeWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_WarehouseId ",
                table: "Clients",
                column: "WarehouseId ");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientId",
                table: "Products",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_WarehouseId",
                table: "PurchaseOrders",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShippingOrderId",
                table: "Shipments",
                column: "ShippingOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingOrderProduct_ProductId",
                table: "ShippingOrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingOrders_FulfillerEmployeeId",
                table: "ShippingOrders",
                column: "FulfillerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingOrders_SourceClientId",
                table: "ShippingOrders",
                column: "SourceClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeWarehouseId",
                table: "Users",
                column: "EmployeeWarehouseId");

            migrationBuilder.CreateIndex(
                name: "unique_index_username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_AddressId",
                table: "Warehouses",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressClient_Addresses_AddressesId",
                table: "AddressClient",
                column: "AddressesId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressClient_Clients_ClientsId",
                table: "AddressClient",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_ShippingOrders_Id",
                table: "Addresses",
                column: "Id",
                principalTable: "ShippingOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Addresses_AddressId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "AddressClient");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "ShippingOrderProduct");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ShippingOrders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
