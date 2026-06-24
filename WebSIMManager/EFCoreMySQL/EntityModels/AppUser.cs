using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Commons.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMySQL.EntityModels
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser(): base() { }
        [StringLength(50)]
        public string? FullName { get; set; }
        public string? Hotline { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Remark { get; set; }
        public string? Province { get; set; }
        public string? Website { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }

        [DefaultValue(true)]
        public bool IsStaff { get; set; }
        [DefaultValue(false)]
        public bool IsAgent { get; set; }
        [DefaultValue(false)]
        public bool IsConsignmentAgent { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public int? DiscountForSimSellersId { get; set; }
	}
}
