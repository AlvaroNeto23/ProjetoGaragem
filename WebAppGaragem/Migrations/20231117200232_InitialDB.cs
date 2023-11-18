using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppGaragem.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormasPagamento",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamento", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Garagens",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Preco_1aHora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Preco_HorasExtra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Preco_Mensalista = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garagens", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarroPlaca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CarroMarca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CarroModelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataHoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormasPagamento");

            migrationBuilder.DropTable(
                name: "Garagens");

            migrationBuilder.DropTable(
                name: "Passagens");
        }
    }
}
