using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Migrations
{
    public partial class AddTabelaVendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimeiroNome = table.Column<string>(maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 50, nullable: false),
                    Endereco1 = table.Column<string>(maxLength: 100, nullable: false),
                    Endereco2 = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(maxLength: 15, nullable: false),
                    Estado = table.Column<string>(maxLength: 10, nullable: true),
                    Pais = table.Column<string>(maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(maxLength: 25, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    TotalVenda = table.Column<decimal>(nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                });

            migrationBuilder.CreateTable(
                name: "VendasDetalhes",
                columns: table => new
                {
                    VendaDetalheId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendasDetalhes", x => x.VendaDetalheId);
                    table.ForeignKey(
                        name: "FK_VendasDetalhes_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendasDetalhes_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendasDetalhes_ProdutoId",
                table: "VendasDetalhes",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendasDetalhes_VendaId",
                table: "VendasDetalhes",
                column: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendasDetalhes");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
