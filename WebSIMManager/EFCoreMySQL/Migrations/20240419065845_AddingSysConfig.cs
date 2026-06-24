using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddingSysConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AskSim_AskingTime",
                table: "SystemConfigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AskSim_SimNumber",
                table: "SystemConfigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Auction_WaitingTime",
                table: "SystemConfigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivedDate",
                table: "GoodsReceivedNotes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "GoodsDeliveryNotes",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "GoodsDeliveryNoteOfSims",
                type: "datetime(6)",
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
                values: new object[] { "91b885f9-ccd1-486e-bafd-775747bcea42", "AQAAAAIAAYagAAAAEDbO7qjSTucnvlfAUhljg06K5duHa9rFJ+S93cJmVKmPHhKM8yiZdGv5zByh2QcIYA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6433), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6201), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6209), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6231), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6244), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6293), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6317), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6327), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6338), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6347), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6351), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6358), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6368), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6368) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AskSim_AskingTime",
                table: "SystemConfigs");

            migrationBuilder.DropColumn(
                name: "AskSim_SimNumber",
                table: "SystemConfigs");

            migrationBuilder.DropColumn(
                name: "Auction_WaitingTime",
                table: "SystemConfigs");

            migrationBuilder.DropColumn(
                name: "ReceivedDate",
                table: "GoodsReceivedNotes");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "GoodsDeliveryNoteOfSims");

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
                values: new object[] { "061df37e-a29a-4a17-9c1e-8b73f89dadec", "AQAAAAIAAYagAAAAEJhHNQERuA+n1P3ab1varBNRiktgyndJdhBNF0lzQSkoF5RWkRRRA/ocUmHXM6wiSw==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4347), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4355), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4357), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4112), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4116), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4118), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4122), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4147), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4151), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4161), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4163), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4173), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4184), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4192), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4194), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4198), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4202), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4224), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4226), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4237), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4239), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4241), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4243), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4257), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4291), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 4, 15, 16, 8, 2, 115, DateTimeKind.Local).AddTicks(4296) });
        }
    }
}
