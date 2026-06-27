using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwabhimanHealthcareCMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifycentermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Centers_CenterId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Vendor",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CenterId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Center",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Block",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Centers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Pincode",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Centers_CenterId",
                table: "Customers",
                column: "CenterId",
                principalTable: "Centers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Centers_CenterId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Center",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Centers");

            migrationBuilder.AlterColumn<string>(
                name: "Vendor",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CenterId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Centers_CenterId",
                table: "Customers",
                column: "CenterId",
                principalTable: "Centers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
