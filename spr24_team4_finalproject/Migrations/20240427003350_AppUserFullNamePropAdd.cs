using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spr24_team4_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class AppUserFullNamePropAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableSeats",
                table: "Flight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightIdentifier",
                table: "Flight",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "FlightIdentifier",
                table: "Flight");
        }
    }
}
