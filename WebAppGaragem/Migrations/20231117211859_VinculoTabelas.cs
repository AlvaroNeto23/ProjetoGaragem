using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppGaragem.Migrations
{
    public partial class VinculoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormaPagamentoCodigo",
                table: "Passagens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormaPagamentoCodigo1",
                table: "Passagens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GaragemCodigo",
                table: "Passagens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GaragemCodigo1",
                table: "Passagens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_FormaPagamentoCodigo1",
                table: "Passagens",
                column: "FormaPagamentoCodigo1");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_GaragemCodigo1",
                table: "Passagens",
                column: "GaragemCodigo1");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagens_FormasPagamento_FormaPagamentoCodigo1",
                table: "Passagens",
                column: "FormaPagamentoCodigo1",
                principalTable: "FormasPagamento",
                principalColumn: "Codigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagens_Garagens_GaragemCodigo1",
                table: "Passagens",
                column: "GaragemCodigo1",
                principalTable: "Garagens",
                principalColumn: "Codigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagens_FormasPagamento_FormaPagamentoCodigo1",
                table: "Passagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Passagens_Garagens_GaragemCodigo1",
                table: "Passagens");

            migrationBuilder.DropIndex(
                name: "IX_Passagens_FormaPagamentoCodigo1",
                table: "Passagens");

            migrationBuilder.DropIndex(
                name: "IX_Passagens_GaragemCodigo1",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "FormaPagamentoCodigo",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "FormaPagamentoCodigo1",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "GaragemCodigo",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "GaragemCodigo1",
                table: "Passagens");
        }
    }
}
