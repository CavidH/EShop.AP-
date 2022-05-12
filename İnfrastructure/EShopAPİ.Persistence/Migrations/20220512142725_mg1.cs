using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShopAPİ.Persistence.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    İD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.İD);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    İD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.İD);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    İD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerİD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.İD);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerİD",
                        column: x => x.CustomerİD,
                        principalTable: "Customers",
                        principalColumn: "İD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersİD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsİD = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersİD, x.ProductsİD });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersİD",
                        column: x => x.OrdersİD,
                        principalTable: "Orders",
                        principalColumn: "İD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsİD",
                        column: x => x.ProductsİD,
                        principalTable: "Products",
                        principalColumn: "İD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsİD",
                table: "OrderProduct",
                column: "ProductsİD");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerİD",
                table: "Orders",
                column: "CustomerİD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
