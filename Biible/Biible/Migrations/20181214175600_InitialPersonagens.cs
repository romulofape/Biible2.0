using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biible.Migrations
{
    public partial class InitialPersonagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Ano_Inicio = table.Column<int>(nullable: false),
                    Ano_Fim = table.Column<int>(nullable: false),
                    Ano_Inicio_Incerto = table.Column<bool>(nullable: false),
                    Ano_Fim_Incerto = table.Column<bool>(nullable: false),
                    Ano_Inicio_AcDc = table.Column<bool>(nullable: false),
                    Ano_Fim_AcDc = table.Column<bool>(nullable: false),
                    Curtida = table.Column<int>(nullable: false),
                    Foto = table.Column<byte>(nullable: false),
                    Usuario_Cadastro = table.Column<string>(nullable: true),
                    Etnia = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curiosidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Curtida = table.Column<int>(nullable: false),
                    PersonagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curiosidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curiosidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genealogias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    IdPersonagem1 = table.Column<int>(nullable: false),
                    IdPersonagem2 = table.Column<int>(nullable: false),
                    PersonagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genealogias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genealogias_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Outros_Nomes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    PersonagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outros_Nomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Outros_Nomes_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PersonagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referencias_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data_Cadastro = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    PersonagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regioes_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passages_Biblicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Livro = table.Column<int>(nullable: false),
                    Capitulo = table.Column<int>(nullable: false),
                    Versiculo = table.Column<int>(nullable: false),
                    CuriosidadeId = table.Column<int>(nullable: true),
                    GenealogiaId = table.Column<int>(nullable: true),
                    Outro_NomeId = table.Column<int>(nullable: true),
                    RegiaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passages_Biblicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passages_Biblicas_Curiosidades_CuriosidadeId",
                        column: x => x.CuriosidadeId,
                        principalTable: "Curiosidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passages_Biblicas_Genealogias_GenealogiaId",
                        column: x => x.GenealogiaId,
                        principalTable: "Genealogias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passages_Biblicas_Outros_Nomes_Outro_NomeId",
                        column: x => x.Outro_NomeId,
                        principalTable: "Outros_Nomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passages_Biblicas_Regioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regioes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curiosidades_PersonagemId",
                table: "Curiosidades",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Genealogias_PersonagemId",
                table: "Genealogias",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Outros_Nomes_PersonagemId",
                table: "Outros_Nomes",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Passages_Biblicas_CuriosidadeId",
                table: "Passages_Biblicas",
                column: "CuriosidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Passages_Biblicas_GenealogiaId",
                table: "Passages_Biblicas",
                column: "GenealogiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Passages_Biblicas_Outro_NomeId",
                table: "Passages_Biblicas",
                column: "Outro_NomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Passages_Biblicas_RegiaoId",
                table: "Passages_Biblicas",
                column: "RegiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Referencias_PersonagemId",
                table: "Referencias",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_PersonagemId",
                table: "Regioes",
                column: "PersonagemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passages_Biblicas");

            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "Curiosidades");

            migrationBuilder.DropTable(
                name: "Genealogias");

            migrationBuilder.DropTable(
                name: "Outros_Nomes");

            migrationBuilder.DropTable(
                name: "Regioes");

            migrationBuilder.DropTable(
                name: "Personagens");
        }
    }
}
