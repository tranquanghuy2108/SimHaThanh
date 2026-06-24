using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSPContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupportContactType",
                table: "SupportContacts");

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "SupportContacts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SupportContacts",
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
                values: new object[] { "33c2ac60-14ff-4afc-9213-cb5320c8c8df", "AQAAAAIAAYagAAAAEPyKibyBeQJeZRsAiHMc9pGiwpT1l67KN+KY9URJVV50ZyqeuMyIcE5P09r2lTZJBQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6923), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6932), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6068), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6106), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6109), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6121), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6124), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6578), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6582), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6585), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6587), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6594), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6598), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6609), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6637), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6642), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6648), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6658), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6665), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6694), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6699) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "SupportContacts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SupportContacts");

            migrationBuilder.AddColumn<int>(
                name: "SupportContactType",
                table: "SupportContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                values: new object[] { "7edb4296-ab47-4e91-b614-4da2d17c66b7", "AQAAAAIAAYagAAAAEJvvJUWGihc0kXqet22D7TeYuWO3nInuTWQ/U3t4yplRbY3w87QrOgk2Qfks5jsq8Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2923), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2654), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2685), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2690), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2696), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2702), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2707), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2709), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2711), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2713), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2715), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2717), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2721), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2723), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2729), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2733), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2735), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2737), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2741), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2744), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2746), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2748), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2753), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2762), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2764), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2766), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2768), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2770), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2776), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2796), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2798), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2802), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2804), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2806), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2808), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2810), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2814), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2820), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2822), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2834), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2842), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2858), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2862), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 4, 8, 11, 47, 32, 689, DateTimeKind.Local).AddTicks(2867) });
        }
    }
}
