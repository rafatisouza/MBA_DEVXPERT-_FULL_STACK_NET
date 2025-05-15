using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class Produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Vendedores_VendedorId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_VendedorId",
                table: "Produtos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Produtos_VendedorId",
                table: "Produtos",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Vendedores_VendedorId",
                table: "Produtos",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
