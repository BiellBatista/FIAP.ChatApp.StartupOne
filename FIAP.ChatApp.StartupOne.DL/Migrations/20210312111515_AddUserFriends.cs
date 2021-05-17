using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.ChatApp.StartupOne.DL.Migrations
{
    public partial class AddUserFriends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Friends",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Friends");
        }
    }
}
