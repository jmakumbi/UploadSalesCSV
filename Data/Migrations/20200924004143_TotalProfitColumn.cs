using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadSales.Data.Migrations
{
    public partial class TotalProfitColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalProfit",
                table: "Sales",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalProfit",
                table: "Sales");
        }
    }
}
