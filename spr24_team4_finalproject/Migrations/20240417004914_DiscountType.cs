using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spr24_team4_finalproject.Migrations
{
    /// <inheritdoc />
    public partial class DiscountType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservation",
                newName: "ReservationMakerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                newName: "IX_Reservation_ReservationMakerId");

            migrationBuilder.RenameColumn(
                name: "ActiveStatus",
                table: "AspNetUsers",
                newName: "empStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_ReservationMakerId",
                table: "Reservation",
                column: "ReservationMakerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_ReservationMakerId",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "ReservationMakerId",
                table: "Reservation",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ReservationMakerId",
                table: "Reservation",
                newName: "IX_Reservation_UserId");

            migrationBuilder.RenameColumn(
                name: "empStatus",
                table: "AspNetUsers",
                newName: "ActiveStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
