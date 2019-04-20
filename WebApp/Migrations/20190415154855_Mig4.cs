using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NFCScans",
                table: "NFCScans");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "NFCScans");

            migrationBuilder.AlterColumn<long>(
                name: "TimeStamp",
                table: "NFCScans",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "ScanID",
                table: "NFCScans",
                nullable: false,
                defaultValue: 0L)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "StudId",
                table: "NFCScans",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NFCScans",
                table: "NFCScans",
                column: "ScanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NFCScans",
                table: "NFCScans");

            migrationBuilder.DropColumn(
                name: "ScanID",
                table: "NFCScans");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "NFCScans");

            migrationBuilder.AlterColumn<long>(
                name: "TimeStamp",
                table: "NFCScans",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "NFCScans",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NFCScans",
                table: "NFCScans",
                column: "TimeStamp");
        }
    }
}
