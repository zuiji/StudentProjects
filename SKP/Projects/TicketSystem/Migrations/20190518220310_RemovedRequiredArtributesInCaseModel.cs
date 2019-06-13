using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketSystem.Migrations
{
    public partial class RemovedRequiredArtributesInCaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_AspNetUsers_OperatorID",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Case_AspNetUsers_RequestorID",
                table: "Case");

            migrationBuilder.AlterColumn<string>(
                name: "RequestorID",
                table: "Case",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "OperatorID",
                table: "Case",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Case",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Case",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_AspNetUsers_OperatorID",
                table: "Case",
                column: "OperatorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_AspNetUsers_RequestorID",
                table: "Case",
                column: "RequestorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_AspNetUsers_OperatorID",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Case_AspNetUsers_RequestorID",
                table: "Case");

            migrationBuilder.AlterColumn<string>(
                name: "RequestorID",
                table: "Case",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OperatorID",
                table: "Case",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Case",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Case",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_AspNetUsers_OperatorID",
                table: "Case",
                column: "OperatorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_AspNetUsers_RequestorID",
                table: "Case",
                column: "RequestorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
