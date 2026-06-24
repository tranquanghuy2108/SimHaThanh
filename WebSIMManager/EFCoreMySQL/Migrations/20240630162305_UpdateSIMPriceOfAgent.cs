using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSIMPriceOfAgent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OriginalSIMPrice",
                table: "SIMDetails",
                newName: "SIMPriceOfAgent");

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
                values: new object[] { "b209ff48-9a2e-484f-befe-f1c45d91e4e4", "AQAAAAIAAYagAAAAEB1tqJKcopRqXU0yCeMFeD6NFRG3WrB9X+UsPkH/mbYLYLVP124him+7tv8aKlN8iA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9253), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9048), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9078), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9083), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9087), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9102), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9105), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9107), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9112), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9118), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9191), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9193), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9196), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9206) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIMPriceOfAgent",
                table: "SIMDetails",
                newName: "OriginalSIMPrice");

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
                values: new object[] { "908a78eb-47ab-4f00-b04c-a59ae1cdfb84", "AQAAAAIAAYagAAAAEB4rwZEhcvSSugROh2rVzuKyWzrb1TBeNMHETbCrONWaZQEm6FaQC7rl64MjvnDitg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6668), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6676), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6679), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6681), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6715), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6722), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6724), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6727), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6729), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6732), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6798), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6823) });
        }
    }
}
