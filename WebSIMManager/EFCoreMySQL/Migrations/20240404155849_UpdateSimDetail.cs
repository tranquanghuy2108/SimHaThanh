using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSimDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollaboratorsGroupDiscounts");

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

            migrationBuilder.AddColumn<bool>(
                name: "IsMySim",
                table: "SIMDetails",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMySim",
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

            migrationBuilder.CreateTable(
                name: "CollaboratorsGroupDiscounts",
                columns: table => new
                {
                    CollaboratorsGroupId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorsGroupDiscounts", x => new { x.CollaboratorsGroupId, x.DiscountId });
                    table.ForeignKey(
                        name: "FK_CollaboratorsGroupDiscounts_CollaboratorsGroups_Collaborator~",
                        column: x => x.CollaboratorsGroupId,
                        principalTable: "CollaboratorsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollaboratorsGroupDiscounts_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_CollaboratorsGroupDiscounts_DiscountId",
                table: "CollaboratorsGroupDiscounts",
                column: "DiscountId");
        }
    }
}
