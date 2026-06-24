using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInvoiceId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "DebtStaffs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "DebtShippings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "DebtBanks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "DebtAgents",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "AppUserGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(128)",
                oldMaxLength: 128)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "AppRoleGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(128)",
                oldMaxLength: 128)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be3faf08-c13d-4290-862a-5ef21fd19e59", "AQAAAAIAAYagAAAAEIi/H5vuaGnigd+KxS3Qd3r7D2xHgWnuO3NWOFGU/XAs+kywjxp5WH2+h7qkT+z13A==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5468), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5472), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5474), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5475), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5253), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5255), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5262), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5264), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5266), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5270), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5274), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5282), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5284), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5285), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5287), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5289), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5291), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5294), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5296), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5300), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5301), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5303), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5310), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5312), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5316), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5318), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5320), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5325), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5327), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5330), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5332), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5334), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5336), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5339), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5342), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5344), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5346), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5347), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5349), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5351), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5353), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5355), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5356), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5375), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5378), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5380), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5382), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5384), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5386), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5393), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5399), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5408), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5414), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5418), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5419), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5423), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5425), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5425) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "DebtStaffs");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "DebtShippings");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "DebtBanks");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "DebtAgents");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppUserGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AppRoleGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "951b36ee-258a-4200-a7d4-796609758d22", "AQAAAAIAAYagAAAAEAYRNm6Bb10ep5ok56XfvI/Q+EOH3Wo4svvhDLMkhIQ9tZ3KB7n+acyCpl0PocI0wg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(613), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(671), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(683), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(688), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(692), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(695), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(699), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(706), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(710), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(729), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(733), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(736), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(746), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(755), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(758), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(760), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(765), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(769), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(770), new DateTime(2024, 9, 22, 22, 51, 33, 871, DateTimeKind.Local).AddTicks(771) });
        }
    }
}
