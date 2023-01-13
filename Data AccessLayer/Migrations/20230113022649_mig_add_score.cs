using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_AccessLayer.Migrations
{
    public partial class mig_add_score : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogScore",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogScore",
                table: "comments");
        }
    }
}
