using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationIdentity.Migrations
{
    public partial class addJwtVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "JwtVersion",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JwtVersion",
                table: "AspNetUsers");
        }
    }
}
