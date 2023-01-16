using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_AccessLayer.Migrations
{
    public partial class mignotrename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NatificationType",
                table: "notifications",
                newName: "NotificationType");

            migrationBuilder.RenameColumn(
                name: "NatificationStatus",
                table: "notifications",
                newName: "NotificationStatus");

            migrationBuilder.RenameColumn(
                name: "NatificationNameTypeSymbol",
                table: "notifications",
                newName: "NotificationNameTypeSymbol");

            migrationBuilder.RenameColumn(
                name: "NatificationDetails",
                table: "notifications",
                newName: "NotificationDetails");

            migrationBuilder.RenameColumn(
                name: "NatificationDate",
                table: "notifications",
                newName: "NotificationDate");

            migrationBuilder.RenameColumn(
                name: "NatificationID",
                table: "notifications",
                newName: "NotificationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationType",
                table: "notifications",
                newName: "NatificationType");

            migrationBuilder.RenameColumn(
                name: "NotificationStatus",
                table: "notifications",
                newName: "NatificationStatus");

            migrationBuilder.RenameColumn(
                name: "NotificationNameTypeSymbol",
                table: "notifications",
                newName: "NatificationNameTypeSymbol");

            migrationBuilder.RenameColumn(
                name: "NotificationDetails",
                table: "notifications",
                newName: "NatificationDetails");

            migrationBuilder.RenameColumn(
                name: "NotificationDate",
                table: "notifications",
                newName: "NatificationDate");

            migrationBuilder.RenameColumn(
                name: "NotificationID",
                table: "notifications",
                newName: "NatificationID");
        }
    }
}
