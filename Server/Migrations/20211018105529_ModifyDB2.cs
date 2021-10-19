using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class ModifyDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vouchers_Customers_CustomerId",
                table: "Vouchers");

            migrationBuilder.DropIndex(
                name: "IX_Vouchers_CustomerId",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Vouchers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Vouchers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_CustomerId",
                table: "Vouchers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vouchers_Customers_CustomerId",
                table: "Vouchers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
