using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 4L, "Teste", "Teste de descrição", "https://teste.png", "Nome do produto teste", 69.9m },
                    { 5L, "Teste", "Teste de descrição 5", "https://teste5.png", "Nome do produto teste 5", 89.9m },
                    { 6L, "Teste", "Teste de descrição 6", "https://teste6.png", "Nome do produto teste 6", 43.4m },
                    { 7L, "Teste", "Teste de descrição 7", "https://teste7.png", "Nome do produto teste 7", 15.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}
