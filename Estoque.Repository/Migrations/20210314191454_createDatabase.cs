using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estoque.Repository.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    dataDeCadastro = table.Column<DateTime>(nullable: false),
                    dataDeAlteracao = table.Column<DateTime>(nullable: false),
                    lixeira = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(maxLength: 300, nullable: true),
                    valor = table.Column<double>(nullable: false),
                    imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");
        }
    }
}
