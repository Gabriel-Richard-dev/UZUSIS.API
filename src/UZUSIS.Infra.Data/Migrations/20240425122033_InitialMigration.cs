using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UZUSIS.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Atributo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 67, DateTimeKind.Local).AddTicks(3665))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoricoPagamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 77, DateTimeKind.Local).AddTicks(2799))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPagamento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seletor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 77, DateTimeKind.Local).AddTicks(8480))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seletor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 78, DateTimeKind.Local).AddTicks(2202))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtributoOption",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OptionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    AtributoId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 67, DateTimeKind.Local).AddTicks(6370))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributoOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtributoOption_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataDePagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HistoricoPagamentoId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 77, DateTimeKind.Local).AddTicks(4775))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamento_HistoricoPagamento_HistoricoPagamentoId",
                        column: x => x.HistoricoPagamentoId,
                        principalTable: "HistoricoPagamento",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeletorOption",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeletorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<byte[]>(type: "longblob", nullable: true),
                    AtributoId = table.Column<long>(type: "bigint", nullable: false),
                    SeletorId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 78, DateTimeKind.Local).AddTicks(502))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeletorOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeletorOption_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeletorOption_Seletor_SeletorId",
                        column: x => x.SeletorId,
                        principalTable: "Seletor",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    valorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 67, DateTimeKind.Local).AddTicks(8824))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favorito",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 72, DateTimeKind.Local).AddTicks(7827))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorito_Usuarios_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isDisponivel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    isEsgotado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Tag = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeletorId = table.Column<long>(type: "bigint", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CarrinhoId = table.Column<long>(type: "bigint", nullable: true),
                    FavoritoId = table.Column<long>(type: "bigint", nullable: true),
                    PagamentoId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 77, DateTimeKind.Local).AddTicks(6663))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produtos_Favorito_FavoritoId",
                        column: x => x.FavoritoId,
                        principalTable: "Favorito",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produtos_Pagamento_PagamentoId",
                        column: x => x.PagamentoId,
                        principalTable: "Pagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produtos_Seletor_SeletorId",
                        column: x => x.SeletorId,
                        principalTable: "Seletor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarrinhoProduto",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarrinhoId = table.Column<long>(type: "bigint", nullable: false),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 70, DateTimeKind.Local).AddTicks(5303))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<long>(type: "bigint", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    Stars = table.Column<short>(type: "smallint", nullable: false),
                    Message = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "DATE", nullable: false, defaultValue: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DataAtualizacao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 4, 25, 9, 20, 33, 76, DateTimeKind.Local).AddTicks(52))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_Usuarios_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoOption_AtributoId",
                table: "AtributoOption",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_CarrinhoId",
                table: "CarrinhoProduto",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_ProdutoId",
                table: "CarrinhoProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_ClienteId",
                table: "Carrinhos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorito_ClienteId",
                table: "Favorito",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ClienteId",
                table: "Feedback",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ProdutoId",
                table: "Feedback",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_HistoricoPagamentoId",
                table: "Pagamento",
                column: "HistoricoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CarrinhoId",
                table: "Produtos",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FavoritoId",
                table: "Produtos",
                column: "FavoritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PagamentoId",
                table: "Produtos",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_SeletorId",
                table: "Produtos",
                column: "SeletorId");

            migrationBuilder.CreateIndex(
                name: "IX_SeletorOption_AtributoId",
                table: "SeletorOption",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_SeletorOption_SeletorId",
                table: "SeletorOption",
                column: "SeletorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtributoOption");

            migrationBuilder.DropTable(
                name: "CarrinhoProduto");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "SeletorOption");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Atributo");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Favorito");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Seletor");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "HistoricoPagamento");
        }
    }
}
