using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForSimPhongThuy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "amDuongTuongSinh",
                table: "SIMDetails",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nguHanhSim",
                table: "SIMDetails",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nguHanhTuongSinh",
                table: "SIMDetails",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<float>(
                name: "point",
                table: "SIMDetails",
                type: "float",
                nullable: false,
                defaultValue: 0f);

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
                values: new object[] { "a976e6f3-57be-420c-af6e-bd8652a698e9", "AQAAAAIAAYagAAAAEPdz2dRES9iUFIgALCGjVTOKlntl+YgHrE5yJb4Rr/TNcmHqGrMCxj5PK687vk5HSA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8473), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8191), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8198), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8207), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8218), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8221), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8229), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8251), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8258), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8262), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8265), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8271), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8289), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8332), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8352), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8379) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amDuongTuongSinh",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "nguHanhSim",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "nguHanhTuongSinh",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "point",
                table: "SIMDetails");

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
                values: new object[] { "bb6e1024-b33c-4164-a971-a6700889134e", "AQAAAAIAAYagAAAAENCIE2TlvTXKtBAF4lDAYsQYp6Jg2FIX99ZFpOziREsVlDojWtWuuMiMACzBiZ27AA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8869), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8871), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8873), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8582), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8642), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8674), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8780), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 3, 13, 18, 38, 47, 711, DateTimeKind.Local).AddTicks(8791) });
        }
    }
}
