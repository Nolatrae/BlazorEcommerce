using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class Product_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "stars weekend trawis scott", "https://avatars.mds.yandex.net/i?id=69ebc3194bc39fbd68a48e92eb6e1e6caddfdcca-9236004-images-thumbs&n=13", 9.99m, "Galaxy" },
                    { 2, "House house house man car", "https://avatars.mds.yandex.net/i?id=7be6729fc150193c06bf0c61840bff798ae2ab62-9152303-images-thumbs&n=13", 8.99m, "House" },
                    { 3, "lorem ipsum", "https://avatars.mds.yandex.net/i?id=7fe5fc045d852fd08454e9bdda42ce1c41f21cc7-9035616-images-thumbs&n=13", 7.99m, "Marginal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
