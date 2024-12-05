using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProducaoAPI.Migrations
{
    /// <inheritdoc />
    public partial class adicaoPropriedadeAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "ProducoesMateriasPrimas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Producoes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "MateriasPrimas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Maquinas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Formas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "ProducoesMateriasPrimas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Producoes");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "MateriasPrimas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Maquinas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Formas");
        }
    }
}
