using Microsoft.EntityFrameworkCore.Migrations;

namespace Сrowdfunding.Data.Migrations
{
    public partial class User6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_AspNetUsers_UserId",
                table: "Campaigns");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_AspNetUsers_UserId",
                table: "Campaigns",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_AspNetUsers_UserId",
                table: "Campaigns");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_AspNetUsers_UserId",
                table: "Campaigns",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
