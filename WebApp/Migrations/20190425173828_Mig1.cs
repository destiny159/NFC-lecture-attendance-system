using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "Devices",
                nullable: false,
                defaultValue: 9999,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "21dfb814-73a2-4cca-b3cf-d0e0f0f73241");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "33cb247d-bb3f-4c88-9d5a-f9010a1abfef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "2518b0ff-44fc-4df4-a7cd-bb06b930ae3f");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "ClassroomId", "DeviceIdReal" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 5, 2 },
                    { 3, 13, 3 },
                    { 4, 9999, 4 },
                    { 5, 9999, 5 },
                    { 6, 9999, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "Devices",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 9999);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "b995146c-2f95-4102-a34e-84925468e391");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "735897fe-eca2-47ba-a7f6-8bd2ce752f7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "3a9e380e-f1dc-445c-a758-cdb71cedcaad");
        }
    }
}
