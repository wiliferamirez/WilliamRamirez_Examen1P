using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WilliamRamirez_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class WR_sub18db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WR_Sub18",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WR_nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WR_apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WR_edad = table.Column<int>(type: "int", nullable: false),
                    WR_dorsal = table.Column<int>(type: "int", nullable: false),
                    WR_activo = table.Column<bool>(type: "bit", nullable: false),
                    WR_fechaInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WR_sueldo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WR_Sub18", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WR_Sub18");
        }
    }
}
