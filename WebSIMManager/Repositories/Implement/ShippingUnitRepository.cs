using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class ShippingUnitRepository : IShippingUnitRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public ShippingUnitRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataModel<string> Create(ShippingUnitModel request, Guid userId)
        {
            try
            {
                var dataChecking = _context.ShippingUnits.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn vị vận chuyển đã tồn tại",
                    };
                }

                //Create SPContact
                var dataNew = new ShippingUnit()
                {
                    Name = request.Name,
                    APIUrl = request.APIUrl,
                    Token = request.Token,
                    Description = request.Description ?? "",
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.ShippingUnits.Add(dataNew);
                var result = _context.SaveChanges();
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
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo đơn vị vận chuyển.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.ShippingUnits.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                _context.ShippingUnits.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa thành công.",
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

        public ShippingUnitModel Detail(int Id)
        {
            ShippingUnitModel result = new ShippingUnitModel();
            var dataEntity = _context.ShippingUnits.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.APIUrl = dataEntity.APIUrl;
                result.Token = dataEntity.Token;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public ResponseDataViewModel<ShippingUnitModel> GetShippingUnit()
        {
            var dataEntity = _context.ShippingUnits.ToList();
            var data = new List<ShippingUnitModel>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                data.Add(new ShippingUnitModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    APIUrl = item.APIUrl,
                    Token = item.Token,
                    Description = item.Description
                });
            }
            //
            return new ResponseDataViewModel<ShippingUnitModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = 100 }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> Update(ShippingUnitModel request, Guid userId)
        {
            try
            {
                var dataEntity = _context.ShippingUnits.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn vị vận chuyển không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.APIUrl = request.APIUrl;
                dataEntity.Token = request.Token;
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;

                _context.ShippingUnits.Update(dataEntity);
                var result = _context.SaveChanges();
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
        public List<SelectListItem> GetShippingUnitForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.ShippingUnits.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }
    }
}
