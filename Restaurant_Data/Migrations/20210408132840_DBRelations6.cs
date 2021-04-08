using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Data.Migrations
{
    public partial class DBRelations6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderProducts_OrderProductsId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderProducts_OrderProductsId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderProductsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderProductsId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TableId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderProductsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderProductsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderProductsId1",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_OrderId",
                table: "Tables",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Orders_OrderId",
                table: "Tables",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Orders_OrderId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_OrderId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Tables");

            migrationBuilder.AddColumn<int>(
                name: "OrderProductsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderProductsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderProductsId1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinksReady = table.Column<bool>(type: "bit", nullable: false),
                    FoodReady = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.OrderProductsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderProductsId",
                table: "Products",
                column: "OrderProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderProductsId1",
                table: "Orders",
                column: "OrderProductsId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderProducts_OrderProductsId1",
                table: "Orders",
                column: "OrderProductsId1",
                principalTable: "OrderProducts",
                principalColumn: "OrderProductsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderProducts_OrderProductsId",
                table: "Products",
                column: "OrderProductsId",
                principalTable: "OrderProducts",
                principalColumn: "OrderProductsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
