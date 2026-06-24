using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;
using WebApplicationAPI;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSIMAPI.Controllers
{
    [Route("api/collaborators")]
    [ApiController]
    [Authorize]
    public class CollaboratorsGroupController : ControllerBase
    {
        private readonly ICollaboratorsGroupRepository _collaboratorsGroupRepository;

        public CollaboratorsGroupController(
            ICollaboratorsGroupRepository collaboratorsGroupRepository
        )
        {
            _collaboratorsGroupRepository = collaboratorsGroupRepository;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost("get-my-group")]
        public ResponseDataPagingModel<CollaboratorsGroupViewModels> GetMyGroup(
            [FromBody] Guid userId
        )
        {
            return _collaboratorsGroupRepository.GetMyGroup(userId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost("get-group-had-join")]
        public ResponseDataPagingModel<CollaboratorsGroupViewModels> GetGroupHadJoin(
            [FromBody] Guid userId
        )
        {
            return _collaboratorsGroupRepository.GetGroupHadJoin(userId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost("get-member-in-group")]
        public ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberInGroup(
            [FromBody] int groupId
        )
        {
            return _collaboratorsGroupRepository.GetMemberInGroup(groupId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost("get-member-request-join")]
        public ResponseDataPagingModel<CollaboratorsGroupMemberModel> GetMemberReques(
            [FromBody] Guid userId
        )
        {
            return _collaboratorsGroupRepository.GetMemberRequest(userId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost("get-group-by-id")]
        public CollaboratorsGroupEditModels GetGroupById([FromBody] int Id)
        {
            return _collaboratorsGroupRepository.GetGroupById(Id);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("create-group")]
        public ResponseDataModel<string> CreateGroup(
            [FromBody] CollaboratorsGroupEditModels request
        )
        {
            request.IsApp = true;
            return _collaboratorsGroupRepository.Create(request);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("edit-group")]
        public ResponseDataModel<string> EditGroup([FromBody] CollaboratorsGroupEditModels request)
        {
            request.IsApp = true;
            return _collaboratorsGroupRepository.Edit(request);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("request-join-group")]
        public ResponseDataModel<string> RequestJoinGroup(
            [FromBody] CollaboratorsGroupJoinRequestModels request
        )
        {
            return _collaboratorsGroupRepository.RequestJoin(request);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("approved-request-join-group")]
        public ResponseDataModel<string> ApprovedRequestJoinGroup(
            [FromBody] CollaboratorsGroupApprovedRequestModels request
        )
        {
            return _collaboratorsGroupRepository.Approved(request);
        }
    }
}
