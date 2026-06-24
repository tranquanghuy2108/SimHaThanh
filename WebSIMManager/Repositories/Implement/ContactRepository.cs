using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
    public class ContactRepository : IContactRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public ContactRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataModel<string> CreateSPContact(SPContactCreateModel request)
        {
            try
            {
                var dataChecking = _context.SupportContacts.FirstOrDefault(x => x.PhoneNumber == request.PhoneNumber && !String.IsNullOrEmpty(request.PhoneNumber));
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số hỗ trợ đã tồn tại",
                    };
                }

                //Create SPContact
                var dataNew = new SupportContact()
                {
                    Name = request.Name,
                    PhoneNumber = request.PhoneNumber,
                    Account = request.Account,
                    Description = request.Description,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.SupportContacts.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo số hỗ trợ.",
                };
            }
        }

        public ResponseDataModel<string> DeleteSPContact(int Id)
        {
            try
            {
                var dataEntity = _context.SupportContacts.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số hỗ trợ không tồn tại.",
                    };
                _context.SupportContacts.Remove(dataEntity);
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

        public SPContactEditModel GetSPContactDetail(int Id)
        {
            SPContactEditModel result = new SPContactEditModel();
            var dataEntity = _context.SupportContacts.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.PhoneNumber = dataEntity.PhoneNumber;
                result.Name = dataEntity.Name;
                result.Account = dataEntity.Account;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public List<SPContactViewModel> GetSPContactAPI()
        {
            var dataEntity = _context.SupportContacts.ToList();
            var data = new List<SPContactViewModel>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                data.Add(new SPContactViewModel()
                {
                    stt = idx,
                    Id = item.Id,
                    PhoneNumber = item.PhoneNumber,
                    Name = item.Name,
                    Account = item.Account,
                    Description = item.Description
                });
            }
            //
            return data;
        }

        public ResponseDataViewModel<SPContactViewModel> GetSPContactPaging(GetPagingRequest request)
        {
            var dataEntity = _context.SupportContacts.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = _context.SupportContacts.Where(x => x.Name.Contains(request.keyword)).Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).ToList();
            var data = new List<SPContactViewModel>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                data.Add(new SPContactViewModel()
                {
                    stt = idx * (request.pageIndex),
                    Id = item.Id,
                    PhoneNumber = item.PhoneNumber,
                    Name = item.Name,
                    Account = item.Account,
                    Description = item.Description
                });
            }
            //
            return new ResponseDataViewModel<SPContactViewModel>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> UpdateSPContact(SPContactEditModel request)
        {
            try
            {
                var dataEntity = _context.SupportContacts.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số hỗ trợ không tồn tại.",
                    };
                }

                dataEntity.PhoneNumber = request.PhoneNumber;
                dataEntity.Name = request.Name;
                dataEntity.Account = request.Account;
                dataEntity.Description = request.Description;
                dataEntity.UpdateTime = DateTime.Now;

                _context.SupportContacts.Update(dataEntity);
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
                    Message = "Có lỗi trong quá trình cập nhật nhà mạng.",
                };
            }
        }

        public List<SelectListItem> GetSPContactForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.SupportContacts.ToList();
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
