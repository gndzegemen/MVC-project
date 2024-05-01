using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class IdPropertiesChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "vehicles",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "vehicles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "Id");
        }
    }
}
