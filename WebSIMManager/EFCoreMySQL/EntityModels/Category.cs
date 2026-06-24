namespace EFCoreMySQL.EntityModels
{
    public class Category : EntityCommon
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        //public string Position { get; set; }
        //public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
    }
}
