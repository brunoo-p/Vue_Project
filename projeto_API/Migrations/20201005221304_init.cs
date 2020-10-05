﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataNasc = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Leda" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Márcia" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Contato", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 1, "(45) 91234-5678", "01/02/2003", "Bruno", 1, "Paulino" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Contato", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 3, "(45) 91101-1215", "21/07/2014", "Maria", 2, "Das Dores" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Contato", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 4, "(45) 98765-4321", "01/05/1993", "Zé", 2, "Benedito" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Contato", "DataNasc", "Nome", "ProfessorId", "Sobrenome" },
                values: new object[] { 2, "(45) 92468-1012", "22/11/2008", "João", 3, "Sem Braço" });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ProfessorId",
                table: "Alunos",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
