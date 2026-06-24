using Commons.Enums;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
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

namespace Repositories.Implement
{
    public class AppContentRepository : IAppContentRepository
    {

        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;
        public AppContentRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }
        public ResponseDataViewModel<FlashSaleModel> GetFlashSalePaging(GetPagingRequest request)
        {
            try
            {
                if (request.keyword == null) request.keyword = string.Empty;
                var query = _context.FlashSales.Where(x => x.Name.Contains(request.keyword));
                var dataPaging = query.ToList().Skip(request.pageIndex - 1).Take(request.pageSize);
                List<FlashSaleModel> data = new();
                foreach (var item in dataPaging)
                {
                    var simOnFlashSale = _context.SIMOnFlashSales.Where(x => x.FlashSaleId == item.Id);
                    List<SIMOnFlashSaleModel> simInfos = new();
                    foreach (var simInfo in simOnFlashSale)
                    {
                        simInfos.Add(new SIMOnFlashSaleModel()
                        {
                            FlashSaleId = item.Id,
                            SalePrice = simInfo.SalePrice,
                            Discount = simInfo.Discount,
                            SimId = simInfo.SimId,
                            SimNumber = simInfo.SimNumber,
                            SimPrice = simInfo.SimPrice,
                        });
                    }
                    data.Add(new FlashSaleModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        StartTime = item.StartTime,
                        EndTime = item.EndTime,
                        Description = item.Description,
                        SimFlashSaleInfos = simInfos,
                    });
                }
                return new ResponseDataViewModel<FlashSaleModel>()
                {
                    Pager = new Pager(new PagingRequestBase() { keyword = request.keyword, pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count()),
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataViewModel<FlashSaleModel>();
            }
        }

        public ResponseDataModel<string> CreateFlashSale(FlashSaleModel request, string userId)
        {
            try
            {
                var dataChecking = _context.FlashSales.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiên FlashSale đã tồn tại",
                    };
                }

                //Create SPContact
                var dataNew = new FlashSale()
                {
                    Name = request.Name,
                    StartTime = request.StartTime,
                    EndTime = request.EndTime,
                    Description = request.Description ?? "",
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.FlashSales.Add(dataNew);
                var result = _context.SaveChanges();
                foreach (var item in request.SimFlashSaleInfos)
                {
                    _context.SIMOnFlashSales.Add(new SIMOnFlashSale()
                    {
                        FlashSaleId = dataNew.Id,
                        SalePrice = item.SalePrice,
                        SimId = item.SimId,
                        SimNumber = item.SimNumber,
                        SimPrice = item.SimPrice,
                        Discount = item.Discount,
                        NetworkId = item.NetworkId,
                    });
                }
                _context.SaveChanges();
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

        public ResponseDataModel<string> UpdateFlashSale(FlashSaleModel request, string userId)
        {
            try
            {
                var dataEntity = _context.FlashSales.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiên flashsale không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.StartTime = request.StartTime;
                dataEntity.EndTime = request.EndTime;
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;

                _context.FlashSales.Update(dataEntity);
                var simOnFlashsaleOld = _context.SIMOnFlashSales.Where(x => x.FlashSaleId == request.Id).ToList();
                _context.SIMOnFlashSales.RemoveRange(simOnFlashsaleOld);
                foreach (var item in request.SimFlashSaleInfos)
                {
                    _context.SIMOnFlashSales.Add(new SIMOnFlashSale()
                    {
                        FlashSaleId = dataEntity.Id,
                        SalePrice = item.SalePrice,
                        SimId = item.SimId,
                        SimNumber = item.SimNumber,
                        Discount = item.Discount,
                        SimPrice = item.SimPrice,
                        NetworkId = item.NetworkId,
                    });
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

        public ResponseDataModel<string> DeleteFlashSale(int Id, string userId)
        {
            try
            {
                var dataEntity = _context.FlashSales.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Phiên flashsale không tồn tại.",
                    };
                _context.FlashSales.Remove(dataEntity);
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

        public FlashSaleModel GetFlashSaleDetail(int Id)
        {
            FlashSaleModel result = new FlashSaleModel();
            var dataEntity = _context.FlashSales.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.StartTime = dataEntity.StartTime;
                result.EndTime = dataEntity.EndTime;
                result.Description = dataEntity.Description;
                List<SIMOnFlashSaleModel> simInfos = new();
                var simOnFlashSales = _context.SIMOnFlashSales.Where(x => x.FlashSaleId == Id);
                foreach (var simInfo in simOnFlashSales)
                {
                    simInfos.Add(new SIMOnFlashSaleModel()
                    {
                        FlashSaleId = simInfo.FlashSaleId,
                        SalePrice = simInfo.SalePrice,
                        SimId = simInfo.SimId,
                        SimNumber = simInfo.SimNumber,
                        SimPrice = simInfo.SimPrice,
                        Discount = simInfo.Discount,
                        NetworkId = simInfo.NetworkId,
                    });
                }
                result.SimFlashSaleInfos = simInfos;
            }
            return result;
        }

        public List<SIMOnFlashSaleModel> GetSimForFlashSale()
        {
            List<SIMOnFlashSaleModel> result = new List<SIMOnFlashSaleModel>();
            var simIdsWithOrder = _context.SIMWithOrders.Select(x => x.SimId).ToList();
            var simFS = _context.SIMDetails.Where(x => x.status == ApprovedStatus.Approved && !simIdsWithOrder.Contains(x.Id) && x.IsMySim == true).ToList();

            if (simFS.Count <= 20)
            {
                foreach (var sim in simFS)
                {
                    result.Add(new SIMOnFlashSaleModel()
                    {
                        SimId = sim.Id,
                        NetworkId = sim.SIMNetworkId,
                        SimNumber = sim.SIMNumber ?? "",
                        SimPrice = sim.SIMPrice,
                        SalePrice = sim.SIMPrice
                    });
                }
            }
            else
            {
                Random rnd = new Random();
                int num = 0;
                while(result.Count < 20)
                {
                    num = rnd.Next(simFS.Count()-1);
                    var SimIdsInResult = result.Select(x => x.SimId).ToList();
                    if (!SimIdsInResult.Contains(simFS[num].Id))
                        result.Add(new SIMOnFlashSaleModel()
                        {
                            SimId = simFS[num].Id,
                            NetworkId = simFS[num].SIMNetworkId,
                            SimNumber = simFS[num].SIMNumber ?? "",
                            SimPrice = simFS[num].SIMPrice,
                            Discount = 10,
                            SalePrice = simFS[num].SIMPrice - (simFS[num].SIMPrice * 10 / 100)
                        });
                }
            }

            return result;
        }
        public FlashSaleModel GetCurentFlashSale()
        {
            FlashSaleModel result = new FlashSaleModel();
            var dataEntity = _context.FlashSales.FirstOrDefault(x => x.StartTime >= DateTime.Now || x.EndTime >= DateTime.Now);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.StartTime = dataEntity.StartTime;
                result.EndTime = dataEntity.EndTime;
                result.Description = dataEntity.Description;
                List<SIMOnFlashSaleModel> simInfos = new();
                var simOnFlashSales = _context.SIMOnFlashSales.Where(x => x.FlashSaleId == dataEntity.Id);
                foreach (var simInfo in simOnFlashSales)
                {
                    simInfos.Add(new SIMOnFlashSaleModel()
                    {
                        FlashSaleId = simInfo.FlashSaleId,
                        SimId = simInfo.SimId,
                        NetworkId = simInfo.NetworkId,
                        SimNumber = simInfo.SimNumber,
                        SimPrice = simInfo.SimPrice,
                        Discount = simInfo.Discount,
                        SalePrice = simInfo.SalePrice,
                    });
                }
                result.SimFlashSaleInfos = simInfos;
            }
            return result;
        }
    }
}
