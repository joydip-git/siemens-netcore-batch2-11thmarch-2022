using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessUsingEFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialEmployeeDbCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employeerecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    department = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeerecords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeerecords");
        }
    }
}
