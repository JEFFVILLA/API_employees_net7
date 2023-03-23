using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UserRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Employeers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employeers_UserId",
                table: "Employeers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employeers_Users_UserId",
                table: "Employeers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employeers_Users_UserId",
                table: "Employeers");

            migrationBuilder.DropIndex(
                name: "IX_Employeers_UserId",
                table: "Employeers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employeers");
        }
    }
}
