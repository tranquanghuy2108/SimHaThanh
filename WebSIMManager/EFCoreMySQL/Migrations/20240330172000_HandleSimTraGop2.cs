using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class HandleSimTraGop2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "DateOfPayment",
                table: "GoodsDeliveryNoteOfSims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DownPayment",
                table: "GoodsDeliveryNoteOfSims",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "InstallmentEndDate",
                table: "GoodsDeliveryNoteOfSims",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "InstallmentPayment",
                table: "GoodsDeliveryNoteOfSims",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "InstallmentPeriod",
                table: "GoodsDeliveryNoteOfSims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "InterestRate",
                table: "GoodsDeliveryNoteOfSims",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyInstallmentPayment",
                table: "GoodsDeliveryNoteOfSims",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

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
                values: new object[] { "e9fc2e6c-d015-45ed-911b-4d985b7f29e0", "AQAAAAIAAYagAAAAEGXtqco+ZMiGa5pIhsYcnwQaPtOHjxrE1rpEEb9GAP5onINYYc26nolfwHhKrrdi4g==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7979), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7995), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7739), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7762), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7767), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7773), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7774), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7776), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7789), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7794), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7798), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7804), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7806), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7809), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7815), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7820), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7836), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7838), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7848), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7852), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7857), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7859), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7869), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7875), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7877), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7879), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7885), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7892), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7894), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7896), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7898), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7900), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7902), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7911), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7913), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7915), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7926), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7930), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7932), new DateTime(2024, 3, 31, 0, 20, 0, 516, DateTimeKind.Local).AddTicks(7932) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfPayment",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "DownPayment",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "InstallmentEndDate",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "InstallmentPayment",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "InstallmentPeriod",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "InterestRate",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropColumn(
                name: "MonthlyInstallmentPayment",
                table: "GoodsDeliveryNoteOfSims");

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
                values: new object[] { "e64469da-bcf3-4830-9916-cdd3f263208c", "AQAAAAIAAYagAAAAEGCm1Kdc5Ii0vqXjs8SzZTLdLC/vWGMrNxoOt+EwOhRfF80z5oyKTUnb03DIg6jWEg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4560), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4569), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4712), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4730), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4742) });
        }
    }
}
