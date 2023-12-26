using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecom.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Sweet tooth: For those who enjoy sweet delicacies so much that they cannot make themselves stop until a whole table of chocolate is gone, this is a must try!", "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/51BgFiH0PlL._SL1031_.jpg", 16.99m, "Roshen Sweet Dark Chocolate Bar" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Premium Gourmet Assorted Hazelnut Milk Chocolate, Dark Chocolate And Coconut Chocolates, Luxury Chocolate Holiday Gift Box", "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/918H0O3KDNL._SL1500_.jpg", 37.99m, "Ferrero Rocher Collection" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Kinder Bueno is a crispy, creamy, and delicious chocolate bar an unexpected combination of tastes and textures", "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/61g32E3y7dL._SL1500_.jpg", 3.49m, "Kinder Bueno" });
        }

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
