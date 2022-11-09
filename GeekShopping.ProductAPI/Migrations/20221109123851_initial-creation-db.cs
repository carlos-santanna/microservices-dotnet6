using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class initialcreationdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 4L, "Teste", "Teste de descrição", "https://teste.png", "Nome do produto teste", 69.9m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 5L, "Teste", "Teste de descrição 5", "https://teste5.png", "Nome do produto teste 5", 89.9m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 6L, "Teste", "Teste de descrição 6", "https://teste6.png", "Nome do produto teste 6", 43.4m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 7L, "Teste", "Teste de descrição 7", "https://teste7.png", "Nome do produto teste 7", 15.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
