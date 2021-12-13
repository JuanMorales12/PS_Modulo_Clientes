using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "NumeroCelular",
                table: "Cliente",
                type: "bigint",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumeroCelular",
                table: "Cliente",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 20);
        }
    }
}
