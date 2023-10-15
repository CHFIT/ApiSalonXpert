using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class addcorporation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturacion_Servicios_IdServicio",
                table: "Facturacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Servicios_ServiciosIdServicio",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_ServiciosIdServicio",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Facturacion_IdServicio",
                table: "Facturacion");

            migrationBuilder.DropColumn(
                name: "ServiciosIdServicio",
                table: "Servicios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiciosIdServicio",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_ServiciosIdServicio",
                table: "Servicios",
                column: "ServiciosIdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Facturacion_IdServicio",
                table: "Facturacion",
                column: "IdServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturacion_Servicios_IdServicio",
                table: "Facturacion",
                column: "IdServicio",
                principalTable: "Servicios",
                principalColumn: "IdServicio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Servicios_ServiciosIdServicio",
                table: "Servicios",
                column: "ServiciosIdServicio",
                principalTable: "Servicios",
                principalColumn: "IdServicio");
        }
    }
}
