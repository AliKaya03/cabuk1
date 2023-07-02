using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabukWeb.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductsProductId",
                table: "Carts",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductsProductId",
                table: "Carts",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductsProductId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductsProductId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "Carts");
        }
    }
}
