using Commons.Enums;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using Newtonsoft.Json;
using Repositories.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Repositories.Implement
{
    public class CashBookRepository : ICashBookRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public CashBookRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        public List<CashBookModel> GetCashBookByType(GetCashBookOnApp request)
        {
            List<CashBook>? dataEntity;
            if (request.cashActionType != null)
            {
                dataEntity = _context
                    .CashBooks.Where(x =>
                        x.cashActionType == request.cashActionType && x.UserId == request.UserId
                    )
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            else
            {
                dataEntity = _context
                    .CashBooks.Where(x => x.UserId == request.UserId)
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            var data = new List<CashBookModel>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                data.Add(
                    new CashBookModel()
                    {
                        Id = item.Id,
                        UserId = item.UserId,
                        OnApp = item.OnApp,
                        cashActionType = item.cashActionType,
                        Liabilities = item.Liabilities,
                        Receivables = item.Receivables,
                        //FinalDebt = item.FinalDebt,
                        Note = item.Note,
                        Description = item.Description,
                        CreateTime = item.CreateTime,
                        CreateBy = item.CreateBy,
                        approvedStatus = item.approvedStatus,
                        approvedBy = item.approvedBy,
                        approvedTime = item.approvedTime,
                    }
                );
            }
            //
            return data;
        }

        public ResponseDataModel<string> CreateCashBook(CashBookModel request, Guid userId)
        {
            try
            {
                var cashWaiting = _context
                    .CashBooks.Where(x =>
                        x.UserId == userId && x.approvedStatus == ApprovedStatus.Waiting
                    )
                    .ToList();
                if (cashWaiting.Count > 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Bạn có giao dịch chưa hoàn thành.",
                    };
                }
                var moneyInCash = GetMoneyInCash(request.UserId);
                if (
                    request.cashActionType == CashActionType.RutTien
                    && request.Liabilities > moneyInCash
                )
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số tiền trong quỹ không đủ.",
                    };
                }
                var dataNew = new CashBook()
                {
                    UserId = request.UserId,
                    cashActionType = request.cashActionType,
                    Liabilities = request.Liabilities,
                    Receivables = request.Receivables,
                    FinalDebt = request.Receivables - request.Liabilities,
                    approvedStatus = ApprovedStatus.Waiting,
                    Description = request.Description ?? "",
                    Note = request.Note ?? "",
                    OnApp = request.OnApp,
                    IsDelete = false,
                    CreateBy = userId,
                    UpdateBy = userId,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.CashBooks.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo kí quỹ.",
                };
            }
        }

        public ResponseDataModel<string> UpdateCashBook(CashBookModel request, Guid userId)
        {
            try
            {
                var dataEntity = _context.CashBooks.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Kí quỹ không tồn tại.",
                    };
                }
                var moneyInCash = GetMoneyInCash(request.UserId);
                if (
                    request.cashActionType == CashActionType.RutTien
                    && request.Liabilities > moneyInCash
                )
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số tiền trong quỹ không đủ.",
                    };
                }
                dataEntity.UserId = request.UserId;
                dataEntity.OnApp = request.OnApp;
                dataEntity.cashActionType = request.cashActionType;
                dataEntity.Liabilities = request.Liabilities;
                dataEntity.Receivables = request.Receivables;
                dataEntity.FinalDebt = request.Receivables - request.Liabilities;
                dataEntity.Note = request.Note ?? "";
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = userId;
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.approvedStatus = ApprovedStatus.Waiting;

                _context.CashBooks.Update(dataEntity);
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

        public ResponseDataModel<string> ApprovedCashBook(
            string cashBookids,
            ApprovedStatus approvedStatus,
            Guid userId
        )
        {
            var ids = cashBookids.Split(',');
            var dataEntity = _context
                .CashBooks.Where(x =>
                    ids.Contains(x.Id.ToString()) && x.approvedStatus == ApprovedStatus.Waiting
                )
                .ToList();
            if (dataEntity.Count == 0)
                return new ResponseDataModel<string>()
                {
                    Code = "0",
                    Message = "Ví kí quỹ không tồn tại hoặc đã được duyệt.",
                };
            foreach (var item in dataEntity)
            {
                item.approvedStatus = approvedStatus;
                item.approvedBy = userId;
                item.approvedTime = DateTime.Now;
            }
            _context.CashBooks.UpdateRange(dataEntity);
            var result = _context.SaveChanges();

            LogAction logAction = new LogAction()
            {
                ActionName = "Approved Kí quỹ",
                ControllerName = "",
                CreateBy = userId,
                CreateTime = DateTime.Now,
                IpAddressUser = null,
                NewData = JsonConvert.SerializeObject(ids),
                OldData = "",
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

        CashBookModel ICashBookRepository.Detail(int Id)
        {
            CashBookModel result = new CashBookModel();
            var dataEntity = _context.CashBooks.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.UserId = dataEntity.UserId;
                result.OnApp = dataEntity.OnApp;
                result.cashActionType = dataEntity.cashActionType;
                result.Liabilities = dataEntity.Liabilities;
                result.Receivables = dataEntity.Receivables;
                //result.FinalDebt = dataEntity.FinalDebt;
                result.Note = dataEntity.Note;
                result.Description = dataEntity.Description;
                result.CreateTime = dataEntity.CreateTime;
                result.CreateBy = dataEntity.CreateBy;
                result.approvedBy = dataEntity.approvedBy;
                result.approvedTime = dataEntity.approvedTime;
            }
            return result;
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            throw new NotImplementedException();
        }

        public double GetMoneyInCash(Guid userId)
        {
            //double moneyInCash = 0;
            return _context
                .CashBooks.Where(x =>
                    x.UserId == userId && x.approvedStatus == ApprovedStatus.Approved
                )
                .Select(x => x.FinalDebt)
                .ToList()
                .Sum();
        }

        public ResponseDataViewModel<CashBookViewModel> GetCashBookPaging(
            GetCashBookPagingRequest request
        )
        {
            List<CashBook>? dataEntity;
            if (request.userIds == null || request.userIds.Count == 0)
            {
                dataEntity = _context.CashBooks.OrderBy(x => x.approvedStatus).ToList();
            }
            else
            {
                dataEntity = _context
                    .CashBooks.Where(x => request.userIds.Contains(x.UserId.ToString()))
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }

            var data = new List<CashBookViewModel>();
            var idx = 0;
            var dataPaging = dataEntity
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            foreach (var item in dataPaging)
            {
                var user = _context.Users.FirstOrDefault(x => x.Id == item.UserId);
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var approvedBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                idx++;
                data.Add(
                    new CashBookViewModel()
                    {
                        Id = item.Id,
                        user = user?.UserName ?? "",
                        OnApp = item.OnApp,
                        cashActionType =
                            Enum.GetName(typeof(CashActionType), item.cashActionType) ?? "",
                        approvedStatus =
                            Enum.GetName(typeof(ApprovedStatus), item.approvedStatus) ?? "",
                        Liabilities = item.Liabilities,
                        Receivables = item.Receivables,
                        //FinalDebt = item.FinalDebt,
                        Note = item.Note,
                        Description = item.Description,
                        CreateTime = item.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                        CreateBy = createBy?.UserName ?? "",
                        approvedBy = approvedBy?.UserName ?? "",
                        approvedTime = item.approvedTime?.ToString("HH:mm dd.MM.yyyy"),
                    }
                );
            }
            //
            return new ResponseDataViewModel<CashBookViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
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
    }
}
