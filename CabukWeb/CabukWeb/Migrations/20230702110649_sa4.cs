using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabukWeb.Migrations
{
    /// <inheritdoc />
    public partial class sa4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriesCategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoriesCategoryId",
                table: "Products",
                newName: "categoriesCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoriesCategoryId",
                table: "Products",
                newName: "IX_Products_categoriesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoriesCategoryId",
                table: "Products",
                column: "categoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoriesCategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoriesCategoryId",
                table: "Products",
                newName: "CategoriesCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoriesCategoryId",
                table: "Products",
                newName: "IX_Products_CategoriesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriesCategoryId",
                table: "Products",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
