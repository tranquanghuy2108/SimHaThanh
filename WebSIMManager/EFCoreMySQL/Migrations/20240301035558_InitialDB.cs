using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsStaffRole = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroups", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FullName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hotline = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Remark = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Province = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avatar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsStaff = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAgent = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DiscountForSimSellersId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoginProvider = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoginProvider = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccOwner = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CollaboratorsGroupJoinRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CollaboratorsGroupId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CollaboratorsGroupCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorsGroupJoinRequests", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CollaboratorsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsApp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsForAgent = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OwnerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorsGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CountIPLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IPLogin = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountLogin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountIPLogins", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DebtAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DebtCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtAgents", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DebtBanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DebtCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtBanks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DebtCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StaffId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    BankId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ShippingId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DebtShippings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DebtCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    ShippingId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtShippings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DebtStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DebtCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receivables = table.Column<double>(type: "double", nullable: false),
                    Liabilities = table.Column<double>(type: "double", nullable: false),
                    FinalDebt = table.Column<double>(type: "double", nullable: false),
                    StaffId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtStaffs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PriceFrom = table.Column<double>(type: "double", nullable: false),
                    PriceTo = table.Column<double>(type: "double", nullable: false),
                    DiscountPer = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FlashSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlashSales", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormOfDeliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfDeliveries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GoodsDeliveryNoteOfSims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    OrderIds = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ListSimNumberInOrder = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderPrice = table.Column<double>(type: "double", nullable: false),
                    TienDaThu = table.Column<double>(type: "double", nullable: false),
                    PhaiThuConLai = table.Column<double>(type: "double", nullable: false),
                    PhoneCard = table.Column<double>(type: "double", nullable: false),
                    OldDebt = table.Column<double>(type: "double", nullable: false),
                    NewDebt = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    PayOrderType = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    TransferAmount = table.Column<double>(type: "double", nullable: false),
                    FormOfDeliveryId = table.Column<int>(type: "int", nullable: true),
                    FormOfDeliveryCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingUnitId = table.Column<int>(type: "int", nullable: true),
                    ShippingCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingFee = table.Column<double>(type: "double", nullable: false),
                    COD = table.Column<double>(type: "double", nullable: false),
                    FlagCOD = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OtherFee = table.Column<double>(type: "double", nullable: false),
                    DeliveryAgent = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SoTienThuHo = table.Column<double>(type: "double", nullable: false),
                    CongNoPhatSinhGiaoDichHo = table.Column<double>(type: "double", nullable: false),
                    FlagThuHo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDeliveryNoteOfSims", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GoodsDeliveryNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    OrderIds = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ListSimNumberInOrder = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    OtherFee = table.Column<double>(type: "double", nullable: false),
                    TienDaThu = table.Column<double>(type: "double", nullable: false),
                    PhaiThuConLai = table.Column<double>(type: "double", nullable: false),
                    NoLai = table.Column<double>(type: "double", nullable: false),
                    OldDebt = table.Column<double>(type: "double", nullable: false),
                    NewDebt = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    PayOrderType = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    FormOfDeliveryId = table.Column<int>(type: "int", nullable: true),
                    FormOfDeliveryCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingUnitId = table.Column<int>(type: "int", nullable: true),
                    ShippingCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingFee = table.Column<double>(type: "double", nullable: false),
                    COD = table.Column<double>(type: "double", nullable: false),
                    FlagCOD = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeliveryAgent = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SoTienThuHo = table.Column<double>(type: "double", nullable: false),
                    CongNoPhatSinhGiaoDichHo = table.Column<double>(type: "double", nullable: false),
                    FlagThuHo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDeliveryNotes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoaiSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPhams", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IpAddressUser = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ControllerName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActionName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OldData = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NewData = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogActions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogExceptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ControllerName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActionName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExceptionName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogExceptions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NhomSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomSanPhams", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaulPrice = table.Column<double>(type: "double", nullable: false),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShippingCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Agent = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Customer = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CustomerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerPhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoodsDeliveryNoteOfSimId = table.Column<int>(type: "int", nullable: false),
                    SoTienThuHo = table.Column<double>(type: "double", nullable: false),
                    ChiPhiThuHo = table.Column<double>(type: "double", nullable: false),
                    SoTienConLai = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<double>(type: "double", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShippingUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    APIUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingUnits", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SIMNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIMSeriaNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIMPrice = table.Column<double>(type: "double", nullable: false),
                    SIMPriceOfAgent = table.Column<double>(type: "double", nullable: false),
                    SIMEmbryoFee = table.Column<double>(type: "double", nullable: false),
                    SIMServiceFee = table.Column<double>(type: "double", nullable: false),
                    SIMNetworkId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    SIMImgUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Owner = table.Column<Guid>(type: "char(250)", maxLength: 250, nullable: true, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMDetails", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMNetworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NetworkName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NetworkImgUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HtmlId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrefixNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMNetworks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PriceOrder = table.Column<double>(type: "double", nullable: false),
                    SIMEmbryoFee = table.Column<double>(type: "double", nullable: false),
                    SIMServiceFee = table.Column<double>(type: "double", nullable: false),
                    PhoneNum = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserBuyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormOfDeliveryId = table.Column<int>(type: "int", nullable: false),
                    debtId = table.Column<int>(type: "int", nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PIC = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TimeUnlock = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMOrders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SupportContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupportContactType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportContacts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SystemActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActionDesc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemActions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TypesOfSIM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Format = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfSIM", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "v_SIMViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Network = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: true),
                    SIMEmbryoFee = table.Column<double>(type: "double", nullable: true),
                    SIMServiceFee = table.Column<double>(type: "double", nullable: true),
                    Owner = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OwnerPhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIMImgUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDSanPhamNguyenVatLieu = table.Column<int>(type: "int", nullable: false),
                    IDLoaiSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaTrungBinh = table.Column<double>(type: "double", nullable: false),
                    DonGiaThapNhat = table.Column<double>(type: "double", nullable: false),
                    DonGiaCaoNhat = table.Column<double>(type: "double", nullable: false),
                    GhiChu = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppRoleGroups",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "char(128)", maxLength: 128, nullable: false, collation: "ascii_general_ci"),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleGroups", x => new { x.RoleId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AppRoleGroups_AppGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AppGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleGroups_AppRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserGroups",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(128)", maxLength: 128, nullable: false, collation: "ascii_general_ci"),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AppUserGroups_AppGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AppGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserGroups_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CollaboratorsGroupUser",
                columns: table => new
                {
                    CollaboratorsGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorsGroupUser", x => new { x.CollaboratorsGroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CollaboratorsGroupUser_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollaboratorsGroupUser_CollaboratorsGroups_CollaboratorsGrou~",
                        column: x => x.CollaboratorsGroupId,
                        principalTable: "CollaboratorsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CollaboratorsGroupId = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_CollaboratorsGroups_CollaboratorsGroupId",
                        column: x => x.CollaboratorsGroupId,
                        principalTable: "CollaboratorsGroups",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ParentCommentID = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_PostComments_ParentCommentID",
                        column: x => x.ParentCommentID,
                        principalTable: "PostComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMOnFlashSales",
                columns: table => new
                {
                    SimId = table.Column<int>(type: "int", nullable: false),
                    FlashSaleId = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMOnFlashSales", x => new { x.SimId, x.FlashSaleId });
                    table.ForeignKey(
                        name: "FK_SIMOnFlashSales_FlashSales_FlashSaleId",
                        column: x => x.FlashSaleId,
                        principalTable: "FlashSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SIMOnFlashSales_SIMDetails_SimId",
                        column: x => x.SimId,
                        principalTable: "SIMDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMWithOrders",
                columns: table => new
                {
                    SimId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMWithOrders", x => new { x.SimId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_SIMWithOrders_SIMDetails_SimId",
                        column: x => x.SimId,
                        principalTable: "SIMDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SIMWithOrders_SIMOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "SIMOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SIMTypes",
                columns: table => new
                {
                    SimId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMTypes", x => new { x.SimId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_SIMTypes_SIMDetails_SimId",
                        column: x => x.SimId,
                        principalTable: "SIMDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SIMTypes_TypesOfSIM_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypesOfSIM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotificationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostImageComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostImgID = table.Column<int>(type: "int", nullable: false),
                    ParentImgCmtID = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImageComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImageComments_PostImageComments_ParentImgCmtID",
                        column: x => x.ParentImgCmtID,
                        principalTable: "PostImageComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostImageComments_PostImages_PostImgID",
                        column: x => x.PostImgID,
                        principalTable: "PostImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostImageLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostImgID = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImageLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImageLikes_PostImages_PostImgID",
                        column: x => x.PostImgID,
                        principalTable: "PostImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d80"), null, "Quyền nhân viên", "Nhân viên", "Nhân viên" },
                    { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"), null, "Quyền quản trị hệ thống", "Quản trị hệ thống", "Quản trị" }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "Birthday", "ConcurrencyStamp", "DiscountForSimSellersId", "Email", "EmailConfirmed", "FullName", "Hotline", "IsActive", "IsAgent", "IsStaff", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Province", "Remark", "SecurityStamp", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), 0, null, null, null, "0f9f346b-4357-417f-b73e-4a0755812303", null, "huongnx@tigergames.vn", true, "Tiger Games .JSC", null, false, false, true, true, null, "huongnx@tigergames.vn", "admin", "AQAAAAIAAYagAAAAEOi3DAvxlzGZIn2YwA++eja+yV4c/m5abmQXANteqJwCtEKsxjmzbNs8Jiaw0/GwgA==", "+840123456789", false, null, null, "", false, "admin", null });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"), new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8") });

            migrationBuilder.InsertData(
                table: "SIMNetworks",
                columns: new[] { "Id", "CreateBy", "CreateTime", "Description", "HtmlId", "IsDelete", "NetworkImgUrl", "NetworkName", "PrefixNumber", "UpdateBy", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5720), "Nhà mạng Viettel", "viettel", false, "viettel", "Viettel", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5721) },
                    { 2, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5723), "Nhà mạng Vinaphone", "vina", false, "vina", "Vinaphone", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5723) },
                    { 3, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5725), "Nhà mạng Mobiphone", "mobi", false, "mobi", "Mobiphone", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5725) },
                    { 4, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5727), "Nhà mạng Vinaphone", "vnn", false, "vnn", "Vietnamobile", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5727) },
                    { 5, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5729), "Nhà mạng Vinaphone", "gmobile", false, "gmobile", "Gmobile", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5729) },
                    { 6, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5731), "Nhà mạng Vinaphone", "vina", false, "vina", "Itelecom", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5731) }
                });

            migrationBuilder.InsertData(
                table: "TypesOfSIM",
                columns: new[] { "Id", "CreateBy", "CreateTime", "Description", "Format", "IsDelete", "Name", "UpdateBy", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5478), "*00000,*11111,*22222,*33333,*44444,*55555,*66666,*77777,*88888,*99999", "AAAAA", false, "Ngũ quý", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5492) },
                    { 2, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5499), "*0000,*1111,*2222,*3333,*4444,*5555,*6666,*7777,*8888,*9999", "AAAA", false, "Tứ quý", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5500) },
                    { 3, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5501), "*0000*,*1111*,*2222*,*3333*,*4444*,*5555*,*6666*,*7777*,*8888*,*9999*", "AAAA.b", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5502) },
                    { 4, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5503), "", "AAAA.", false, "Tứ quý giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5504) },
                    { 5, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5505), "", "AAAA.bx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5506) },
                    { 6, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5507), "", "AAAA.bxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5508) },
                    { 7, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5510), "", "AAA.BBB", false, "Tam hoa kép", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5510) },
                    { 8, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5511), "*000,*111,*222,*333,*444,*555,*666,*777,*888,*999", ".AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5512) },
                    { 9, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5513), "", "ABC.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5514) },
                    { 10, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5515), "", "BcB.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5515) },
                    { 11, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5517), "", "BBx.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5517) },
                    { 12, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5519), "", "xBB.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5519) },
                    { 13, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5520), "*000*,*111*,*222*,*333*,*444*,*555*,*666*,*777*,*888*,*999*", "AAA.b", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5521) },
                    { 14, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5522), "", "AAA.bx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5523) },
                    { 15, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5524), "", "AAA.xxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5525) },
                    { 16, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5526), "", "AB.AB.AB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5527) },
                    { 17, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5528), "", "ABCD.ABCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5528) },
                    { 18, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5530), "", "BAA.BAA", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5530) },
                    { 19, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5532), "", "ABC.ABC", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5532) },
                    { 20, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5533), "", "ABA.ABA", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5534) },
                    { 21, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5535), "", "AAB.AAB", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5536) },
                    { 22, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5537), "", "bxx.bxx", false, "Taxi thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5537) },
                    { 23, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5539), "", "ABCDE", false, "Tiến đơn 5", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5539) },
                    { 24, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5540), "", "ABCD", false, "Tiến đơn 4", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5541) },
                    { 25, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5542), "", "ABC.ABC", false, "Tiến đơn 3 kép", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5543) },
                    { 26, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5544), "", "SPECIAL", false, "Số đặc biệt", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5545) },
                    { 27, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5563), "", "SPECIAL_UP", false, "Tiến đặc biệt", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5563) },
                    { 28, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5564), "", "AA.BB.AA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5565) },
                    { 29, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5566), "", "AA.BB.CC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5567) },
                    { 30, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5568), "", "AbA.AcA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5569) },
                    { 31, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5570), "", "ABB.CBB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5570) },
                    { 32, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5572), "", "AAB.AAC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5572) },
                    { 33, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5573), "", "ABC.ABD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5574) },
                    { 34, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5575), "", "ABAB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5576) },
                    { 35, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5577), "", "ABBA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5578) },
                    { 36, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5579), "", "ABBA.CDDC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5579) },
                    { 37, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5581), "", "AA.BB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5581) },
                    { 38, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5583), "*012,*123,*234,*345,*456,*567,*678,*789", "ABC", false, "Tiến đơn 3", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5583) },
                    { 39, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5584), "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*", "123.xxx", false, "Tiến giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5585) },
                    { 40, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5586), "", "AB.CB.DB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5587) },
                    { 41, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5588), "", "AB.AC.AD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5588) },
                    { 42, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5590), "", "AA.BC.AA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5590) },
                    { 43, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5592), "*79,*39", "79-39", false, "Thần tài", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5592) },
                    { 44, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5593), "", "xyz.zyx", false, "Số đối", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5594) },
                    { 45, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5595), "*68", "68", false, "Lộc phát", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5596) },
                    { 46, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5597), "*86", "86", false, "Phát lộc", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5597) },
                    { 47, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5599), "*99", "99", false, "Cửu cửu", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5599) },
                    { 48, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5600), "*88", "88", false, "Phát phát", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5601) },
                    { 49, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5602), "*89", "0.89", false, "Đuôi 89", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5603) },
                    { 50, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5604), "*66", "66", false, "Lộc lộc", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5605) },
                    { 51, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5606), "*78,*38", "78-38", false, "Ông địa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5606) },
                    { 52, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5608), "", "AAb.xxx", false, "Kép giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5608) },
                    { 53, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5609), "", "AB.AB.AB.xy", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5610) },
                    { 54, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5611), "", "ABC.Abc+1", false, "Tiến đầu", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5612) },
                    { 55, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5613), "", "dd.MM.yy", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5613) },
                    { 56, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5615), "", "xA.yA.zA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5615) },
                    { 57, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5616), "", "AB AD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5617) },
                    { 58, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5618), "", ".ABA", false, "Số gánh", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5619) },
                    { 59, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5620), "", "ABB CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5621) },
                    { 60, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5622), "", "A<B<C<D", false, "Tiến 4 số cuối", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5622) },
                    { 61, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5624), "", "ADB.ACB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5624) },
                    { 62, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5625), "", "bxx.bxx.", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5626) },
                    { 63, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5627), "", "AAB.CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5628) },
                    { 64, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5629), "", "ABA.CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5629) },
                    { 65, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5631), "", "ABA.CCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5631) },
                    { 66, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5633), "", "CBA.CBD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5633) },
                    { 67, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5634), "", "ACB.DCB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5635) },
                    { 68, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5636), "", "ABAB.xxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5637) },
                    { 69, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5638), "", "AABB.Cx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5638) },
                    { 70, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5640), "", "AABB.CxD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5640) },
                    { 71, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5641), "", "BCD.EAA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5642) },
                    { 72, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5643), "", "ABAB.xx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5644) },
                    { 73, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5645), "", "ABCB", false, "Tiến 2 đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5646) },
                    { 74, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5647), "", "ABAC", false, "Tiến 2 đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5647) },
                    { 75, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5649), "", "AB.CD.AB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5649) },
                    { 76, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5652), "", "ABA", false, "Gánh thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5652) },
                    { 77, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5654), "", "AAB CCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5654) },
                    { 78, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5655), "", "xAABBx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5656) },
                    { 79, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5657), "", "AAB.CDE", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5658) },
                    { 80, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5659), "", "xAA.BCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5659) },
                    { 81, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5661), "", "BCD.AAx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5661) },
                    { 82, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5663), "", "ABC.BAC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5663) },
                    { 83, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5664), "", "ABC.ACB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5665) },
                    { 84, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5666), "", "ABA.CDC", false, "Gánh đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5667) },
                    { 85, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5668), "", "NORMAL", false, "Bình thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5668) },
                    { 86, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5670), "", "19bx", false, "Năm sinh", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5670) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleGroups_GroupId",
                table: "AppRoleGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserGroups_GroupId",
                table: "AppUserGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CollaboratorsGroupDiscounts_DiscountId",
                table: "CollaboratorsGroupDiscounts",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_CollaboratorsGroupUser_UserId",
                table: "CollaboratorsGroupUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CollaboratorsGroupId",
                table: "Notifications",
                column: "CollaboratorsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_NotificationId",
                table: "NotificationUsers",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_UserId",
                table: "NotificationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_ParentCommentID",
                table: "PostComments",
                column: "ParentCommentID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImageComments_ParentImgCmtID",
                table: "PostImageComments",
                column: "ParentImgCmtID");

            migrationBuilder.CreateIndex(
                name: "IX_PostImageComments_PostImgID",
                table: "PostImageComments",
                column: "PostImgID");

            migrationBuilder.CreateIndex(
                name: "IX_PostImageLikes_PostImgID",
                table: "PostImageLikes",
                column: "PostImgID");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostID",
                table: "PostImages",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId",
                table: "PostLikes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_SIMOnFlashSales_FlashSaleId",
                table: "SIMOnFlashSales",
                column: "FlashSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SIMTypes_TypeId",
                table: "SIMTypes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SIMWithOrders_OrderId",
                table: "SIMWithOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoleGroups");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserGroups");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "CollaboratorsGroupDiscounts");

            migrationBuilder.DropTable(
                name: "CollaboratorsGroupJoinRequests");

            migrationBuilder.DropTable(
                name: "CollaboratorsGroupUser");

            migrationBuilder.DropTable(
                name: "CountIPLogins");

            migrationBuilder.DropTable(
                name: "DebtAgents");

            migrationBuilder.DropTable(
                name: "DebtBanks");

            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropTable(
                name: "DebtShippings");

            migrationBuilder.DropTable(
                name: "DebtStaffs");

            migrationBuilder.DropTable(
                name: "FormOfDeliveries");

            migrationBuilder.DropTable(
                name: "GoodsDeliveryNoteOfSims");

            migrationBuilder.DropTable(
                name: "GoodsDeliveryNotes");

            migrationBuilder.DropTable(
                name: "LoaiSanPhams");

            migrationBuilder.DropTable(
                name: "LogActions");

            migrationBuilder.DropTable(
                name: "LogExceptions");

            migrationBuilder.DropTable(
                name: "NhomSanPhams");

            migrationBuilder.DropTable(
                name: "NotificationUsers");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "PostImageComments");

            migrationBuilder.DropTable(
                name: "PostImageLikes");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "ShippingUnits");

            migrationBuilder.DropTable(
                name: "SIMNetworks");

            migrationBuilder.DropTable(
                name: "SIMOnFlashSales");

            migrationBuilder.DropTable(
                name: "SIMTypes");

            migrationBuilder.DropTable(
                name: "SIMWithOrders");

            migrationBuilder.DropTable(
                name: "SupportContacts");

            migrationBuilder.DropTable(
                name: "SystemActions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "v_SIMViews");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppGroups");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "FlashSales");

            migrationBuilder.DropTable(
                name: "TypesOfSIM");

            migrationBuilder.DropTable(
                name: "SIMDetails");

            migrationBuilder.DropTable(
                name: "SIMOrders");

            migrationBuilder.DropTable(
                name: "CollaboratorsGroups");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
