using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductTypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductTypes",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                values: new object[] { "f15f3389-685f-4a3c-b9e5-1ed3160e4eff", "AQAAAAIAAYagAAAAEIzr9J6G0x+f4rfuONsYdIAbNxVxLYdgyWgH1M7X3p1kWoiLPr4x0ELKHsAL/cBlAw==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6132), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6134), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6136), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6139), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5953), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5963), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5980), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5994), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5998), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6004), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6008), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6016), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6018), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6021), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6026), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6034), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6036), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6041), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6058), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6067), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6091) });
        }
    }
}
