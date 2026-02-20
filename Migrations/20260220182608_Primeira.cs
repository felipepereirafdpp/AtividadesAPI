using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtividadesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carterinhas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rm = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    UrlFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    DataVencimento = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carterinhas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rgs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrlFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomeMae = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: true),
                    OrgaoExpedidor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FatorRH = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Naturilidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rgs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carterinhas");

            migrationBuilder.DropTable(
                name: "Rgs");
        }
    }
}
