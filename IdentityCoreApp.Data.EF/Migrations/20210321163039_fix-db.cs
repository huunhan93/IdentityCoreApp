using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCoreApp.Data.EF.Migrations
{
    public partial class fixdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "AppUsers",
                newName: "BirthDay");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AppUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "AppUsers",
                newName: "Birthday");
        }
    }
}
