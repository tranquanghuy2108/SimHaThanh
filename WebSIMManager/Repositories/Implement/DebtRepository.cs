using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using MySqlConnector;
using Newtonsoft.Json;
using Repositories.Interface;

namespace Repositories.Implement
{
    public class DebtRepository : IDebtRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public DebtRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new LogActionRepository(context);
        }

        #region Công nợ phát sinh
        public ResponseDataModel<string> ApprovedDebt(
            string debtIds,
            ApprovedStatus status,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .Debts.Where(x =>
                        debtIds.Contains(x.Id.ToString())
                        && x.approvedStatus == ApprovedStatus.Waiting
                    )
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
                    data.approvedBy = new Guid(userId);
                    data.approvedTime = DateTime.Now;
                    data.approvedStatus = status;
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
                _context.Debts.UpdateRange(dataAppr);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Approved PPSCN",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = debtIds + Enum.GetName(typeof(ApprovedStatus), status),
                    OldData =
                        debtIds + Enum.GetName(typeof(ApprovedStatus), dataAppr[0].approvedStatus),
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

        public ResponseDataModel<string> Create(DebtModels request, string userId)
        {
            try
            {
                var debtCodeNum = 0;
                var debt = _context
                    .Debts.Where(x => x.DebtTypeId == request.DebtTypeId)
                    .OrderByDescending(x => x.CreateTime)
                    .FirstOrDefault();
                var debtType = _context.DebtTypes.FirstOrDefault(x => x.Id == request.DebtTypeId);
                if (debt != null)
                {
                    var code = debt.DebtCode;
                    debtCodeNum = Int32.Parse(code.Replace(debtType?.Code ?? "PPSCN", ""));
                }
                var debtCode = (debtType?.Code ?? "PPSCN") + (debtCodeNum + 1).ToString("000000");
                //Create SPContact
                var dataNew = new Debt()
                {
                    DebtTypeId = request.DebtTypeId,
                    DebtCode = debtCode,
                    AgentId = request.AgentId,
                    approvedStatus = Commons.Enums.ApprovedStatus.Waiting,
                    Receivables = request.Receivables ?? 0,
                    Liabilities = request.Liabilities ?? 0,
                    Description = request.Description ?? "",
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsDelete = false,
                };
                _context.Debts.Add(dataNew);
                //Update debt code
                var result = _context.SaveChanges();

                if (request.orderIds != null)
                {
                    var orderIds = request.orderIds.Split(',');
                    if (orderIds.Length > 0)
                    {
                        var orders = _context
                            .SIMOrders.Where(x => orderIds.Contains(x.Id.ToString()))
                            .ToList();
                        foreach (var order in orders)
                        {
                            order.debtId = dataNew.Id;
                            order.Status = StatusOrder.WaitingApproved;
                            if (order.PIC.ToString() == "00000000-0000-0000-0000-000000000000")
                            {
                                order.PIC = new Guid(userId);
                            }
                        }
                        _context.SIMOrders.UpdateRange(orders);
                        _context.SaveChanges();
                    }
                }

                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo PPSCN",
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
                    Message = "Có lỗi trong quá trình tạo công nợ.",
                };
            }
        }

        public ResponseDataModel<string> Delete(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Debts.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.Debts.Remove(dataEntity);
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa PPSCN",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>() { Code = "1", Message = "Xóa thành công." };
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

        public DebtModels Detail(int Id)
        {
            DebtModels result = new DebtModels();
            var dataEntity = _context.Debts.FirstOrDefault(x => x.Id == Id);
            var createByStr = "";
            var createBy = _context.Users.FirstOrDefault(x => x.Id == dataEntity.CreateBy);
            if (createBy != null)
                createByStr = createBy.FullName;
            var approvedByStr = "";
            var approvedBy = _context.Users.FirstOrDefault(x => x.Id == dataEntity.approvedBy);
            if (approvedBy != null)
                approvedByStr = approvedBy.FullName;
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.DebtCode = dataEntity.DebtCode;
                result.approvedStatus = dataEntity.approvedStatus;
                result.Receivables = dataEntity.Receivables;
                result.Liabilities = dataEntity.Liabilities;
                result.Description = dataEntity.Description ?? "";
                result.approvedBy = dataEntity.approvedBy;
                result.Description = dataEntity.Description;
                result.createBy = createByStr;
                result.createTime =
                    dataEntity.CreateTime.ToString("dd/MM/yyyy") == "01/01/0001"
                        ? ""
                        : dataEntity.CreateTime.ToString("dd/MM/yyyy");
                ;
                result.approvedByStr = approvedByStr;
                result.approvedTime =
                    dataEntity.approvedTime.ToString("dd/MM/yyyy") == "01/01/0001"
                        ? ""
                        : dataEntity.approvedTime.ToString("dd/MM/yyyy");
            }
            return result;
        }

        public ResponseDataViewModel<DebtViewModels> GetDebt(DebtFilterModel request)
        {
            var dataEntity = _context
                .Debts.Where(x => !x.IsDelete)
                .OrderByDescending(x => x.UpdateTime)
                .ToList();
            if (request.agents.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.agents.Contains(x.AgentId.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.pics.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.pics.Contains(x.CreateBy.ToString()))
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.userId))
            {
                dataEntity = dataEntity
                    .Where(x => x.CreateBy.ToString() == request.userId)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            if (request.approvedStatus != null)
            {
                dataEntity = dataEntity
                    .Where(x => x.approvedStatus == request.approvedStatus)
                    .OrderByDescending(x => x.UpdateTime)
                    .ToList();
            }
            var data = new List<DebtViewModels>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.AgentId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                idx++;
                data.Add(
                    new DebtViewModels()
                    {
                        id = item.Id,
                        debtCode = item.DebtCode,
                        agentId = agent ?? "",
                        approvedBy = apprBy?.FullName ?? "",
                        createBy = createBy?.FullName ?? "",
                        approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus),
                        liabilities = item.Liabilities,
                        receivables = item.Receivables,
                        description = item.Description,
                        createTime = item.CreateTime.ToString("dd.MM.yyyy"),
                        approvedTime =
                            item.approvedTime.ToString("dd.MM.yyyy") == "01/01/0001"
                                ? ""
                                : item.approvedTime.ToString("dd.MM.yyyy"),
                    }
                );
            }
            //
            return new ResponseDataViewModel<DebtViewModels>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = 100,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<string> Update(DebtModels request, string userId)
        {
            try
            {
                var dataEntity = _context.Debts.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus == ApprovedStatus.Waiting
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                dataEntity.Liabilities = request.Liabilities ?? 0;
                dataEntity.Receivables = request.Receivables ?? 0;
                dataEntity.AgentId = request.AgentId;
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;

                _context.Debts.Update(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật PPSCN",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        public ResponseDataViewModel<DebtViewModels> GetDebtForFilter(DebtFilterRequest request)
        {
            var dataEntity = _context.Debts.OrderBy(x => x.approvedStatus).ToList();
            if (request.agentIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.agentIds.Contains(x.AgentId.ToString()))
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            if (!string.IsNullOrEmpty(request.userId))
            {
                dataEntity = dataEntity
                    .Where(x => x.CreateBy.ToString() == request.userId)
                    .OrderBy(x => x.approvedStatus)
                    .ToList();
            }
            else if (request.staffIds.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.staffIds.Contains(x.CreateBy.ToString()))
                    .OrderBy(x => x.approvedStatus)
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
            var data = new List<DebtViewModels>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                var agent = _context.Users.FirstOrDefault(x => x.Id == item.AgentId)?.FullName;
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var apprBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                //var formOfDelivery = _context.FormOfDeliveries.FirstOrDefault(x => x.Id == item.FormOfDeliveryId)?.Name;
                //
                //var orderIdsArr = item.OrderIds?.Split(',');
                //List<string> sims = new();
                //if (orderIdsArr?.Length > 0)
                //{
                //    //var agentId = _context.SIMOrders.FirstOrDefault(x => orderIdsArr.Contains(x.Id.ToString())).UserBuyId;
                //    var orders = _context.SIMOrders.Where(x => orderIdsArr.Contains(x.Id.ToString()));
                //    var simIds = _context.SIMWithOrders.Where(x => orderIdsArr.Contains(x.OrderId.ToString())).Select(x => x.SimId).ToList();
                //    sims = _context.SIMDetails.Where(x => simIds.Contains(x.Id)).Select(x=>x.SIMNumber).ToList();
                //}
                idx++;
                data.Add(
                    new DebtViewModels()
                    {
                        id = item.Id,
                        debtCode = item.DebtCode,
                        agentId = agent ?? "",
                        approvedBy = apprBy?.FullName ?? "",
                        createBy = createBy?.FullName ?? "",
                        approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus),
                        //orderIds = item.OrderIds,
                        //formOfDeliveryCode = item.FormOfDeliveryCode,
                        //formOfDeliveryId = formOfDelivery,
                        //sims = string.Join("\n", sims),
                        liabilities = item.Liabilities,
                        receivables = item.Receivables,
                        otherFeeTotal = 0,
                        description = item.Description,
                        createTime = item.CreateTime.ToString("dd.MM.yyyy"),
                        approvedTime =
                            item.approvedTime.ToString("dd.MM.yyyy") == "01/01/0001"
                                ? ""
                                : item.approvedTime.ToString("dd.MM.yyyy"),
                    }
                );
            }
            //
            return new ResponseDataViewModel<DebtViewModels>()
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

        public ResponseDataViewModel<AgencyGroupReportModel> GetAgencyGroupReport(
            AgencyGroupReportRequest request
        )
        {
            try
            {
                List<AgencyGroupReportModel> data = new List<AgencyGroupReportModel>();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetAgencyGroupReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate ?? new DateTime(1900, 1, 1)),
                    new("@EndDate", request.endDate ?? new DateTime(2999, 12, 31)),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<AgencyGroupReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                dataExec = dataExec
                    .Select(
                        (item, index) =>
                        {
                            item.Stt = index + 1;
                            return item;
                        }
                    )
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<AgencyGroupReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<AgencyGroupReportModel>();
            }
        }

        public double GetOldDebt(string userId)
        {
            double oldDebt = 0;
            var debtOfUser = _context
                .DebtAgents.Where(x =>
                    x.AgentId.ToString() == userId && x.approvedStatus == ApprovedStatus.Approved
                )
                .ToList();
            if (debtOfUser.Count > 0)
            {
                oldDebt = debtOfUser.Sum(x => x.FinalDebt);
            }
            return oldDebt;
        }
        #endregion

        #region Report
        public ResponseDataViewModel<DebtStaffReportModel> GetDebtDetail(
            DebtDetailFilterModel request
        )
        {
            try
            {
                List<DebtStaffReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "";
                switch (request.debtCategory)
                {
                    case DebtCategory.Staff:
                        storedProcedureName = "GetDebtStaffDetail";
                        break;
                    case DebtCategory.Bank:
                        storedProcedureName = "GetDebtBankDetail";
                        break;
                    case DebtCategory.Agent:
                        storedProcedureName = "GetDebtAgentDetail";
                        break;
                    case DebtCategory.Shipping:
                        storedProcedureName = "GetDebtShippingDetail";
                        break;
                    default:
                        storedProcedureName = "GetDebtDetail";
                        break;
                }
                string query =
                    $"CALL {storedProcedureName}(@UserId, @IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@UserId", string.Join(",", request.userIds)),
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<DebtStaffReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<DebtStaffReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<DebtStaffReportModel>();
            }
        }

        public ResponseDataViewModel<DebtStaffReportModel> GetDebtBankDetail(
            DebtDetailFilterModel request
        )
        {
            try
            {
                List<DebtStaffReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetDebtBankDetail";
                string query =
                    $"CALL {storedProcedureName}(@UserId, @IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@UserId", string.Join(",", request.userIds)),
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<DebtStaffReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<DebtStaffReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<DebtStaffReportModel>();
            }
            //try
            //{
            //    var query = _context.DebtBanks.Where(x => request.userIds.Contains(x.BankId.ToString()) && x.CreateTime > request.startDate && x.CreateTime < request.endDate).ToList();

            //    var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize);
            //    List<DebtStaffReportModel> data = new();
            //    foreach (var item in dataPaging)
            //    {
            //        var bankInfo = _context.Banks.FirstOrDefault(x => x.Id == item.BankId);
            //        var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
            //        var approvedBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
            //        DebtStaffReportModel debtBankReportItem = new DebtStaffReportModel();
            //        debtBankReportItem.id = item.Id;
            //        debtBankReportItem.DebtCode = item.DebtCode;
            //        debtBankReportItem.Receivables = item.Receivables;
            //        debtBankReportItem.Liabilities = item.Liabilities;
            //        debtBankReportItem.FinalDebt = item.FinalDebt;
            //        //debtBankReportItem.isDebtSettlement = item.IsDebtSettlement;
            //        debtBankReportItem.Description = item.Description;
            //        debtBankReportItem.Note = item.Note;
            //        debtBankReportItem.PIC = bankInfo?.Name + "-" + bankInfo?.AccOwner + "-" + bankInfo?.AccNumber;
            //        debtBankReportItem.createBy = createBy?.FullName ?? "";
            //        debtBankReportItem.createTime = item.CreateTime;
            //        debtBankReportItem.approvedBy = approvedBy?.FullName ?? "";
            //        debtBankReportItem.approvedTime = item.approvedTime;
            //        debtBankReportItem.approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus);
            //        data.Add(debtBankReportItem);
            //    }

            //    // Tạo đối tượng Pager và ResponseDataViewModel
            //    var pager = new Pager(new PagingRequestBase() { pageIndex = request.pageIndex, pageSize = request.pageSize }, query.Count());
            //    var responseData = new ResponseDataViewModel<DebtStaffReportModel>() { Pager = pager, Data = data };

            //    return responseData;
            //}
            //catch (Exception ex)
            //{
            //    // Ghi log lỗi và trả về ResponseDataViewModel rỗng
            //    Console.WriteLine("Error: " + ex);
            //    return new ResponseDataViewModel<DebtStaffReportModel>();
            //}
        }

        public ResponseDataViewModel<DebtStaffReportModel> GetDebtShippingDetail(
            DebtDetailFilterModel request
        )
        {
            try
            {
                var query = _context
                    .DebtShippings.Where(x =>
                        request.userIds.Contains(x.ShippingId.ToString())
                        && x.CreateTime > request.startDate
                        && x.CreateTime < request.endDate
                        && !x.IsDebtSettlement
                    )
                    .ToList();

                var dataPaging = query.Skip((request.pageIndex - 1) * request.pageSize);
                List<DebtStaffReportModel> data = new();
                foreach (var item in dataPaging)
                {
                    var shipping = _context.ShippingUnits.FirstOrDefault(x =>
                        x.Id == item.ShippingId
                    );
                    var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                    var approvedBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                    DebtStaffReportModel debtBankReportItem = new DebtStaffReportModel();
                    debtBankReportItem.id = item.Id;
                    debtBankReportItem.InvoiceId = item.InvoiceId;
                    debtBankReportItem.DebtCode = item.DebtCode;
                    debtBankReportItem.Receivables = item.Receivables;
                    debtBankReportItem.Liabilities = item.Liabilities;
                    debtBankReportItem.FinalDebt = item.FinalDebt;
                    debtBankReportItem.isDebtSettlement = item.IsDebtSettlement;
                    debtBankReportItem.Description = item.Description;
                    debtBankReportItem.Note = item.Note;
                    debtBankReportItem.PIC = shipping?.Name ?? "";
                    debtBankReportItem.createBy = createBy?.FullName ?? "";
                    debtBankReportItem.createTime = item.CreateTime;
                    debtBankReportItem.approvedBy = approvedBy?.FullName ?? "";
                    debtBankReportItem.approvedTime = item.approvedTime;
                    debtBankReportItem.approvedStatus = Enum.GetName(
                        typeof(ApprovedStatus),
                        item.approvedStatus
                    );
                    data.Add(debtBankReportItem);
                }

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    query.Count()
                );
                var responseData = new ResponseDataViewModel<DebtStaffReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<DebtStaffReportModel>();
            }
        }

        public ResponseDataModel<string> ConfirmDebtSettlementOfStaff(
            string debtIds,
            bool isDebtSettlement,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .DebtStaffs.Where(x => debtIds.Contains(x.Id.ToString()))
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
                    data.approvedBy = new Guid(userId);
                    data.approvedTime = DateTime.Now;
                }
                _context.DebtStaffs.UpdateRange(dataAppr);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa CN nhân viên",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = debtIds,
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
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataModel<string> ConfirmDebtSettlementOfBank(
            string debtIds,
            bool isDebtSettlement,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .DebtBanks.Where(x => debtIds.Contains(x.Id.ToString()))
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
                    data.IsDebtSettlement = isDebtSettlement;
                    data.UpdateBy = new Guid(userId);
                    data.UpdateTime = DateTime.Now;
                    data.approvedBy = new Guid(userId);
                    data.approvedTime = DateTime.Now;
                }
                _context.DebtBanks.UpdateRange(dataAppr);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa CN tài khoản ngân hàng",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = debtIds,
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
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataModel<string> ConfirmDebtSettlementOfShipping(
            string debtIds,
            bool isDebtSettlement,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .DebtShippings.Where(x => debtIds.Contains(x.Id.ToString()))
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
                    data.approvedBy = new Guid(userId);
                    data.approvedTime = DateTime.Now;
                    data.IsDebtSettlement = isDebtSettlement;
                }
                _context.DebtShippings.UpdateRange(dataAppr);
                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa CN đơn vị vận chuyển",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = debtIds,
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
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật.",
                };
            }
        }

        public ResponseDataViewModel<CashFundBalanceReportModel> GetCashFundBalance(
            CashFundBalanceReportRequest request
        )
        {
            try
            {
                List<CashFundBalanceReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetCashFundBalanceReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<CashFundBalanceReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<CashFundBalanceReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<CashFundBalanceReportModel>();
            }
        }

        public ResponseDataViewModel<BankFundBalanceReportModel> GetBankFundBalance(
            CashFundBalanceReportRequest request
        )
        {
            try
            {
                List<BankFundBalanceReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetBankFundBalanceReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<BankFundBalanceReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<BankFundBalanceReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<BankFundBalanceReportModel>();
            }
        }

        public ResponseDataViewModel<ShippingFundBalanceReportModel> GetShippingFundBalance(
            CashFundBalanceReportRequest request
        )
        {
            try
            {
                List<ShippingFundBalanceReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetShippingFundBalanceReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<ShippingFundBalanceReportModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<ShippingFundBalanceReportModel>()
                {
                    Pager = pager,
                    Data = data,
                };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<ShippingFundBalanceReportModel>();
            }
        }

        public ResponseDataModel<string> Approved(
            string debtIds,
            ApprovedStatus status,
            string userId
        )
        {
            try
            {
                var dataAppr = _context
                    .Debts.Where(x =>
                        debtIds.Contains(x.Id.ToString())
                        && (
                            x.approvedStatus == ApprovedStatus.Waiting
                            || status == ApprovedStatus.Reject
                        )
                    )
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
                    data.approvedBy = new Guid(userId);
                    data.approvedTime = DateTime.Now;
                    data.approvedStatus = status;
                }
                _context.Debts.UpdateRange(dataAppr);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Approved PPSCN",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData =
                        "PXSim có ID: "
                        + debtIds
                        + " status "
                        + Enum.GetName(typeof(ApprovedStatus), status),
                    OldData =
                        "PXSim có ID: "
                        + debtIds
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

        #region Loại công nợ phát sinh

        public ResponseDataViewModel<DebtTypeViewModel> GetDebtType(GetPagingRequest request)
        {
            var dataEntity = _context
                .DebtTypes.Where(x =>
                    x.Name.Contains(request.keyword) || x.Code.Contains(request.keyword)
                )
                .ToList();

            var data = new List<DebtTypeViewModel>();
            var idx = 0;
            foreach (var item in dataEntity)
            {
                idx++;
                var debtReceiveType = "";
                switch (item.DebtReceiveType)
                {
                    case DebtReceiveType.All:
                        debtReceiveType = "Phát sinh thu/chi";
                        break;
                    case DebtReceiveType.Receivables:
                        debtReceiveType = "Phát sinh thu";
                        break;
                    case DebtReceiveType.Liabilities:
                        debtReceiveType = "Phát sinh chi";
                        break;
                }
                data.Add(
                    new DebtTypeViewModel()
                    {
                        Stt = item.Id,
                        Id = item.Id,
                        Code = item.Code,
                        Name = item.Name,
                        DebtReceiveType = debtReceiveType,
                        Description = item.Description,
                    }
                );
            }
            //
            return new ResponseDataViewModel<DebtTypeViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = 100,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<int> CreateDebtType(DebtTypeModel request, string userId)
        {
            try
            {
                var data = _context.DebtTypes.FirstOrDefault(x => x.Code == request.Code);
                if (data != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Loại công nợ đã tồn tại.",
                        Data = 0,
                    };
                }

                //Create DebtType
                var dataNew = new DebtType()
                {
                    Code = request.Code,
                    Name = request.Name,
                    DebtReceiveType = request.DebtReceiveType,
                    Description = request.Description ?? "",
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsDelete = false,
                };
                _context.DebtTypes.Add(dataNew);
                //Update debt code
                var result = _context.SaveChanges();

                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo loại PPSCN",
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
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại công nợ.",
                    Data = 0,
                };
            }
        }

        public DebtTypeModel DetailDebtType(int Id)
        {
            DebtTypeModel result = new DebtTypeModel();
            var dataEntity = _context.DebtTypes.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.Name = dataEntity.Name;
                result.DebtReceiveType = dataEntity.DebtReceiveType;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public ResponseDataModel<string> UpdateDebtType(DebtTypeModel request, string userId)
        {
            try
            {
                var dataEntity = _context.DebtTypes.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                dataEntity.Code = request.Code;
                dataEntity.Name = request.Name;
                dataEntity.DebtReceiveType = request.DebtReceiveType;
                dataEntity.Description = request.Description ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;

                _context.DebtTypes.Update(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật loại PPSCN",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        public ResponseDataModel<string> DeleteDebtType(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.DebtTypes.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.DebtTypes.Remove(dataEntity);
                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa loại PPSCN",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>() { Code = "1", Message = "Xóa thành công." };
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

        public List<SelectListItem> GetDebtTypeForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.DebtTypes.ToList();
            foreach (var item in data)
            {
                var debtReceiveType = "";
                switch (item.DebtReceiveType)
                {
                    case DebtReceiveType.All:
                        debtReceiveType = "T/C";
                        break;
                    case DebtReceiveType.Receivables:
                        debtReceiveType = "T";
                        break;
                    case DebtReceiveType.Liabilities:
                        debtReceiveType = "C";
                        break;
                }
                selectListItems.Add(
                    new SelectListItem
                    {
                        Text = item.Name + "(" + item.Code + " (" + debtReceiveType + ")) ",
                        Value = item.Id.ToString(),
                    }
                );
            }
            return selectListItems;
        }

        #endregion

        #region Lệnh chuyển tiền

        public ResponseDataViewModel<TransferMoneyViewModel> GetTransferMoney(
            TransferMoneyFilterModel request
        )
        {
            var dataEntity = _context
                .TransferMoneys.Where(x => x.ReceiverId.ToString() == request.ReceiverId)
                .ToList();
            if (request.RemittersIds?.Count > 0)
            {
                dataEntity = dataEntity
                    .Where(x => request.RemittersIds.Contains(x.RemittersId.ToString()))
                    .ToList();
            }

            var data = new List<TransferMoneyViewModel>();
            foreach (var item in dataEntity)
            {
                var receiver = _context.Users.FirstOrDefault(x => x.Id == item.ReceiverId);
                var remitters = _context.Users.FirstOrDefault(x => x.Id == item.RemittersId);
                var approvedBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                var debtStaffCode = _context
                    .DebtStaffs.Where(x => x.TransferMoneyId == item.Id)
                    .Select(x => x.DebtCode)
                    .ToList();
                data.Add(
                    new TransferMoneyViewModel()
                    {
                        Id = item.Id,
                        Code = item.Code,
                        Amount = item.Amount,
                        ReceiverId = receiver?.FullName ?? "",
                        RemittersId = remitters?.FullName ?? "",
                        Description = item.Description,
                        Note = item.Note,
                        DebtStaffCodes = string.Join(" \n", debtStaffCode),
                        approvedBy = approvedBy?.FullName ?? "",
                        approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus),
                        approvedTime = item.approvedTime.ToString("dd.MM.yyyy"),
                    }
                );
            }
            //
            return new ResponseDataViewModel<TransferMoneyViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = 100,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<int> CreateTransferMoney(TransferMoneyModel request, string userId)
        {
            try
            {
                var transferMoneyCodeNum = 0;
                var transferMoney = _context
                    .TransferMoneys.OrderByDescending(x => x.CreateTime)
                    .FirstOrDefault();
                if (transferMoney != null)
                {
                    transferMoneyCodeNum = transferMoney.Id;
                }
                var transferMoneyCode = "ChTien" + (transferMoneyCodeNum + 1).ToString("000000");
                var data = _context.TransferMoneys.FirstOrDefault(x => x.Code == request.Code);
                if (data != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Loại công nợ đã tồn tại.",
                        Data = 0,
                    };
                }

                //Create transferMoney
                var dataNew = new TransferMoney()
                {
                    Code = transferMoneyCode,
                    Amount = request.Amount,
                    ReceiverId = request.ReceiverId,
                    RemittersId = request.RemittersId,
                    Description = request.Description ?? "",
                    Note = request.Note ?? "",
                    approvedStatus = ApprovedStatus.Waiting,
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsDelete = false,
                };
                _context.TransferMoneys.Add(dataNew);
                //Update debt code
                var result = _context.SaveChanges();

                var debtStaffs = _context
                    .DebtStaffs.Where(x => request.DebtStaffIds.Contains(x.Id))
                    .ToList();
                foreach (var debtStaff in debtStaffs)
                {
                    debtStaff.TransferMoneyId = dataNew.Id;
                }
                _context.DebtStaffs.UpdateRange(debtStaffs);
                _context.SaveChanges();

                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo phiếu chuyển tiền",
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
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại công nợ.",
                    Data = 0,
                };
            }
        }

        public TransferMoneyModel DetailTransferMoney(int Id)
        {
            TransferMoneyModel result = new TransferMoneyModel();
            var dataEntity = _context.TransferMoneys.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.Amount = dataEntity.Amount;
                result.ReceiverId = dataEntity.ReceiverId;
                result.RemittersId = dataEntity.RemittersId;
                result.Description = dataEntity.Description;
                result.Note = dataEntity.Note;
            }
            return result;
        }

        public ResponseDataModel<string> UpdateTransferMoney(
            TransferMoneyModel request,
            string userId
        )
        {
            try
            {
                var dataEntity = _context.TransferMoneys.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus != ApprovedStatus.Approved
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                //dataEntity.Amount = request.Amount;
                dataEntity.ReceiverId = request.ReceiverId;
                //dataEntity.RemittersId = request.RemittersId;
                dataEntity.Description = request.Description ?? "";
                dataEntity.Note = request.Note ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.approvedStatus = ApprovedStatus.Waiting;

                _context.TransferMoneys.Update(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật Phiếu chuyển tiền",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        public ResponseDataModel<string> DeleteTransferMoney(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.TransferMoneys.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.TransferMoneys.Remove(dataEntity);

                var debtStaffs = _context.DebtStaffs.Where(x => x.TransferMoneyId == Id).ToList();
                foreach (var debtStaff in debtStaffs)
                {
                    debtStaff.TransferMoneyId = null;
                }
                _context.DebtStaffs.UpdateRange(debtStaffs);

                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa phiếu chuyển tiền",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>() { Code = "1", Message = "Xóa thành công." };
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

        public ResponseDataModel<CheckTransferMoneyResponseModel> CheckTransferMoneyLst(
            List<int> deffStaffIds
        )
        {
            CheckTransferMoneyResponseModel data = new();
            data.DebtStaffIds = new();
            data.DebtStaffCodes = new();
            var deffStaffs = _context.DebtStaffs.Where(x => deffStaffIds.Contains(x.Id)).ToList();

            var staffs = deffStaffs.Select(x => x.StaffId).Distinct().ToList();

            double amount = 0;
            foreach (var item in deffStaffs)
            {
                if (item.TransferMoneyId == null)
                {
                    data.DebtStaffIds.Add(item.Id);
                    data.DebtStaffCodes.Add(item.DebtCode);
                    amount += item.FinalDebt;
                }
            }
            data.TotalAmount = amount;
            if (data.DebtStaffIds.Count() == 0)
            {
                return new ResponseDataModel<CheckTransferMoneyResponseModel>()
                {
                    Code = "0",
                    Message = "Phiếu bạn chọn đã được xử lý.",
                    Data = data,
                };
            }
            else
            {
                return new ResponseDataModel<CheckTransferMoneyResponseModel>()
                {
                    Code = "1",
                    Message = "Kiểm tra thành công.",
                    Data = data,
                };
            }
        }

        public ResponseDataModel<string> ApprovedTransferMoney(
            TransferMoneApprovedModel request,
            string userId
        )
        {
            try
            {
                var TransferMoneyIds = request.TransferMoneyIds.Split(",");
                var dataEntity = _context
                    .TransferMoneys.Where(x =>
                        TransferMoneyIds.Contains(x.Id.ToString())
                        && x.approvedStatus == ApprovedStatus.Waiting
                    )
                    .ToList();
                if (dataEntity.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                foreach (var item in dataEntity)
                {
                    item.approvedStatus = request.Status;
                    item.approvedBy = new Guid(userId);
                    item.approvedTime = DateTime.Now;
                }

                _context.TransferMoneys.UpdateRange(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Duyệt phiếu chuyển tiền",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        #region Phiếu thu

        public ResponseDataViewModel<ReceiptViewModel> GetReceipt(ReceiptFilterModel request)
        {
            List<Receipt>? dataEntity;
            if (request.AgentIds != null)
                dataEntity = _context
                    .Receipts.Where(x => request.AgentIds.Contains(x.AgentId.ToString()))
                    .ToList();
            else
                dataEntity = _context.Receipts.ToList();

            var data = new List<ReceiptViewModel>();
            foreach (var item in dataEntity)
            {
                var approvedBy = _context.Users.FirstOrDefault(x => x.Id == item.approvedBy);
                var createBy = _context.Users.FirstOrDefault(x => x.Id == item.CreateBy);
                var formOfPayment = "";
                switch (item.formOfPayment)
                {
                    case FormOfPayment.Direct:
                        formOfPayment = "Trực tiếp";
                        break;
                    case FormOfPayment.Banking:
                        formOfPayment = "Chuyển khoản";
                        break;
                }
                data.Add(
                    new ReceiptViewModel()
                    {
                        Id = item.Id,
                        Code = item.Code,
                        Receivables = item.Receivables,
                        Liabilities = item.Liabilities,
                        AgentId = item.AgentId,
                        AgentName = item.AgentName,
                        AgentInfo = item.AgentInfo,
                        Description = item.Description,
                        Note = item.Note,
                        formOfPayment = formOfPayment,
                        approvedBy = approvedBy?.FullName ?? "",
                        approvedStatus = Enum.GetName(typeof(ApprovedStatus), item.approvedStatus),
                        approvedTime = item.approvedTime?.ToString("HH:mm dd.MM.yyyy") ?? "",
                        ReceiptDate = item.ReceiptDate.ToString("HH:mm dd.MM.yyyy"),
                        CreateBy = createBy?.FullName ?? "",
                    }
                );
            }
            //
            return new ResponseDataViewModel<ReceiptViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = 100,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<int> CreateReceipt(ReceiptModel request, string userId)
        {
            try
            {
                var ReceiptCodeNum = 0;
                var Receipt = _context
                    .Receipts.OrderByDescending(x => x.CreateTime)
                    .FirstOrDefault();
                if (Receipt != null)
                {
                    ReceiptCodeNum = Receipt.Id;
                }
                var ReceiptCode = "PThuChi" + (ReceiptCodeNum + 1).ToString("000000");
                var data = _context.Receipts.FirstOrDefault(x => x.Code == request.Code);
                if (data != null)
                {
                    return new ResponseDataModel<int>()
                    {
                        Code = "1",
                        Message = "Loại công nợ đã tồn tại.",
                        Data = 0,
                    };
                }

                //Create Receipt
                var dataNew = new Receipt()
                {
                    Code = ReceiptCode,
                    OldDebt = request.OldDebt,
                    Receivables = request.Receivables,
                    Liabilities = request.Liabilities,
                    NewDebt = request.NewDebt,
                    AgentId = request.AgentId,
                    AgentName = request.AgentName,
                    AgentInfo = request.AgentInfo,
                    formOfPayment = request.formOfPayment,
                    StaffId = new Guid(userId),
                    BankId = request.BankId,
                    Description = request.Description ?? "",
                    Note = request.Note ?? "",
                    ReceiptDate = request.ReceiptDate ?? DateTime.Now,
                    approvedStatus = ApprovedStatus.Waiting,
                    CreateBy = new Guid(userId),
                    UpdateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    IsDelete = false,
                };
                _context.Receipts.Add(dataNew);
                var result = _context.SaveChanges();
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo phiếu thu tiền",
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
                    Code = "-1",
                    Message = "Có lỗi trong quá trình tạo loại công nợ.",
                    Data = 0,
                };
            }
        }

        public ReceiptModel DetailReceipt(int Id)
        {
            ReceiptModel result = new ReceiptModel();
            var dataEntity = _context.Receipts.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Code = dataEntity.Code;
                result.OldDebt = dataEntity.OldDebt;
                result.Receivables = dataEntity.Receivables;
                result.Liabilities = dataEntity.Liabilities;
                result.NewDebt = dataEntity.NewDebt;
                result.AgentId = dataEntity.AgentId;
                result.AgentName = dataEntity.AgentName;
                result.AgentInfo = dataEntity.AgentInfo;
                result.Description = dataEntity.Description;
                result.ReceiptDate = dataEntity.ReceiptDate;
                result.Note = dataEntity.Note;
                result.CreateBy = dataEntity.CreateBy;
                result.CreateTime = dataEntity.CreateTime;
            }
            return result;
        }

        public ResponseDataModel<string> UpdateReceipt(ReceiptModel request, string userId)
        {
            try
            {
                var dataEntity = _context.Receipts.FirstOrDefault(x =>
                    x.Id == request.Id && x.approvedStatus != ApprovedStatus.Approved
                );
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu đã được duyệt hoặc không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                dataEntity.Receivables = request.Receivables;
                dataEntity.Liabilities = request.Liabilities;
                //dataEntity.AgentId = request.AgentId;
                //dataEntity.AgentName = request.AgentName;
                dataEntity.ReceiptDate = request.ReceiptDate ?? DateTime.Now;
                dataEntity.StaffId = new Guid(userId);
                dataEntity.BankId = request.BankId;
                dataEntity.Description = request.Description ?? "";
                dataEntity.Note = request.Note ?? "";
                dataEntity.UpdateBy = new Guid(userId);
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.approvedStatus = ApprovedStatus.Waiting;

                _context.Receipts.Update(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật phiếu thu tiền",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        public ResponseDataModel<string> DeleteReceipt(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.Receipts.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Công nợ không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.Receipts.Remove(dataEntity);

                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa phiếu thu",
                    ControllerName = "",
                    CreateBy = userId,
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = "",
                    OldData = oldData,
                };
                _logAction.InsertLogAction(logAction);
                return new ResponseDataModel<string>() { Code = "1", Message = "Xóa thành công." };
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

        //public ResponseDataModel<CheckReceiptResponseModel> CheckReceiptLst(List<int> deffStaffIds)
        //{
        //    CheckReceiptResponseModel data = new();
        //    data.DebtStaffIds = new();
        //    data.DebtStaffCodes = new();
        //    var deffStaffs = _context.DebtStaffs.Where(x => deffStaffIds.Contains(x.Id)).ToList();

        //    var staffs = deffStaffs.Select(x => x.StaffId).Distinct().ToList();

        //    double amount = 0;
        //    foreach (var item in deffStaffs)
        //    {
        //        if (item.ReceiptId == null)
        //        {
        //            data.DebtStaffIds.Add(item.Id);
        //            data.DebtStaffCodes.Add(item.DebtCode);
        //            amount += item.FinalDebt;
        //        }
        //    }
        //    data.TotalAmount = amount;
        //    if (data.DebtStaffIds.Count() == 0)
        //    {
        //        return new ResponseDataModel<CheckReceiptResponseModel>()
        //        {
        //            Code = "0",
        //            Message = "Phiếu bạn chọn đã được xử lý.",
        //            Data = data
        //        };
        //    }
        //    else
        //    {
        //        return new ResponseDataModel<CheckReceiptResponseModel>()
        //        {
        //            Code = "1",
        //            Message = "Kiểm tra thành công.",
        //            Data = data
        //        };
        //    }
        //}

        public ResponseDataModel<string> ApprovedReceipt(
            ReceiptApprovedModel request,
            string userId
        )
        {
            try
            {
                var ReceiptIds = request.ReceiptIds.Split(",");
                var dataEntity = _context
                    .Receipts.Where(x =>
                        ReceiptIds.Contains(x.Id.ToString())
                        && x.approvedStatus == ApprovedStatus.Waiting
                    )
                    .ToList();
                if (dataEntity.Count == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại hoặc đã được duyệt.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                foreach (var item in dataEntity)
                {
                    item.approvedStatus = request.Status;
                    item.approvedBy = new Guid(userId);
                    item.approvedTime = DateTime.Now;
                }

                _context.Receipts.UpdateRange(dataEntity);
                var result = _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Duyệt phiếu thu tiền",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = JsonConvert.SerializeObject(request),
                    OldData = oldData,
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

        public double CheckOldDebtOfAgent(DebtOfAgentRequest request)
        {
            double oldDebt = 0;
            var debtOfUser = _context
                .DebtAgents.Where(x =>
                    x.AgentId.ToString() == request.AgentId
                    && request.receiptDate > x.CreateTime
                    && x.approvedStatus == ApprovedStatus.Approved
                )
                .ToList();
            if (debtOfUser.Count > 0)
            {
                oldDebt = debtOfUser.Sum(x => x.FinalDebt);
            }
            var receiptOfUser = _context
                .Receipts.Where(x =>
                    x.AgentId.ToString() == request.AgentId
                    && request.receiptDate > x.CreateTime
                    && x.approvedStatus == ApprovedStatus.Approved
                )
                .ToList();
            if (receiptOfUser.Count > 0)
            {
                oldDebt += receiptOfUser.Sum(x => x.Receivables);
            }
            return oldDebt;
        }
        #endregion
    }
}
