using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BorkarEmlak.REPO.Migrations
{
    public partial class İNİT1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_AspNetUsers_AppUserId1",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_AppUserId1",
                table: "Emlaks");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Emlaks");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Emlaks",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_AppUserId",
                table: "Emlaks",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_AspNetUsers_AppUserId",
                table: "Emlaks",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_AspNetUsers_AppUserId",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_AppUserId",
                table: "Emlaks");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Emlaks",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Emlaks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_AppUserId1",
                table: "Emlaks",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_AspNetUsers_AppUserId1",
                table: "Emlaks",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
