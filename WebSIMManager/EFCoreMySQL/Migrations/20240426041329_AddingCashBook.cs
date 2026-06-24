using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddingCashBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CashBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    cashActionType = table.Column<int>(type: "int", nullable: false),
                    OnApp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashBooks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "900f1d83-f476-49e0-9b9c-81936fb5d042", "AQAAAAIAAYagAAAAEDpdUR0F64B1ARyUtyXvDXmcMJLWG8dmx9If5Qc/Y6Z7kYFua7teHPSRZQCpqjSMFQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4365), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4368), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4372), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4118), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4147), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4187), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4195), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4205), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4216), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4225), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4227), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4242), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4244), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4246), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4257), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4299), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4304), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4309) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashBooks");

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
                values: new object[] { "0c25b070-32a9-4329-b164-7be36e30c2c9", "AQAAAAIAAYagAAAAEAhiNrXIPnPG2roQc1EDMAZkoqCpIsDwNUeB0f1xh+gBm77OPWkljB/Qrbq/jikGeQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1167), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1169), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(958), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(962), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(986), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(991), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(996), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(999), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1018), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1059), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1062), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1066), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1074), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1081), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1120), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1121) });
        }
    }
}
