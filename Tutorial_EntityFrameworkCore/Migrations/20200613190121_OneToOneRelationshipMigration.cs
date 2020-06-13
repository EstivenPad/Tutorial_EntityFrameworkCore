using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial_EntityFrameworkCore.Migrations
{
    public partial class OneToOneRelationshipMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Prestamo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo",
                column: "ClienteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Prestamo");
        }
    }
}
