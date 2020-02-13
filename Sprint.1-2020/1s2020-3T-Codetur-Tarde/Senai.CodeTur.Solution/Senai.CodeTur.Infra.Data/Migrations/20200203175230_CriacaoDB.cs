using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    public partial class CriacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(3000)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    Pais = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Oferta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Senha = table.Column<string>(name: "Senha ", type: "varchar(20)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pacotes",
                columns: new[] { "Id", "Ativo", "DataFim", "DataInicio", "Descricao", "Imagem", "Oferta", "Pais", "Titulo" },
                values: new object[] { 1, true, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Um tour feito passando pela maioria dos paises europeus, que abrangera grandes polos de tecnologia mundial", "https://www.passagenspromo.com.br/blog/wp-content/uploads/2019/05/tour-pela-europa-740x415.jpg", false, "Portugal, Espanha, França, Italia, Grecia, Inglaterra", "Tour Europa" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Senha ", "Tipo" },
                values: new object[] { 1, "fernando.guerra@sp.senai.br", "senai132", "Adm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
