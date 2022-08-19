using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleRelation.Migrations
{
    public partial class addpriceforarticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Articles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Articles");
        }
    }
}
