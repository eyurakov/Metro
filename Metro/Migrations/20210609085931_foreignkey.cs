using Microsoft.EntityFrameworkCore.Migrations;

namespace Metro.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Human_Position_PositionId",
                table: "Human");

            migrationBuilder.DropForeignKey(
                name: "FK_Human_Station_StationId",
                table: "Human");

            migrationBuilder.DropForeignKey(
                name: "FK_Human_Weapon_WeaponId",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_PositionId",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_StationId",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_WeaponId",
                table: "Human");

            migrationBuilder.AlterColumn<byte>(
                name: "WeaponId",
                table: "Human",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "StationId",
                table: "Human",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "PositionId",
                table: "Human",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PositionId1",
                table: "Human",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationId1",
                table: "Human",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId1",
                table: "Human",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Human_PositionId1",
                table: "Human",
                column: "PositionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Human_StationId1",
                table: "Human",
                column: "StationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Human_WeaponId1",
                table: "Human",
                column: "WeaponId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Position_PositionId1",
                table: "Human",
                column: "PositionId1",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Station_StationId1",
                table: "Human",
                column: "StationId1",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Weapon_WeaponId1",
                table: "Human",
                column: "WeaponId1",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Human_Position_PositionId1",
                table: "Human");

            migrationBuilder.DropForeignKey(
                name: "FK_Human_Station_StationId1",
                table: "Human");

            migrationBuilder.DropForeignKey(
                name: "FK_Human_Weapon_WeaponId1",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_PositionId1",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_StationId1",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_WeaponId1",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "PositionId1",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "StationId1",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "WeaponId1",
                table: "Human");

            migrationBuilder.AlterColumn<int>(
                name: "WeaponId",
                table: "Human",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "StationId",
                table: "Human",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Human",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.CreateIndex(
                name: "IX_Human_PositionId",
                table: "Human",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Human_StationId",
                table: "Human",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_Human_WeaponId",
                table: "Human",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Position_PositionId",
                table: "Human",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Station_StationId",
                table: "Human",
                column: "StationId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Weapon_WeaponId",
                table: "Human",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
