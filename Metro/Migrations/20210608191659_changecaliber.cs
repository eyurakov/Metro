using Microsoft.EntityFrameworkCore.Migrations;

namespace Metro.Migrations
{
    public partial class changecaliber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Caliber",
                table: "Weapon",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Caliber",
                table: "Weapon",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
