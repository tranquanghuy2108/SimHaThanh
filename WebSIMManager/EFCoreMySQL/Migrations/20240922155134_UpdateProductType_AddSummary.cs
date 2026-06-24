using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductType_AddSummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "ProductTypes",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "ProductTypes");

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
                values: new object[] { "5d759b09-cc5e-4aff-be87-abbae4a2a670", "AQAAAAIAAYagAAAAEMmS0XBH7f2EK8ofS581pT0v5LiB1Ga/UwmW6Duzz8H2JPciKU83mY1cwByZ4zbe8Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2714), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2716), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2718), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2471), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2488), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2495), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2499), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2501), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2502), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2504), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2538), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2543), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2546), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2553), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2556), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2563), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2565), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2582), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2586), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2596), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2600), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2603), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2606), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2612), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2613), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2615), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2617), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2636), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2638), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2644), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2649), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2651), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2654), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2656), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2658), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2659), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2663), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2665), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2668), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 9, 22, 22, 24, 28, 540, DateTimeKind.Local).AddTicks(2671) });
        }
    }
}
