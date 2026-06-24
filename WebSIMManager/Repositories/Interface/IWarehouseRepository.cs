using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Commons.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface IWarehouseRepository
    {
        //
        #region Material
        public List<MaterialViewModel> GetListMaterial();
        public List<SelectListItem> GetMaterialForCombo();
        public List<SelectListItem> GetMaterialSeriaForCombo();
        public ResponseDataViewModel<MaterialSeriaViewModel> GetMaterialWithSeriaInfo(
            GetMateriaSeriaPagingRequest request
        );
        public MaterialModel GetMaterialDetail(int id);
        public ResponseDataModel<string> CreateMaterial(MaterialModel material, string userId);
        public ResponseDataModel<string> UpdateMaterial(MaterialModel material, string userId);
        public ResponseDataModel<string> DeleteMaterial(int id, string userId);
        #endregion
        //
        #region MaterialGroup
        public List<MaterialGroupModel> GetListMaterialGroup();
        public List<SelectListItem> GetMaterialGroupForCombo();
        public MaterialGroupModel GetMaterialGroupDetail(int id);
        public ResponseDataModel<string> CreateMaterialGroup(
            MaterialGroupModel material,
            string userId
        );
        public ResponseDataModel<string> UpdateMaterialGroup(
            MaterialGroupModel material,
            string userId
        );
        public ResponseDataModel<string> DeleteMaterialGroup(int id, string userId);
        #endregion
        //
        #region MaterialType
        public List<MaterialTypeModel> GetListMaterialType();
        public List<SelectListItem> GetMaterialTypeForCombo();
        public MaterialTypeModel GetMaterialTypeDetail(int id);
        public ResponseDataModel<string> CreateMaterialType(
            MaterialTypeModel material,
            string userId
        );
        public ResponseDataModel<string> UpdateMaterialType(
            MaterialTypeModel material,
            string userId
        );
        public ResponseDataModel<string> DeleteMaterialType(int id, string userId);
        #endregion
        //
        #region GoodsReceivedNote
        public ResponseDataViewModel<GoodsReceivedNoteViewModel> GetListGoodsReceivedNote(
            GoodsReceivedNoteFilterRequest request
        );
        public MaterialSeriaModel GetMaterialSeriaInGoodsReceivedNote(int id);
        public GoodsReceivedNoteModel GetGoodsReceivedNoteDetail(int id);
        public ResponseDataModel<int> CreateGoodsReceivedNote(
            GoodsReceivedNoteModel request,
            string userId
        );
        public ResponseDataModel<string> UpdateGoodsReceivedNote(
            GoodsReceivedNoteModel request,
            string userId
        );
        public ResponseDataModel<string> DeleteGoodsReceivedNote(int id, string userId);
        public ResponseDataModel<string> ApprovedGoodsReceivedNote(
            string goodsReceivedNoteIds,
            ApprovedStatus status,
            string userId
        );
        #endregion
        //
        #region GoodsDeliveryNote
        public ResponseDataViewModel<GoodsDeliveryNoteViewModel> GetListGoodsDeliveryNote(
            GoodsDeliveryNoteFilterRequest request
        );
        public GoodsDeliveryNoteModel GetGoodsDeliveryNoteDetail(int id);
        public ResponseDataModel<int> CreateGoodsDeliveryNote(
            GoodsDeliveryNoteModel request,
            string userId
        );
        public ResponseDataModel<string> UpdateGoodsDeliveryNote(
            GoodsDeliveryNoteModel request,
            string userId
        );
        public ResponseDataModel<string> DeleteGoodsDeliveryNote(int id, string userId);
        public ResponseDataModel<string> ApprovedGoodsDeliveryNote(
            string GoodsDeliveryNoteIds,
            ApprovedStatus status,
            string userId
        );
        #endregion
        #region Other
        public List<ReadMaterialSeriaCSVModel> CheckMaterialSerias(
            List<ReadMaterialSeriaCSVModel> request,
            bool isDelivery,
            int gdnid,
            int materiaId
        );
        #endregion
    }
}
