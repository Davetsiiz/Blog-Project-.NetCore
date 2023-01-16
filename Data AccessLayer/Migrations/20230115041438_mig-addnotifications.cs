using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_AccessLayer.Migrations
{
    public partial class migaddnotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "notifications",
                columns: table => new
                {
                    NatificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NatificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatificationNameTypeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NatificationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifications", x => x.NatificationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notifications");
        }
    }
}
