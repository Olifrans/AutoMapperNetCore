using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMapperNetCore.Migrations
{
    public partial class DetalhesCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetalhesOrderId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DetalhesClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQuantidade = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdutoNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalhesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQuantidade = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesOrders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_DetalhesOrderId",
                table: "Produtos",
                column: "DetalhesOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_DetalhesOrders_DetalhesOrderId",
                table: "Produtos",
                column: "DetalhesOrderId",
                principalTable: "DetalhesOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_DetalhesOrders_DetalhesOrderId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "DetalhesClientes");

            migrationBuilder.DropTable(
                name: "DetalhesOrders");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_DetalhesOrderId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DetalhesOrderId",
                table: "Produtos");
        }
    }
}
