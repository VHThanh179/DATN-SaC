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
                    MonthlyRevenue = table.Column<decimal>(type: "money", nullable: false),
                    AnnualRevenue = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statisticals", x => x.StatisticalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statisticals");
        }
    }
}
