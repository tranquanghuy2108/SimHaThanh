using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatebranchOfBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "Banks",
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
                values: new object[] { "31753692-8284-4cb8-9ac7-b43a62296c8a", "AQAAAAIAAYagAAAAEHAkVGAMh3fOF6/rkW1pY4BCoS9FBCqgWwkmftTymUDgGsVgqR7oS9Gglh5Eir1O6g==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3985), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4030), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4064), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4076), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4086), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4122), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4169) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Banks");

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
                values: new object[] { "de773d5d-4a24-4104-b666-b971038c45f6", "AQAAAAIAAYagAAAAEFFe9z4xOOtGoctPJ+9wj6BAnwoXGTcM+zWPJNASW17RRjgvlnURSvbZ42plFlkgug==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9835), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9881), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9902), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9943), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(11), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(25) });
        }
    }
}
