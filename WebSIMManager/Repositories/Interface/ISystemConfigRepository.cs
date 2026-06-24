using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface ISystemConfigRepository
    {
        #region AppConfig

        InstallmentSimConfigModel GetInstallmentSimConfig(); 
        ResponseDataModel<string> UpdateAppSysConfig(AppSysConfigModel request, Guid userId);
        AppSysConfigModel GetAppSysConfig();
        #endregion
        #region Country
        ResponseDataModel<string> CreateCountry(CountryModels request, Guid userId);
        public ResponseDataModel<string> DeleteCountry(int Id, Guid userId);
        public CountryModels GetCountryById(int Id);
        public ResponseDataViewModel<CountryModels> GetCountry();
        public ResponseDataModel<string> UpdateCountry(CountryModels request, Guid userId);
        public List<SelectListItem> GetCountryForCombo();
        #endregion
    }
}
