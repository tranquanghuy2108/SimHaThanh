using Commons.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface INewsRepository
    {
        ResponseDataViewModel<NewsViewModel> GetNewPaging(GetPagingRequest request);
        ResponseDataViewModel<NewsViewModel> GetNewsOnHomePaging(GetPagingRequest request);
        NewsEditModel GetNewDetail(int id);
        NewsEditModel GetNewDetail(string slug);
        ResponseDataModel<int> CreateNew(NewsEditModel request, TypeOfPage typeOfPage = TypeOfPage.News);
        ResponseDataModel<string> UpdateNew(NewsEditModel request);
        ResponseDataModel<string> DeleteNew(int Id);
        //
        ResponseDataViewModel<CategoryViewModel> GetCategoryPaging(GetPagingRequest request);
        CategoryEditModel GetCategory(int id);
        ResponseDataModel<int> CreateCategory(CategoryEditModel request);
        ResponseDataModel<string> UpdateCategory(CategoryEditModel request);
        ResponseDataModel<string> DeleteCategory(int Id);
        List<SelectListItem> GetCategoryListForCombo(string selectedValue = "");
        //
        ResponseDataViewModel<TagViewModel> GetTagPaging(GetPagingRequest request);
        TagEditModel GetTag(int id);
        ResponseDataModel<int> CreateTag(TagEditModel request);
        ResponseDataModel<string> UpdateTag(TagEditModel request);
        ResponseDataModel<string> DeleteTag(int Id);
        //
    }
}
