using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.PartidoId);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    PlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePlan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descuento = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    PrecioPlan = table.Column<double>(type: "float", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    NumeroCelular = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contraseña = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "PartidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    TurnoId = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.HistoriaClinicaId);
                    table.ForeignKey(
                        name: "FK_HistoriaClinica_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "PartidoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Berazategui" },
                    { 2, "Florencio Varela" },
                    { 3, "Quilmes" }
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "PlanId", "Descripcion", "Descuento", "NombrePlan", "PrecioPlan" },
                values: new object[,]
                {
                    { 1, "Descuento del 15% en especialidades comunes", 15.0, "Basico", 1500.0 },
                    { 2, "Descuento del 35% en todo tipo de especialidades", 35.0, "Premium", 3500.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PartidoId",
                table: "Cliente",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PlanId",
                table: "Cliente",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinica_ClienteId",
                table: "HistoriaClinica",
                column: "ClienteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriaClinica");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DropTable(
                name: "Plan");
        }
    }
}
