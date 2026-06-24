using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSimOnFlashsale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetworkId",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetworkId",
                table: "SIMOnFlashSales");

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
                values: new object[] { "170f0f13-ecfc-4658-adb1-9e2494cc12ff", "AQAAAAIAAYagAAAAEAsjfmTFiA8MRFO1J9iUhb0wuZ9ktzSA2qkPQp4p4hXtZYCWVNfjC1b8LaZLjiST/Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4196), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4198), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4202), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4210), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4212), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3988), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4010), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4014), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4022), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4029), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4064), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4083), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4085), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4087), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4089), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4107), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4121), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4123), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4125), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4135), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4145), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4147), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 4, 15, 12, 21, 38, 759, DateTimeKind.Local).AddTicks(4153) });
        }
    }
}
