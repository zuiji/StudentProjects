using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePizzaChallenge.Data.Migrations
{
    public partial class Pizza20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "Pizzas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "Pizzas");
        }
    }
}
