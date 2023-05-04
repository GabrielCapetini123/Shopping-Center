using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "T-shirt", "Camiseta da Nike em 100% algodão", "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg", "Camiseta Nike Preta", 69.9m },
                    { 4L, "T-shirt", "Camiseta da Adidas em 100% algodão", "https://gaston.vteximg.com.br/arquivos/ids/337744-420-420/2001155676_Ampliada.jpg?v=638035987668800000", "Camiseta Adidas Preta", 69.9m },
                    { 5L, "T-shirt", "Camiseta da Hering em 100% algodão", "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg", "Camiseta Hering", 69.9m },
                    { 6L, "T-shirt", "Camiseta da Nike em 100% algodão", "https://cdn.dooca.store/946/products/c4lgbuzwcmrcemhzmsfxymisccwvok0cwhod.jpg?v=1658773028&webp=0", "Camiseta Nike Branca", 69.9m },
                    { 7L, "T-shirt", "Camiseta da Adidas em 100% algodão", "https://centralsurf.vteximg.com.br/arquivos/ids/313815-1000-1000/Camiseta-Adidas-Logo-0.jpg?v=637387355630500000", "Camiseta Adidas Branca", 69.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}
