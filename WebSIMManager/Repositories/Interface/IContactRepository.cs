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
    public interface IContactRepository
    {
        ResponseDataViewModel<SPContactViewModel> GetSPContactPaging(GetPagingRequest request);
        List<SPContactViewModel> GetSPContactAPI();
        ResponseDataModel<string> CreateSPContact(SPContactCreateModel request);
        ResponseDataModel<string> UpdateSPContact(SPContactEditModel request);
        SPContactEditModel GetSPContactDetail(int Id);
        ResponseDataModel<string> DeleteSPContact(int Id);
        List<SelectListItem> GetSPContactForCombo();
    }
}
