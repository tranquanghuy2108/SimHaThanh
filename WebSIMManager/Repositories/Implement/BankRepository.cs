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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Repositories.Implement
{
    public class BankRepository : IBankRepository
    {
        private readonly SIMCenterDbContext _context; 
        private readonly LogActionRepository _logAction;
        public BankRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataModel<string> Create(BankModels request, Guid userId)
        {
            try
            {
                var dataChecking = _context.Banks.FirstOrDefault(x => x.Name == request.Name && x.AccNumber == request.Number);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản ngân hàng đã tồn tại",
                    };
                }

                //Create SPContact
                var dataNew = new Bank()
                {
                    Name = request.Name,
                    Branch = request.Branch,
                    AccNumber = request.Number,
                    AccOwner = request.Owner,
                    Description = request.Description ?? "",
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Banks.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo tài khoản ngân hàng.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Banks.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "TK ngân hàng không tồn tại.",
                    };
                _context.Banks.Remove(dataEntity);
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

        public BankModels Detail(int Id)
        {
            BankModels result = new BankModels();
            var dataEntity = _context.Banks.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.Branch = dataEntity.Branch;
                result.Number = dataEntity.AccNumber;
                result.Owner = dataEntity.AccOwner;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public ResponseDataViewModel<BankModels> GetBank()
        {
            var dataEntity = _context.Banks.ToList();
            var data = new List<BankModels>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                data.Add(new BankModels()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Branch = item.Branch,
                    Number = item.AccNumber,
                    Owner = item.AccOwner,
                    Description = item.Description
                });
            }
            //
            return new ResponseDataViewModel<BankModels>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = 100 }, dataEntity.Count()),
                Data = data
            };
        }
        public BankModels GetBankForApp()
        {
            var dataEntity = _context.Banks.FirstOrDefault();
            var data = new BankModels();
            if (dataEntity != null)
            {
                data.Id = dataEntity.Id;
                data.Name = dataEntity.Name;
                data.Number = dataEntity.AccNumber;
                data.Owner = dataEntity.AccOwner;
                data.Description = dataEntity.Description;
            }
            return data;
        }

        public ResponseDataModel<string> Update(BankModels request, Guid userId)
        {
            try
            {
                var dataEntity = _context.Banks.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản ngân hàng không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.Branch = request.Branch;
                dataEntity.AccNumber = request.Number;
                dataEntity.AccOwner = request.Owner;
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;

                _context.Banks.Update(dataEntity);
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
        public List<SelectListItem> GetBankForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Banks.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = item.Name + "-" + item.AccNumber + "-" + item.AccOwner,
                    Value = item.Id.ToString(),
                });
            }
            return selectListItems;
        }
    }
}
