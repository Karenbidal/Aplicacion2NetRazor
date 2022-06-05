using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion2NetRazor.Migrations
{
    public partial class Migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Curso",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    idAlumno = table.Column<int>(type : "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_nac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cant_cursos = table.Column<int>(type: "int", nullable: false),
                    Fecha_egr = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.idAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    idProf = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Esp = table.Column<int>(type: "int", nullable: false),
                    Fecha_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_nac = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.idProf);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Curso",
                newName: "id");
        }
    }
}
