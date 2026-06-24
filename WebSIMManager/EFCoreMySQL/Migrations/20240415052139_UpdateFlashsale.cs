using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFlashsale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SIMOnFlashSales_FlashSales_FlashSaleId",
                table: "SIMOnFlashSales");

            migrationBuilder.DropForeignKey(
                name: "FK_SIMOnFlashSales_SIMDetails_SimId",
                table: "SIMOnFlashSales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SIMOnFlashSales",
                table: "SIMOnFlashSales");

            migrationBuilder.DropIndex(
                name: "IX_SIMOnFlashSales_FlashSaleId",
                table: "SIMOnFlashSales");

            migrationBuilder.AlterColumn<int>(
                name: "FlashSaleId",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "SimId",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "SimNumber",
                table: "SIMOnFlashSales",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "SimPrice",
                table: "SIMOnFlashSales",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FlashSales",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FlashSales",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_SIMOnFlashSales",
                table: "SIMOnFlashSales",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SIMOnFlashSales",
                table: "SIMOnFlashSales");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SIMOnFlashSales");

            migrationBuilder.DropColumn(
                name: "SimNumber",
                table: "SIMOnFlashSales");

            migrationBuilder.DropColumn(
                name: "SimPrice",
                table: "SIMOnFlashSales");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FlashSales");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FlashSales");

            migrationBuilder.AlterColumn<int>(
                name: "SimId",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "FlashSaleId",
                table: "SIMOnFlashSales",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_SIMOnFlashSales",
                table: "SIMOnFlashSales",
                columns: new[] { "SimId", "FlashSaleId" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd7b64e1-563a-4f8a-bf56-2ec642f509e1", "AQAAAAIAAYagAAAAEIEVtLLPNX2qBlEuK2CXFK/kzdpMY21IkPEWkE40WplYNXILj9y+N1+6j0FDvwR90Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6958), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6962), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6966), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6969), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7004), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7046), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.CreateIndex(
                name: "IX_SIMOnFlashSales_FlashSaleId",
                table: "SIMOnFlashSales",
                column: "FlashSaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SIMOnFlashSales_FlashSales_FlashSaleId",
                table: "SIMOnFlashSales",
                column: "FlashSaleId",
                principalTable: "FlashSales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SIMOnFlashSales_SIMDetails_SimId",
                table: "SIMOnFlashSales",
                column: "SimId",
                principalTable: "SIMDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
