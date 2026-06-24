using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface IAccountRepository
    {
        Task<ResponseDataModel<UserInfoAPIModels>> AuthenticateAPI(LoginRequest request, bool isCMS = true);
        Task<ResponseDataModel<UserInfoModels>> Authenticate(LoginRequest request, bool isCMS = true);
        Task<bool> ForgotPassword(ForgotPassRequest request);
        Task<ResponseDataModel<string>> ChangePassword(ChangePasswordRequest request);
        int GetCountIPLogin(string ip);
        int ResetCountIPLogin(string ip); 
        ResponseDataModel<string> Create(UserCreateRequest request, bool isCMS = true);
        ResponseDataModel<string> CreateUserMobile(UserMobileCreateRequest request);
        ResponseDataModel<UserInfoModels> Update(UserEditRequest request, bool IsApp = false);
        ResponseDataModel<string> Delete(Guid Id, string userId);
        Task<List<UserViewModel>> GetAll();
        ResponseDataViewModel<UserViewModel> GetAllPaging(GetPagingRequest request);
		UserEditRequest GetUserForEdit(Guid Id);
        UserInfoAPIModels GetUserForApp(Guid Id);
        List<SelectListItem> GetListAllUserForCombo();
        ResponseDataViewModel<AgentViewModel> GetAgentList(AgentFilterRequest request);
        ResponseDataViewModel<AgentViewModel> GetConsignmentAgentLst(AgentFilterRequest request);
        ResponseDataViewModel<AgentViewModel> GetCustomerLst(AgentFilterRequest request);
        List<SelectListItem> GetAgentForCombo();
        List<SelectListItem> GetAgentConsigmentForCombo();
        List<SelectListItem> GetAgentAndAgentConsigmentForCombo();
        List<SelectListItem> GetCusAgentForCombo();
        List<SelectListItem> GetStaffForCombo();
        Task<ResponseDataModel<string>> ResetPasswordAsync(string userId);
    }
}
