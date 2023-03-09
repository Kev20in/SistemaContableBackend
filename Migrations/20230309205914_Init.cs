using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APEC.ProyectoFinal.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SistemaAuxiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaAuxiliares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuentaContables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuentaContables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoMonedas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaTasaCambiara = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMonedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentaContables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermiteTransaciones = table.Column<bool>(type: "bit", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    CuentaMayor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    TipoCuentaContableId = table.Column<int>(type: "int", nullable: false),
                    TipoMonedaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaContables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentaContables_TipoCuentaContables_TipoCuentaContableId",
                        column: x => x.TipoCuentaContableId,
                        principalTable: "TipoCuentaContables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuentaContables_TipoMonedas_TipoMonedaId",
                        column: x => x.TipoMonedaId,
                        principalTable: "TipoMonedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntradaContables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SistemaAuxiliaresId = table.Column<int>(type: "int", nullable: false),
                    CuentaContableId = table.Column<int>(type: "int", nullable: false),
                    FechaAsiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoAsiento = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaContables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradaContables_CuentaContables_CuentaContableId",
                        column: x => x.CuentaContableId,
                        principalTable: "CuentaContables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntradaContables_SistemaAuxiliares_SistemaAuxiliaresId",
                        column: x => x.SistemaAuxiliaresId,
                        principalTable: "SistemaAuxiliares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentaContables_TipoCuentaContableId",
                table: "CuentaContables",
                column: "TipoCuentaContableId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaContables_TipoMonedaId",
                table: "CuentaContables",
                column: "TipoMonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaContables_CuentaContableId",
                table: "EntradaContables",
                column: "CuentaContableId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaContables_SistemaAuxiliaresId",
                table: "EntradaContables",
                column: "SistemaAuxiliaresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradaContables");

            migrationBuilder.DropTable(
                name: "CuentaContables");

            migrationBuilder.DropTable(
                name: "SistemaAuxiliares");

            migrationBuilder.DropTable(
                name: "TipoCuentaContables");

            migrationBuilder.DropTable(
                name: "TipoMonedas");
        }
    }
}
