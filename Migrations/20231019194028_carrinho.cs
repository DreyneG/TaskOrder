using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskOrder.Migrations
{
    /// <inheritdoc />
    public partial class carrinho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Itens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ImagemPequenaUrl",
                table: "Itens",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    CarrinhoItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    CarrinhoId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.CarrinhoItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ItemId",
                table: "CarrinhoItens",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Itens",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagemPequenaUrl",
                table: "Itens",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
