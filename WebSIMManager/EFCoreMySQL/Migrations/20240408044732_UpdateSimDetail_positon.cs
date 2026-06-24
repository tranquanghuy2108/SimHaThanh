using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSimDetail_positon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "SIMDetails",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "SIMDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
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
                values: new object[] { "13269e0f-f2a9-41dc-bc87-028d3465bfef", "AQAAAAIAAYagAAAAEJntIhB1jjF6NNaGUY05VyQsemv9OEGiMUogR9hJIRk+LLA3E+tEMai3mQH/n5egrg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(76), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9846), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9850), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9854), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9867), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9875), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9879), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9935), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9942), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9961), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9978), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 796, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(9), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 4, 4, 22, 58, 48, 797, DateTimeKind.Local).AddTicks(13) });
        }
    }
}
