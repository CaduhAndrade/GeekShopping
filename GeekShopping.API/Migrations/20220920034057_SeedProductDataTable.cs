using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.API.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m },
                    { 2L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m },
                    { 3L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m },
                    { 4L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m },
                    { 5L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m },
                    { 6L, "T-shirt", "oaisdaoisdjaiosjdasoid", "www.google.com.br", "Name", 56.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
