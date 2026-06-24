using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class PostRepository : IPostRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public PostRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }


        //POST
        public ResponseDataModel<string> CreatePost(PostCreateRequestModel request)
        {
            try
            {
                var currentPostID = _context.Posts.OrderByDescending(e => e.Id).Select(e => e.Id).FirstOrDefault();
                var postData = new Post
                {
                    ViewCount = 0,
                    Content = request.Content,
                    CreateBy = request.UserID,
                    UpdateBy = request.UserID,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsDelete = false,
                };
                _context.Posts.Add(postData);
                _context.SaveChanges();

                foreach (var image in request.imageUrls)
                {
                    var postImageData = new PostImage
                    {
                        PostID = currentPostID + 1,
                        ImageUrl = image.ImageUrl,
                        Description = image.Description,
                        CreateTime = DateTime.Now,
                        UpdateTime = DateTime.Now,

                    };
                    _context.PostImages.Add(postImageData);
                }

                var resultPost = _context.SaveChanges();

                if (resultPost > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo Post thành công!"
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo Post thất bại!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo Post.",
                };
            }

        }

        public ResponseDataViewModel<PostViewModel> GetAllPost(PagingRequestBase request)
        {
            var dataEntity = _context.Posts;
            var dataPaging = dataEntity.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();

            dataPaging.Reverse();
            var data = new List<PostViewModel>();
            foreach (var item in dataPaging)
            {
                var userInfo = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                data.Add(new PostViewModel()
                {
                    Id = item.Id,
                    UserID = item.CreateBy,
                    FullName = userInfo == null ? "" : userInfo.FullName,
                    AvatarURL = userInfo == null ? "" : userInfo.Avatar,
                    Content = item.Content,
                    ViewCount = item.ViewCount,
                    CreateTime = item.CreateTime,
                    UpdateDate = item.UpdateTime
                });
            }

            return new ResponseDataViewModel<PostViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

        //COMMENT OF POSTS
        public ResponseDataModel<string> CreatePostComment(PostCmtCreateRequestModel request)
        {
            try
            {
                var postData = new PostComment
                {
                    PostId = request.PostID,
                    ParentCommentID = request.ParentCommentID == null ? null : request.ParentCommentID,
                    Content = request.Content,
                    CreateBy = request.UserID,
                    UpdateBy = request.UserID,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                };
                _context.Comments.Add(postData);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo Post thành công!"
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo Post thất bại!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo Post.",
                };
            }

        }
        public ResponseDataViewModel<PostCommentViewModel> GetPostComment(GetCommentRequest request)
        {

            var dataEntity = _context.Comments.Where(x => x.PostId == request.PostID);
            var dataPaging = _context.Comments.Where(x => x.PostId == request.PostID).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            dataPaging.Reverse();
            var data = new List<PostCommentViewModel>();
            foreach (var item in dataPaging)
            {
                var userInfo = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                data.Add(new PostCommentViewModel()
                {
                    Id = item.Id,
                    ParentCommentID = item.ParentCommentID,
                    PostID = item.PostId,
                    UserID = item.CreateBy,
                    FullName = userInfo == null ? "" : userInfo.FullName,
                    AvatarURL = userInfo == null ? "" : userInfo.Avatar,
                    Content = item.Content,
                    CreateDate = item.CreateTime,
                    UpdateDate = item.UpdateTime,

                });
            }
            return new ResponseDataViewModel<PostCommentViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };


            //

        }
        //POST_IMAGE
        public ResponseDataViewModel<PostImageViewModel> GetPostImage(GetImageRequest request)
        {
            var dataEntity = _context.PostImages.Where(x => x.PostID == request.PostID && x.PostID == request.PostID);
            var dataPaging = _context.PostImages.Where(x => x.PostID == request.PostID && x.PostID == request.PostID).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<PostImageViewModel>();
            foreach (var item in dataPaging)
            {
                data.Add(new PostImageViewModel()
                {
                    Id = item.Id,
                    PostId = item.PostID,
                    ImageUrl = item.ImageUrl,
                    ImageDescription = item.Description,
                    TotalLike = 0

                });
            }
            return new ResponseDataViewModel<PostImageViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

        //LIKE
        //COMMENT OF POSTS

        public ResponseDataModel<string> UnLike(PostLikeRequestModel request)
        {
            try
            {
                var dataEntity = _context.PostLikes.Where(x => x.PostId == request.PostID && x.CreateBy == request.UserID).FirstOrDefault();
                _context.PostLikes.Remove(dataEntity);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "UnLike Post thành công!"
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "UnLike Post thất bại!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình UnLike Post.",
                };
            }
        }



        public ResponseDataModel<string> Like(PostLikeRequestModel request)
        {
            try
            {
                var postLikeData = new PostLikes
                {
                    PostId = request.PostID,
                    CreateBy = request.UserID,
                    UpdateBy = request.UserID,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                };
                _context.PostLikes.Add(postLikeData);

                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Like Post thành công!"
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Like Post thất bại!"
                    };
                }

            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình Like Post.",
                };
            }

        }



        public ResponseDataModel<CommentCountViewModel> GetTotalComment(PostLikeRequestModel request)
        {
            try
            {
                var totalComment = _context.Comments.Count(x => x.PostId == request.PostID && x.ParentCommentID == null);

                return new ResponseDataModel<CommentCountViewModel>()
                {
                    Code = "1",
                    Message = "Get Count Comment thành công!",
                    Data = new CommentCountViewModel()
                    {
                        TotalComment = totalComment,
                        PostID = request.PostID
                    }
                };

            }
            catch (Exception ex)
            {
                return new ResponseDataModel<CommentCountViewModel>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trìnhGet Count Comment",
                    Data = null,
                };
            }
        }

        public ResponseDataViewModel<PostLikeViewModel> GetTotalLike(GetLikeRequest request)
        {
            var dataEntity = _context.PostLikes.Where(x => x.PostId == request.PostID);


            var dataPaging = _context.PostLikes.Where(x => x.PostId == request.PostID).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();

            dataPaging.Reverse();

            var data = new List<PostLikeViewModel>();
            foreach (var item in dataPaging)
            {
                var userInfo = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                data.Add(new PostLikeViewModel()
                {
                    Id = item.Id,
                    PostID = item.PostId,
                    UserID = item.CreateBy,
                    FullName = userInfo == null ? "" : userInfo.FullName,
                    AvatarURL = userInfo == null ? "" : userInfo.Avatar,
                    CreateDate = item.CreateTime,
                    UpdateDate = item.UpdateTime,

                });
            }
            return new ResponseDataViewModel<PostLikeViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

  
    }
}
