using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyInVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ActiveWorkingTimePercentage",
                table: "vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IdleStandbyTimePercentage",
                table: "vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveWorkingTimePercentage",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "IdleStandbyTimePercentage",
                table: "vehicles");
        }
    }
}
