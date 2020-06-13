using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_EntityFrameworkCore.Migrations
{
    public partial class UpdatePrestamoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamo",
                column: "LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "LibroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Libro_LibroId",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "LibroId",
                table: "Prestamo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Prestamo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
