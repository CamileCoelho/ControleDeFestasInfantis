﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteKeeper.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class ConfigInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCategoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBNota",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tema = table.Column<int>(type: "int", nullable: false),
                    Arquivada = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBNota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCategoria_TBNota",
                        column: x => x.CategoriaId,
                        principalTable: "TBCategoria",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBNota_TBCategoria_CategoriaId1",
                        column: x => x.CategoriaId1,
                        principalTable: "TBCategoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBNota_CategoriaId",
                table: "TBNota",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBNota_CategoriaId1",
                table: "TBNota",
                column: "CategoriaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBNota");

            migrationBuilder.DropTable(
                name: "TBCategoria");
        }
    }
}
