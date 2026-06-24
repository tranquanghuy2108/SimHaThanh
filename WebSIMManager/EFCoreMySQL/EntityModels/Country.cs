using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMySQL.EntityModels
{
    [Table("Countries")]
    public class Country : EntityCommon
    {
        public string Name { get; set; }
        public string? Note { get; set; }
    }
}
