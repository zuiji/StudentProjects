using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Migrations
{
    public partial class AddedNullableValueToClosedDateInCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Closed",
                table: "Case",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Closed",
                table: "Case",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
