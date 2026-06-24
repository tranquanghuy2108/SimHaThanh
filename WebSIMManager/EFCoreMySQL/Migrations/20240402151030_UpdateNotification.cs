using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_CollaboratorsGroups_CollaboratorsGroupId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_CollaboratorsGroupId",
                table: "Notifications");

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

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "SIMDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsSimData",
                table: "ProductTypes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Notifications",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CollaboratorsGroupId",
                table: "Discounts",
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
                values: new object[] { "20197f8b-73e7-4d62-b9df-f255be40b3f9", "AQAAAAIAAYagAAAAECp5cMqFtJwGOBZiv3ebdbnXHeC9GHai8bKaINmdes/qwWAb+9N4pPb8QZe6MAs1EA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4188), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3825), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3842), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3871), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3908), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3939), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3944), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3946), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3949), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3956), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3972), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3974), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4014), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4030), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4067), new DateTime(2024, 4, 2, 22, 10, 29, 679, DateTimeKind.Local).AddTicks(4068) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "IsSimData",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "CollaboratorsGroupId",
                table: "Discounts");

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

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CollaboratorsGroupId",
                table: "Notifications",
                column: "CollaboratorsGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_CollaboratorsGroups_CollaboratorsGroupId",
                table: "Notifications",
                column: "CollaboratorsGroupId",
                principalTable: "CollaboratorsGroups",
                principalColumn: "Id");
        }
    }
}
