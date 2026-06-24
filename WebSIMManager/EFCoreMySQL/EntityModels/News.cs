using Commons.Enums;

namespace EFCoreMySQL.EntityModels
{
    public class News : EntityCommon
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string? Content { get; set; }
        //public string? ImgL { get; set; }
        //public string? ImgM { get; set; }
        //public string? ImgS { get; set; }
        //public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public TypeOfPage typeOfPage { get; set; }
    }
}
