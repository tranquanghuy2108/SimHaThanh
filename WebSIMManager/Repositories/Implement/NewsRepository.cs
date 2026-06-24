using Commons.Enums;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class NewsRepository : INewsRepository
    {
        private readonly SIMCenterDbContext _context;
        public NewsRepository(SIMCenterDbContext context)
        {
            _context = context;
        }
        public ResponseDataModel<int> CreateCategory(CategoryEditModel request)
        {
            try
            {
                var dataChecking = _context.Categories.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tiêu đề đã tồn tại",
                        Data = 0
                    };
                }

                //
                var dataNew = new Category()
                {
                    Name = request.Name,
                    ParentId = request.ParentId ?? 0,
                    Summary = request.Summary,
                    Url = request.Url,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Categories.Add(dataNew);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                        Data = dataNew.Id
                    };
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo SIM.",
                    Data = 0
                };
            }
        }

        public ResponseDataModel<int> CreateNew(NewsEditModel request, TypeOfPage typeOfPage = TypeOfPage.News)
        {
            try
            {
                var dataChecking = _context.News.FirstOrDefault(x => x.Title == request.Title);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tin đã tồn tại",
                        Data = 0
                    };
                }

                //Create SIM
                var dataNew = new News()
                {
                    Title = request.Title,
                    CategoryId = request.CategoryId,
                    Content = request.Content,
                    Summary = request.Summary,
                    ViewCount = 0,
                    Slug = request.Slug,
                    typeOfPage = typeOfPage,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.News.Add(dataNew);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                        Data = dataNew.Id
                    };
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                        Data = 0
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo SIM.",
                    Data = 0
                };
            }
        }

        public ResponseDataModel<int> CreateTag(TagEditModel request)
        {
            try
            {
                var dataChecking = _context.Tags.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tag đã tồn tại",
                        Data = 0
                    };
                }

                //Create SIM
                var dataNew = new Tag()
                {
                    Name = request.Name,
                    //MetaRemark = request.MetaRemark,
                    //MetaKey = request.MetaKey,
                    //MetaTitle = request.MetaTitle,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Tags.Add(dataNew);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                        Data = dataNew.Id
                    };
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                        Data = 0
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteCategory(int Id)
        {
            try
            {
                var dataEntity = _context.Categories.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM không tồn tại.",
                    };
                _context.Categories.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteNew(int Id)
        {
            try
            {
                var dataEntity = _context.News.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM không tồn tại.",
                    };
                _context.News.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteTag(int Id)
        {
            try
            {
                var dataEntity = _context.Tags.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM không tồn tại.",
                    };
                _context.Tags.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa SIM.",
                };
            }
        }

        public CategoryEditModel GetCategory(int id)
        {
            CategoryEditModel result = new CategoryEditModel();
            var dataEntity = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Summary = dataEntity.Summary;
                result.Url = dataEntity.Url;
                result.Name = dataEntity.Name;
                result.ParentId = dataEntity.ParentId;
            }
            return result;
        }

        public List<SelectListItem> GetCategoryListForCombo(string selectedValue = "")
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Categories.Where(x => !x.IsDelete).ToList();

            selectListItems.Add(new SelectListItem
            {
                Text = "Không có",
                Value = "0"
            });
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                    Selected = item.Id.ToString().Contains(selectedValue) && !string.IsNullOrEmpty(selectedValue)
                });
            }
            return selectListItems;
        }

        public ResponseDataViewModel<CategoryViewModel> GetCategoryPaging(GetPagingRequest request)
        {
            var dataEntity = _context.Categories.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = _context.Categories.Where(x => x.Name.Contains(request.keyword)).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<CategoryViewModel>();
            int idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                var parent = "";
                var category = _context.Categories.FirstOrDefault(x => x.Id == item.ParentId);
                if (category != null)
                {
                    parent = category.Name;
                }
                data.Add(new CategoryViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Parent = parent,
                    Url = item.Url,
                    stt = idx * request.pageIndex,
                    Summary = item.Summary
                });
            }
            //
            return new ResponseDataViewModel<CategoryViewModel>()
            {
                Pager = new Pager(new GetSIMRequest() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

        public NewsEditModel GetNewDetail(int id)
        {
            NewsEditModel result = new NewsEditModel();
            var dataEntity = _context.News.FirstOrDefault(x => x.Id == id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.CategoryId = dataEntity.CategoryId;
                result.Summary = dataEntity.Summary;
                result.Title = dataEntity.Title;
                result.Slug = dataEntity.Slug;
                result.Content = dataEntity.Content;
                result.CreateTime = dataEntity.CreateTime.ToString("G");
            }
            return result;
        }
        public NewsEditModel GetNewDetail(string slug)
        {
            NewsEditModel result = new NewsEditModel();
            var dataEntity = _context.News.FirstOrDefault(x => x.Slug == slug);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.CategoryId = dataEntity.CategoryId;
                result.Summary = dataEntity.Summary;
                result.Title = dataEntity.Title;
                result.Slug = dataEntity.Slug;
                result.Content = dataEntity.Content;
                result.CreateTime = dataEntity.CreateTime.ToString("G");
            }
            return result;
        }

        public ResponseDataViewModel<NewsViewModel> GetNewPaging(GetPagingRequest request)
        {
            var query = from n in _context.News
                        join c in _context.Categories on n.CategoryId equals c.Id into nc
                        from c in nc.DefaultIfEmpty()
                        where n.Title.Contains(request.keyword)
                        select new { n, c };

            var dataPaging = query.Where(x => x.n.Title.Contains(request.keyword)).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<NewsViewModel>();
            int idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                data.Add(new NewsViewModel()
                {
                    Id = item.n.Id,
                    Slug = item.n.Slug,
                    stt = idx * request.pageIndex,
                    Summary = item.n.Summary,
                    Title = item.n.Title,
                    Content = item.n.Content,
                    Category = item.c?.Name
                });
            }
            //
            return new ResponseDataViewModel<NewsViewModel>()
            {
                Pager = new Pager(new GetSIMRequest() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = data
            };
        }
        public ResponseDataViewModel<NewsViewModel> GetNewsOnHomePaging(GetPagingRequest request)
        {
            var query = from n in _context.News
                        join c in _context.Categories on n.CategoryId equals c.Id
                        where n.Title.Contains(request.keyword)
                        orderby n.CreateTime
                        select new { n, c };

            var dataPaging = query.Where(x => x.n.Title.Contains(request.keyword)).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<NewsViewModel>();
            int idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                data.Add(new NewsViewModel()
                {
                    Id = item.n.Id,
                    Slug = item.n.Slug,
                    stt = idx * request.pageIndex,
                    Summary = item.n.Summary,
                    Title = item.n.Title,
                    Content = item.n.Content,
                    Category = item.c.Name,
                    CreateTime = item.n.CreateTime.ToString("G"),
                });
            }
            //
            return new ResponseDataViewModel<NewsViewModel>()
            {
                Pager = new Pager(new GetSIMRequest() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                Data = data
            };
        }

        public TagEditModel GetTag(int id)
        {
            TagEditModel result = new TagEditModel();
            var dataEntity = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                //result.MetaRemark = dataEntity.MetaRemark;
                //result.MetaTitle = dataEntity.MetaTitle;
                //result.MetaKey = dataEntity.MetaKey;
            }
            return result;
        }

        public ResponseDataViewModel<TagViewModel> GetTagPaging(GetPagingRequest request)
        {
            var dataEntity = _context.Tags.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = _context.Tags.Where(x => x.Name.Contains(request.keyword)).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<TagViewModel>();
            int idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                data.Add(new TagViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    //MetaKey = item.MetaKey,
                    //MetaRemark = item.MetaRemark,
                    //MetaTitle = item.MetaTitle,
                    stt = idx * request.pageIndex,
                });
            }
            //
            return new ResponseDataViewModel<TagViewModel>()
            {
                Pager = new Pager(new GetSIMRequest() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> UpdateCategory(CategoryEditModel request)
        {
            try
            {
                var dataEntity = _context.Categories.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.ParentId = request.ParentId;
                dataEntity.Summary = request.Summary;
                dataEntity.Url = request.Url;
                dataEntity.UpdateTime = DateTime.Now;

                _context.Categories.Update(dataEntity);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại SIM.",
                };
            }
        }

        public ResponseDataModel<string> UpdateNew(NewsEditModel request)
        {
            try
            {
                var dataEntity = _context.News.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại.",
                    };
                }

                dataEntity.Title = request.Title;
                dataEntity.CategoryId = request.CategoryId;
                dataEntity.Content = request.Content;
                dataEntity.Summary = request.Summary;
                dataEntity.Slug = request.Slug;
                dataEntity.UpdateTime = DateTime.Now;

                _context.News.Update(dataEntity);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại SIM.",
                };
            }
        }

        public ResponseDataModel<string> UpdateTag(TagEditModel request)
        {
            try
            {
                var dataEntity = _context.Tags.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                //dataEntity.MetaTitle = request.MetaTitle;
                //dataEntity.MetaRemark = request.MetaRemark;
                //dataEntity.MetaTitle = request.MetaTitle;
                //dataEntity.MetaKey = request.MetaKey;
                dataEntity.UpdateTime = DateTime.Now;

                _context.Tags.Update(dataEntity);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại SIM.",
                };
            }
        }
    }
}
