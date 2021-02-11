using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class proximity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosFactura_Factura_facturaid",
                table: "ArticulosFactura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Cliente_clienteid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idArcticulo",
                table: "ArticulosFactura");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "Factura",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_clienteid",
                table: "Factura",
                newName: "IX_Factura_clienteId");

            migrationBuilder.RenameColumn(
                name: "facturaid",
                table: "ArticulosFactura",
                newName: "facturaId");

            migrationBuilder.RenameColumn(
                name: "idFactura",
                table: "ArticulosFactura",
                newName: "arcticuloId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticulosFactura_facturaid",
                table: "ArticulosFactura",
                newName: "IX_ArticulosFactura_facturaId");

            migrationBuilder.AlterColumn<int>(
                name: "clienteId",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "facturaId",
                table: "ArticulosFactura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosFactura_Factura_facturaId",
                table: "ArticulosFactura",
                column: "facturaId",
                principalTable: "Factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Cliente_clienteId",
                table: "Factura",
                column: "clienteId",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosFactura_Factura_facturaId",
                table: "ArticulosFactura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Cliente_clienteId",
                table: "Factura");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Factura",
                newName: "clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_clienteId",
                table: "Factura",
                newName: "IX_Factura_clienteid");

            migrationBuilder.RenameColumn(
                name: "facturaId",
                table: "ArticulosFactura",
                newName: "facturaid");

            migrationBuilder.RenameColumn(
                name: "arcticuloId",
                table: "ArticulosFactura",
                newName: "idFactura");

            migrationBuilder.RenameIndex(
                name: "IX_ArticulosFactura_facturaId",
                table: "ArticulosFactura",
                newName: "IX_ArticulosFactura_facturaid");

            migrationBuilder.AlterColumn<int>(
                name: "clienteid",
                table: "Factura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "facturaid",
                table: "ArticulosFactura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idArcticulo",
                table: "ArticulosFactura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosFactura_Factura_facturaid",
                table: "ArticulosFactura",
                column: "facturaid",
                principalTable: "Factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Cliente_clienteid",
                table: "Factura",
                column: "clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
