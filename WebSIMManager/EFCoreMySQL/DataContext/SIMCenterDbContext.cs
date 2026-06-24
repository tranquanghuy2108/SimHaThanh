using EFCoreMySQL.EntityModels;
using EFCoreMySQL.Extensions;
using EFCoreMySQL.StoredProcedureModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels;

namespace EFCoreMySQL.DataContext
{
    public partial class SIMCenterDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public SIMCenterDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Identity User, Role
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder
                .Entity<IdentityUserRole<Guid>>()
                .ToTable("AppUserRoles")
                .HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder
                .Entity<IdentityUserLogin<Guid>>()
                .ToTable("AppUserLogins")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder
                .Entity<IdentityUserToken<Guid>>()
                .ToTable("AppUserTokens")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<AppRoleGroup>().HasKey(x => new { x.RoleId, x.GroupId });
            modelBuilder.Entity<AppUserGroup>().HasKey(x => new { x.UserId, x.GroupId });
            modelBuilder.Entity<SIMType>().HasKey(x => new { x.SimId, x.TypeId });
            modelBuilder.Entity<SIMWithOrder>().HasKey(x => new { x.SimId, x.OrderId });
            modelBuilder
                .Entity<CollaboratorsGroupUser>()
                .HasKey(x => new { x.CollaboratorsGroupId, x.UserId });
            //modelBuilder.Entity<SIMOnFlashSale>().HasKey(x => new { x.SimId, x.FlashSaleId });

            // For stored procedure
            modelBuilder.Entity<v_SIMDetail>().HasNoKey().ToView(null);
            modelBuilder.Entity<AgencyGroupReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimInventoryCompanyReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<WarehouseOutboundReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SoldSimReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<ProfitSituationReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<CashFundBalanceReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<BankBalanceReportModel>().HasNoKey().ToView(null);

            modelBuilder.Entity<ProfitStatementReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<OrderProfitReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<BankTransactionReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<CashFundReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimInventoryReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<OrderImportExportReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<InventoryMovementReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<CustomerDebtReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<DebtStaffReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<BankFundBalanceReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<ShippingFundBalanceReportModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<LogSYSViewModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimForCheckSimVNPYModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimPhongThuyResultModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimOnAppModel>().HasNoKey().ToView(null);
            modelBuilder.Entity<SimOfAgentOnCMSModel>().HasNoKey().ToView(null);
            //Configure Seeding
            //modelBuilder.Seed();
        }

        //SIM
        public DbSet<SIMDetail> SIMDetails { set; get; }
        public DbSet<SIMNetwork> SIMNetworks { set; get; }
        public DbSet<SIMType> SIMTypes { set; get; }
        public DbSet<TypeOfSIM> TypeOfSIMs { set; get; }
        public DbSet<SIMOrder> SIMOrders { set; get; }
        public DbSet<SIMWithOrder> SIMWithOrders { set; get; }
        public DbSet<SupportContact> SupportContacts { set; get; }
        public DbSet<FlashSale> FlashSales { set; get; }
        public DbSet<SIMOnFlashSale> SIMOnFlashSales { set; get; }
        public DbSet<ProductType> ProductTypes { set; get; }

        //Posts
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostComment> Comments { set; get; }
        public DbSet<PostLikes> PostLikes { set; get; }
        public DbSet<PostImage> PostImages { set; get; }
        public DbSet<PostImageLike> PostImageLikes { set; get; }
        public DbSet<PostImageComment> PostImageComments { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<News> News { set; get; }

        //Notification
        public DbSet<Notification> Notifications { set; get; }
        public DbSet<NotificationUser> NotificationUsers { set; get; }

        //
        public DbSet<CollaboratorsGroup> CollaboratorsGroups { set; get; }
        public DbSet<CollaboratorsGroupJoinRequest> CollaboratorsGroupJoinRequests { set; get; }
        public DbSet<CollaboratorsGroupUser> CollaboratorsGroupUsers { set; get; }
        public DbSet<Discount> Discounts { set; get; }
        public DbSet<TransferMoney> TransferMoneys { set; get; }
        public DbSet<Receipt> Receipts { set; get; }
        public DbSet<DebtType> DebtTypes { set; get; }
        public DbSet<Debt> Debts { set; get; }
        public DbSet<DebtAgent> DebtAgents { set; get; }
        public DbSet<DebtBank> DebtBanks { set; get; }
        public DbSet<DebtShipping> DebtShippings { set; get; }
        public DbSet<DebtStaff> DebtStaffs { set; get; }
        public DbSet<FormOfDelivery> FormOfDeliveries { set; get; }
        public DbSet<Bank> Banks { set; get; }
        public DbSet<ShippingUnit> ShippingUnits { set; get; }
        public DbSet<Shipping> Shippings { set; get; }
        public DbSet<SimInfosInOrder> SimInfosInOrders { set; get; }
        public DbSet<GoodsDeliveryNoteOfSim> GoodsDeliveryNoteOfSim { set; get; }
        public DbSet<GoodsDeliveryNote> GoodsDeliveryNotes { set; get; }
        public DbSet<GoodsReceivedNote> GoodsReceivedNotes { set; get; }
        public DbSet<Warehouse> Warehouses { set; get; }
        public DbSet<Material> Materials { set; get; }
        public DbSet<MaterialType> MaterialTypes { set; get; }
        public DbSet<MaterialGroup> MaterialGroups { set; get; }
        public DbSet<MaterialSeria> MaterialSerias { set; get; }
        public DbSet<CashBook> CashBooks { set; get; }

        //
        public DbSet<Auction> Auctions { set; get; }
        public DbSet<AuctionUserBidding> AuctionUserBiddings { set; get; }

        // System
        public DbSet<AppRole> Roles { set; get; }
        public DbSet<AppRoleGroup> RoleGroups { set; get; }
        public DbSet<AppUser> Users { set; get; }
        public DbSet<AppUserGroup> UserGroups { set; get; }
        public DbSet<AppGroup> Groups { set; get; }
        public DbSet<LogException> LogExceptions { get; set; }
        public DbSet<LogAction> LogActions { get; set; }
        public DbSet<SystemAction> SystemActions { set; get; }
        public DbSet<CountIPLogin> CountIPLogins { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Country> Countries { set; get; }

        // For stored procedure
        public virtual DbSet<v_SIMDetail> v_SIMViews { set; get; }
    }
}
