using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace extratinhos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Limit = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<long>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entry_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Limit" },
                values: new object[] { 1L, 100000L });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Limit" },
                values: new object[] { 2L, 80000L });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Limit" },
                values: new object[] { 3L, 1000000L });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Limit" },
                values: new object[] { 4L, 10000000L });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Limit" },
                values: new object[] { 5L, 500000L });

            migrationBuilder.CreateIndex(
                name: "IX_Entry_ClientId",
                table: "Entry",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
