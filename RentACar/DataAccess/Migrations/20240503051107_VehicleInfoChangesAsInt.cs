using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class VehicleInfoChangesAsInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdleStandbyTimePercentage",
                table: "vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ActiveWorkingTimePercentage",
                table: "vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "IdleStandbyTimePercentage",
                table: "vehicles",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "ActiveWorkingTimePercentage",
                table: "vehicles",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
