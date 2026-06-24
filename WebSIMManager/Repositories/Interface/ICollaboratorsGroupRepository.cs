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
    public interface ICollaboratorsGroupRepository
    {
        ResponseDataModel<string> Create(CollaboratorsGroupEditModels request);
        ResponseDataModel<string> Edit(CollaboratorsGroupEditModels request);
        ResponseDataModel<string> Delete(int Id);
        ResponseDataModel<string> RequestJoin(CollaboratorsGroupJoinRequestModels request);
        ResponseDataModel<string> Approved(CollaboratorsGroupApprovedRequestModels request);
        CollaboratorsGroupEditModels GetGroupById(int Id);
        ResponseDataPagingModel<CollaboratorsGroupViewModels> GetMyGroup(Guid userId);
        ResponseDataPagingModel<CollaboratorsGroupViewModels> GetGroupHadJoin(Guid userId);
        ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberInGroup(int groupId);
        ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberRequest(Guid userId);
        List<SelectListItem> GetAgentGroupsForCombo(bool isForAgent = false);
        ResponseDataPagingModel<CollaboratorsGroupViewModels> GetAgentGroup(GetPagingRequest request);
    }
}
