using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Debts");

            migrationBuilder.DropColumn(
                name: "ShippingId",
                table: "Debts");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Debts");

            migrationBuilder.AlterColumn<Guid>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(250)",
                maxLength: 250,
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "DebtStaffs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "DebtShippings",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Debts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "DebtBanks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "DebtAgents",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
                values: new object[] { "bb6e1024-b33c-4164-a971-a6700889134e", "AQAAAAIAAYagAAAAENCIE2TlvTXKtBAF4lDAYsQYp6Jg2FIX99ZFpOziREsVlDojWtWuuMiMACzBiZ27AA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8869), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8871), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8873), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8582), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8780), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8791) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "DebtStaffs");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "DebtShippings");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Debts");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "DebtBanks");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "DebtAgents");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "BankId",
                table: "Debts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ShippingId",
                table: "Debts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "Debts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

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
                values: new object[] { "33cd39d6-d7f1-4b2b-8039-18e6d05187b1", "AQAAAAIAAYagAAAAEKsi5BBUuXU+mVhHVJu38gGbUAX7RWe5jjuw2+J0WAishPACGdtrubvIwv1dhfe6+Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7228), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7237), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7239), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7242), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7250), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7256), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7263), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7274), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7279), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7293), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7294) });
        }
    }
}
