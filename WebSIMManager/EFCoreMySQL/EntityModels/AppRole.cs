using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Commons.Enums;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMySQL.EntityModels
{
    public class AppRole : IdentityRole<Guid>
    {
        public AppRole() : base() { }
        [StringLength(250)]
        public string? Description { get; set; }
    }
}
