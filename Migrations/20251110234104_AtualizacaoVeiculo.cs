using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVeiculosComMVC.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Revisao",
                table: "TabelaVeiculo",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Revisao",
                table: "TabelaVeiculo");
        }
    }
}
