using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class CreateStatistical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statisticals",
                columns: table => new
                {
                    StatisticalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatisticalMonth = table.Column<int>(type: "int", nullable: false),
                    QuantityRegister = table.Column<int>(type: "int", nullable: false),
                    QuantityOrder = table.Column<int>(type: "int", nullable: false),
                    Revenue = table.Column<decimal>(type: "money", nullable: false),
                    Transport = table.Column<decimal>(type: "money", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statisticals", x => x.StatisticalId);
                });

            migrationBuilder.CreateTable(
                name: "TotalAllStatistical",
                columns: table => new
                {
                    TotalStatisticallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalQuantityRegister = table.Column<int>(type: "int", nullable: false),
                    TotalQuantityOrder = table.Column<int>(type: "int", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "money", nullable: false),
                    TotalTransport = table.Column<decimal>(type: "money", nullable: false),
                    TotalAllRevenue = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalAllStatistical", x => x.TotalStatisticallId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statisticals");

            migrationBuilder.DropTable(
                name: "TotalAllStatistical");
        }
    }
}
