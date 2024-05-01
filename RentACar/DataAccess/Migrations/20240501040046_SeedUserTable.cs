using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO users VALUES ('admin1', 'a111', 1)");
            migrationBuilder.Sql("INSERT INTO users VALUES ('admin2', 'a222', 1)");
            migrationBuilder.Sql("INSERT INTO users VALUES ('user1', 'u111', 2)");
            migrationBuilder.Sql("INSERT INTO users VALUES ('user2', 'u222', 2)");
            migrationBuilder.Sql("INSERT INTO users VALUES ('user3', 'u333', 2)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
