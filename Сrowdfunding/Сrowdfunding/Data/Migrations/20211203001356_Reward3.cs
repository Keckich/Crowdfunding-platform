using Microsoft.EntityFrameworkCore.Migrations;

namespace Сrowdfunding.Data.Migrations
{
    public partial class Reward3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageStorageName",
                table: "Rewards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Rewards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageStorageName",
                table: "Rewards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Rewards");
        }
    }
}
