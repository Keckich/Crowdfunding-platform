using Microsoft.EntityFrameworkCore.Migrations;

namespace Сrowdfunding.Data.Migrations
{
    public partial class Achievement2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserAchievements");

            migrationBuilder.AddColumn<int>(
                name: "UserAchievementId",
                table: "UserAchievements",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAchievementId",
                table: "UserAchievements");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserAchievements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
