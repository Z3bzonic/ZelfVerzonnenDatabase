using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZelfVerzonnenDatabase.DAL.Migrations
{
    public partial class AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_AddressId",
                table: "Teacher",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_AddressId",
                table: "Student",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Address_AddressId",
                table: "Student",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Address_AddressId",
                table: "Teacher",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Address_AddressId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Address_AddressId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_AddressId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Student_AddressId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Student");
        }
    }
}
