using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_AccessLayer.Migrations
{
    public partial class mig_new_message2_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messages2",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages2", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_messages2_writers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_messages2_writers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_messages2_ReceiverID",
                table: "messages2",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_messages2_SenderID",
                table: "messages2",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messages2");
        }
    }
}
