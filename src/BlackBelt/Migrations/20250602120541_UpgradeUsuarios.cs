using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faixas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faixas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Tipo_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Id_Faixa = table.Column<int>(type: "int", nullable: false),
                    Dt_Matricula = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Faixas_Id_Faixa",
                        column: x => x.Id_Faixa,
                        principalTable: "Faixas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Usuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Instrutor = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Usuarios_Id_Instrutor",
                        column: x => x.Id_Instrutor,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadesAluno",
                columns: table => new
                {
                    Id_Aluno = table.Column<int>(type: "int", nullable: false),
                    Id_Habilidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HabilidadesAluno_Alunos_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabilidadesAluno_Habilidades_Id_Habilidade",
                        column: x => x.Id_Habilidade,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressosGerais",
                columns: table => new
                {
                    Id_Aluno = table.Column<int>(type: "int", nullable: false),
                    Dt_Avaliacao = table.Column<DateOnly>(type: "date", nullable: false),
                    DesempenhoMedio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ProgressosGerais_Alunos_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Turma = table.Column<int>(type: "int", nullable: false),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false),
                    Dt_Aula = table.Column<DateOnly>(type: "date", nullable: false),
                    Presenca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aulas_Alunos_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aulas_Turmas_Id_Turma",
                        column: x => x.Id_Turma,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Id_Faixa",
                table: "Alunos",
                column: "Id_Faixa");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_Id_Aluno",
                table: "Aulas",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_Id_Turma",
                table: "Aulas",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesAluno_Id_Aluno",
                table: "HabilidadesAluno",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesAluno_Id_Habilidade",
                table: "HabilidadesAluno",
                column: "Id_Habilidade");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Id_Usuario",
                table: "Logins",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressosGerais_Id_Aluno",
                table: "ProgressosGerais",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_Id_Instrutor",
                table: "Turmas",
                column: "Id_Instrutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "HabilidadesAluno");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "ProgressosGerais");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Faixas");
        }
    }
}
