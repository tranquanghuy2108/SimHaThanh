using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class HandleSimTraGop3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionSimPrices");

            migrationBuilder.DropColumn(
                name: "AuctionSimPriceId",
                table: "AuctionUserBidding");

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
                name: "UserName",
                table: "AuctionUserBidding",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "AuctionPrice",
                table: "Auctions",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Auctions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Auctions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "SimId",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SimNumber",
                table: "Auctions",
                type: "longtext",
                nullable: false)
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
                values: new object[] { "56758305-e0af-41f5-9530-11fa092a2292", "AQAAAAIAAYagAAAAEOmtMShqIrc/ni3F6l+aEQQ/xT+1birydAMQvg/j27SHnCVWpaS5WG1LlFQFWi5yrQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(635), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(661), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(682), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(684), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(698), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(700), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(711), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(755), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(759), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(766), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(770), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(775), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(777), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(801), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 3, 31, 17, 20, 33, 151, DateTimeKind.Local).AddTicks(806) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AuctionUserBidding");

            migrationBuilder.DropColumn(
                name: "AuctionPrice",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "SimId",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "SimNumber",
                table: "Auctions");

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

            migrationBuilder.AddColumn<int>(
                name: "AuctionSimPriceId",
                table: "AuctionUserBidding",
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

            migrationBuilder.CreateTable(
                name: "AuctionSimPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MinPrice = table.Column<double>(type: "double", nullable: false),
                    SimId = table.Column<int>(type: "int", nullable: false),
                    SimNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSimPrices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
