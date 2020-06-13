using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_EntityFrameworkCore.Migrations
{
    public partial class DataAnnotationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaPrestamo",
                table: "Prestamo",
                newName: "Fecha de prestamo");

            migrationBuilder.RenameColumn(
                name: "FechaDevolucion",
                table: "Prestamo",
                newName: "Fecha de devolucion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha de prestamo",
                table: "Prestamo",
                newName: "FechaPrestamo");

            migrationBuilder.RenameColumn(
                name: "Fecha de devolucion",
                table: "Prestamo",
                newName: "FechaDevolucion");
        }
    }
}
