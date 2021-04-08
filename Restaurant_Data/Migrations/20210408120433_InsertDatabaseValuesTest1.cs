using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Data.Migrations
{
    public partial class InsertDatabaseValuesTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DrinksReady",
                table: "OrderProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FoodReady",
                table: "OrderProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "FoodType", "Name", "OrderProductsId", "Price" },
                values: new object[] { 1, 3, "Spaghetti", null, 20.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "FoodType", "Name", "OrderProductsId", "Price" },
                values: new object[] { 2, 3, "Lasagne", null, 25.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DrinksReady",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "FoodReady",
                table: "OrderProducts");
        }
    }
}
