using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquiposFutbol.API.Migrations
{
    /// <inheritdoc />
    public partial class v03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_EquipoId",
                table: "Jugador");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Jugador",
                newName: "equipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador",
                newName: "IX_Jugador_equipoId");

            migrationBuilder.AlterColumn<int>(
                name: "equipoId",
                table: "Jugador",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_equipoId",
                table: "Jugador",
                column: "equipoId",
                principalTable: "Equipo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_equipoId",
                table: "Jugador");

            migrationBuilder.RenameColumn(
                name: "equipoId",
                table: "Jugador",
                newName: "EquipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Jugador_equipoId",
                table: "Jugador",
                newName: "IX_Jugador_EquipoId");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Jugador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_EquipoId",
                table: "Jugador",
                column: "EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
