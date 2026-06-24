using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Commons.Helper;
using Commons.Models;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Repositories.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories.Implement
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public WarehouseRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        //
        #region Material
        public List<MaterialViewModel> GetListMaterial()
        {
            var listMaterial = new List<MaterialViewModel>();
            var materials = _context.Materials.ToList();
            if (materials != null)
            {
                foreach (var material in materials)
                {
                    var network = _context.SIMNetworks.FirstOrDefault(x =>
                        x.Id == material.NetworkId
                    );
                    var materialGroup = _context.MaterialGroups.FirstOrDefault(x =>
                        x.Id == material.MaterialGroupId
                    );
                    var materialType = _context.MaterialTypes.FirstOrDefault(x =>
                        x.Id == material.MaterialTypeId
                    );
                    listMaterial.Add(
                        new MaterialViewModel()
                        {
                            Id = material.Id,
                            Code = material.Code,
                            Name = material.Name,
                            Price = material.Price,
                            Network = network?.NetworkName ?? "",
                            MaterialGroup = materialGroup?.Name ?? "",
                            MaterialType = materialType?.Name ?? "",
                            Description = material.Description,
                            UsingSeria = material.UsingSeria,
                            IsSimEmbryo = material.IsSimEmbryo,
                            IsActive = material.IsActive,
                        }
                    );
                }
            }
            return listMaterial;
        }

        public List<SelectListItem> GetMaterialForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Materials.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public List<SelectListItem> GetMaterialSeriaForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Materials.Where(x => x.UsingSeria).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public ResponseDataViewModel<MaterialSeriaViewModel> GetMaterialWithSeriaInfo(
            GetMateriaSeriaPagingRequest request
        )
        {
            var materialSerias = _context.MaterialSerias.ToList();
            var dataPaging = new List<MaterialSeria>();
            var keyword = request.keyword.Trim();
            if (keyword.StartsWith("84"))
                keyword = keyword.Substring(2);
            if (!string.IsNullOrEmpty(request.keyword))
            {
                if (keyword.StartsWith("PNK"))
                {
                    var grnInfo = _context.GoodsReceivedNotes.FirstOrDefault(x =>
                        x.Code == keyword
                    );
                    if (grnInfo != null)
                    {
                        materialSerias = materialSerias
                            .Where(x => x.GoodsReceivedNoteId == grnInfo.Id)
                            .ToList();
                    }
                    else
                    {
                        materialSerias = new();
                    }
                }
                else if (keyword.StartsWith("PXK"))
                {
                    var gdnInfo = _context.GoodsDeliveryNotes.FirstOrDefault(x =>
                        x.Code == keyword
                    );
                    if (gdnInfo != null)
                    {
                        materialSerias = materialSerias
                            .Where(x => x.GoodsDeliveryNoteId == gdnInfo.Id)
                            .ToList();
                    }
                    else
                    {
                        materialSerias = new();
                    }
                }
                else
                {
                    materialSerias = materialSerias
                        .Where(x =>
                            (x.Number?.Contains(keyword) ?? false)
                            || (x.Seria?.Contains(keyword) ?? false)
                        )
                        .ToList();
                }
            }

            if (!string.IsNullOrEmpty(request.MateriaSeriaIds))
            {
                var msids = request.MateriaSeriaIds.Split(',').Select(id => int.Parse(id)).ToList();
                materialSerias = materialSerias.Where(x => msids.Contains(x.MaterialId)).ToList();
            }

            if (request.HadSelled == "1")
                materialSerias = materialSerias.Where(x => !x.HadSelled).ToList();
            if (request.HadSelled == "2")
                materialSerias = materialSerias.Where(x => x.HadSelled).ToList();

            if (request.isPaged)
                dataPaging = materialSerias
                    .Skip((request.pageIndex - 1) * request.pageSize)
                    .Take(request.pageSize)
                    .ToList();
            else
                dataPaging = materialSerias;

            var data = new List<MaterialSeriaViewModel>();
            var grn = _context.GoodsReceivedNotes.ToList();
            var gdn = _context.GoodsDeliveryNotes.ToList();
            foreach (var item in dataPaging)
            {
                var gdnCode = "";
                if (item.GoodsDeliveryNoteId != 0)
                    gdnCode = gdn.FirstOrDefault(x => x.Id == item.GoodsDeliveryNoteId)?.Code;
                var grnCode = "";
                if (item.GoodsReceivedNoteId != 0)
                    grnCode = grn.FirstOrDefault(x => x.Id == item.GoodsReceivedNoteId)?.Code;
                data.Add(
                    new MaterialSeriaViewModel()
                    {
                        Id = item.Id,
                        gdnId = item.GoodsDeliveryNoteId,
                        gdnCode = gdnCode,
                        grnId = item.GoodsReceivedNoteId,
                        grnCode = grnCode,
                        WarehouseId = item.WarehouseId,
                        MaterialId = item.MaterialId,
                        MaterialCode = item.MaterialCode,
                        MaterialName = item.MaterialName,
                        Number = item.Number,
                        Seria = item.Seria,
                        Position = item.Position,
                        Price = item.Price,
                        Description = item.Description,
                        HadSelled = item.HadSelled,
                    }
                );
            }
            return new ResponseDataViewModel<MaterialSeriaViewModel>()
            {
                Pager = new Pager(
                    new GetSIMRequest()
                    {
                        keyword = "",
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    materialSerias.Count()
                ),
                Data = data,
            };
        }

        public MaterialModel GetMaterialDetail(int id)
        {
            var material = _context.Materials.FirstOrDefault(x => x.Id == id);

            var result = new MaterialModel();
            if (material != null)
            {
                //Tính toán lượng tồn của mặt hàng
                double inventoryQuantity = 0;
                if (material.UsingSeria)
                {
                    var materiaSeriaAmountInWarehouse = _context
                        .MaterialSerias.Where(x =>
                            x.MaterialId == id
                            && !x.HadSelled
                            && x.approvedStatus == ApprovedStatus.Approved
                        )
                        .ToList();
                    if (materiaSeriaAmountInWarehouse.Count > 0)
                    {
                        inventoryQuantity = materiaSeriaAmountInWarehouse.Count;
                    }
                }
                else
                {
                    var materiaAmountInWarehouseGRN = _context
                        .Warehouses.Where(x =>
                            x.MaterialId == id
                            && x.approvedStatus == ApprovedStatus.Approved
                            && x.GoodsReceivedNoteId > 0
                        )
                        .Select(x => x.Amount)
                        .ToList();
                    var materiaAmountInWarehouseGDN = _context
                        .Warehouses.Where(x =>
                            x.MaterialId == id
                            && x.approvedStatus == ApprovedStatus.Approved
                            && x.GoodsDeliveryNoteId > 0
                        )
                        .Select(x => x.Amount)
                        .ToList();
                    if (materiaAmountInWarehouseGRN.Count > 0)
                    {
                        if (materiaAmountInWarehouseGDN.Count > 0)
                        {
                            inventoryQuantity =
                                materiaAmountInWarehouseGRN.Sum()
                                - materiaAmountInWarehouseGDN.Sum();
                        }
                        else
                        {
                            inventoryQuantity = materiaAmountInWarehouseGRN.Sum();
                        }
                    }
                }

                result.Id = material.Id;
                result.Code = material.Code;
                result.Name = material.Name;
                result.Price = material.Price;
                result.Description = material.Description;
                result.UsingSeria = material.UsingSeria;
                result.IsSimEmbryo = material.IsSimEmbryo;
                result.IsActive = material.IsActive;
                result.NetworkId = material.NetworkId;
                result.MaterialGroupId = material.MaterialGroupId;
                result.MaterialTypeId = material.MaterialTypeId;
                result.InventoryQuantity = inventoryQuantity;
            }
            return result;
        }

        public ResponseDataModel<string> CreateMaterial(MaterialModel request, string userId)
        {
            try
            {
                var dataChecking = _context.Materials.Where(x => x.Code == request.Code).ToList();
                if (dataChecking.Count > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã tồn tại.",
                    };
                }
                var newData = new Material()
                {
                    Id = request.Id ?? 0,
                    Code = request.Code,
                    Name = request.Name,
                    Description = request.Description,
                    MaterialGroupId = request.MaterialGroupId,
                    MaterialTypeId = request.MaterialTypeId,
                    NetworkId = request.NetworkId,
                    Price = request.Price ?? 0,
                    UsingSeria = request.UsingSeria,
                    IsActive = request.IsActive,
                    IsSimEmbryo = request.IsSimEmbryo,
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateBy = new Guid(userId),
                    UpdateTime = DateTime.Now,
                };
                _context.Materials.Add(newData);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo hàng hóa",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = "",
                };
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình thêm dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> UpdateMaterial(MaterialModel request, string userId)
        {
            try
            {
                var data = _context.Materials.FirstOrDefault(x => x.Id == request.Id);
                if (data == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(data);

                data.Code = request.Code;
                data.Name = request.Name;
                data.Description = request.Description;
                data.MaterialGroupId = request.MaterialGroupId;
                data.MaterialTypeId = request.MaterialTypeId;
                data.NetworkId = request.NetworkId;
                data.Price = request.Price ?? 0;
                data.UsingSeria = request.UsingSeria;
                data.IsSimEmbryo = request.IsSimEmbryo;
                data.IsActive = request.IsActive;
                data.UpdateBy = new Guid(userId);
                data.UpdateTime = DateTime.Now;
                _context.Materials.Update(data);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật hàng hóa",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
                };
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Chập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteMaterial(int id, string userId)
        {
            try
            {
                var dataEntity = _context.Materials.Find(id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.Materials.Remove(dataEntity);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa mặt hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }
        #endregion
        //
        #region MaterialGroup
        public List<MaterialGroupModel> GetListMaterialGroup()
        {
            var listMaterial = new List<MaterialGroupModel>();
            var materials = _context.MaterialGroups.ToList();
            if (materials != null)
            {
                foreach (var material in materials)
                {
                    listMaterial.Add(
                        new MaterialGroupModel()
                        {
                            Id = material.Id,
                            Code = material.Code,
                            Name = material.Name,
                            Description = material.Description,
                        }
                    );
                }
            }
            return listMaterial;
        }

        public List<SelectListItem> GetMaterialGroupForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.MaterialGroups.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public MaterialGroupModel GetMaterialGroupDetail(int id)
        {
            var material = _context.MaterialGroups.FirstOrDefault(x => x.Id == id);
            var result = new MaterialGroupModel();
            if (material != null)
            {
                result.Id = material.Id;
                result.Code = material.Code;
                result.Name = material.Name;
                result.Description = material.Description;
                result.Note = material.Note;
            }
            return result;
        }

        public ResponseDataModel<string> CreateMaterialGroup(
            MaterialGroupModel material,
            string userId
        )
        {
            try
            {
                var dataChecking = _context
                    .MaterialGroups.Where(x => x.Code == material.Code)
                    .ToList();
                if (dataChecking.Count > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã tồn tại.",
                    };
                }
                var newData = new MaterialGroup()
                {
                    Id = material.Id,
                    Code = material.Code,
                    Name = material.Name,
                    Description = material.Description,
                    Note = material.Note,
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateBy = new Guid(userId),
                    UpdateTime = DateTime.Now,
                };
                _context.MaterialGroups.Add(newData);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo nhóm hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(material),
                    OldData = "",
                };
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình thêm dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> UpdateMaterialGroup(
            MaterialGroupModel material,
            string userId
        )
        {
            try
            {
                var data = _context.MaterialGroups.FirstOrDefault(x => x.Id == material.Id);
                if (data == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(data);
                data.Id = material.Id;
                data.Code = material.Code;
                data.Name = material.Name;
                data.Description = material.Description;
                data.Note = material.Note;
                data.UpdateBy = new Guid(userId);
                data.UpdateTime = DateTime.Now;
                _context.MaterialGroups.Update(data);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật nhóm hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(material),
                    OldData = oldData,
                };
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Chập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteMaterialGroup(int id, string userId)
        {
            try
            {
                var dataEntity = _context.MaterialGroups.Find(id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.MaterialGroups.Remove(dataEntity);
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa nhóm hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }
        #endregion
        //
        #region MaterialType
        public List<MaterialTypeModel> GetListMaterialType()
        {
            var listMaterial = new List<MaterialTypeModel>();
            var materials = _context.MaterialTypes.ToList();
            if (materials != null)
            {
                foreach (var material in materials)
                {
                    listMaterial.Add(
                        new MaterialTypeModel()
                        {
                            Id = material.Id,
                            Code = material.Code,
                            Name = material.Name,
                            Description = material.Description,
                        }
                    );
                }
            }
            return listMaterial;
        }

        public List<SelectListItem> GetMaterialTypeForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.MaterialTypes.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public MaterialTypeModel GetMaterialTypeDetail(int id)
        {
            var material = _context.MaterialTypes.FirstOrDefault(x => x.Id == id);
            var result = new MaterialTypeModel();
            if (material != null)
            {
                result.Id = material.Id;
                result.Code = material.Code;
                result.Name = material.Name;
                result.Description = material.Description;
                result.Note = material.Note;
            }
            return result;
        }

        public ResponseDataModel<string> CreateMaterialType(
            MaterialTypeModel material,
            string userId
        )
        {
            try
            {
                var dataChecking = _context
                    .MaterialTypes.Where(x => x.Code == material.Code)
                    .ToList();
                if (dataChecking.Count > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã tồn tại.",
                    };
                }
                var newData = new MaterialType()
                {
                    Id = material.Id,
                    Code = material.Code,
                    Name = material.Name,
                    Description = material.Description,
                    Note = material.Note,
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateBy = new Guid(userId),
                    UpdateTime = DateTime.Now,
                };
                _context.MaterialTypes.Add(newData);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo loại hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(material),
                    OldData = "",
                };
                _logAction.InsertLogAction(logAction);
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình thêm dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> UpdateMaterialType(
            MaterialTypeModel material,
            string userId
        )
        {
            try
            {
                var data = _context.MaterialTypes.FirstOrDefault(x => x.Id == material.Id);
                if (data == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(data);

                data.Id = material.Id;
                data.Code = material.Code;
                data.Name = material.Name;
                data.Description = material.Description;
                data.Note = material.Note;
                data.UpdateBy = new Guid(userId);
                data.UpdateTime = DateTime.Now;
                _context.MaterialTypes.Update(data);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật loại hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(material),
                    OldData = oldData,
                };
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Chập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteMaterialType(int id, string userId)
        {
            try
            {
                var dataEntity = _context.MaterialTypes.Find(id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.MaterialTypes.Remove(dataEntity);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa loại hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }
        #endregion
        //
        #region GoodsReceivedNote
        public ResponseDataViewModel<GoodsReceivedNoteViewModel> GetListGoodsReceivedNote(
            GoodsReceivedNoteFilterRequest request
        )
        {
            var dataEntity = _context
                .GoodsReceivedNotes.OrderByDescending(x => x.UpdateTime)
                .ToList();
            if (request.SupplierIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.SupplierIds.Contains(x.SupplierId.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.staffIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.staffIds.Contains(x.CreateBy.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.apprStatus != null && ((int)request.apprStatus).ToString() != "0")
            {
                dataEntity = dataEntity
                    .Where(x => x.approvedStatus == request.apprStatus)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }

            var dataPaging = dataEntity
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<GoodsReceivedNoteViewModel>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.SupplierId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.StaffId)?.FullName;
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.ApprovedBy)?.FullName;
                var warehouse = _context
                    .Warehouses.Where(x => x.GoodsReceivedNoteId == item.Id)
                    .Select(x => x.MaterialName)
                    .ToList();
                idx++;

                var result = new GoodsReceivedNoteViewModel();
                result.Id = item.Id;
                result.Code = item.Code;
                result.SupplierId = item.SupplierId;
                result.SupplierName = item.SupplierName;
                result.SupplierPhone = item.SupplierPhone;
                result.SupplierAddress = item.SupplierAddress;
                result.Warehouses = string.Join("\n", warehouse);
                result.StaffId = item.StaffId;
                result.StaffName = item.StaffName;
                result.StaffPhone = item.StaffPhone;
                result.StaffAddress = item.StaffAddress;
                result.TotalPrice = item.TotalPrice;
                result.OtherFee = item.OtherFee;
                result.TienPhaiTra = item.TienPhaiTra;
                result.TienDaTra = item.TienDaTra;
                result.Note = item.Note ?? "";
                result.approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus);
                result.CreateBy = createBy ?? "";
                result.CreateTime = item.CreateTime.ToString("HH:mm:ss dd.MM.yyyy");
                result.ReceivedDate = item.ReceivedDate?.ToString("HH:mm:ss dd.MM.yyyy");
                result.ApprovedBy = apprBy;

                data.Add(result);
            }
            //
            return new ResponseDataViewModel<GoodsReceivedNoteViewModel>()
            {
                Pager = new Pager(
                    new GetSIMRequest()
                    {
                        keyword = "",
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public MaterialSeriaModel GetMaterialSeriaInGoodsReceivedNote(int id)
        {
            var result = new MaterialSeriaModel();
            var materialSeria = _context.MaterialSerias.FirstOrDefault(x =>
                x.GoodsReceivedNoteId == id
            );
            if (materialSeria != null)
            {
                result.Id = materialSeria.Id;
                result.WarehouseId = materialSeria.WarehouseId;
                result.MaterialId = materialSeria.MaterialId;
                result.MaterialCode = materialSeria.MaterialCode;
                result.MaterialName = materialSeria.MaterialName;
                result.Number = materialSeria.Number;
                result.Seria = materialSeria.Seria;
                result.Position = materialSeria.Position;
                result.Price = materialSeria.Price;
                result.Description = materialSeria.Description;
                result.HadSelled = materialSeria.HadSelled;
            }
            return result;
        }

        public GoodsReceivedNoteModel GetGoodsReceivedNoteDetail(int id)
        {
            var dataEntity = _context.GoodsReceivedNotes.FirstOrDefault(x => x.Id == id);
            var result = new GoodsReceivedNoteModel();
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.SupplierId = dataEntity.SupplierId;
                result.SupplierName = dataEntity.SupplierName;
                result.SupplierPhone = dataEntity.SupplierPhone;
                result.SupplierAddress = dataEntity.SupplierAddress;
                result.StaffId = dataEntity.StaffId;
                result.StaffName = dataEntity.StaffName;
                result.StaffPhone = dataEntity.StaffPhone;
                result.StaffAddress = dataEntity.StaffAddress;
                result.TotalPrice = dataEntity.TotalPrice;
                result.OtherFee = dataEntity.OtherFee;
                result.TienPhaiTra = dataEntity.TienPhaiTra;
                result.TienDaTra = dataEntity.TienDaTra;
                result.OldDebt = dataEntity.OldDebt;
                result.NewDebt = dataEntity.NewDebt;
                result.Note = dataEntity.Note;
                result.PayOrderType = dataEntity.PayOrderType;
                result.BankId = dataEntity.BankId;
                result.CongNoPhatSinh = dataEntity.CongNoPhatSinh;
                result.ReceivedDate = dataEntity.ReceivedDate;
                result.approvedStatus = dataEntity.approvedStatus;
                result.ApprovedTime = dataEntity.ApprovedTime;
                result.ApprovedBy = dataEntity.ApprovedBy;
                result.CreateBy = dataEntity.CreateBy;
                result.CreateTime = dataEntity.CreateTime;

                result.Warehouses = new List<WarehouseModel>();
                var warehouses = _context
                    .Warehouses.Where(x => x.GoodsReceivedNoteId == id)
                    .ToList();
                foreach (var item in warehouses)
                {
                    var warehouse = new WarehouseModel();
                    warehouse.Id = item.Id;
                    warehouse.MaterialId = item.MaterialId;
                    warehouse.MaterialTypeId = item.MaterialTypeId;
                    warehouse.Amount = item.Amount;
                    warehouse.Price = item.Price;
                    warehouse.Discount = item.Discount;
                    warehouse.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouse.Note = item.Note;
                    warehouse.UsingSeria = item.UsingSeria;
                    warehouse.approvedStatus = item.approvedStatus;
                    warehouse.ApprovedTime = item.ApprovedTime;
                    warehouse.ApprovedBy = item.ApprovedBy;
                    warehouse.materialSerias = new();
                    if (warehouse.UsingSeria)
                    {
                        var materialSerias = _context
                            .MaterialSerias.Where(x => x.WarehouseId == warehouse.Id)
                            .ToList();
                        foreach (var materialSeria in materialSerias)
                        {
                            var materialSeriaModel = new MaterialSeriaModel();
                            materialSeriaModel.Id = materialSeria.Id;
                            materialSeriaModel.WarehouseId = materialSeria.WarehouseId;
                            materialSeriaModel.MaterialId = materialSeria.MaterialId;
                            materialSeriaModel.MaterialCode = materialSeria.MaterialCode;
                            materialSeriaModel.MaterialName = materialSeria.MaterialName;
                            materialSeriaModel.Number = materialSeria.Number;
                            materialSeriaModel.Seria = materialSeria.Seria;
                            materialSeriaModel.Position = materialSeria.Position;
                            materialSeriaModel.Price = materialSeria.Price;
                            materialSeriaModel.Description = materialSeria.Description;
                            materialSeriaModel.HadSelled = materialSeria.HadSelled;

                            warehouse.materialSerias.Add(materialSeriaModel);
                        }
                    }

                    result.Warehouses.Add(warehouse);
                }
            }
            return result;
        }

        public ResponseDataModel<int> CreateGoodsReceivedNote(
            GoodsReceivedNoteModel request,
            string userId
        )
        {
            try
            {
                var apprStatus = ApprovedStatus.Waiting;
                var debtCodePrefix = "PNK";
                var debtCodeNum = _context
                    .GoodsReceivedNotes.OrderBy(x => x.Id)
                    .Select(x => x.Id)
                    .LastOrDefault();
                var debtCode = debtCodePrefix + (debtCodeNum + 1).ToString("000000");
                var newData = new GoodsReceivedNote();

                newData.Code = debtCode;
                newData.SupplierId = request.SupplierId;
                newData.SupplierName = request.SupplierName ?? "";
                newData.SupplierPhone = request.SupplierPhone ?? "";
                newData.SupplierAddress = request.SupplierAddress ?? "";
                newData.StaffId = request.StaffId;
                newData.StaffName = request.StaffName ?? "";
                newData.StaffPhone = request.StaffPhone ?? "";
                newData.StaffAddress = request.StaffAddress ?? "";
                newData.TotalPrice = request.TotalPrice;
                newData.OtherFee = request.OtherFee;
                newData.TienPhaiTra = request.TienPhaiTra;
                newData.TienDaTra = request.TienDaTra;
                newData.OldDebt = request.OldDebt;
                newData.NewDebt = request.NewDebt;
                newData.Note = request.Note;
                newData.PayOrderType = request.PayOrderType;
                newData.BankId = request.BankId;
                newData.CongNoPhatSinh = request.CongNoPhatSinh;
                newData.ReceivedDate = request.ReceivedDate;
                newData.approvedStatus = apprStatus;
                newData.CreateBy = new Guid(userId);
                newData.CreateTime = DateTime.Now;
                newData.UpdateBy = new Guid(userId);
                newData.UpdateTime = DateTime.Now;
                _context.GoodsReceivedNotes.Add(newData);

                var result = _context.SaveChanges();
                //
                foreach (var item in request.Warehouses)
                {
                    var material = _context.Materials.FirstOrDefault(x => x.Id == item.MaterialId);
                    var warehouse = new Warehouse();
                    warehouse.GoodsReceivedNoteId = newData.Id;
                    warehouse.MaterialId = item.MaterialId;
                    warehouse.MaterialName = material?.Name ?? "";
                    warehouse.MaterialCode = material?.Code ?? "";
                    warehouse.MaterialTypeId = item.MaterialTypeId;
                    warehouse.MaterialTypeCode = item.MaterialTypeCode;
                    warehouse.MaterialTypeName = item.MaterialTypeName;
                    warehouse.Amount = (int)item.Amount;
                    warehouse.Price = item.Price;
                    warehouse.Discount = item.Discount;
                    warehouse.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouse.Note = item.Note;
                    warehouse.UsingSeria = material?.UsingSeria ?? false;
                    warehouse.approvedStatus = apprStatus;
                    warehouse.CreateBy = new Guid(userId);
                    warehouse.CreateTime = DateTime.Now;
                    warehouse.UpdateBy = new Guid(userId);
                    warehouse.UpdateTime = DateTime.Now;
                    _context.Warehouses.Add(warehouse);
                    _context.SaveChanges();
                    if (warehouse.UsingSeria)
                    {
                        foreach (var materialSeria in item.materialSerias)
                        {
                            var materialSeriadata = new MaterialSeria();
                            materialSeriadata.Id = materialSeria.Id;
                            materialSeriadata.GoodsReceivedNoteId = newData.Id;
                            materialSeriadata.GoodsDeliveryNoteId = 0;
                            materialSeriadata.WarehouseId = warehouse.Id;
                            materialSeriadata.MaterialId = warehouse.MaterialId;
                            materialSeriadata.MaterialCode = material?.Code ?? "";
                            materialSeriadata.MaterialName = material?.Name ?? "";
                            materialSeriadata.Number = materialSeria.Number;
                            materialSeriadata.Seria = materialSeria.Seria;
                            materialSeriadata.Position = materialSeria.Position;
                            materialSeriadata.Price = warehouse.Price;
                            materialSeriadata.Description = warehouse.Note;
                            materialSeriadata.HadSelled = false;
                            materialSeriadata.approvedStatus = apprStatus;
                            materialSeriadata.CreateBy = new Guid(userId);
                            materialSeriadata.CreateTime = DateTime.Now;
                            materialSeriadata.UpdateBy = new Guid(userId);
                            materialSeriadata.UpdateTime = DateTime.Now;

                            _context.MaterialSerias.Add(materialSeriadata);
                        }
                    }
                }

                _context.SaveChanges();

                //Ghi công nợ vào tài khoản ngân hàng
                if (request.PayOrderType == PaymentType.Online)
                {
                    var dataBank = new DebtBank()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = newData.approvedStatus,
                        BankId = request.BankId ?? 0,
                        DebtCode = debtCode,
                        Receivables = 0,
                        Liabilities = newData.TienDaTra,
                        FinalDebt = 0 - newData.TienDaTra,
                        Description = "Công nợ bank cho nhập kho " + debtCode,
                        Note = newData.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };

                    var bank = _context.Banks.FirstOrDefault(x => x.Id == newData.BankId);
                    _ = TelegramHelper.SendMessage(
                        -4286160390,
                        "Phiếu nhập kho: "
                            + newData.Code
                            + " vừa thanh toán online số tiền "
                            + newData.TienDaTra
                            + " vào tài khoản "
                            + bank?.AccOwner
                            + " - "
                            + bank?.AccNumber
                    );
                    _context.DebtBanks.Add(dataBank);
                }
                else
                {
                    //Ghi công nợ cho nhân viên nhận hàng
                    var dataStaff = new DebtStaff()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = newData.approvedStatus,
                        StaffId = newData.StaffId ?? new Guid(userId),
                        DebtCode = debtCode,
                        Receivables = 0,
                        Liabilities = newData.TienDaTra,
                        FinalDebt = 0 - newData.TienDaTra,
                        Description = "Công nợ cho người nhận hàng " + debtCode,
                        Note = newData.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtStaffs.Add(dataStaff);
                }
                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (newData.TienPhaiTra != 0)
                {
                    var dataCustomer = new DebtAgent()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = newData.approvedStatus,
                        AgentId = newData.SupplierId ?? new Guid(),
                        DebtCode = debtCode,
                        Receivables = newData.TienDaTra,
                        Liabilities = newData.TotalPrice,
                        FinalDebt = newData.TienDaTra - newData.TotalPrice,
                        Description = "Công nợ của bên nhà cung cấp " + debtCode,
                        Note = newData.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtAgents.Add(dataCustomer);
                }
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo PNK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = "",
                };
                _logAction.InsertLogAction(logAction);
                _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                        Data = newData.Id,
                    };
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                        Data = 0,
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình thêm dữ liệu.",
                    Data = 0,
                };
            }
        }

        public ResponseDataModel<string> UpdateGoodsReceivedNote(
            GoodsReceivedNoteModel request,
            string userId
        )
        {
            try
            {
                var dataEntity = _context.GoodsReceivedNotes.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus != ApprovedStatus.Approved
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                var materialSerias = _context.MaterialSerias.FirstOrDefault(x =>
                    x.GoodsDeliveryNoteId != 0
                    && x.GoodsDeliveryNoteId != null
                    && x.GoodsReceivedNoteId == request.Id
                );
                if (materialSerias != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiếu nhập kho đã có phiếu xuất kho, không thể sửa.",
                    };
                }
                var apprStatus = ApprovedStatus.Waiting;
                var oldData = JsonConvert.SerializeObject(dataEntity);

                dataEntity.SupplierId = request.SupplierId;
                dataEntity.SupplierName = request.SupplierName ?? "";
                dataEntity.SupplierPhone = request.SupplierPhone ?? "";
                dataEntity.SupplierAddress = request.SupplierAddress ?? "";
                dataEntity.StaffId = request.StaffId;
                dataEntity.StaffName = request.StaffName ?? "";
                dataEntity.StaffPhone = request.StaffPhone ?? "";
                dataEntity.StaffAddress = request.StaffAddress ?? "";
                dataEntity.TotalPrice = request.TotalPrice;
                dataEntity.OtherFee = request.OtherFee;
                dataEntity.TienPhaiTra = request.TienPhaiTra;
                dataEntity.TienDaTra = request.TienDaTra;
                dataEntity.OldDebt = request.OldDebt;
                dataEntity.NewDebt = request.NewDebt;
                dataEntity.Note = request.Note;
                dataEntity.PayOrderType = request.PayOrderType;
                dataEntity.BankId = request.BankId;
                dataEntity.CongNoPhatSinh = request.CongNoPhatSinh;
                dataEntity.ReceivedDate = request.ReceivedDate;
                dataEntity.approvedStatus = apprStatus;
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;
                _context.GoodsReceivedNotes.Update(dataEntity);

                var result = _context.SaveChanges();
                //Cập nhật kho
                var warehouseNotUse = _context.Warehouses.Where(x =>
                    x.GoodsReceivedNoteId == request.Id
                );
                if (warehouseNotUse != null)
                    _context.Warehouses.RemoveRange(warehouseNotUse);

                var oldmaterialSeriaItem = _context.MaterialSerias.Where(x =>
                    x.GoodsReceivedNoteId == request.Id
                );
                if (oldmaterialSeriaItem != null)
                    _context.MaterialSerias.RemoveRange(oldmaterialSeriaItem);

                foreach (var item in request.Warehouses)
                {
                    var material = _context.Materials.FirstOrDefault(x => x.Id == item.MaterialId);

                    var warehouseNew = new Warehouse();
                    warehouseNew.GoodsReceivedNoteId = dataEntity.Id;
                    warehouseNew.MaterialId = material?.Id ?? 0;
                    warehouseNew.MaterialName = material?.Name ?? "";
                    warehouseNew.MaterialCode = material?.Code ?? "";
                    warehouseNew.MaterialTypeId = material?.MaterialTypeId ?? 0;
                    warehouseNew.MaterialTypeCode = item.MaterialTypeCode;
                    warehouseNew.MaterialTypeName = item.MaterialTypeName;
                    warehouseNew.Amount = (int)item.Amount;
                    warehouseNew.Price = item.Price;
                    warehouseNew.Discount = item.Discount;
                    warehouseNew.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouseNew.Note = item.Note;
                    warehouseNew.UsingSeria = material?.UsingSeria ?? false;
                    warehouseNew.approvedStatus = apprStatus;
                    warehouseNew.ApprovedTime = item.ApprovedTime;
                    warehouseNew.ApprovedBy = item.ApprovedBy;
                    warehouseNew.UpdateBy = new Guid(userId);
                    warehouseNew.UpdateTime = DateTime.Now;
                    warehouseNew.CreateBy = new Guid(userId);
                    warehouseNew.CreateTime = DateTime.Now;
                    _context.Warehouses.Add(warehouseNew);
                    _context.SaveChanges();
                    if (warehouseNew.UsingSeria)
                    {
                        foreach (var materialSeria in item.materialSerias)
                        {
                            var materialSeriadata = new MaterialSeria();
                            materialSeriadata.Id = materialSeria.Id;
                            materialSeriadata.GoodsReceivedNoteId = dataEntity.Id;
                            materialSeriadata.GoodsDeliveryNoteId = 0;
                            materialSeriadata.WarehouseId = warehouseNew.Id;
                            materialSeriadata.MaterialId = material?.Id ?? 0;
                            materialSeriadata.MaterialCode = material?.Code ?? "";
                            materialSeriadata.MaterialName = material?.Name ?? "";
                            materialSeriadata.Number = materialSeria.Number;
                            materialSeriadata.Seria = materialSeria.Seria;
                            materialSeriadata.Position = materialSeria.Position;
                            materialSeriadata.Price = warehouseNew.Price;
                            materialSeriadata.Description = warehouseNew.Note;
                            materialSeriadata.HadSelled = false;
                            materialSeriadata.approvedStatus = item.approvedStatus;
                            materialSeriadata.CreateBy = new Guid(userId);
                            materialSeriadata.CreateTime = DateTime.Now;
                            materialSeriadata.UpdateBy = new Guid(userId);
                            materialSeriadata.UpdateTime = DateTime.Now;

                            _context.MaterialSerias.Add(materialSeriadata);
                        }
                    }
                }

                _context.SaveChanges();
                //Cập nhật lại công nợ

                //Ghi công nợ vào tài khoản ngân hàng
                if (request.PayOrderType == PaymentType.Online)
                {
                    var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataBank != null)
                    {
                        dataBank.approvedStatus = dataEntity.approvedStatus;
                        dataBank.BankId = request.BankId ?? 0;
                        dataBank.Receivables = 0;
                        dataBank.Liabilities = dataEntity.TienDaTra;
                        dataBank.FinalDebt = 0 - dataEntity.TienDaTra;
                        dataBank.UpdateBy = new Guid(userId);
                        dataBank.UpdateTime = DateTime.Now;
                        _context.DebtBanks.Update(dataBank);
                    }
                    else
                    {
                        var dataBankNew = new DebtBank()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = dataEntity.Code,
                            Receivables = 0,
                            Liabilities = dataEntity.TienDaTra,
                            FinalDebt = 0 - dataEntity.TienDaTra,
                            Description = "Công nợ bank cho nhập kho " + dataEntity.Code,
                            Note = dataEntity.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBankNew);
                    }
                }
                else
                {
                    var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataBank != null)
                    {
                        _context.DebtBanks.Remove(dataBank);
                    }

                    //Ghi công nợ cho nhân viên nhận hàng
                    var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataStaff != null)
                    {
                        dataStaff.approvedStatus = dataEntity.approvedStatus;
                        dataStaff.StaffId = dataEntity.StaffId ?? new Guid(userId);
                        dataStaff.Receivables = 0;
                        dataStaff.Liabilities = dataEntity.TienPhaiTra;
                        dataStaff.FinalDebt = 0 - dataEntity.TienPhaiTra;
                        dataStaff.UpdateBy = new Guid(userId);
                        dataStaff.UpdateTime = DateTime.Now;
                        _context.DebtStaffs.Update(dataStaff);
                    }
                    else
                    {
                        var dataStaffNew = new DebtStaff()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            StaffId = dataEntity.StaffId ?? new Guid(userId),
                            DebtCode = dataEntity.Code,
                            Receivables = 0,
                            Liabilities = dataEntity.TienDaTra,
                            FinalDebt = 0 - dataEntity.TienDaTra,
                            Description = "Công nợ cho người nhận hàng " + dataEntity.Code,
                            Note = dataEntity.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtStaffs.Add(dataStaffNew);
                    }
                }
                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (dataEntity.TienPhaiTra != 0)
                {
                    var dataCustomer = _context.DebtAgents.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataCustomer != null)
                    {
                        dataCustomer.CreateBy = new Guid(userId);
                        dataCustomer.CreateTime = DateTime.Now;
                        dataCustomer.approvedStatus = dataEntity.approvedStatus;
                        dataCustomer.AgentId = dataEntity.SupplierId ?? new Guid();
                        dataCustomer.Receivables = dataEntity.TienDaTra;
                        dataCustomer.Liabilities = dataEntity.TotalPrice;
                        dataCustomer.FinalDebt = dataEntity.TienDaTra - dataEntity.TotalPrice;
                        dataCustomer.UpdateBy = new Guid(userId);
                        dataCustomer.UpdateTime = DateTime.Now;

                        _context.DebtAgents.Update(dataCustomer);
                    }
                    else
                    {
                        var dataCustomerNew = new DebtAgent()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            AgentId = dataEntity.SupplierId ?? new Guid(),
                            DebtCode = dataEntity.Code,
                            Receivables = dataEntity.TienDaTra,
                            Liabilities = dataEntity.TotalPrice,
                            FinalDebt = dataEntity.TienDaTra - dataEntity.TotalPrice,
                            Description = "Công nợ của bên nhà cung cấp " + dataEntity.Code,
                            Note = dataEntity.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataCustomerNew);
                    }
                }
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật PNK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Chập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteGoodsReceivedNote(int id, string userId)
        {
            try
            {
                var dataEntity = _context.GoodsReceivedNotes.Find(id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                //
                var materialSerias = _context.MaterialSerias.FirstOrDefault(x =>
                    x.GoodsDeliveryNoteId != 0
                    && x.GoodsDeliveryNoteId != null
                    && x.GoodsReceivedNoteId == id
                );
                if (materialSerias != null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiếu nhập kho có sản phẩm đã được mua.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.GoodsReceivedNotes.Remove(dataEntity);
                var dataWarehouse = _context.Warehouses.Where(x => x.GoodsReceivedNoteId == id);
                _context.Warehouses.RemoveRange(dataWarehouse);
                var dataMaterialSeria = _context.MaterialSerias.Where(x =>
                    x.GoodsReceivedNoteId == id
                );
                _context.MaterialSerias.RemoveRange(dataMaterialSeria);
                var grnCode = dataEntity.Code;
                //Xóa công nợ bank
                var debtbank = _context.DebtBanks.Where(x => x.DebtCode == grnCode);
                if (debtbank != null)
                {
                    _context.DebtBanks.RemoveRange(debtbank);
                }
                //Xóa công nợ Agent
                var debtAgent = _context.DebtAgents.Where(x => x.DebtCode == grnCode);
                if (debtAgent != null)
                {
                    _context.DebtAgents.RemoveRange(debtAgent);
                }
                //Xóa công nợ Staff
                var debtStaff = _context.DebtStaffs.Where(x => x.DebtCode == grnCode);
                if (debtStaff != null)
                {
                    _context.DebtStaffs.RemoveRange(debtStaff);
                }
                //Xóa công nợ Shipping
                var debtShipping = _context.DebtShippings.Where(x => x.DebtCode == grnCode);
                if (debtShipping != null)
                {
                    _context.DebtShippings.RemoveRange(debtShipping);
                }
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa PNK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> ApprovedGoodsReceivedNote(
            string goodsReceivedNoteIds,
            ApprovedStatus status,
            string userId
        )
        {
            try
            {
                List<string> goodsReceivedNoteIdLst = goodsReceivedNoteIds.Split(",").ToList();
                var dataAppr = _context
                    .GoodsReceivedNotes.Where(x => goodsReceivedNoteIdLst.Contains(x.Id.ToString()))
                    .ToList();
                if (dataAppr == null || dataAppr.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại hoặc đã được duyệt.",
                    };
                }
                foreach (var data in dataAppr)
                {
                    data.UpdateBy = new Guid(userId);
                    data.UpdateTime = DateTime.Now;
                    data.ApprovedBy = new Guid(userId);
                    data.ApprovedTime = DateTime.Now;
                    data.approvedStatus = status;

                    var dataBank = _context.DebtBanks.FirstOrDefault(x => x.DebtCode == data.Code);
                    if (dataBank != null)
                    {
                        dataBank.approvedBy = new Guid(userId);
                        dataBank.approvedTime = DateTime.Now;
                        dataBank.approvedStatus = status;
                        _context.DebtBanks.Update(dataBank);
                    }
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataShipping != null)
                    {
                        dataShipping.approvedBy = new Guid(userId);
                        dataShipping.approvedTime = DateTime.Now;
                        dataShipping.approvedStatus = status;
                        _context.DebtShippings.Update(dataShipping);
                    }
                    var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataStaff != null)
                    {
                        dataStaff.approvedBy = new Guid(userId);
                        dataStaff.approvedTime = DateTime.Now;
                        dataStaff.approvedStatus = status;
                        _context.DebtStaffs.Update(dataStaff);
                    }
                    var dataAgents = _context.DebtAgents.Where(x => x.DebtCode == data.Code);
                    foreach (var agent in dataAgents)
                    {
                        agent.approvedBy = new Guid(userId);
                        agent.approvedTime = DateTime.Now;
                        agent.approvedStatus = status;
                        _context.DebtAgents.Update(agent);
                    }
                    //
                    var warehouses = _context
                        .Warehouses.Where(x => x.GoodsReceivedNoteId == data.Id)
                        .ToList();
                    foreach (var warehouse in warehouses)
                    {
                        warehouse.ApprovedBy = new Guid(userId);
                        warehouse.ApprovedTime = DateTime.Now;
                        warehouse.approvedStatus = status;
                        _context.Warehouses.Update(warehouse);
                        if (warehouse.UsingSeria)
                        {
                            var materialSerias = _context
                                .MaterialSerias.Where(x => x.GoodsReceivedNoteId == data.Id)
                                .ToList();

                            foreach (var materialSeria in materialSerias)
                            {
                                materialSeria.ApprovedBy = new Guid(userId);
                                materialSeria.ApprovedTime = DateTime.Now;
                                materialSeria.approvedStatus = status;
                                _context.MaterialSerias.Update(materialSeria);
                            }
                        }
                    }
                }
                var listDataAprrIds = dataAppr.Select(x => x.Id).ToList();
                var orders = _context.SIMOrders.Where(x => listDataAprrIds.Contains(x.debtId ?? 0));
                foreach (var order in orders)
                {
                    order.UpdateBy = new Guid(userId);
                    order.UpdateTime = DateTime.Now;
                    var statusOrder = StatusOrder.Approved;
                    if (status == ApprovedStatus.Reject)
                        statusOrder = StatusOrder.Cancel;
                    order.Status = statusOrder;
                }
                _context.SIMOrders.UpdateRange(orders);
                _context.GoodsReceivedNotes.UpdateRange(dataAppr);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Approved PNK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData =
                        "PNK có ID: "
                        + goodsReceivedNoteIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), status),
                    OldData =
                        "PNK có ID: "
                        + goodsReceivedNoteIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), dataAppr[0].approvedStatus),
                };
                _logAction.InsertLogAction(logAction);

                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }
        #endregion
        //
        #region GoodsDeliveryNote
        public ResponseDataViewModel<GoodsDeliveryNoteViewModel> GetListGoodsDeliveryNote(
            GoodsDeliveryNoteFilterRequest request
        )
        {
            var dataEntity = _context
                .GoodsDeliveryNotes.OrderByDescending(x => x.UpdateTime)
                .ToList();
            if (request.SupplierIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.SupplierIds.Contains(x.CustomerId.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.staffIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.staffIds.Contains(x.CreateBy.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.apprStatus != null && ((int)request.apprStatus).ToString() != "0")
            {
                dataEntity = dataEntity
                    .Where(x => x.approvedStatus == request.apprStatus)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }

            var dataPaging = dataEntity
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<GoodsDeliveryNoteViewModel>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.CustomerId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy)?.FullName;
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.ApprovedBy)?.FullName;
                var warehouse = _context
                    .Warehouses.Where(x => x.GoodsDeliveryNoteId == item.Id)
                    .Select(x => x.MaterialName)
                    .ToList();
                idx++;

                var result = new GoodsDeliveryNoteViewModel();
                result.Id = item.Id;
                result.Code = item.Code;
                result.CustomerId = item.CustomerId;
                result.CustomerName = item.CustomerName;
                result.CustomerPhone = item.CustomerPhone;
                result.CustomerAddress = item.CustomerAddress;
                result.Warehouses = string.Join("\n", warehouse);
                result.StaffId = item.StaffId;
                result.StaffName = item.StaffName;
                result.StaffPhone = item.StaffPhone;
                result.StaffAddress = item.StaffAddress;
                result.TotalPrice = item.TotalPrice;
                result.OtherFee = item.OtherFee;
                result.PhaiThuConLai = item.PhaiThuConLai;
                result.TienDaThu = item.TienDaThu;
                result.Note = item.Note ?? "";
                result.approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus);
                result.CreateBy = createBy ?? "";
                result.CreateTime = item.CreateTime.ToString("HH:mm:ss dd.MM.yyyy");
                result.DeliveryDate = item.DeliveryDate?.ToString("HH:mm:ss dd.MM.yyyy");
                result.ApprovedBy = apprBy;

                data.Add(result);
            }
            //
            return new ResponseDataViewModel<GoodsDeliveryNoteViewModel>()
            {
                Pager = new Pager(
                    new GetSIMRequest()
                    {
                        keyword = "",
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public GoodsDeliveryNoteModel GetGoodsDeliveryNoteDetail(int id)
        {
            var dataEntity = _context.GoodsDeliveryNotes.FirstOrDefault(x => x.Id == id);
            var result = new GoodsDeliveryNoteModel();
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.ListMaterial = dataEntity.ListMaterial;
                result.CustomerId = dataEntity.CustomerId;
                result.CustomerName = dataEntity.CustomerName;
                result.CustomerPhone = dataEntity.CustomerPhone;
                result.CustomerAddress = dataEntity.CustomerAddress;
                result.StaffId = dataEntity.StaffId;
                result.StaffName = dataEntity.StaffName;
                result.StaffPhone = dataEntity.StaffPhone;
                result.StaffAddress = dataEntity.StaffAddress;
                result.TotalPrice = dataEntity.TotalPrice;
                result.OtherFee = dataEntity.OtherFee;
                result.TienDaThu = dataEntity.TienDaThu;
                result.PhaiThuConLai = dataEntity.PhaiThuConLai;
                result.OldDebt = dataEntity.OldDebt;
                result.NewDebt = dataEntity.NewDebt;
                result.Note = dataEntity.Note;
                result.approvedStatus = dataEntity.approvedStatus;
                result.PayOrderType = dataEntity.PayOrderType;
                result.BankId = dataEntity.BankId;
                result.FormOfDeliveryId = dataEntity.FormOfDeliveryId;
                result.FormOfDeliveryCode = dataEntity.FormOfDeliveryCode;
                result.ShippingUnitId = dataEntity.ShippingUnitId;
                result.ShippingCode = dataEntity.ShippingCode;
                result.ShippingFee = dataEntity.ShippingFee;
                result.COD = dataEntity.COD;
                result.FlagCOD = dataEntity.FlagCOD;
                result.DeliveryAgent = dataEntity.DeliveryAgent;
                result.SoTienThuHo = dataEntity.SoTienThuHo;
                result.CongNoPhatSinhGiaoDichHo = dataEntity.CongNoPhatSinhGiaoDichHo;
                result.FlagThuHo = dataEntity.FlagThuHo;
                result.DeliveryDate = dataEntity.DeliveryDate;
                result.CreateBy = dataEntity.CreateBy;
                result.CreateTime = dataEntity.CreateTime;
                result.ApprovedTime = dataEntity.ApprovedTime;
                result.ApprovedBy = dataEntity.ApprovedBy;
                result.approvedStatus = dataEntity.approvedStatus;

                result.Warehouses = new List<WarehouseModel>();
                var warehouses = _context
                    .Warehouses.Where(x => x.GoodsDeliveryNoteId == id)
                    .ToList();
                foreach (var item in warehouses)
                {
                    var warehouse = new WarehouseModel();
                    warehouse.Id = item.Id;
                    warehouse.MaterialId = item.MaterialId;
                    warehouse.MaterialTypeId = item.MaterialTypeId;
                    warehouse.InventoryQuantity =
                        GetMaterialDetail(item.MaterialId).InventoryQuantity ?? 0;
                    warehouse.Amount = item.Amount;
                    warehouse.Price = item.Price;
                    warehouse.Discount = item.Discount;
                    warehouse.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouse.Note = item.Note;
                    warehouse.UsingSeria = item.UsingSeria;
                    warehouse.approvedStatus = item.approvedStatus;
                    warehouse.ApprovedTime = item.ApprovedTime;
                    warehouse.ApprovedBy = item.ApprovedBy;
                    warehouse.materialSerias = new();
                    if (warehouse.UsingSeria)
                    {
                        var materialSerias = _context
                            .MaterialSerias.Where(x =>
                                x.WarehouseDeliveryId == warehouse.Id || x.GoodsDeliveryNoteId == id
                            )
                            .ToList();

                        warehouse.Amount = materialSerias.Count;
                        foreach (var materialSeria in materialSerias)
                        {
                            var materialSeriaModel = new MaterialSeriaModel();
                            materialSeriaModel.Id = materialSeria.Id;
                            materialSeriaModel.WarehouseId = materialSeria.WarehouseId;
                            materialSeriaModel.MaterialId = materialSeria.MaterialId;
                            materialSeriaModel.MaterialCode = materialSeria.MaterialCode;
                            materialSeriaModel.MaterialName = materialSeria.MaterialName;
                            materialSeriaModel.Number = materialSeria.Number;
                            materialSeriaModel.Seria = materialSeria.Seria;
                            materialSeriaModel.Position = materialSeria.Position;
                            materialSeriaModel.Price = materialSeria.Price;
                            materialSeriaModel.Description = materialSeria.Description;
                            materialSeriaModel.HadSelled = materialSeria.HadSelled;

                            warehouse.materialSerias.Add(materialSeriaModel);
                        }
                    }

                    result.Warehouses.Add(warehouse);
                }
            }
            return result;
        }

        public ResponseDataModel<int> CreateGoodsDeliveryNote(
            GoodsDeliveryNoteModel request,
            string userId
        )
        {
            try
            {
                var apprStatus = ApprovedStatus.Waiting;
                var prefix = "PXK";
                var debtCodeNum = _context
                    .GoodsDeliveryNotes.OrderBy(x => x.Id)
                    .Select(x => x.Id)
                    .LastOrDefault();
                var debtCode = prefix + (debtCodeNum + 1).ToString("000000");
                //Create SPContact
                var dataNew = new GoodsDeliveryNote();
                dataNew.Code = debtCode;
                dataNew.approvedStatus = apprStatus;
                dataNew.CreateBy = new Guid(userId);
                dataNew.UpdateBy = new Guid(userId);
                dataNew.CreateTime = DateTime.Now;
                dataNew.UpdateTime = DateTime.Now;
                dataNew.ListMaterial = "";
                dataNew.CustomerId = request.CustomerId;
                dataNew.CustomerName = request.CustomerName;
                dataNew.CustomerPhone = request.CustomerPhone;
                dataNew.CustomerAddress = request.CustomerAddress;
                dataNew.StaffId = request.StaffId;
                dataNew.StaffName = request.StaffName;
                dataNew.StaffPhone = request.StaffPhone;
                dataNew.StaffAddress = request.StaffAddress;
                dataNew.TotalPrice = request.TotalPrice;
                dataNew.OtherFee = request.OtherFee;
                dataNew.TienDaThu = request.TienDaThu;
                dataNew.PhaiThuConLai = request.PhaiThuConLai;
                dataNew.OldDebt = request.OldDebt;
                dataNew.NewDebt = request.NewDebt;
                dataNew.Note = request.Note;
                dataNew.PayOrderType = request.PayOrderType;
                dataNew.BankId = request.BankId;
                dataNew.FormOfDeliveryId = request.FormOfDeliveryId;
                dataNew.FormOfDeliveryCode = request.FormOfDeliveryCode;
                dataNew.ShippingUnitId = request.ShippingUnitId;
                dataNew.ShippingCode = request.ShippingCode;
                dataNew.ShippingFee = request.ShippingFee;
                dataNew.COD = request.COD;
                dataNew.FlagCOD = request.FlagCOD;
                dataNew.DeliveryAgent = request.DeliveryAgent;
                dataNew.SoTienThuHo = request.SoTienThuHo;
                dataNew.CongNoPhatSinhGiaoDichHo = request.CongNoPhatSinhGiaoDichHo;
                dataNew.FlagThuHo = request.FlagThuHo;
                dataNew.DeliveryDate = request.DeliveryDate;
                _context.GoodsDeliveryNotes.Add(dataNew);
                var result = _context.SaveChanges();
                //
                foreach (var item in request.Warehouses)
                {
                    var material = _context.Materials.FirstOrDefault(x => x.Id == item.MaterialId);
                    var warehouse = new Warehouse();
                    warehouse.GoodsDeliveryNoteId = dataNew.Id;
                    warehouse.MaterialId = item.MaterialId;
                    warehouse.MaterialName = material?.Name ?? "";
                    warehouse.MaterialCode = material?.Code ?? "";
                    warehouse.MaterialTypeId = material?.MaterialTypeId ?? 0;
                    warehouse.MaterialTypeCode = item.MaterialTypeCode;
                    warehouse.MaterialTypeName = item.MaterialTypeName;
                    warehouse.UsingSeria = material?.UsingSeria ?? false;
                    warehouse.Amount = (int)item.Amount;
                    warehouse.Price = item.Price;
                    warehouse.Discount = item.Discount;
                    warehouse.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouse.Note = item.Note;
                    warehouse.approvedStatus = apprStatus;
                    warehouse.CreateBy = new Guid(userId);
                    warehouse.UpdateBy = new Guid(userId);
                    warehouse.CreateTime = DateTime.Now;
                    warehouse.UpdateTime = DateTime.Now;
                    _context.Warehouses.Add(warehouse);
                    _context.SaveChanges();
                    if (warehouse.UsingSeria)
                    {
                        foreach (var materiaSeria in item.materialSerias.ToList())
                        {
                            var ms = _context.MaterialSerias.FirstOrDefault(x =>
                                x.Seria == materiaSeria.Seria
                                && x.Number == materiaSeria.Number
                                && !x.HadSelled
                            );
                            if (ms == null)
                                continue;
                            ms.GoodsDeliveryNoteId = dataNew.Id;
                            ms.WarehouseDeliveryId = warehouse.Id;
                            ms.HadSelled = true;
                            _context.Update(ms);
                        }
                    }
                }

                _context.SaveChanges();

                if (
                    dataNew.FormOfDeliveryId == 1
                    || dataNew.FormOfDeliveryId == 3
                    || dataNew.FormOfDeliveryId == 5
                    || dataNew.FormOfDeliveryId == 6
                    || dataNew.FormOfDeliveryId == 7
                    || dataNew.FormOfDeliveryId == 12
                )
                {
                    //Ghi công nợ vào tài khoản ngân hàng
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = new DebtBank()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataNew.TienDaThu,
                            Description = "Công nợ bank cho phiếu xuất kho " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBank);

                        var bank = _context.Banks.FirstOrDefault(x => x.Id == dataNew.BankId);
                        _ = TelegramHelper.SendMessage(
                            -4286160390,
                            "Phiếu xuất kho: "
                                + dataNew.Code
                                + " vừa thanh toán online số tiền "
                                + dataNew.TienDaThu
                                + " vào tài khoản "
                                + bank?.AccOwner
                                + " - "
                                + bank?.AccNumber
                        );
                    }
                    else
                    {
                        //Ghi công nợ cho nhân viên bán sim
                        var dataStaff = new DebtStaff()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            StaffId = new Guid(userId),
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = dataNew.ShippingFee,
                            FinalDebt = dataNew.TienDaThu - dataNew.ShippingFee,
                            Description =
                                "Công nợ cho người tạo phiếu cho phiếu xuất kho " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtStaffs.Add(dataStaff);
                    }
                }
                if (
                    dataNew.FormOfDeliveryId == 2
                    || dataNew.FormOfDeliveryId == 9
                    || dataNew.FormOfDeliveryId == 10
                    || dataNew.FormOfDeliveryId == 11
                )
                {
                    //Ghi công nợ vào tài khoản ngân hàng
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = new DebtBank()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            BankId = request.BankId ?? 0,
                            DebtCode = debtCode,
                            Receivables = dataNew.TienDaThu,
                            Liabilities = 0,
                            FinalDebt = dataNew.TienDaThu,
                            Description = "Công nợ bank cho phiếu xuất kho " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtBanks.Add(dataBank);

                        var bank = _context.Banks.FirstOrDefault(x => x.Id == dataNew.BankId);
                        _ = TelegramHelper.SendMessage(
                            -4286160390,
                            "Phiếu xuất kho: "
                                + dataNew.Code
                                + " vừa thanh toán online số tiền "
                                + dataNew.TienDaThu
                                + " vào tài khoản "
                                + bank?.AccOwner
                                + " - "
                                + bank?.AccNumber
                        );
                    }
                    else
                    {
                        //Phát sinh đại lý thu hộ
                        var dataDeliveryAgent = new DebtAgent()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataNew.approvedStatus,
                            AgentId = dataNew.DeliveryAgent ?? new Guid(),
                            DebtCode = debtCode,
                            Receivables = 0,
                            Liabilities = dataNew.TienDaThu,
                            FinalDebt = 0 - dataNew.TienDaThu,
                            Description =
                                "Công nợ của đại lí giao hộ hàng cho phiếu xuất kho " + debtCode,
                            Note = dataNew.Note,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataDeliveryAgent);
                    }
                }
                //Ghi công nợ cho bên vận chuyển
                if (dataNew.FormOfDeliveryId == 4 || dataNew.FormOfDeliveryId == 8)
                {
                    var dataShipping = new DebtShipping()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataNew.approvedStatus,
                        ShippingId = dataNew.ShippingUnitId ?? 0,
                        DebtCode = debtCode,
                        Receivables = dataNew.COD,
                        Liabilities = dataNew.ShippingFee,
                        FinalDebt = dataNew.COD - dataNew.ShippingFee,
                        Description = "Công nợ shipping cho phiếu xuất kho " + debtCode,
                        Note = dataNew.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtShippings.Add(dataShipping);
                }
                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (dataNew.PhaiThuConLai != 0)
                {
                    var dataCustomer = new DebtAgent()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataNew.approvedStatus,
                        AgentId = dataNew.CustomerId ?? new Guid(),
                        DebtCode = debtCode,
                        Receivables = dataNew.PhaiThuConLai > 0 ? dataNew.PhaiThuConLai : 0,
                        Liabilities = dataNew.PhaiThuConLai < 0 ? dataNew.PhaiThuConLai * -1 : 0,
                        FinalDebt = dataNew.PhaiThuConLai,
                        Description = "Công nợ của người mua hàng cho phiếu xuất kho " + debtCode,
                        Note = dataNew.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtAgents.Add(dataCustomer);
                }

                _context.SaveChanges();
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo PXK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = "",
                };
                _logAction.InsertLogAction(logAction);
                if (result > 0)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Tạo mới thành công.",
                        Data = dataNew.Id,
                    };
                }
                else
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "0",
                        Message = "Tạo mới thất bại.",
                        Data = 0,
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<int>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình thêm dữ liệu.",
                    Data = 0,
                };
            }
        }

        public ResponseDataModel<string> UpdateGoodsDeliveryNote(
            GoodsDeliveryNoteModel request,
            string userId
        )
        {
            try
            {
                var apprStatus = ApprovedStatus.Waiting;
                var dataEntity = _context.GoodsDeliveryNotes.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus != ApprovedStatus.Approved
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                dataEntity.PayOrderType = request.PayOrderType;
                dataEntity.TienDaThu = request.TienDaThu;
                dataEntity.PhaiThuConLai = request.TotalPrice - request.TienDaThu;
                dataEntity.OldDebt = request.OldDebt;
                dataEntity.NewDebt = request.NewDebt;
                dataEntity.BankId = request.BankId;
                dataEntity.FormOfDeliveryId = request.FormOfDeliveryId;
                dataEntity.FormOfDeliveryCode = request.FormOfDeliveryCode;
                dataEntity.CustomerId = request.CustomerId;
                dataEntity.CustomerName = request.CustomerName;
                dataEntity.CustomerPhone = request.CustomerPhone;
                dataEntity.CustomerAddress = request.CustomerAddress;
                dataEntity.FlagThuHo = request.FlagThuHo;
                dataEntity.DeliveryDate = request.DeliveryDate;
                dataEntity.COD = request.COD;
                dataEntity.FlagCOD = request.FlagCOD;
                dataEntity.OtherFee = request.OtherFee;
                dataEntity.ShippingCode = request.ShippingCode;
                dataEntity.ShippingFee = request.ShippingFee;
                dataEntity.ShippingUnitId = request.ShippingUnitId;
                dataEntity.DeliveryAgent = request.DeliveryAgent;
                dataEntity.Note = request.Note ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.approvedStatus = apprStatus;

                _context.GoodsDeliveryNotes.Update(dataEntity);

                var result = _context.SaveChanges();
                // Cập nhật kho
                var warehouseNotUse = _context.Warehouses.Where(x =>
                    x.GoodsDeliveryNoteId == request.Id
                );

                // Xoá kho cũ
                if (warehouseNotUse != null)
                    _context.Warehouses.RemoveRange(warehouseNotUse);

                foreach (var item in request.Warehouses)
                {
                    var material = _context.Materials.FirstOrDefault(x => x.Id == item.MaterialId);

                    var warehouseNew = new Warehouse();
                    warehouseNew.GoodsDeliveryNoteId = dataEntity.Id;
                    warehouseNew.MaterialId = item.MaterialId;
                    warehouseNew.MaterialName = material?.Name ?? "";
                    warehouseNew.MaterialCode = material?.Code ?? "";
                    warehouseNew.MaterialTypeId = material?.MaterialTypeId ?? 0;
                    warehouseNew.MaterialTypeCode = item.MaterialTypeCode;
                    warehouseNew.MaterialTypeName = item.MaterialTypeName;
                    warehouseNew.UsingSeria = material?.UsingSeria ?? false;
                    warehouseNew.Amount = (int)item.Amount;
                    warehouseNew.Price = item.Price;
                    warehouseNew.Discount = item.Discount;
                    warehouseNew.PriceAfterDiscount = item.PriceAfterDiscount;
                    warehouseNew.Note = item.Note;
                    warehouseNew.approvedStatus = apprStatus;
                    warehouseNew.UpdateBy = new Guid(userId);
                    warehouseNew.UpdateTime = DateTime.Now;
                    _context.Warehouses.Add(warehouseNew);
                    _context.SaveChanges();
                    if (warehouseNew.UsingSeria)
                    {
                        //Update old MaterialSerias
                        var materialSeriasOld = _context
                            .MaterialSerias.Where(x => x.GoodsReceivedNoteId == dataEntity.Id)
                            .ToList();
                        foreach (var materialSeria in materialSeriasOld)
                        {
                            materialSeria.GoodsDeliveryNoteId = 0;
                            materialSeria.WarehouseDeliveryId = 0;
                            materialSeria.HadSelled = false;
                        }
                        _context.MaterialSerias.UpdateRange(materialSeriasOld);

                        foreach (var materiaSeria in item.materialSerias.ToList())
                        {
                            var ms = _context.MaterialSerias.FirstOrDefault(x =>
                                x.Seria == materiaSeria.Seria
                                && x.Number == materiaSeria.Number
                                && !x.HadSelled
                            );
                            if (ms == null)
                                continue;
                            ms.GoodsDeliveryNoteId = dataEntity.Id;
                            ms.WarehouseDeliveryId = warehouseNew.Id;
                            ms.HadSelled = true;
                            _context.MaterialSerias.Update(ms);
                        }
                    }
                }

                _context.SaveChanges();

                if (
                    dataEntity.FormOfDeliveryId == 1
                    || dataEntity.FormOfDeliveryId == 3
                    || dataEntity.FormOfDeliveryId == 5
                    || dataEntity.FormOfDeliveryId == 6
                    || dataEntity.FormOfDeliveryId == 7
                    || dataEntity.FormOfDeliveryId == 12
                )
                {
                    //Cập nhật công nợ bank
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            dataBank.BankId = request.BankId ?? 0;
                            dataBank.Receivables = dataEntity.TienDaThu;
                            dataBank.Liabilities = 0;
                            dataBank.FinalDebt = dataEntity.TienDaThu;
                            dataBank.UpdateBy = new Guid(userId);
                            dataBank.UpdateTime = DateTime.Now;
                            _context.DebtBanks.Update(dataBank);
                        }
                        else
                        {
                            var dataBankNew = new DebtBank()
                            {
                                CreateBy = new Guid(userId),
                                CreateTime = DateTime.Now,
                                approvedStatus = dataEntity.approvedStatus,
                                BankId = request.BankId ?? 0,
                                DebtCode = dataEntity.Code,
                                Receivables = dataEntity.TienDaThu,
                                Liabilities = 0,
                                FinalDebt = dataEntity.TienDaThu,
                                Description = "Công nợ bank cho phiếu xuất kho " + dataEntity.Code,
                                Note = dataEntity.Note,
                                UpdateBy = new Guid(userId),
                                UpdateTime = DateTime.Now,
                            };
                            _context.DebtBanks.Add(dataBankNew);
                        }
                    }
                    else
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            _context.DebtBanks.Remove(dataBank);
                        }

                        //Cập nhật công nợ cho nhân viên
                        var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataStaff != null)
                        {
                            dataStaff.Receivables = dataEntity.TienDaThu;
                            dataStaff.Liabilities = dataEntity.ShippingFee;
                            dataStaff.FinalDebt = dataEntity.TienDaThu - dataEntity.ShippingFee;
                            dataStaff.UpdateBy = new Guid(userId);
                            dataStaff.UpdateTime = DateTime.Now;
                            _context.DebtStaffs.Update(dataStaff);
                        }
                        else
                        {
                            //Ghi công nợ cho nhân viên bán sim
                            var dataStaffNew = new DebtStaff()
                            {
                                CreateBy = new Guid(userId),
                                CreateTime = DateTime.Now,
                                approvedStatus = dataEntity.approvedStatus,
                                StaffId = new Guid(userId),
                                DebtCode = dataEntity.Code,
                                Receivables = dataEntity.TienDaThu,
                                Liabilities = dataEntity.ShippingFee,
                                FinalDebt = dataEntity.TienDaThu - dataEntity.ShippingFee,
                                Description =
                                    "Công nợ cho người tạo phiếu cho phiếu xuất kho "
                                    + dataEntity.Code,
                                Note = dataEntity.Note,
                                UpdateBy = new Guid(userId),
                                UpdateTime = DateTime.Now,
                            };
                            _context.DebtStaffs.Add(dataStaffNew);
                        }
                    }
                }
                //

                //remove data old agent
                var dataAgents = _context.DebtAgents.Where(x => x.DebtCode == dataEntity.Code);
                _context.DebtAgents.RemoveRange(dataAgents);

                if (
                    dataEntity.FormOfDeliveryId == 2
                    || dataEntity.FormOfDeliveryId == 9
                    || dataEntity.FormOfDeliveryId == 10
                    || dataEntity.FormOfDeliveryId == 11
                )
                {
                    //Cập nhật công nợ bank
                    if (request.PayOrderType == PaymentType.Online)
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            dataBank.BankId = request.BankId ?? 0;
                            dataBank.Receivables = dataEntity.TienDaThu;
                            dataBank.Liabilities = 0;
                            dataBank.FinalDebt = dataEntity.TienDaThu;
                            dataBank.UpdateBy = new Guid(userId);
                            dataBank.UpdateTime = DateTime.Now;
                            _context.DebtBanks.Update(dataBank);
                        }
                        else
                        {
                            var dataBankNew = new DebtBank()
                            {
                                CreateBy = new Guid(userId),
                                CreateTime = DateTime.Now,
                                approvedStatus = dataEntity.approvedStatus,
                                BankId = request.BankId ?? 0,
                                DebtCode = dataEntity.Code,
                                Receivables = dataEntity.TienDaThu,
                                Liabilities = 0,
                                FinalDebt = dataEntity.TienDaThu,
                                Description = "Công nợ bank cho phiếu xuất kho " + dataEntity.Code,
                                Note = dataEntity.Note,
                                UpdateBy = new Guid(userId),
                                UpdateTime = DateTime.Now,
                            };
                            _context.DebtBanks.Add(dataBankNew);
                        }
                    }
                    else
                    {
                        var dataBank = _context.DebtBanks.FirstOrDefault(x =>
                            x.DebtCode == dataEntity.Code
                        );
                        if (dataBank != null)
                        {
                            _context.DebtBanks.Remove(dataBank);
                        }

                        //Cập nhật công nợ cho đại lý thu hộ
                        var dataDeliveryAgent = new DebtAgent()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            AgentId = dataEntity.DeliveryAgent ?? new Guid(),
                            DebtCode = dataEntity.Code,
                            Receivables = dataEntity.COD,
                            Liabilities = 0,
                            FinalDebt = dataEntity.COD,
                            Description =
                                "Công nợ của đại lí giao hộ hàng cho phiếu xuất kho "
                                + dataEntity.Code,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtAgents.Add(dataDeliveryAgent);
                    }
                }

                //Phát sinh công nợ khách hàng nếu chưa thanh toán hết
                if (dataEntity.PhaiThuConLai != 0)
                {
                    var dataCustomer = new DebtAgent()
                    {
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        approvedStatus = dataEntity.approvedStatus,
                        AgentId = dataEntity.CustomerId ?? new Guid(),
                        DebtCode = dataEntity.Code,
                        Receivables = dataEntity.PhaiThuConLai > 0 ? dataEntity.PhaiThuConLai : 0,
                        Liabilities =
                            dataEntity.PhaiThuConLai < 0 ? dataEntity.PhaiThuConLai * -1 : 0,
                        FinalDebt = dataEntity.PhaiThuConLai,
                        Description =
                            "Công nợ của người mua hàng cho phiếu xuất kho " + dataEntity.Code,
                        Note = dataEntity.Note,
                        UpdateBy = new Guid(userId),
                        UpdateTime = DateTime.Now,
                    };
                    _context.DebtAgents.Add(dataCustomer);
                }
                //Cập nhật công nợ nhà vận chuyển
                if (dataEntity.FormOfDeliveryId == 4 || dataEntity.FormOfDeliveryId == 8)
                {
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataShipping != null)
                    {
                        dataShipping.ShippingId = dataEntity.ShippingUnitId ?? 0;
                        dataShipping.Receivables = dataEntity.COD;
                        dataShipping.Liabilities = dataEntity.ShippingFee;
                        dataShipping.FinalDebt = dataEntity.COD - dataEntity.ShippingFee;
                        dataShipping.UpdateBy = new Guid(userId);
                        dataShipping.UpdateTime = DateTime.Now;

                        _context.DebtShippings.Update(dataShipping);
                    }
                    else
                    {
                        var dataShippingNew = new DebtShipping()
                        {
                            CreateBy = new Guid(userId),
                            CreateTime = DateTime.Now,
                            approvedStatus = dataEntity.approvedStatus,
                            ShippingId = dataEntity.ShippingUnitId ?? 0,
                            DebtCode = dataEntity.Code,
                            Receivables = dataEntity.COD,
                            Liabilities = 0,
                            FinalDebt = dataEntity.COD,
                            Description = "Công nợ shipping cho phiếu xuất kho " + dataEntity.Code,
                            UpdateBy = new Guid(userId),
                            UpdateTime = DateTime.Now,
                        };
                        _context.DebtShippings.Add(dataShippingNew);
                    }
                }
                else
                {
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == dataEntity.Code
                    );
                    if (dataShipping != null)
                    {
                        _context.DebtShippings.Remove(dataShipping);
                    }
                }

                _context.SaveChanges();
                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Chập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Có lỗi trong quá trình cập nhật dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteGoodsDeliveryNote(int id, string userId)
        {
            try
            {
                var dataEntity = _context.GoodsDeliveryNotes.Find(id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.GoodsDeliveryNotes.Remove(dataEntity);
                var dataWarehouse = _context.Warehouses.Where(x => x.GoodsDeliveryNoteId == id);
                _context.Warehouses.RemoveRange(dataWarehouse);
                //Update old MaterialSerias
                var materialSeriasOld = _context
                    .MaterialSerias.Where(x => x.GoodsDeliveryNoteId == dataEntity.Id)
                    .ToList();
                foreach (var materialSeria in materialSeriasOld)
                {
                    materialSeria.GoodsDeliveryNoteId = 0;
                    materialSeria.WarehouseDeliveryId = 0;
                    materialSeria.HadSelled = false;
                }
                _context.UpdateRange(materialSeriasOld);

                var gdnCode = dataEntity.Code;
                //Xóa công nợ bank
                var debtbank = _context.DebtBanks.Where(x => x.DebtCode == gdnCode);
                if (debtbank != null)
                {
                    _context.DebtBanks.RemoveRange(debtbank);
                }
                //Xóa công nợ Agent
                var debtAgent = _context.DebtAgents.Where(x => x.DebtCode == gdnCode);
                if (debtAgent != null)
                {
                    _context.DebtAgents.RemoveRange(debtAgent);
                }
                //Xóa công nợ Staff
                var debtStaff = _context.DebtStaffs.Where(x => x.DebtCode == gdnCode);
                if (debtStaff != null)
                {
                    _context.DebtStaffs.RemoveRange(debtStaff);
                }
                //Xóa công nợ Shipping
                var debtShipping = _context.DebtShippings.Where(x => x.DebtCode == gdnCode);
                if (debtShipping != null)
                {
                    _context.DebtShippings.RemoveRange(debtShipping);
                }
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa PXK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa dữ liệu thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> ApprovedGoodsDeliveryNote(
            string GoodsDeliveryNoteIds,
            ApprovedStatus status,
            string userId
        )
        {
            try
            {
                List<string> GoodsDeliveryNoteIdLst = GoodsDeliveryNoteIds.Split(",").ToList();
                var dataAppr = _context
                    .GoodsDeliveryNotes.Where(x => GoodsDeliveryNoteIdLst.Contains(x.Id.ToString()))
                    .ToList();
                if (dataAppr == null || dataAppr.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại hoặc đã được duyệt.",
                    };
                }
                foreach (var data in dataAppr)
                {
                    data.UpdateBy = new Guid(userId);
                    data.UpdateTime = DateTime.Now;
                    data.ApprovedBy = new Guid(userId);
                    data.ApprovedTime = DateTime.Now;
                    data.approvedStatus = status;

                    var dataBank = _context.DebtBanks.FirstOrDefault(x => x.DebtCode == data.Code);
                    if (dataBank != null)
                    {
                        dataBank.approvedBy = new Guid(userId);
                        dataBank.approvedTime = DateTime.Now;
                        dataBank.approvedStatus = status;
                        _context.DebtBanks.Update(dataBank);
                    }
                    var dataShipping = _context.DebtShippings.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataShipping != null)
                    {
                        dataShipping.approvedBy = new Guid(userId);
                        dataShipping.approvedTime = DateTime.Now;
                        dataShipping.approvedStatus = status;
                        _context.DebtShippings.Update(dataShipping);
                    }
                    var dataStaff = _context.DebtStaffs.FirstOrDefault(x =>
                        x.DebtCode == data.Code
                    );
                    if (dataStaff != null)
                    {
                        dataStaff.approvedBy = new Guid(userId);
                        dataStaff.approvedTime = DateTime.Now;
                        dataStaff.approvedStatus = status;
                        _context.DebtStaffs.Update(dataStaff);
                    }
                    var dataAgents = _context.DebtAgents.Where(x => x.DebtCode == data.Code);
                    foreach (var agent in dataAgents)
                    {
                        agent.approvedBy = new Guid(userId);
                        agent.approvedTime = DateTime.Now;
                        agent.approvedStatus = status;
                        _context.DebtAgents.Update(agent);
                    }
                    //
                    var warehouses = _context
                        .Warehouses.Where(x => x.GoodsDeliveryNoteId == data.Id)
                        .ToList();
                    foreach (var warehouse in warehouses)
                    {
                        warehouse.ApprovedBy = new Guid(userId);
                        warehouse.ApprovedTime = DateTime.Now;
                        warehouse.approvedStatus = status;
                        _context.Warehouses.Update(warehouse);
                    }
                }
                _context.GoodsDeliveryNotes.UpdateRange(dataAppr);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Approved PXK",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData =
                        "PXK có ID: "
                        + GoodsDeliveryNoteIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), status),
                    OldData =
                        "PXK có ID: "
                        + GoodsDeliveryNoteIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), dataAppr[0].approvedStatus),
                };
                _logAction.InsertLogAction(logAction);

                if (result > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Cập nhật thành công.",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }
        #endregion
        //
        #region Other

        //Kiểm tra danh sách import materialseria có trong hệ thống không
        public List<ReadMaterialSeriaCSVModel> CheckMaterialSerias(
            List<ReadMaterialSeriaCSVModel> request,
            bool isDelivery = true,
            int gdnid = 0,
            int materiaId = 0
        )
        {
            bool isOtherWarehouse = false;
            List<ReadMaterialSeriaCSVModel> response = new();
            request = request.DistinctBy(x => (x.seria, x.phoneNumber)).ToList();
            if (isDelivery)
            {
                var numberLst = request.Select(r => r.phoneNumber).ToList();
                var seriaLst = request.Select(r => r.seria).ToList();
                var warehouseLst = _context
                    .MaterialSerias.Where(x =>
                        numberLst.Contains(x.Number)
                        && seriaLst.Contains(x.Seria)
                        && !x.HadSelled
                        && gdnid != 0
                    )
                    .Select(x => x.WarehouseId)
                    .Distinct()
                    .ToList();
                if (warehouseLst.Count > 1)
                    isOtherWarehouse = true;
            }
            foreach (var item in request)
            {
                ReadMaterialSeriaCSVModel data = new ReadMaterialSeriaCSVModel();

                data.phoneNumber = item.phoneNumber;
                data.seria = item.seria;
                data.price = item.price;
                data.position = item.position;
                data.isValid = true;
                //
                var result = "";
                if (isDelivery)
                {
                    var dataReceive = _context
                        .MaterialSerias.Where(x =>
                            x.Seria == item.seria && x.Number == item.phoneNumber
                        )
                        .ToList();
                    if (dataReceive.Count <= 0)
                    {
                        result = "Số và seria của loại hàng không có trong kho";
                        data.isValid = false;
                    }
                    else
                    {
                        if (isOtherWarehouse)
                        {
                            var dataMS = dataReceive.FirstOrDefault();
                            var grnCode = _context
                                .GoodsReceivedNotes.FirstOrDefault(x =>
                                    x.Id == dataMS.GoodsReceivedNoteId
                                )
                                ?.Code;
                            result =
                                "Số và seria khác PNK ("
                                + grnCode
                                + "_wh"
                                + dataMS.WarehouseId
                                + ")";
                            data.isValid = false;
                        }
                        else
                        {
                            // Kiểm tra số khả dụng
                            var dataReceiveTmp = dataReceive
                                .Where(x =>
                                    (x.approvedStatus == ApprovedStatus.Approved && !x.HadSelled)
                                    || (x.GoodsDeliveryNoteId == gdnid && gdnid != 0)
                                )
                                .ToList();
                            if (dataReceiveTmp.Count <= 0)
                            {
                                result = "Số và seria chưa được duyệt hoặc đã bán";
                                data.isValid = false;
                            }
                            // Kiểm tra loại mặt hàng
                            var dataReceiveOnWarehouseTmp = dataReceiveTmp
                                .Where(x => x.MaterialId == materiaId)
                                .ToList();
                            if (dataReceiveOnWarehouseTmp.Count <= 0)
                            {
                                result = "Số và seria không đúng với loại sim bạn nhập";
                                data.isValid = false;
                            }
                        }
                    }
                }
                else
                {
                    var dataReceive = _context
                        .MaterialSerias.Where(x =>
                            (x.Seria == item.seria || x.Number == item.phoneNumber)
                            && x.GoodsReceivedNoteId != gdnid
                        )
                        .ToList();
                    if (dataReceive.Count > 0)
                    {
                        data.isValid = false;
                        var hadSelledData = dataReceive.Where(x => !x.HadSelled).ToList();
                        if (hadSelledData.Count > 0)
                            result = "Số hoặc seria đã có trong kho và chưa bán";
                        else
                            result = "Số hoặc seria đã có trong kho";
                    }
                }
                data.result = result;
                response.Add(data);
            }
            return response;
        }
        #endregion
    }
}
