using EFCoreMySQL.EntityModels;
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
	public interface IRoleRepository
	{
		ResponseDataPagingModel<RoleGroupView> GetRoleGroupPaging(GetPagingRequest request);
		ResponseDataPagingModel<RoleView> GetRolePaging();
        RoleCreate GetRoleById(Guid Id);
        AppGroupCreate GetGroupById(int Id);
		ResponseDataPagingModel<AppRole> CreateRole(RoleCreate request);
		ResponseDataPagingModel<AppRole> UpdateRole(RoleCreate request);
		ResponseDataPagingModel<AppRole> DeleteRole(Guid Id);
		ResponseDataPagingModel<AppGroup> CreateGroup(AppGroupCreate request);
		ResponseDataPagingModel<AppGroup> UpdateGroup(AppGroupCreate request);
		ResponseDataPagingModel<AppGroup> DeleteGroup(int Id);
		List<SelectListItem> GetRoleListForCombo(string selectedValue = "");
		List<SelectListItem> GetGroupListForCombo(string selectedValue = "", bool isStaffRole = true);
	}
}
