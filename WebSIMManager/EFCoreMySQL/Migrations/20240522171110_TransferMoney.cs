using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class TransferMoney : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransferMoneyId",
                table: "DebtStaffs",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferMoneyId",
                table: "DebtStaffs");

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
                values: new object[] { "17851f3c-7f9f-4f96-b1ab-6f0024ba375d", "AQAAAAIAAYagAAAAEBH67h4sFHk7/CQsCXD2qbj/PgB4tLBracd5S6WHc+PHzIpfttVtlHG5EQfr8u58DA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7621), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7623), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7438), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7445), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7466), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7471), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7528), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7532), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7537), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7547), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7551), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7567), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7571), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7578), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7579) });
        }
    }
}
