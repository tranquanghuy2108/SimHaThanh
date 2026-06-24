using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class SystemConfigRepository : ISystemConfigRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public SystemConfigRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }


        public InstallmentSimConfigModel GetInstallmentSimConfig()
        {
            InstallmentSimConfigModel result = new();
            var config = _context.SystemConfigs.FirstOrDefault();
            if (config != null)
            {
                result.Installment_MinimumPaymentRate = config.Installment_MinimumPaymentRate;
                result.Installment_DailyInterestRate = config.Installment_DailyInterestRate;
            }
            return result;
        }

        public ResponseDataModel<string> UpdateAppSysConfig(AppSysConfigModel request, Guid userId)
        {
            try
            {
                var dataEntity = _context.SystemConfigs.FirstOrDefault();
                if (dataEntity == null)
                {
                    var appConfig = new SystemConfig()
                    {
                        Installment_DailyInterestRate = request.Installment_DailyInterestRate,
                        Installment_MinimumPaymentRate = request.Installment_MinimumPaymentRate,
                        Auction_WaitingTime = request.Auction_WaitingTime,
                        Auction_Deposit = request.Auction_Deposit,
                        AskSim_AskingTime = request.AskSim_AskingTime,
                        AskSim_SimNumber = request.AskSim_SimNumber,
                        CreateBy = userId,
                        CreateTime = DateTime.Now,
                        UpdateBy = userId,
                        UpdateTime = DateTime.Now,
                    };
                    _context.SystemConfigs.Add(appConfig);
                }
                else
                {
                    dataEntity.Installment_DailyInterestRate = request.Installment_DailyInterestRate;
                    dataEntity.Installment_MinimumPaymentRate = request.Installment_MinimumPaymentRate;
                    dataEntity.Auction_WaitingTime = request.Auction_WaitingTime;
                    dataEntity.Auction_Deposit = request.Auction_Deposit;
                    dataEntity.AskSim_AskingTime = request.AskSim_AskingTime;
                    dataEntity.AskSim_SimNumber = request.AskSim_SimNumber;
                    dataEntity.UpdateBy = userId;
                    dataEntity.UpdateTime = DateTime.Now;

                    _context.SystemConfigs.Update(dataEntity);
                }
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
        public AppSysConfigModel GetAppSysConfig()
        {
            AppSysConfigModel result = new AppSysConfigModel();
            var dataEntity = _context.SystemConfigs.FirstOrDefault();
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Installment_DailyInterestRate = dataEntity.Installment_DailyInterestRate;
                result.Installment_MinimumPaymentRate = dataEntity.Installment_MinimumPaymentRate;
                result.Auction_WaitingTime = dataEntity.Auction_WaitingTime;
                result.Auction_Deposit = dataEntity.Auction_Deposit;
                result.AskSim_AskingTime = dataEntity.AskSim_AskingTime;
                result.AskSim_SimNumber = dataEntity.AskSim_SimNumber;
            }
            return result;
        }

        #region Country

        public ResponseDataModel<string> CreateCountry(CountryModels request, Guid userId)
        {
            try
            {
                var dataChecking = _context.Countries.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã tồn tại",
                    };
                }

                //Create SPContact
                var dataNew = new Country()
                {
                    Name = request.Name,
                    Note = request.Note,
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.Countries.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo dữ liệu.",
                };
            }
        }

        public ResponseDataModel<string> DeleteCountry(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Countries.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                _context.Countries.Remove(dataEntity);
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

        public CountryModels GetCountryById(int Id)
        {
            CountryModels result = new CountryModels();
            var dataEntity = _context.Countries.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.Note = dataEntity.Note;
            }
            return result;
        }

        public ResponseDataViewModel<CountryModels> GetCountry()
        {
            var dataEntity = _context.Countries.ToList();
            var data = new List<CountryModels>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                data.Add(new CountryModels()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Note = item.Note
                });
            }
            //
            return new ResponseDataViewModel<CountryModels>()
            {
                Pager = new Pager(new PagingRequestBase() { keyword = "", pageIndex = 1, pageSize = 100 }, dataEntity.Count()),
                Data = data
            };
        }

        public ResponseDataModel<string> UpdateCountry(CountryModels request, Guid userId)
        {
            try
            {
                var dataEntity = _context.Countries.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Tài khoản ngân hàng không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.Note = request.Note;
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;

                _context.Countries.Update(dataEntity);
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
        public List<SelectListItem> GetCountryForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.Countries.ToList();
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
        #endregion
    }
}
