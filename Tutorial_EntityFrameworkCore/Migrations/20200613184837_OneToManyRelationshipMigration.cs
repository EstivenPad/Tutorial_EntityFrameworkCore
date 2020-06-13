using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_EntityFrameworkCore.Migrations
{
    public partial class OneToManyRelationshipMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "LibroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "LibroId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
