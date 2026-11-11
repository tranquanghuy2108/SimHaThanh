using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface IPostRepository
    {
        //Post
        ResponseDataModel<string> CreatePost(PostCreateRequestModel request);
        ResponseDataViewModel<PostViewModel> GetAllPost(GetPostRequest request);

        //PostComment
        ResponseDataModel<string> CreatePostComment(PostCmtCreateRequestModel request);
        ResponseDataViewModel<PostCommentViewModel> GetPostComment(GetCommentRequest request);

        //PostImage
        ResponseDataViewModel<PostImageViewModel> GetPostImage(GetImageRequest request);

        //PostLike

        ResponseDataModel<string> Like(PostLikeRequestModel request);
        ResponseDataModel<string> UnLike(PostLikeRequestModel request);

        ResponseDataViewModel<PostLikeViewModel> GetTotalLike(GetLikeRequest request);
        ResponseDataModel<CommentCountViewModel> GetTotalComment(PostLikeRequestModel request);
        ResponseDataModel<string> ReportPost(ReportPostRequestModel request);
        ResponseDataModel<string> BlockUser(BlockUserRequestModel request);
        ResponseDataModel<string> ReviewReportPost(PostStatus status, int postID);
        ResponseDataViewModel<PostViewModel> GetAllPostReport(GetPostRequest request);
    }
}
