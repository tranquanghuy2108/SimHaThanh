using Commons.Enums;
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
    public interface ICashBookRepository
    {
        List<CashBookModel> GetCashBookByType(GetCashBookOnApp request);
        ResponseDataModel<string> CreateCashBook(CashBookModel request, Guid userId);
        ResponseDataModel<string> UpdateCashBook(CashBookModel request, Guid userId);
        ResponseDataModel<string> ApprovedCashBook(string cashBookids, ApprovedStatus approvedStatus, Guid userId);
        CashBookModel Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        double GetMoneyInCash(Guid userId);
        ResponseDataViewModel<CashBookViewModel> GetCashBookPaging(GetCashBookPagingRequest request);
    }
}
