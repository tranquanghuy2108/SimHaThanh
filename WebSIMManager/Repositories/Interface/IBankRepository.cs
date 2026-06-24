using Commons.Models;
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
    public interface IBankRepository
    {
        ResponseDataViewModel<BankModels> GetBank();
        ResponseDataModel<string> Create(BankModels request, Guid userId);
        ResponseDataModel<string> Update(BankModels request, Guid userId);
        BankModels Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        List<SelectListItem> GetBankForCombo();
        BankModels GetBankForApp();
    }
}
