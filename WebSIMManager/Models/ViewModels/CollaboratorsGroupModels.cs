using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class CollaboratorsGroupViewModels
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
        public string? Description { get; set; }
        public List<DiscountModel>? discount { get; set; }
    }
    public class CollaboratorsGroupEditModels
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên nhóm.")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsApp { get; set; }
        public bool IsForAgent { get; set; }
        public Guid OwnerId { get; set; }
        public List<DiscountModel>? discount { get; set; }
    }
    public class CollaboratorsGroupJoinRequestModels
    {
        public string? Code { get; set; }
        public Guid userId { get; set; }
    }
    public class CollaboratorsGroupApprovedRequestModels
    {
        public List<int> requestIds { get; set; }
        public bool IsApproved { get; set; }
    }
    public class CollaboratorsGroupMemberModel
    {
        public int requesId { get; set; }
        public Guid MemberId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberPhoneNumber { get; set; }
        public string? MemberGroup { get; set; }
    }
    public class DiscountModel {
        public int? Id { get; set; }
        public double PriceFrom { get; set; }
        public double PriceTo { get; set; }
        public int DiscountPer { get; set; }
        public string? Description { get; set; }
    }
}
