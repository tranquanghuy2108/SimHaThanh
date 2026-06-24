using Commons.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("CollaboratorsGroupJoinRequests")]
    public class CollaboratorsGroupJoinRequest : EntityCommon
    {
        [StringLength(10)]
        public int CollaboratorsGroupId { get; set; }
        public string? CollaboratorsGroupCode { get; set; }
        public Guid UserId { get; set; }
        public ApprovedStatus Status { get; set; }
    }
}
