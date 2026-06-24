using Commons.Enums;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMySQL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Add admin user
            var adminId = new Guid("C09B6C9B-3405-4ABB-B39F-2FAA705226D8");
            // any guid, but nothing is against to use the same one
            var roleIdAdmin = new Guid("A32513B8-6EB4-433D-AF51-CE369BCF4D83");
            modelBuilder
                .Entity<AppRole>()
                .HasData(
                    new AppRole
                    {
                        Id = roleIdAdmin,
                        Name = "Quản trị hệ thống",
                        NormalizedName = "Quản trị",
                        Description = "Quyền quản trị hệ thống",
                    }
                );

            var roleIdEmployee = new Guid("A32513B8-6EB4-433D-AF51-CE369BCF4D80");
            modelBuilder
                .Entity<AppRole>()
                .HasData(
                    new AppRole
                    {
                        Id = roleIdEmployee,
                        Name = "Nhân viên",
                        NormalizedName = "Nhân viên",
                        Description = "Quyền nhân viên",
                    }
                );

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder
                .Entity<AppUser>()
                .HasData(
                    new AppUser
                    {
                        Id = adminId,
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        Email = "huongnx@tigergames.vn",
                        NormalizedEmail = "huongnx@tigergames.vn",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "Abcd@1234"),
                        SecurityStamp = string.Empty,
                        FullName = "Tiger Games .JSC",
                        PhoneNumber = "+840123456789",
                        LockoutEnabled = true,
                        IsStaff = true,
                        IsAgent = false,
                    }
                );

            modelBuilder
                .Entity<IdentityUserRole<Guid>>()
                .HasData(new IdentityUserRole<Guid> { RoleId = roleIdAdmin, UserId = adminId });

            ////Add TypeOfSim defaul
            //modelBuilder.Entity<TypeOfSIM>().HasData(
            //    new TypeOfSIM { Id = 1, Name = "Ngũ quý", Format = "AAAAA", Description = "*00000,*11111,*22222,*33333,*44444,*55555,*66666,*77777,*88888,*99999", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 2, Name = "Tứ quý", Format = "AAAA", Description = "*0000,*1111,*2222,*3333,*4444,*5555,*6666,*7777,*8888,*9999", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 3, Name = "Sim số đẹp", Format = "AAAA.b", Description = "*0000*,*1111*,*2222*,*3333*,*4444*,*5555*,*6666*,*7777*,*8888*,*9999*", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 4, Name = "Tứ quý giữa", Format = "AAAA.", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 5, Name = "Sim số đẹp", Format = "AAAA.bx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 6, Name = "Sim số đẹp", Format = "AAAA.bxx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 7, Name = "Tam hoa kép", Format = "AAA.BBB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 8, Name = "Tam hoa", Format = ".AAA", Description = "*000,*111,*222,*333,*444,*555,*666,*777,*888,*999", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 9, Name = "Tam hoa", Format = "ABC.AAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 10, Name = "Tam hoa", Format = "BcB.AAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 11, Name = "Tam hoa", Format = "BBx.AAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 12, Name = "Tam hoa", Format = "xBB.AAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 13, Name = "Sim số đẹp", Format = "AAA.b", Description = "*000*,*111*,*222*,*333*,*444*,*555*,*666*,*777*,*888*,*999*", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 14, Name = "Sim số đẹp", Format = "AAA.bx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 15, Name = "Sim số đẹp", Format = "AAA.xxx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 16, Name = "Sim số đẹp", Format = "AB.AB.AB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 17, Name = "Sim số đẹp", Format = "ABCD.ABCD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 18, Name = "Taxi", Format = "BAA.BAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 19, Name = "Taxi", Format = "ABC.ABC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 20, Name = "Taxi", Format = "ABA.ABA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 21, Name = "Taxi", Format = "AAB.AAB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 22, Name = "Taxi thường", Format = "bxx.bxx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 23, Name = "Tiến đơn 5", Format = "ABCDE", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 24, Name = "Tiến đơn 4", Format = "ABCD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 25, Name = "Tiến đơn 3 kép", Format = "ABC.ABC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 26, Name = "Số đặc biệt", Format = "SPECIAL", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 27, Name = "Tiến đặc biệt", Format = "SPECIAL_UP", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 28, Name = "Sim số đẹp", Format = "AA.BB.AA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 29, Name = "Sim số đẹp", Format = "AA.BB.CC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 30, Name = "Sim số đẹp", Format = "AbA.AcA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 31, Name = "Sim số đẹp", Format = "ABB.CBB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 32, Name = "Sim số đẹp", Format = "AAB.AAC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 33, Name = "Sim số đẹp", Format = "ABC.ABD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 34, Name = "Sim số đẹp", Format = "ABAB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 35, Name = "Sim số đẹp", Format = "ABBA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 36, Name = "Sim số đẹp", Format = "ABBA.CDDC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 37, Name = "Sim số đẹp", Format = "AA.BB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 38, Name = "Tiến đơn 3", Format = "ABC", Description = "*012,*123,*234,*345,*456,*567,*678,*789", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 39, Name = "Tiến giữa", Format = "123.xxx", Description = "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 40, Name = "Sim số đẹp", Format = "AB.CB.DB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 41, Name = "Sim số đẹp", Format = "AB.AC.AD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 42, Name = "Sim số đẹp", Format = "AA.BC.AA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 43, Name = "Thần tài", Format = "79-39", Description = "*79,*39", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 44, Name = "Số đối", Format = "xyz.zyx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 45, Name = "Lộc phát", Format = "68", Description = "*68", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 46, Name = "Phát lộc", Format = "86", Description = "*86", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 47, Name = "Cửu cửu", Format = "99", Description = "*99", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 48, Name = "Phát phát", Format = "88", Description = "*88", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 49, Name = "Đuôi 89", Format = "0.89", Description = "*89", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 50, Name = "Lộc lộc", Format = "66", Description = "*66", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 51, Name = "Ông địa", Format = "78-38", Description = "*78,*38", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 52, Name = "Kép giữa", Format = "AAb.xxx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 53, Name = "Sim số đẹp", Format = "AB.AB.AB.xy", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 54, Name = "Tiến đầu", Format = "ABC.Abc+1", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 55, Name = "Sim số đẹp", Format = "dd.MM.yy", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 56, Name = "Sim số đẹp", Format = "xA.yA.zA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 57, Name = "Sim số đẹp", Format = "AB AD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 58, Name = "Số gánh", Format = ".ABA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 59, Name = "Sim số đẹp", Format = "ABB CDD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 60, Name = "Tiến 4 số cuối", Format = "A<B<C<D", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 61, Name = "Sim số đẹp", Format = "ADB.ACB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 62, Name = "Sim số đẹp", Format = "bxx.bxx.", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 63, Name = "Sim số đẹp", Format = "AAB.CDD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 64, Name = "Sim số đẹp", Format = "ABA.CDD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 65, Name = "Sim số đẹp", Format = "ABA.CCD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 66, Name = "Sim số đẹp", Format = "CBA.CBD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 67, Name = "Sim số đẹp", Format = "ACB.DCB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 68, Name = "Sim số đẹp", Format = "ABAB.xxx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 69, Name = "Sim số đẹp", Format = "AABB.Cx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 70, Name = "Sim số đẹp", Format = "AABB.CxD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 71, Name = "Sim số đẹp", Format = "BCD.EAA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 72, Name = "Sim số đẹp", Format = "ABAB.xx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 73, Name = "Tiến 2 đôi", Format = "ABCB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 74, Name = "Tiến 2 đôi", Format = "ABAC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 75, Name = "Sim số đẹp", Format = "AB.CD.AB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 76, Name = "Gánh thường", Format = "ABA", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 77, Name = "Sim số đẹp", Format = "AAB CCD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 78, Name = "Sim số đẹp", Format = "xAABBx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 79, Name = "Sim số đẹp", Format = "AAB.CDE", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 80, Name = "Sim số đẹp", Format = "xAA.BCD", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 81, Name = "Sim số đẹp", Format = "BCD.AAx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 82, Name = "Sim số đẹp", Format = "ABC.BAC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 83, Name = "Sim số đẹp", Format = "ABC.ACB", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 84, Name = "Gánh đôi", Format = "ABA.CDC", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 85, Name = "Bình thường", Format = "NORMAL", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false },
            //    new TypeOfSIM { Id = 86, Name = "Năm sinh", Format = "19bx", Description = "", CreateBy = adminId, CreateTime = DateTime.Now, UpdateBy = adminId, UpdateTime = DateTime.Now, IsDelete = false }
            //);

            //Add Network defaul
            modelBuilder
                .Entity<SIMNetwork>()
                .HasData(
                    new SIMNetwork
                    {
                        Id = 1,
                        NetworkName = "Viettel",
                        HtmlId = "viettel",
                        NetworkImgUrl = "viettel",
                        Description = "Nhà mạng Viettel",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    },
                    new SIMNetwork
                    {
                        Id = 2,
                        NetworkName = "Vinaphone",
                        HtmlId = "vina",
                        NetworkImgUrl = "vina",
                        Description = "Nhà mạng Vinaphone",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    },
                    new SIMNetwork
                    {
                        Id = 3,
                        NetworkName = "Mobiphone",
                        HtmlId = "mobi",
                        NetworkImgUrl = "mobi",
                        Description = "Nhà mạng Mobiphone",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    },
                    new SIMNetwork
                    {
                        Id = 4,
                        NetworkName = "Vietnamobile",
                        HtmlId = "vnn",
                        NetworkImgUrl = "vnn",
                        Description = "Nhà mạng Vinaphone",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    },
                    new SIMNetwork
                    {
                        Id = 5,
                        NetworkName = "Gmobile",
                        HtmlId = "gmobile",
                        NetworkImgUrl = "gmobile",
                        Description = "Nhà mạng Vinaphone",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    },
                    new SIMNetwork
                    {
                        Id = 6,
                        NetworkName = "Itelecom",
                        HtmlId = "vina",
                        NetworkImgUrl = "vina",
                        Description = "Nhà mạng Vinaphone",
                        CreateBy = adminId,
                        CreateTime = DateTime.Now,
                        UpdateBy = adminId,
                        UpdateTime = DateTime.Now,
                        IsDelete = false,
                    }
                );
        }
    }
}
