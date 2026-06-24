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
    public interface IShippingUnitRepository
    {
        ResponseDataViewModel<ShippingUnitModel> GetShippingUnit();
        ResponseDataModel<string> Create(ShippingUnitModel request, Guid userId);
        ResponseDataModel<string> Update(ShippingUnitModel request, Guid userId);
        ShippingUnitModel Detail(int Id);
        ResponseDataModel<string> Delete(int Id, Guid userId);
        List<SelectListItem> GetShippingUnitForCombo();
    }
}
