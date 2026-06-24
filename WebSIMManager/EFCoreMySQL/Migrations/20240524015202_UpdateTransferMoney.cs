using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTransferMoney : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDebtSettlement",
                table: "DebtStaffs");

            migrationBuilder.AddColumn<int>(
                name: "TransferMoneyId",
                table: "TransferMoneys",
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
                values: new object[] { "91b02a3f-c898-4d29-8388-26ff45f4412a", "AQAAAAIAAYagAAAAELxTpt/Bdgsz7tLs9u1iZCGCFZCxRPXBcz4DYXTD2ngUeYu5D5iMSF2BFQ15m7VD1g==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5315), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5319), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5101), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5116), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5120), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5123), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5134), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5147), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5166), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5182), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5226), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5228), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5230), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5232), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5246), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5251), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5255), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5257) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferMoneyId",
                table: "TransferMoneys");

            migrationBuilder.AddColumn<bool>(
                name: "IsDebtSettlement",
                table: "DebtStaffs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                values: new object[] { "f225b089-c102-43ee-b9e5-fa50aa6dc1a1", "AQAAAAIAAYagAAAAEHAZbkHV51tEJlMNIoVXQQflGuK1PEHrUnzzJwVEsDcowzTVo7zg4etFXLeATU2hAg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7231), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7238), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7003), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7041), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7049), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7139), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7141), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 5, 23, 0, 11, 9, 768, DateTimeKind.Local).AddTicks(7181) });
        }
    }
}
