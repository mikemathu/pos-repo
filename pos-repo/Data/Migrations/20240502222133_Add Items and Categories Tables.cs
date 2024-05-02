using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace pos_repo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItemsandCategoriesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    ItemCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Meat" },
                    { 2, "Burger" },
                    { 3, "Pizza" },
                    { 4, "Drinks" },
                    { 5, "Desserts" },
                    { 6, "Snacks" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AvailableQuantity", "Description", "Image", "ItemCategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 100, "chicken, egg, mushroom, salad", "product-1.jpg", 1, "Grill Chicken Chop", 10.99 },
                    { 2, 90, "pork, egg, mushroom, salad", "product-2.jpg", 1, "Grill Pork Chop", 12.99 },
                    { 3, 70, "spaghetti, tomato, mushroom ", "product-3.jpg", 1, "Capellini Tomato Sauce", 11.99 },
                    { 4, 120, "apple, carrot, tomato", "product-4.jpg", 1, "Vegan Salad Bowl", 6.9900000000000002 },
                    { 5, 30, "Dill pickle, cheddar cheese, tomato, red onion, ground chuck beef", "product-17.jpg", 2, "Perfect Burger", 8.9900000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ItemCategories");
        }
    }
}
