using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMAPI.Controllers
{
    [ApiController]
    [Route("api/post")]
    [Authorize]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        //POST
        [HttpPost("create-post")]
        public ResponseDataModel<string> CreatePost([FromBody] PostCreateRequestModel request)
        {
            return _postRepository.CreatePost(request);
        }

        [HttpPost("get-all-post")]
        public ResponseDataViewModel<PostViewModel> GetAllPost([FromBody] PagingRequestBase request)
        {
            return _postRepository.GetAllPost(request);
        }

        //POST_IMAGE

        [HttpPost("get-images-of-post")]
        public ResponseDataViewModel<PostImageViewModel> GetImagePost(
            [FromBody] GetImageRequest request
        )
        {
            return _postRepository.GetPostImage(request);
        }

        //POST_COMMENT
        [HttpPost("create-post-comment")]
        public ResponseDataModel<string> CreatePostComment(
            [FromBody] PostCmtCreateRequestModel request
        )
        {
            return _postRepository.CreatePostComment(request);
        }

        [HttpPost("get-comments-of-post")]
        public ResponseDataViewModel<PostCommentViewModel> GetPostComment(
            [FromBody] GetCommentRequest request
        )
        {
            return _postRepository.GetPostComment(request);
        }

        //POST_LIKE
        [HttpPost("like-post")]
        public ResponseDataModel<string> LikePost([FromBody] PostLikeRequestModel request)
        {
            return _postRepository.Like(request);
        }

        [HttpPost("unlike-post")]
        public ResponseDataModel<string> UnLikePost([FromBody] PostLikeRequestModel request)
        {
            return _postRepository.UnLike(request);
        }

        [HttpPost("get-post-like")]
        public ResponseDataViewModel<PostLikeViewModel> GetTotalLike(
            [FromBody] GetLikeRequest request
        )
        {
            return _postRepository.GetTotalLike(request);
        }

        [HttpPost("get-post-comment-count")]
        public ResponseDataModel<CommentCountViewModel> GetTotalComment(
            [FromBody] PostLikeRequestModel request
        )
        {
            return _postRepository.GetTotalComment(request);
        }

        //POST_IMAGE_LIKE*/
    }
}
