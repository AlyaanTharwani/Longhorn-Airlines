using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spr24_team4_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class Remigrate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State1",
                table: "FlightRoute");

            migrationBuilder.DropColumn(
                name: "State2",
                table: "FlightRoute");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State1",
                table: "FlightRoute",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State2",
                table: "FlightRoute",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
