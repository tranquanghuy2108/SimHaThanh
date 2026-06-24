using Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class NewsViewModel
    {
        public int stt { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string? Content { get; set; }
        public string CreateTime { get; set; }
        //public string? ImgL { get; set; }
        //public string? ImgM { get; set; }
        //public string? ImgS { get; set; }
        //public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
        public int ViewCount { get; set; }
        public string? Category { get; set; }
    }
    public class NewsEditModel
    {
        public int? Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string? Content { get; set; }
        public string? CreateTime { get; set; }
        //public string? ImgL { get; set; }
        //public string? ImgM { get; set; }
        //public string? ImgS { get; set; }
        //public string? MetaTitle { get; set; }
        //public string? MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class CategoryViewModel
    {
        public int stt { get; set; }
        public int Id { get; set; }
        public string Parent { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        //public string Position { get; set; }
        //public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
    }
    public class CategoryEditModel
    {
        public int? Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        //public string Position { get; set; }
        //public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        //public string? MetaRemark { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class TagViewModel
    {
        public int stt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaRemark { get; set; }
    }
    public class TagEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaRemark { get; set; }
    }
}
