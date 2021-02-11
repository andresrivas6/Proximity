using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class proximity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosFactura_Articulo_articuloid",
                table: "ArticulosFactura");

            migrationBuilder.DropColumn(
                name: "arcticuloId",
                table: "ArticulosFactura");

            migrationBuilder.RenameColumn(
                name: "articuloid",
                table: "ArticulosFactura",
                newName: "articuloId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticulosFactura_articuloid",
                table: "ArticulosFactura",
                newName: "IX_ArticulosFactura_articuloId");

            migrationBuilder.AlterColumn<int>(
                name: "articuloId",
                table: "ArticulosFactura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosFactura_Articulo_articuloId",
                table: "ArticulosFactura",
                column: "articuloId",
                principalTable: "Articulo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosFactura_Articulo_articuloId",
                table: "ArticulosFactura");

            migrationBuilder.RenameColumn(
                name: "articuloId",
                table: "ArticulosFactura",
                newName: "articuloid");

            migrationBuilder.RenameIndex(
                name: "IX_ArticulosFactura_articuloId",
                table: "ArticulosFactura",
                newName: "IX_ArticulosFactura_articuloid");

            migrationBuilder.AlterColumn<int>(
                name: "articuloid",
                table: "ArticulosFactura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "arcticuloId",
                table: "ArticulosFactura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosFactura_Articulo_articuloid",
                table: "ArticulosFactura",
                column: "articuloid",
                principalTable: "Articulo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
