using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class PostImageRequestModel
    {
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
    }
    //
    public class PostCreateRequestModel
    {
        public Guid UserID { get; set; }
        public string Content { get; set; }

        public List<PostImageRequestModel> imageUrls { get; set; }
    }
    public class PostCmtCreateRequestModel //Post Commnet Create Request Model
    {
        public Guid UserID { get; set; }
        public int PostID { get; set; }
        public string Content { get; set; }
        public int? ParentCommentID { get; set; }
     
    }
    public class PostLikeRequestModel 
    {
        public Guid UserID { get; set; }
        public int PostID { get; set; }

    }
    public class PostLikeViewModel
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public Guid UserID { get; set; }
        public string FullName { get; set; }
        public string AvatarURL { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    public class CommentCountViewModel
    {
        public int TotalComment { get; set; }
        public int PostID { get; set; }
    }
    public class PostEditRequestModel
    {

    }
    //
    public class PostViewModel
    {
        public int Id { get; set; }
        public Guid UserID { get; set; }
        public string FullName { get; set; }
        public string AvatarURL { get; set; }

        public string Content { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    public class PostCommentViewModel
    {
        public int Id { get; set; }
        public int? ParentCommentID { get; set; }
        public int PostID { get; set; }
        public Guid UserID { get; set; }
        public string FullName { get; set; }
        public string AvatarURL { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }

    public class PostImageViewModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string ImageUrl { get; set; }
        public int TotalLike { get; set; }
        public string ImageDescription { get; set; }

    }

}
