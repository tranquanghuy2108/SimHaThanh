using Commons.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("DebtTypes")]
    public class DebtType : EntityCommon
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DebtReceiveType DebtReceiveType { get; set; }
        public string? Description { get; set; }
    }
}
