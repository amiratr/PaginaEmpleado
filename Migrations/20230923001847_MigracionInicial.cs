using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practicaEmpleado.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bono",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BonoTra = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bono", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CI = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SueldoBasico = table.Column<double>(type: "float", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasTrabajadas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bono");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
