using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class changeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,3)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 4, 14, 27, 50, 709, DateTimeKind.Local).AddTicks(4393));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(15,3)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8976), new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 10, 22, 32, 126, DateTimeKind.Local).AddTicks(9131));
        }
    }
}
