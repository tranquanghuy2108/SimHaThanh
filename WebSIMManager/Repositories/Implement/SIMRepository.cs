using System;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Runtime;
using System.Runtime.CompilerServices;
using Commons.Enums;
using Commons.Helper;
using Commons.Models;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using EFCoreMySQL.StoredProcedureModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using MySqlConnector;
using Newtonsoft.Json;
using Repositories.Interface;
using Telegram.Bot.Requests.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories.Implement
{
    public class SIMRepository : ISIMRepository
    {
        private readonly SIMCenterDbContext _context;
        private readonly LogActionRepository _logAction;

        public SIMRepository(SIMCenterDbContext context)
        {
            _context = context;
            _logAction = new(context);
        }

        public async Task<ResponseDataModel<List<ReadSimCSVModel>>> ImportSIM2(
            ImportSIMModel request,
            Guid userId,
            bool isAgent = false
        )
        {
            List<ReadSimCSVModel> importResult = new();
            request.DataInFile.RemoveAt(0);
            List<string> dataInsertLst = new();
            List<string> sqlQueryUpdates = new();
            List<string> phoneNumberInsert = new();
            List<string> phoneNumberHadFormatInsert = new();
            List<string> phoneNumberInsertSuccess = new();
            List<string> phoneNumberHadFormatInsertSuccess = new();
            List<string> phoneNumberInsertFail = new();
            List<string> phoneNumberUpdate = new();
            List<string> phoneNumberUpdateSuccess = new();
            List<string> phoneNumberUpdateFail = new();
            int block = 1000;
            var isMySim = false;
            var isStaff = _context
                .Users.FirstOrDefault(x => x.Id.ToString() == request.Owner)
                .IsStaff;
            if (isStaff)
            {
                isMySim = true;
            }
            var owner = new Guid(request.Owner);
            var simsOfOwner = _context
                .SIMDetails.AsNoTracking()
                .Where(x => x.Owner == owner)
                .Select(x => new { Id = x.Id, SNumber = x.SIMNumber })
                .ToList();
            foreach (var dataRow in request.DataInFile)
            {
                ReadSimCSVModel readSimCSVModel = new ReadSimCSVModel()
                {
                    phoneNumber = dataRow.phoneNumber,
                    seria = dataRow.seria,
                    price = dataRow.price,
                    priceOfAgent = dataRow.priceOfAgent,
                    agentSIMPrice = dataRow.agentSIMPrice,
                    collaboratorsSIMPrice = dataRow.collaboratorsSIMPrice,
                    network = dataRow.network,
                    position = dataRow.position,
                    productType = dataRow.productType,
                    description = dataRow.description,
                };
                try
                {
                    var simNum = dataRow.phoneNumber.Replace(".", "");
                    if (simNum.Length == 10)
                    {
                        simNum = simNum.Substring(1, 9);
                    }
                    string simHadFormat;
                    var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(
                        simNum,
                        out simHadFormat
                    );
                    if (simsOfOwner.Select(x => x.SNumber).ToList().Contains(simHadFormat))
                    {
                        //Setup sql raw query
                        string sqlQueryUpdateStr =
                            "UPDATE simdetails SET SIMPrice = "
                            + dataRow.price
                            + ", AgentSIMPrice = "
                            + dataRow.agentSIMPrice
                            + ", CollaboratorsSIMPrice = "
                            + dataRow.collaboratorsSIMPrice
                            + ", SIMNetworkId = "
                            + GetNetworkIdByName(dataRow.network)
                            + ", ProductTypeId = "
                            + GetGetProductTypeIdByName(dataRow.productType)
                            + ", Description = '"
                            + dataRow.description
                            + "', UpdateBy = '"
                            + userId
                            + "', UpdateTime = '"
                            + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "', SIMPriceOfAgent = "
                            + dataRow.priceOfAgent
                            + ", Position = '"
                            + dataRow.position
                            + "' WHERE (Id = "
                            + simsOfOwner.FirstOrDefault(x => x.SNumber == simHadFormat).Id
                            + ")";
                        sqlQueryUpdates.Add(sqlQueryUpdateStr);
                        phoneNumberUpdate.Add(dataRow.phoneNumber);
                        if (
                            phoneNumberUpdate.Count >= block
                            || dataRow == request.DataInFile.LastOrDefault()
                        )
                        {
                            FormattableString UpdateSql = FormattableStringFactory.Create(
                                string.Join(";", sqlQueryUpdates)
                            );
                            sqlQueryUpdates = new();
                            var result = await _context.Database.ExecuteSqlInterpolatedAsync(
                                UpdateSql
                            );

                            if (result > 0)
                                phoneNumberUpdateSuccess.AddRange(phoneNumberUpdate);
                            else
                                phoneNumberUpdateFail.AddRange(phoneNumberUpdate);

                            phoneNumberUpdate = new();
                        }
                    }
                    else
                    {
                        //Create SIM
                        var diemSim = SimPhongThuy.TinhDiemPhongThuy(simHadFormat);
                        var status = ApprovedStatus.Approved;
                        if (isAgent)
                            status = ApprovedStatus.Waiting;

                        string dataInsert =
                            "('"
                            + simHadFormat
                            + "',"
                            + dataRow.price
                            + ","
                            + dataRow.agentSIMPrice
                            + ","
                            + dataRow.collaboratorsSIMPrice
                            + ","
                            + GetNetworkIdByName(dataRow.network)
                            + ","
                            + GetNetworkIdByName(dataRow.productType)
                            + ",'"
                            + dataRow.description
                            + "','"
                            + userId
                            + "','"
                            + userId
                            + "','"
                            + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "','"
                            + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "',"
                            + 0
                            + ",'"
                            + new Guid(request.Owner)
                            + "','"
                            + dataRow.seria
                            + "',"
                            + 0
                            + ","
                            + 0
                            + ","
                            + dataRow.priceOfAgent
                            + ",'"
                            + diemSim.amDuongTuongSinh
                            + "','"
                            + diemSim.nguHanhSim
                            + "','"
                            + diemSim.nguHanhTuongSinh
                            + "',"
                            + diemSim.point
                            + ","
                            + (int)status
                            + ","
                            + isMySim
                            + ",'"
                            + dataRow.position
                            + "',"
                            + 0
                            + ")";
                        dataInsertLst.Add(dataInsert);
                        phoneNumberInsert.Add(dataRow.phoneNumber);
                        phoneNumberHadFormatInsert.Add(simHadFormat);

                        if (
                            phoneNumberInsert.Count >= 100
                            || dataRow == request.DataInFile.LastOrDefault()
                        )
                        {
                            FormattableString InsertSqlStr = FormattableStringFactory.Create(
                                "INSERT INTO simdetails (SIMNumber, SIMPrice, AgentSIMPrice, CollaboratorsSIMPrice, SIMNetworkId, ProductTypeId, Description, CreateBy, UpdateBy, CreateTime, UpdateTime, IsDelete, Owner, SIMSeriaNumber, SIMEmbryoFee, SIMServiceFee, SIMPriceOfAgent, amDuongTuongSinh, nguHanhSim, nguHanhTuongSinh, point, status, IsMySim, Position, IsVerify) VALUES "
                                    + string.Join(",", dataInsertLst)
                            );
                            dataInsertLst = new();
                            var result = await _context.Database.ExecuteSqlInterpolatedAsync(
                                InsertSqlStr
                            );

                            if (result > 0)
                            {
                                phoneNumberInsertSuccess.AddRange(phoneNumberInsert);
                                phoneNumberHadFormatInsertSuccess.AddRange(
                                    phoneNumberHadFormatInsert
                                );
                            }
                            else
                                phoneNumberInsertFail.AddRange(phoneNumberInsert);

                            phoneNumberInsert = new();
                            phoneNumberHadFormatInsert = new();
                        }
                    }
                    //Thêm dữ liệu data đã xử lý
                    importResult.Add(readSimCSVModel);
                }
                catch (Exception ex)
                {
                    readSimCSVModel.result = "Có lỗi trong quá trình tạo SIM.";
                    importResult.Add(readSimCSVModel);
                    continue;
                }
            }
            List<string> dataInsertSimTypes = new();

            var simsInsert = _context
                .SIMDetails.AsNoTracking()
                .Where(x =>
                    x.Owner == owner && phoneNumberHadFormatInsertSuccess.Contains(x.SIMNumber)
                )
                .Select(x => new { Id = x.Id, SNumber = x.SIMNumber })
                .ToList();
            foreach (var item in importResult)
            {
                if (phoneNumberInsertSuccess.Contains(item.phoneNumber))
                {
                    //Fill trạng thái
                    item.result = "Tạo mới thành công.";

                    //Cập nhật loại sim số đẹp
                    var simNum = item.phoneNumber.Replace(".", "");
                    if (simNum.Length == 10)
                    {
                        simNum = simNum.Substring(1, 9);
                    }
                    string simHadFormat;
                    var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(
                        simNum,
                        out simHadFormat
                    );
                    var simInfo = simsInsert.FirstOrDefault(x => x.SNumber == simHadFormat);
                    if (simInfo != null)
                    {
                        //INSERT INTO simtypes (SimId, TypeId) VALUES ('1', '1');
                        var listTypeOfSimId = _context
                            .TypeOfSIMs.AsEnumerable()
                            .Where(x =>
                                listFormatTypeOfSim.Any(f =>
                                    !string.IsNullOrEmpty(f)
                                    && (
                                        x.Format != null
                                        && f != null
                                        && x.Format.Split(',')
                                            .Any(format => format.Trim() == f.Trim())
                                    )
                                )
                            )
                            .Select(x => x.Id)
                            .ToList();
                        listTypeOfSimId.Distinct();
                        foreach (var type in listTypeOfSimId)
                        {
                            string dataInsert = "(" + simInfo.Id + "," + type + ")";
                            dataInsertSimTypes.Add(dataInsert);
                        }
                    }
                    if (dataInsertSimTypes.Count >= block || item == importResult.LastOrDefault())
                    {
                        FormattableString InsertSqlStr = FormattableStringFactory.Create(
                            "INSERT INTO simtypes (SimId, TypeId) VALUES "
                                + string.Join(",", dataInsertSimTypes)
                        );
                        dataInsertSimTypes = new();
                        var result = await _context.Database.ExecuteSqlInterpolatedAsync(
                            InsertSqlStr
                        );
                    }
                }
                if (phoneNumberInsertFail.Contains(item.phoneNumber))
                    item.result = "Tạo mới thất bại.";
                if (phoneNumberUpdateSuccess.Contains(item.phoneNumber))
                    item.result = "Cập nhật thành công.";
                if (phoneNumberUpdateFail.Contains(item.phoneNumber))
                    item.result = "Cập nhật thất bại.";
            }
            //Ghi log
            LogAction logAction = new LogAction()
            {
                ActionName = "Import SIM",
                ControllerName = "",
                CreateBy = userId,
                CreateTime = DateTime.Now,
                IpAddressUser = null,
                NewData = JsonConvert.SerializeObject(request),
                OldData = "",
            };
            _logAction.InsertLogAction(logAction);
            return new ResponseDataModel<List<ReadSimCSVModel>>()
            {
                Code = "1",
                Message = "Import dữ liệu thành công",
                Data = importResult,
            };
        }

        public ResponseDataModel<string> CreateSIM(SIMCreateModel request, string userId)
        {
            try
            {
                var isMySim = false;
                var isStaff = _context
                    .Users.FirstOrDefault(x => x.Id.ToString() == request.Owner)
                    .IsStaff;
                if (isStaff)
                {
                    isMySim = true;
                }
                var dataChecking = _context.SIMDetails.FirstOrDefault(x =>
                    x.SIMNumber == request.SIMNumber
                );
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM đã tồn tại",
                    };
                }
                var simNum = request.SIMNumber.Replace(".", "");
                if (simNum.Length == 10)
                {
                    simNum = simNum.Substring(1, 9);
                }
                string simHadFormat;
                var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(simNum, out simHadFormat);
                var listTypeOfSimId = _context
                    .TypeOfSIMs.AsEnumerable()
                    .Where(x =>
                        listFormatTypeOfSim.Any(f =>
                            !string.IsNullOrEmpty(f)
                            && (
                                x.Format != null
                                && f != null
                                && x.Format.Split(',').Any(format => format.Trim() == f.Trim())
                            )
                        )
                    )
                    .Select(x => x.Id)
                    .ToList();
                listTypeOfSimId.Distinct();
                //Create SIM

                var diemSim = SimPhongThuy.TinhDiemPhongThuy(simHadFormat);
                var dataNew = new SIMDetail()
                {
                    SIMNumber = simHadFormat,
                    SIMSeriaNumber = request.Seria,
                    SIMImgUrl = request.SIMImgUrl ?? "",
                    SIMPrice = request.SIMPrice,
                    SIMPriceOfAgent = request.SIMPriceOfAgent,
                    AgentSIMPrice = request.AgentSIMPrice,
                    CollaboratorsSIMPrice = request.CollaboratorsSIMPrice,
                    SIMNetworkId = request.SIMNetworkId,
                    ProductTypeId = request.ProductTypeId,
                    Description = request.Description,
                    nguHanhSim = diemSim.nguHanhSim,
                    nguHanhTuongSinh = diemSim.nguHanhTuongSinh,
                    amDuongTuongSinh = diemSim.amDuongTuongSinh,
                    point = diemSim.point,
                    Owner = new Guid(request.Owner),
                    CreateTime = DateTime.Now,
                    CreateBy = new Guid(userId),
                    UpdateTime = DateTime.Now,
                    UpdateBy = new Guid(userId),
                    status = ApprovedStatus.Approved,
                    Position = request.Position,
                    IsMySim = isMySim,
                    IsVerify = true,
                };
                _context.SIMDetails.Add(dataNew);

                var result = _context.SaveChanges();

                foreach (var item in listTypeOfSimId)
                {
                    var simTypeData = new SIMType() { SimId = dataNew.Id, TypeId = item };
                    _context.SIMTypes.Add(simTypeData);
                }

                _context.SaveChanges();
                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Tạo mới SIM",
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
                    Message = "Có lỗi trong quá trình tạo SIM.",
                };
            }
        }

        public ResponseDataModel<string> CreateSIMNetwork(SIMNetworkCreateModel request)
        {
            try
            {
                var dataChecking = _context.SIMNetworks.FirstOrDefault(x =>
                    x.NetworkName == request.NetworkName
                );
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Nhà mạng đã tồn tại.",
                    };
                }

                //Create SIM
                var dataNew = new SIMNetwork()
                {
                    NetworkName = request.NetworkName,
                    NetworkImgUrl = request.NetworkImgUrl ?? "",
                    PrefixNumber = request.PrefixNumber,
                    Description = request.Description,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    HtmlId = request.HtmlId,
                };

                _context.SIMNetworks.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo nhà mạng.",
                };
            }
        }

        public ResponseDataModel<string> CreateTypeOfSIM(TypeOfSimCreateModel request)
        {
            try
            {
                var dataChecking = _context.TypeOfSIMs.FirstOrDefault(x => x.Name == request.Name);
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Loại SIM đã tồn tại",
                    };
                }

                //Create SIM
                var dataNew = new TypeOfSIM()
                {
                    Name = request.Name,
                    Format = request.Format,
                    Description = request.Description,
                    EstimatedPrice = request.EstimatedPrice,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                };

                _context.TypeOfSIMs.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteSIM(int Id, string userId)
        {
            try
            {
                var dataEntity = _context.SIMDetails.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM không tồn tại.",
                    };
                var oldData = JsonConvert.SerializeObject(dataEntity);
                _context.SIMDetails.Remove(dataEntity);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa SIM",
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
                    Message = "Xóa SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteAllMySIM(string userId)
        {
            try
            {
                var dataEntity = _context.SIMDetails.Where(x => x.IsMySim);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "SIM không tồn tại.",
                    };
                var oldData = "";
                _context.SIMDetails.RemoveRange(dataEntity);
                _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Xóa Tất cả SIM nhà",
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
                    Message = "Xóa SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa SIM.",
                };
            }
        }

        public ResponseDataModel<string> DeleteSIMNetwork(int Id)
        {
            try
            {
                var dataEntity = _context.SIMNetworks.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Nhà mạng không tồn tại.",
                    };
                _context.SIMNetworks.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa nhà mạng thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa nhà mạng.",
                };
            }
        }

        public ResponseDataModel<string> DeleteSIMType(int Id)
        {
            try
            {
                var dataEntity = _context.SIMTypes.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Loại SIM không tồn tại.",
                    };
                _context.SIMTypes.Remove(dataEntity);
                _context.SaveChanges();

                return new ResponseDataModel<string>()
                {
                    Code = "1",
                    Message = "Xóa loại SIM thành công.",
                };
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình xóa loại SIM.",
                };
            }
        }

        public SIMEditModel GetSIMDetail(int Id)
        {
            SIMEditModel result = new SIMEditModel();
            var dataEntity = _context.SIMDetails.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.SIMNumber = dataEntity.SIMNumber;
                result.Seria = dataEntity.SIMSeriaNumber;
                result.SIMPrice = dataEntity.SIMPrice;
                result.AgentSIMPrice = dataEntity.AgentSIMPrice;
                result.CollaboratorsSIMPrice = dataEntity.CollaboratorsSIMPrice;
                result.OriginalSIMPrice = dataEntity.SIMPriceOfAgent;
                result.SIMImgUrl = dataEntity.SIMImgUrl;
                result.SIMNetworkId = dataEntity.SIMNetworkId;
                result.ProductTypeId = dataEntity.ProductTypeId;
                result.Owner = dataEntity.Owner.ToString();
                result.Position = dataEntity.Position;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public SIMViewModel GetSIMInfo(int Id)
        {
            var query =
                from s in _context.SIMDetails
                join n in _context.SIMNetworks on s.SIMNetworkId equals n.Id
                where s.Id == Id
                select new { s, n };
            var data = query.FirstOrDefault();
            SIMViewModel result = new SIMViewModel();
            if (data != null)
            {
                var simType = (
                    from t in _context.TypeOfSIMs
                    join st in _context.SIMTypes on t.Id equals st.TypeId
                    where st.SimId == Id
                    select t.Name
                ).ToList();

                result.stt = 0;
                result.Id = data.s.Id;
                result.SIMImgUrl = data.s.SIMImgUrl;
                result.Network = data.n.NetworkName;
                result.Description = data.s.Description;
                result.Number = data.s.SIMNumber;
                result.Price = (int)data.s.SIMPrice;
                result.SIMServiceFee = data.s.SIMServiceFee;
                result.SIMEmbryoFee = data.s.SIMEmbryoFee;
                result.SIMType = simType;

                var simorder = (
                    from order in _context.SIMOrders
                    join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                    where swoder.SimId == Id
                    select order
                ).FirstOrDefault();
                var status = "Sẵn sàng";
                if (simorder != null)
                {
                    switch (simorder.Status)
                    {
                        case StatusOrder.Order:
                            status = "Đã đặt mua";
                            break;
                        case StatusOrder.WaitingApproved:
                            status = "Đang giao hàng";
                            break;
                        case StatusOrder.Success:
                            status = "Đã giao hàng";
                            break;
                        default:
                            break;
                    }
                }
                result.Status = status;
            }
            ;
            return result;
        }

        public ResponseGetSimInfoInOrderModel GetSIMInOrder(RequestGetSimInfoInOrderModel request)
        {
            var listSimId = request.simIds.Split(',').ToList();
            var simInDebt = _context
                .SimInfosInOrders.Where(x => listSimId.Contains(x.SimId.ToString()))
                .ToList();
            ResponseGetSimInfoInOrderModel result = new();
            if (simInDebt.Count > 0)
            {
                var customer = _context.Users.FirstOrDefault(x =>
                    x.Id.ToString() == request.customerId
                );
                result.customerName = customer?.FullName ?? "";
                result.address = customer?.Address ?? "";
                result.phoneNumber = customer?.PhoneNumber ?? "";
                result.totalPrice = simInDebt.Sum(x => x.PriceOfSim);
                var discount = GetDiscountOfUser(request.customerId, result.totalPrice).discount;
                result.discount = discount;
                result.simInfos = new();
                int idx = 0;
                foreach (var data in simInDebt)
                {
                    var owner = _context.Users.FirstOrDefault(x => x.Id == data.AgentId);
                    var discountOrder = GetDiscountOfUser(
                        customer?.Id.ToString() ?? "",
                        data.DiscountOfSim
                    );
                    var discountForMe = GetDiscountOfUser(
                        data.AgentId.ToString() ?? "",
                        data.DiscountOfAgent,
                        true
                    );
                    var order = (
                        from odr in _context.SIMOrders
                        join swodr in _context.SIMWithOrders on odr.Id equals swodr.OrderId
                        where odr.Status != StatusOrder.Cancel && swodr.SimId == data.Id
                        select odr
                    ).FirstOrDefault();

                    idx++;
                    result.simInfos.Add(
                        new SimInfoInOrderModel()
                        {
                            stt = idx,
                            id = data.Id,
                            orderId = order?.Id ?? 0,
                            number = data.SimNumber,
                            seria = data.SimSeria,
                            price = data.PriceOfSim,
                            discountOrder = data.DiscountOfSim,
                            priceDiscountOrder = data.PriceOfDiscount,
                            priceOrder = data.PriceAfterDiscount,
                            simEmbryoFee = data.SimServiceFee,
                            simServiceFee = data.SimServiceFee,
                            ownerId = owner?.Id,
                            owner = owner?.FullName ?? "",
                            ownerPhoneNumber = owner?.PhoneNumber ?? "",
                            SIMPriceOfAgent = data.PriceOfAgent,
                            discountForMe = data.DiscountOfAgent,
                            priceDiscountForMe = data.PriceOfDiscountAgent,
                            priceForMe = data.PriceAfterDiscountAgent,
                        }
                    );
                }

                result.totalOrderPrice = result.simInfos.Sum(x => x.priceOrder);
                result.totalSimEmbryoFee = result.simInfos.Sum(x => x.simEmbryoFee);
                result.totalSimServiceFee = result.simInfos.Sum(x => x.simServiceFee);
            }
            else
            {
                var query = _context
                    .SIMDetails.Where(x => listSimId.Contains(x.Id.ToString()))
                    .ToList();
                var customer = _context.Users.FirstOrDefault(x =>
                    x.Id.ToString() == request.customerId
                );
                result.customerName = customer?.FullName ?? "";
                result.address = customer?.Address ?? "";
                result.phoneNumber = customer?.PhoneNumber ?? "";
                result.totalPrice = query.Sum(x => x.SIMPrice);
                var discount = GetDiscountOfUser(request.customerId, result.totalPrice).discount;
                result.discount = discount;
                result.simInfos = new();
                int idx = 0;
                foreach (var data in query)
                {
                    var owner = _context.Users.FirstOrDefault(x => x.Id == data.Owner);
                    var discountOrder = GetDiscountOfUser(
                        customer?.Id.ToString() ?? "",
                        data.SIMPrice
                    );
                    var discountForMe = GetDiscountOfUser(
                        data.Owner.ToString() ?? "",
                        data.SIMPriceOfAgent,
                        true
                    );
                    var order = (
                        from odr in _context.SIMOrders
                        join swodr in _context.SIMWithOrders on odr.Id equals swodr.OrderId
                        where odr.Status != StatusOrder.Cancel && swodr.SimId == data.Id
                        select odr
                    ).FirstOrDefault();
                    var price = data.SIMPrice;
                    switch (order?.TypePriceSimOrder)
                    {
                        case TypePriceSimOrder.ForAgent:
                            price = data.AgentSIMPrice;
                            break;
                        case TypePriceSimOrder.ForCollaborators:
                            price = data.CollaboratorsSIMPrice;
                            break;
                    }

                    idx++;
                    result.simInfos.Add(
                        new SimInfoInOrderModel()
                        {
                            stt = idx,
                            id = data.Id,
                            orderId = order?.Id ?? 0,
                            number = data.SIMNumber,
                            seria = data.SIMSeriaNumber,
                            price = price,
                            discountOrder = discount,
                            priceDiscountOrder = discount * data.SIMPrice / 100,
                            priceOrder = data.SIMPrice - discount * data.SIMPrice / 100,
                            simEmbryoFee = data.SIMServiceFee,
                            simServiceFee = data.SIMServiceFee,
                            ownerId = owner?.Id,
                            owner = owner?.FullName ?? "",
                            ownerPhoneNumber = owner?.PhoneNumber ?? "",
                            SIMPriceOfAgent = data.SIMPriceOfAgent,
                            discountForMe = discountForMe.discount,
                            priceDiscountForMe =
                                data.SIMPriceOfAgent - discountForMe.priceWithDiscount,
                            priceForMe = discountForMe.priceWithDiscount,
                        }
                    );
                }

                result.totalOrderPrice = result.simInfos.Sum(x => x.priceOrder);
                result.totalSimEmbryoFee = result.simInfos.Sum(x => x.simEmbryoFee);
                result.totalSimServiceFee = result.simInfos.Sum(x => x.simServiceFee);
            }

            return result;
        }

        public List<SimInfosInOrderModel> GetSIMInfoInOrder(RequestGetSimInfoInOrderModel request)
        {
            var listSimId = request.simIds.Split(',').ToList();
            var query = _context
                .SIMDetails.Where(x => listSimId.Contains(x.Id.ToString()))
                .ToList();
            var customer = _context.Users.FirstOrDefault(x =>
                x.Id.ToString() == request.customerId
            );
            List<SimInfosInOrderModel> result = new();
            var discount = GetDiscountOfUser(
                request.customerId,
                query.Sum(x => x.SIMPrice)
            ).discount;
            int idx = 0;
            foreach (var data in query)
            {
                var owner = _context.Users.FirstOrDefault(x => x.Id == data.Owner);
                var discountOrder = GetDiscountOfUser(customer?.Id.ToString() ?? "", data.SIMPrice);
                var discountForMe = GetDiscountOfUser(
                    data.Owner.ToString() ?? "",
                    data.SIMPriceOfAgent,
                    true
                );
                idx++;
                result.Add(
                    new SimInfosInOrderModel()
                    {
                        SimId = data.Id,
                        SimNumber = data.SIMNumber,
                        SimSeria = data.SIMSeriaNumber,
                        PriceOfSim = data.SIMPrice,
                        DiscountOfSim = discount,
                        PriceOfDiscount = discount * data.SIMPrice / 100,
                        PriceAfterDiscount = data.SIMPrice - discount * data.SIMPrice / 100,
                        SimEmbryoFee = data.SIMServiceFee,
                        SimServiceFee = data.SIMServiceFee,
                        AgentId = owner?.Id,
                        AgentName = owner?.FullName ?? "",
                        PriceOfAgent = data.SIMPriceOfAgent,
                        DiscountOfAgent = discountForMe.discount,
                        PriceAfterDiscountAgent =
                            data.SIMPriceOfAgent - discountForMe.priceWithDiscount,
                        PriceOfDiscountAgent = data.SIMPriceOfAgent * discountForMe.discount / 100,
                    }
                );
            }

            return result;
        }

        private AgentChangeResModel GetDiscountOfUser(
            string userId,
            double price,
            bool isAgentForMe = false
        )
        {
            var userInfo = _context.Users.FirstOrDefault(x => x.Id.ToString() == userId);
            AgentChangeResModel agentChangeResModel = new AgentChangeResModel()
            {
                phoneNumber = userInfo?.PhoneNumber ?? "",
                address = userInfo?.Address ?? "",
                discount = 0,
                priceWithDiscount = price,
            };
            if (isAgentForMe)
            {
                if (userInfo != null)
                {
                    var discountData = _context.Discounts.FirstOrDefault(x =>
                        x.PriceFrom <= price
                        && x.PriceTo >= price
                        && x.CollaboratorsGroupId == userInfo.DiscountForSimSellersId
                    );
                    var discount = discountData?.DiscountPer ?? 0;
                    agentChangeResModel.discount = discount;
                    agentChangeResModel.priceWithDiscount = price - price * discount / 100;
                }
            }
            else
            {
                var agentGroupOfUser = _context.CollaboratorsGroupUsers.FirstOrDefault(x =>
                    x.UserId.ToString() == userId
                );
                if (agentGroupOfUser != null)
                {
                    var discountData = _context.Discounts.FirstOrDefault(x =>
                        x.PriceFrom <= price
                        && x.PriceTo >= price
                        && x.CollaboratorsGroupId == agentGroupOfUser.CollaboratorsGroupId
                    );
                    var discount = discountData?.DiscountPer ?? 0;
                    agentChangeResModel.discount = discount;
                    agentChangeResModel.priceWithDiscount = price - price * discount / 100;
                }
            }

            return agentChangeResModel;
        }

        public SIMNetworkEditModel GetSIMNetwork(int Id)
        {
            SIMNetworkEditModel result = new SIMNetworkEditModel();
            var dataEntity = _context.SIMNetworks.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.NetworkImgUrl = dataEntity.NetworkImgUrl;
                result.NetworkName = dataEntity.NetworkName;
                result.HtmlId = dataEntity.HtmlId;
                result.PrefixNumber = dataEntity.PrefixNumber;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public List<SelectListItem> GetSIMNetworkListForCombo(string selectedValue = "")
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.SIMNetworks.Where(x => !x.IsDelete).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.NetworkName, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public ResponseDataViewModel<SIMNetworkViewModel> GetSIMNetworkPaging(
            GetPagingRequest request
        )
        {
            var dataEntity = _context.SIMNetworks.Where(x =>
                x.NetworkName.Contains(request.keyword)
            );
            var dataPaging = _context
                .SIMNetworks.Where(x => x.NetworkName.Contains(request.keyword))
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<SIMNetworkViewModel>();
            foreach (var item in dataPaging)
            {
                data.Add(
                    new SIMNetworkViewModel()
                    {
                        Id = item.Id,
                        NetworkName = item.NetworkName,
                        NetworkImgUrl = item.NetworkImgUrl,
                        PrefixNumber = item.PrefixNumber,
                        HtmlId = item.HtmlId,
                        Description = item.Description,
                    }
                );
            }
            //
            return new ResponseDataViewModel<SIMNetworkViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.keyword,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataViewModel<SIMViewModel> GetSIMPaging(SIMFilterModel request)
        {
            //Call stored procedure
            request.SimNumber = request.SimNumber.Replace(".", "");
            MySqlParameter[] queryParams = new MySqlParameter[]
            {
                new MySqlParameter("@p1", request.SimNumber),
                new MySqlParameter("@p2", string.Join(",", request.ProductTypes)),
                new MySqlParameter("@p3", string.Join(",", request.Networks)),
                new MySqlParameter("@p4", string.Join(",", request.Owners)),
                new MySqlParameter("@p5", request.pageIndex - 1),
                new MySqlParameter("@p6", request.pageSize),
            };
            string store_pocedure = "call GetSimInfoPaging(@p1,@p2,@p3,@p4,@p5,@p6)";
            var result = _context
                .Set<v_SIMDetail>()
                .FromSqlRaw(store_pocedure, queryParams)
                .ToList<v_SIMDetail>();

            var data = new List<SIMViewModel>();
            int idx = 0;
            var simlock = result
                .Where(x => x.Status == "Đã có người đặt")
                .Select(x => x.Number)
                .ToList();
            foreach (var item in result)
            {
                var simType = (
                    from t in _context.TypeOfSIMs
                    join st in _context.SIMTypes on t.Id equals st.TypeId
                    where st.SimId == item.Id
                    select t.Name
                )
                    .Distinct()
                    .ToList();

                idx++;
                data.Add(
                    new SIMViewModel()
                    {
                        stt = ((request.pageIndex - 1) * request.pageSize) + idx,
                        Id = item.Id ?? 0,
                        SIMImgUrl = item.SIMImgUrl,
                        Network = item.Network,
                        Position = item.Position,
                        Description = item.Description,
                        Number = item.Number,
                        Seria = item.Seria ?? "",
                        Owner = item.Owner ?? "",
                        OwnerPhoneNumber = item.OwnerPhoneNumber,
                        ProductType = item.ProductType ?? "",
                        Price = item.Price ?? 0,
                        SIMEmbryoFee = item.SIMEmbryoFee ?? 0,
                        SIMServiceFee = item.SIMServiceFee ?? 0,
                        SIMType = simType,
                        Status = simlock.Contains(item.Number) ? "Đã có người đặt" : item.Status,
                    }
                );
            }
            //
            return new ResponseDataViewModel<SIMViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.SimNumber,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    result.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOnHomePaging(
            SearchSIMRequest request
        )
        {
            try
            {
                List<SimOfAgentOnCMSModel> data = new();
                Guid agentId = new Guid();

                var agentOfUser = (
                    from collab in _context.CollaboratorsGroupUsers
                    join collabGroup in _context.CollaboratorsGroups
                        on collab.CollaboratorsGroupId equals collabGroup.Id
                    where collab.UserId == request.userId
                    select collabGroup.OwnerId
                ).FirstOrDefault();
                if (agentOfUser != null)
                    agentId = agentOfUser;

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSIMOnHomePaging";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @SimTypeIds, @NetworkIds, @ProducTypeIds, @Prefixs, @AvoidNums, @AvoidSixNum, @PriceFrom, @PriceTo, @SortBy, @AgentId)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@SimTypeIds", string.Join(",", request.simTypeIds)),
                    new("@NetworkIds", string.Join(",", request.networkIds)),
                    new("@ProducTypeIds", string.Join(",", request.productTypeIds)),
                    new("@Prefixs", string.Join(",", request.prefixs)),
                    new("@AvoidNums", string.Join(",", request.avoidNums)),
                    new("@AvoidSixNum", request.avoidSixNum ? 1 : 0),
                    new("@PriceFrom", request.priceFrom),
                    new("@PriceTo", request.priceTo),
                    new("@SortBy", request.sortBy),
                    new("@AgentId", agentId),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOfAgentOnCMSModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                if (string.IsNullOrEmpty(request.keyword))
                    data.AddRange(dataExec);
                else
                    foreach (var item in dataExec)
                    {
                        SimOfAgentOnCMSModel dataViewItem = new SimOfAgentOnCMSModel();
                        dataViewItem = item as SimOfAgentOnCMSModel;
                        dataViewItem.SIMNumber = item.SIMNumber.Replace(
                            request.keyword.Replace("*", ""),
                            "<span style=\"color:red\">"
                                + request.keyword.Replace("*", "")
                                + "</span>"
                        );
                        data.Add(dataViewItem);
                    }

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<SimOfAgentOnCMSModel>()
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
                return new ResponseDataViewModel<SimOfAgentOnCMSModel>();
            }
        }

        public ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOnHome(SearchSIMRequest request)
        {
            try
            {
                List<SimOfAgentOnCMSModel> data = new();
                Guid agentId = new Guid();

                var agentOfUser = (
                    from collab in _context.CollaboratorsGroupUsers
                    join collabGroup in _context.CollaboratorsGroups
                        on collab.CollaboratorsGroupId equals collabGroup.Id
                    where collab.UserId == request.userId
                    select collabGroup.OwnerId
                ).FirstOrDefault();
                if (agentOfUser != null)
                    agentId = agentOfUser;

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSIMOnHome";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @SimTypeIds, @NetworkIds, @ProducTypeIds, @Prefixs, @AvoidNums, @AvoidSixNum, @PriceFrom, @PriceTo, @SortBy, @AgentId)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@SimTypeIds", string.Join(",", request.simTypeIds)),
                    new("@NetworkIds", string.Join(",", request.networkIds)),
                    new("@ProducTypeIds", string.Join(",", request.productTypeIds)),
                    new("@Prefixs", string.Join(",", request.prefixs)),
                    new("@AvoidNums", string.Join(",", request.avoidNums)),
                    new("@AvoidSixNum", request.avoidSixNum ? 1 : 0),
                    new("@PriceFrom", request.priceFrom),
                    new("@PriceTo", request.priceTo),
                    new("@SortBy", request.sortBy),
                    new("@AgentId", agentId),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOfAgentOnCMSModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                if (string.IsNullOrEmpty(request.keyword))
                    data.AddRange(dataExec);
                else
                    foreach (var item in dataExec)
                    {
                        SimOfAgentOnCMSModel dataViewItem = new SimOfAgentOnCMSModel();
                        dataViewItem = item as SimOfAgentOnCMSModel;
                        dataViewItem.SIMNumber = item.SIMNumber.Replace(
                            request.keyword.Replace("*", ""),
                            "<span style=\"color:red\">"
                                + request.keyword.Replace("*", "")
                                + "</span>"
                        );
                        data.Add(dataViewItem);
                    }

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(
                    new PagingRequestBase()
                    {
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    data?.FirstOrDefault()?.TotalCount ?? 0
                );
                var responseData = new ResponseDataViewModel<SimOfAgentOnCMSModel>()
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
                return new ResponseDataViewModel<SimOfAgentOnCMSModel>();
            }
        }

        public TypeOfSimEditModel GetTypeOfSim(int Id)
        {
            TypeOfSimEditModel result = new TypeOfSimEditModel();
            var dataEntity = _context.TypeOfSIMs.FirstOrDefault(x => x.Id == Id);
            if (dataEntity != null)
            {
                result.Id = dataEntity.Id;
                result.Name = dataEntity.Name;
                result.Format = dataEntity.Format;
                result.EstimatedPrice = dataEntity.EstimatedPrice;
                result.Description = dataEntity.Description;
            }
            return result;
        }

        public List<SelectListItem> GetTypeOfSIMListForCombo(string selectedValue = "")
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.TypeOfSIMs.ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public ResponseDataViewModel<TypeOfSIMViewModel> GetTypeOfSIMPaging(
            GetPagingRequest request
        )
        {
            var dataEntity = _context.TypeOfSIMs.Where(x => x.Name.Contains(request.keyword));
            var dataPaging = _context
                .TypeOfSIMs.Where(x => x.Name.Contains(request.keyword))
                .Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .ToList();
            var data = new List<TypeOfSIMViewModel>();
            foreach (var item in dataPaging)
            {
                data.Add(
                    new TypeOfSIMViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Format = item.Format,
                        EstimatedPrice = item.EstimatedPrice,
                        Description = item.Description,
                    }
                );
            }
            //
            return new ResponseDataViewModel<TypeOfSIMViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = request.keyword,
                        pageIndex = request.pageIndex,
                        pageSize = request.pageSize,
                    },
                    dataEntity.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<string> UpdateSIM(SIMEditModel request, string userId)
        {
            try
            {
                var isMySim = false;
                var isStaff = _context
                    .Users.FirstOrDefault(x => x.Id.ToString() == request.Owner)
                    .IsStaff;
                if (isStaff)
                {
                    isMySim = true;
                }
                var dataEntity = _context.SIMDetails.FirstOrDefault(x => x.Id == request.Id);
                var simNum = request.SIMNumber.Replace(".", "");
                if (simNum.Length == 10)
                {
                    simNum = simNum.Substring(1, 9);
                }
                string simHadFormat;
                var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(simNum, out simHadFormat);
                var listTypeOfSimId = _context
                    .TypeOfSIMs.AsEnumerable()
                    .Where(x =>
                        listFormatTypeOfSim.Any(f =>
                            !string.IsNullOrEmpty(f)
                            && (
                                x.Format != null
                                && f != null
                                && x.Format.Split(',').Any(format => format.Trim() == f.Trim())
                            )
                        )
                    )
                    .Select(x => x.Id)
                    .ToList();
                listTypeOfSimId.Distinct();
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số SIM không tồn tại.",
                    };
                }
                var oldData = JsonConvert.SerializeObject(dataEntity);
                dataEntity.SIMPrice = request.SIMPrice;
                dataEntity.SIMPriceOfAgent = request.OriginalSIMPrice;
                dataEntity.AgentSIMPrice = request.AgentSIMPrice;
                dataEntity.CollaboratorsSIMPrice = request.CollaboratorsSIMPrice;
                dataEntity.SIMNumber = request.SIMNumber;
                dataEntity.SIMSeriaNumber = request.Seria;
                dataEntity.SIMNetworkId = request.SIMNetworkId;
                dataEntity.SIMImgUrl = request.SIMImgUrl;
                dataEntity.ProductTypeId = request.ProductTypeId;
                dataEntity.Description = request.Description;
                dataEntity.Owner = new Guid(request.Owner);
                dataEntity.Position = request.Position;
                dataEntity.UpdateTime = DateTime.Now;
                dataEntity.IsMySim = isMySim;

                _context.SIMDetails.Update(dataEntity);

                Console.WriteLine(
                    $"AgentSIMPrice = {dataEntity.AgentSIMPrice} ({dataEntity.AgentSIMPrice.GetType()})"
                );
                Console.WriteLine(
                    $"CollaboratorsSIMPrice = {dataEntity.CollaboratorsSIMPrice} ({dataEntity.CollaboratorsSIMPrice.GetType()})"
                );
                var check = _context
                    .SIMDetails.Where(x => x.Id == dataEntity.Id)
                    .Select(x => new { x.AgentSIMPrice, x.CollaboratorsSIMPrice })
                    .FirstOrDefault();
                Console.WriteLine(
                    $"DB value: {check.AgentSIMPrice}, {check.CollaboratorsSIMPrice}"
                );
                var entry = _context.Entry(dataEntity);
                foreach (var prop in entry.Properties)
                {
                    Console.WriteLine(
                        $"{prop.Metadata.Name} - Current: {prop.CurrentValue}, Original: {prop.OriginalValue}, Modified: {prop.IsModified}"
                    );
                }
                var simTypeOld = _context.SIMTypes.Where(x => x.SimId == dataEntity.Id);
                _context.SIMTypes.RemoveRange(simTypeOld);

                foreach (var item in listTypeOfSimId)
                {
                    var simTypeData = new SIMType() { SimId = request.Id, TypeId = item };
                    _context.SIMTypes.Add(simTypeData);
                }

                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Cập nhật SIM",
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
                    Message = "Có lỗi trong quá trình cập nhật SIM.",
                };
            }
        }

        public ResponseDataModel<string> UpdateSIMNetwork(SIMNetworkEditModel request)
        {
            try
            {
                var dataEntity = _context.SIMNetworks.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Nhà mạng không tồn tại.",
                    };
                }

                dataEntity.NetworkName = request.NetworkName;
                dataEntity.NetworkImgUrl = request.NetworkImgUrl;
                dataEntity.HtmlId = request.HtmlId;
                dataEntity.PrefixNumber = request.PrefixNumber;
                dataEntity.Description = request.Description;
                dataEntity.UpdateTime = DateTime.Now;

                _context.SIMNetworks.Update(dataEntity);
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

        public ResponseDataModel<string> UpdateTypeOfSim(TypeOfSimEditModel request)
        {
            try
            {
                var dataEntity = _context.TypeOfSIMs.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Loại SIM không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.Format = request.Format;
                dataEntity.Description = request.Description;
                dataEntity.EstimatedPrice = request.EstimatedPrice;
                dataEntity.UpdateTime = DateTime.Now;

                _context.TypeOfSIMs.Update(dataEntity);
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
                    Message = "Có lỗi trong quá trình tạo loại SIM.",
                };
            }
        }

        public List<SimOnAppModel> GetSIMAPI(SearchSIMRequest request)
        {
            try
            {
                List<SimOnAppModel> data = new();
                Guid agentId = new Guid();

                var agentOfUser = (
                    from collab in _context.CollaboratorsGroupUsers
                    join collabGroup in _context.CollaboratorsGroups
                        on collab.CollaboratorsGroupId equals collabGroup.Id
                    where collab.UserId == request.userId
                    select collabGroup.OwnerId
                ).FirstOrDefault();
                if (agentOfUser != null)
                    agentId = agentOfUser;

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSIMForApp";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @SimTypeIds, @NetworkIds, @ProducTypeIds, @Prefixs, @AvoidNums, @AvoidSixNum, @PriceFrom, @PriceTo, @SortBy, @AgentId)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@SimTypeIds", string.Join(",", request.simTypeIds)),
                    new("@NetworkIds", string.Join(",", request.networkIds)),
                    new("@ProducTypeIds", string.Join(",", request.productTypeIds)),
                    new("@Prefixs", string.Join(",", request.prefixs)),
                    new("@AvoidNums", string.Join(",", request.avoidNums)),
                    new("@AvoidSixNum", request.avoidSixNum ? 1 : 0),
                    new("@PriceFrom", request.priceFrom),
                    new("@PriceTo", request.priceTo),
                    new("@SortBy", request.sortBy),
                    new("@AgentId", agentId),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOnAppModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                return data;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new List<SimOnAppModel>();
            }
        }

        public ResponseDataViewModel<SimOnAppModel> GetSIMDataOnAppAPI(
            SearchSIMDataOnAppRequest request
        )
        {
            try
            {
                List<SimOnAppModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSIMDataForApp";
                string query =
                    $"CALL {storedProcedureName}(@PageIndex, @PageSize, @Keyword, @ProducTypeIds, @SortBy)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@ProducTypeIds", string.Join(",", request.productTypeIds)),
                    new("@SortBy", request.sortBy),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOnAppModel>()
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
                var responseData = new ResponseDataViewModel<SimOnAppModel>()
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
                return new ResponseDataViewModel<SimOnAppModel>();
            }
        }

        public List<SimOnAppModel> GetSIMOfAgentOnAppAPI(SearchSIMOfAgentOnAppRequest request)
        {
            try
            {
                List<SimOnAppModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSimOfAgentOnApp";
                string query =
                    $"CALL {storedProcedureName}(@PageIndex, @PageSize, @Keyword, @UserId, @SimOnAppStatus, @SortBy)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@UserId", request.userId),
                    new("@SimOnAppStatus", request.simOnAppStatus),
                    new("@SortBy", request.sortBy),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOnAppModel>()
                    .FromSqlRaw(query, parameters.ToArray())
                    .ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                return data;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new List<SimOnAppModel>();
            }
        }

        public ResponseDataViewModel<SimOfAgentOnCMSModel> GetSIMOfAgentOnCMS(
            SearchSIMOfAgentOnAppRequest request
        )
        {
            try
            {
                List<SimOfAgentOnCMSModel> data = new();
                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSimOfAgentOnCMS";
                string query =
                    $"CALL {storedProcedureName}(@PageIndex, @PageSize, @Keyword, @UserId, @SimOnAppStatus, @SortBy)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@UserId", request.userId),
                    new("@SimOnAppStatus", request.simOnAppStatus),
                    new("@SortBy", request.sortBy),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimOfAgentOnCMSModel>()
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
                var responseData = new ResponseDataViewModel<SimOfAgentOnCMSModel>()
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
                return new ResponseDataViewModel<SimOfAgentOnCMSModel>();
            }
        }

        public List<SIMNetworkViewModel> GetSIMNetwork()
        {
            var dataEntity = _context.SIMNetworks;
            var data = new List<SIMNetworkViewModel>();
            foreach (var item in dataEntity)
            {
                data.Add(
                    new SIMNetworkViewModel()
                    {
                        Id = item.Id,
                        NetworkName = item.NetworkName,
                        NetworkImgUrl = item.NetworkImgUrl,
                        PrefixNumber = item.PrefixNumber,
                        HtmlId = item.HtmlId,
                        Description = item.Description,
                    }
                );
            }
            return data;
        }

        public List<TypeOfSIMViewModel> GetTypeOfSIM()
        {
            var dataEntity = _context.TypeOfSIMs;
            var data = new List<TypeOfSIMViewModel>();
            foreach (var item in dataEntity)
            {
                data.Add(
                    new TypeOfSIMViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Format = item.Format,
                        Description = item.Description,
                    }
                );
            }
            return data;
        }

        public List<SIMViewOnApp> GetSIMFlashSale()
        {
            List<SIMViewOnApp> simLst = new List<SIMViewOnApp>();
            var data = _context
                .SIMDetails.Where(x => !x.IsDelete)
                .OrderByDescending(x => x.UpdateTime)
                .Take(20);
            foreach (var item in data)
            {
                simLst.Add(
                    new SIMViewOnApp()
                    {
                        Id = item.Id,
                        PhoneNumber = item.SIMNumber,
                        Price = item.SIMPrice.ToString(),
                        PriceOnSale = "",
                        SimNetworkId = item.SIMNetworkId,
                        SimType = "",
                    }
                );
            }
            return simLst;
        }

        public List<SIMViewOnApp> GetSIMSaleOnDay()
        {
            List<SIMViewOnApp> simLst = new List<SIMViewOnApp>();
            Random rng = new Random();
            var simData = _context.SIMDetails.Where(x => !x.IsDelete).ToList();
            List<int> lst = simData.Select(x => x.Id).ToList();
            int dataSaleNum = 0;
            while (dataSaleNum < 20)
            {
                int idx = rng.Next(lst.Count);
                var item = simData[idx];
                simLst.Add(
                    new SIMViewOnApp()
                    {
                        Id = item.Id,
                        PhoneNumber = item.SIMNumber,
                        Price = item.SIMPrice.ToString(),
                        PriceOnSale = "",
                        SimNetworkId = item.SIMNetworkId,
                        SimType = "",
                    }
                );
                dataSaleNum++;
            }
            return simLst;
        }

        public List<SIMViewOnApp> GetSIMLastUpdate()
        {
            List<SIMViewOnApp> simLst = new List<SIMViewOnApp>();
            var data = _context
                .SIMDetails.Where(x => !x.IsDelete)
                .OrderByDescending(x => x.UpdateTime)
                .Take(20);
            foreach (var item in data)
            {
                simLst.Add(
                    new SIMViewOnApp()
                    {
                        Id = item.Id,
                        PhoneNumber = item.SIMNumber,
                        Price = item.SIMPrice.ToString(),
                        PriceOnSale = "",
                        SimNetworkId = item.SIMNetworkId,
                        SimType = "",
                    }
                );
            }
            return simLst;
        }

        public ResponseDataViewModel<ProductTypeViewModel> GetProductTypePaging(
            GetPagingRequest request
        )
        {
            var query = _context.ProductTypes.Where(x => x.Name.Contains(request.keyword));

            var dataPaging = query.ToList();
            var data = new List<ProductTypeViewModel>();
            var idx = 0;
            foreach (var item in dataPaging)
            {
                idx++;
                var country = _context.Countries.FirstOrDefault(x => x.Id == item.CountryId);
                data.Add(
                    new ProductTypeViewModel()
                    {
                        Stt = idx * request.pageIndex,
                        Id = item.Id,
                        Name = item.Name ?? "",
                        CountryName = country?.Name ?? "",
                        DefaulPrice = item.DefaulPrice.ToString("#,##0"),
                        Summary = item.Summary ?? "",
                        Description = item.Description ?? "",
                        IsSimData = item.IsSimData,
                        IsTouristSim = item.IsTouristSim,
                    }
                );
            }

            //
            return new ResponseDataViewModel<ProductTypeViewModel>()
            {
                Pager = new Pager(
                    new PagingRequestBase()
                    {
                        keyword = "",
                        pageIndex = 1,
                        pageSize = dataPaging.Count(),
                    },
                    dataPaging.Count()
                ),
                Data = data,
            };
        }

        public ResponseDataModel<string> CreateProductType(ProductTypeModel request)
        {
            try
            {
                var dataChecking = _context.ProductTypes.FirstOrDefault(x =>
                    x.Name == request.Name
                );
                if (dataChecking != null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Loại sim đã tồn tại.",
                    };
                }

                //Create SIM
                var dataNew = new ProductType()
                {
                    Name = request.Name,
                    CountryId = request.CountryId,
                    DefaulPrice = request.DefaulPrice,
                    Summary = request.Summary,
                    Description = request.Description,
                    IsSimData = request.IsSimData,
                    IsTouristSim = request.IsTouristSim,
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                    CreateBy = request.CreateBy ?? new Guid(),
                    UpdateBy = request.CreateBy ?? new Guid(),
                };

                _context.ProductTypes.Add(dataNew);
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
                    Message = "Có lỗi trong quá trình tạo mới.",
                };
            }
        }

        public ResponseDataModel<string> UpdateProductType(ProductTypeModel request)
        {
            try
            {
                var dataEntity = _context.ProductTypes.FirstOrDefault(x => x.Id == request.Id);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Loại sim không tồn tại.",
                    };
                }

                dataEntity.Name = request.Name;
                dataEntity.CountryId = request.CountryId;
                dataEntity.DefaulPrice = request.DefaulPrice;
                dataEntity.Summary = request.Summary;
                dataEntity.Description = request.Description;
                dataEntity.IsSimData = request.IsSimData;
                dataEntity.IsTouristSim = request.IsTouristSim;
                dataEntity.UpdateTime = DateTime.Now;

                _context.ProductTypes.Update(dataEntity);

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
                    Message = "Có lỗi trong quá trình cập nhật SIM.",
                };
            }
        }

        public ProductTypeModel GetProductTypeById(int Id)
        {
            var data = _context.ProductTypes.FirstOrDefault(p => p.Id == Id);
            if (data != null)
            {
                return new ProductTypeModel()
                {
                    Id = data.Id,
                    Name = data.Name ?? "",
                    CountryId = data.CountryId,
                    DefaulPrice = data.DefaulPrice,
                    Summary = data.Summary,
                    Description = data.Description,
                    IsSimData = data.IsSimData,
                    IsTouristSim = data.IsTouristSim,
                };
            }
            else
                return null;
        }

        public ResponseDataModel<string> DeleteProductType(int Id, Guid userId)
        {
            try
            {
                var dataEntity = _context.ProductTypes.Find(Id);
                if (dataEntity == null)
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Dữ liệu không tồn tại.",
                    };
                _context.ProductTypes.Remove(dataEntity);
                _context.SaveChanges();

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

        public List<SelectListItem> GetProductTypeForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.ProductTypes.Where(x => !x.IsDelete).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public List<SelectListItem> GetProductTypeSIMDataForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.ProductTypes.Where(x => !x.IsDelete && x.IsSimData).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public List<SelectListItem> GetTouristSIMForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context.ProductTypes.Where(x => !x.IsDelete && x.IsTouristSim).ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public List<SelectListItem> GetSIMTypeForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context
                .ProductTypes.Where(x => !x.IsDelete && !x.IsSimData && !x.IsTouristSim)
                .ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public List<SelectListItem> GetSIMDataNTouristForCombo()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var data = _context
                .ProductTypes.Where(x => !x.IsDelete && (x.IsSimData || x.IsTouristSim))
                .ToList();
            foreach (var item in data)
            {
                selectListItems.Add(
                    new SelectListItem { Text = item.Name, Value = item.Id.ToString() }
                );
            }
            return selectListItems;
        }

        public int GetNetworkIdByName(string name)
        {
            var network = _context.SIMNetworks.FirstOrDefault(x => x.NetworkName == name);
            if (network != null)
                return network.Id;
            else
                return 2;
        }

        public string GetNetworkNameByPrefix(string prefix)
        {
            var network = _context.SIMNetworks.FirstOrDefault(x => x.PrefixNumber.Contains(prefix));
            if (network != null)
                return network.NetworkName;
            else
                return "Vinaphone";
        }

        public int GetGetProductTypeIdByName(string name)
        {
            var productType = _context.ProductTypes.FirstOrDefault(x => x.Name == name);
            if (productType != null)
                return productType.Id;
            else
                return 1;
        }

        public string CheckSimIdIsAvaliable(List<int> simIds)
        {
            List<string> avaliableSimId = new List<string>();
            foreach (var simId in simIds)
            {
                var simorder = (
                    from order in _context.SIMOrders
                    join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                    where
                        swoder.SimId == simId
                        && (
                            order.Status != StatusOrder.Cancel
                            && (
                                order.Status == StatusOrder.Order
                                && order.TimeUnlock >= DateTime.Now
                            )
                        )
                    select order
                ).ToList();
                if (simorder.Count == 0)
                {
                    var sim = _context.SIMDetails.FirstOrDefault(x =>
                        x.Id == simId && x.status == ApprovedStatus.Approved
                    );
                    if (sim != null)
                        avaliableSimId.Add(simId.ToString());
                }
            }
            return string.Join(",", avaliableSimId);
        }

        public AskSimViewModel GetSimInfoForAskSim(string simNumber)
        {
            try
            {
                AskSimViewModel askSimView = new();
                askSimView.priceOrder = 0;
                askSimView.simIds = "";
                askSimView.simInfos = new();
                askSimView.orderCancelInfos = new();
                askSimView.orderInfos = new();
                var simInfos = _context
                    .SIMDetails.Where(x =>
                        x.SIMNumber.Replace(".", "").Contains(simNumber.Replace(".", ""))
                    )
                    .ToList();
                if (simInfos.Count != 0)
                {
                    var simOrders = (
                        from order in _context.SIMOrders
                        join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                        where
                            simInfos.Select(x => x.Id).ToList().Contains(swoder.SimId)
                            && (
                                order.Status != StatusOrder.Cancel
                                || (
                                    order.Status == StatusOrder.Order
                                    && order.TimeUnlock >= DateTime.Now
                                )
                            )
                        select order
                    ).ToList();
                    if (simOrders.Count == 0)
                    {
                        askSimView.priceOrder =
                            simInfos[0].SIMPrice
                            + simInfos.Sum(x => x.SIMEmbryoFee)
                            + simInfos.Sum(x => x.SIMServiceFee);
                        askSimView.simIds = string.Join(",", simInfos.Select(x => x.Id).ToList());
                        int idx = 0;
                        foreach (var simInfo in simInfos.ToList())
                        {
                            idx++;
                            var network = _context
                                .SIMNetworks.FirstOrDefault(x => x.Id == simInfo.SIMNetworkId)
                                ?.NetworkName;
                            var productType = _context
                                .ProductTypes.FirstOrDefault(x => x.Id == simInfo.ProductTypeId)
                                ?.Name;
                            var owner = _context.Users.FirstOrDefault(x => x.Id == simInfo.Owner);
                            var simType = (
                                from t in _context.TypeOfSIMs
                                join st in _context.SIMTypes on t.Id equals st.TypeId
                                where st.SimId == simInfo.Id
                                select t.Name
                            )
                                .Distinct()
                                .ToList();
                            askSimView.simInfos.Add(
                                new SIMViewModel()
                                {
                                    stt = idx,
                                    Id = simInfo.Id,
                                    Number = simInfo.SIMNumber,
                                    Seria = simInfo.SIMSeriaNumber,
                                    Price = simInfo.SIMPrice,
                                    AgentSIMPrice = simInfo.AgentSIMPrice,
                                    CollaboratorsSIMPrice = simInfo.CollaboratorsSIMPrice,
                                    Description = simInfo.Description,
                                    Network = network,
                                    ProductType = productType,
                                    Owner = owner?.FullName ?? "",
                                    OwnerPhoneNumber = owner?.PhoneNumber ?? "",
                                    Position = simInfo.Position,
                                    IsMySim = simInfo.IsMySim,
                                    SIMType = simType,
                                }
                            );
                        }
                        //Check lịch sử hỏi sim
                        var simOrderCancels = (
                            from order in _context.SIMOrders
                            join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                            where simInfos.Select(x => x.Id).ToList().Contains(swoder.SimId)
                            //&& (order.Status != StatusOrder.Cancel || (order.Status == StatusOrder.Order && order.TimeUnlock >= DateTime.Now))
                            select order
                        ).ToList();
                        foreach (var simOrder in simOrderCancels)
                        {
                            var payOrderType = "";
                            switch (simOrder.PayOrderType)
                            {
                                case PaymentType.COD:
                                    payOrderType = "Thanh toán tiền mặt";
                                    break;
                                case PaymentType.Online:
                                    payOrderType = "Thanh toán online";
                                    break;
                                case PaymentType.Company:
                                    payOrderType = "Xuất hóa đơn công ty";
                                    break;
                                case PaymentType.Installment:
                                    payOrderType = "Thanh toán trả góp";
                                    break;
                            }
                            var simWithOrder = _context.SIMWithOrders.Where(x =>
                                x.OrderId == simOrder.Id
                            );
                            var simInOrderInfos = _context
                                .SIMDetails.Where(x =>
                                    simWithOrder.Select(x => x.SimId).ToList().Contains(x.Id)
                                )
                                .ToList();
                            var productTypeIds = simInOrderInfos
                                .Select(x => x.ProductTypeId)
                                .ToList();
                            var productTypes = _context
                                .ProductTypes.Where(x => productTypeIds.Contains(x.Id))
                                .Select(x => x.Name)
                                .ToList();
                            var contact = _context.SupportContacts.FirstOrDefault(x =>
                                x.Id == simOrder.ContactId
                            );
                            var pic = _context.Users.FirstOrDefault(x => x.Id == simOrder.PIC);
                            askSimView.orderCancelInfos.Add(
                                new SIMOrderViewModel()
                                {
                                    Id = simOrder.Id,
                                    Address = simOrder.Address,
                                    seria = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.SIMSeriaNumber).ToList()
                                    ),
                                    CreateTime = simOrder.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                                    Name = simOrder.Name,
                                    Note = simOrder.Note,
                                    payOrderType = payOrderType,
                                    PhoneNum = simOrder.PhoneNum,
                                    PIC = pic?.FullName,
                                    priceOrder = simOrder.PriceOrder.ToString("#,##0.##"),
                                    priceOfSim = simOrder.PriceOfSim.ToString("#,##0.##"),
                                    SIMNumber = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.SIMNumber).ToList()
                                    ),
                                    Status = Enum.GetName(typeof(StatusOrder), simOrder.Status),
                                    SimPosition = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.Position).ToList()
                                    ),
                                    ProductType = string.Join("<br/>", productTypes),
                                    Contact = contact?.Name ?? "",
                                }
                            );
                        }
                    }
                    else
                    {
                        foreach (var simOrder in simOrders)
                        {
                            var payOrderType = "";
                            switch (simOrder.PayOrderType)
                            {
                                case PaymentType.COD:
                                    payOrderType = "Thanh toán tiền mặt";
                                    break;
                                case PaymentType.Online:
                                    payOrderType = "Thanh toán online";
                                    break;
                                case PaymentType.Company:
                                    payOrderType = "Xuất hóa đơn công ty";
                                    break;
                                case PaymentType.Installment:
                                    payOrderType = "Thanh toán trả góp";
                                    break;
                            }
                            var simWithOrder = _context.SIMWithOrders.Where(x =>
                                x.OrderId == simOrder.Id
                            );
                            var simInOrderInfos = _context
                                .SIMDetails.Where(x =>
                                    simWithOrder.Select(x => x.SimId).ToList().Contains(x.Id)
                                )
                                .ToList();
                            var productTypeIds = simInOrderInfos
                                .Select(x => x.ProductTypeId)
                                .ToList();
                            var productTypes = _context
                                .ProductTypes.Where(x => productTypeIds.Contains(x.Id))
                                .Select(x => x.Name)
                                .ToList();
                            var contact = _context.SupportContacts.FirstOrDefault(x =>
                                x.Id == simOrder.ContactId
                            );
                            var pic = _context.Users.FirstOrDefault(x => x.Id == simOrder.PIC);
                            askSimView.orderInfos.Add(
                                new SIMOrderViewModel()
                                {
                                    Id = simOrder.Id,
                                    Address = simOrder.Address,
                                    seria = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.SIMSeriaNumber).ToList()
                                    ),
                                    CreateTime = simOrder.CreateTime.ToString("HH:mm dd.MM.yyyy"),
                                    Name = simOrder.Name,
                                    Note = simOrder.Note,
                                    payOrderType = payOrderType,
                                    PhoneNum = simOrder.PhoneNum,
                                    PIC = pic?.FullName,
                                    priceOrder = simOrder.PriceOrder.ToString("#,##0.##"),
                                    priceOfSim = simOrder.PriceOfSim.ToString("#,##0.##"),
                                    SIMNumber = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.SIMNumber).ToList()
                                    ),
                                    Status = Enum.GetName(typeof(StatusOrder), simOrder.Status),
                                    SimPosition = string.Join(
                                        "<br/>",
                                        simInOrderInfos.Select(x => x.Position).ToList()
                                    ),
                                    ProductType = string.Join("<br/>", productTypes),
                                    Contact = contact?.Name ?? "",
                                }
                            );
                        }
                    }
                }

                return askSimView;
            }
            catch (Exception ex)
            {
                return new AskSimViewModel();
            }
        }

        public AskSimViewModel GetSimInfoByIds(List<int> simIds, int orderId = 0)
        {
            AskSimViewModel askSimView = new();
            var simIdLst = simIds;
            askSimView.priceOrder = 0;
            askSimView.simIds = "";
            askSimView.simInfos = new();
            askSimView.orderInfos = new();
            var simInfos = _context.SIMDetails.Where(x => simIdLst.Contains(x.Id));
            if (simInfos != null)
            {
                var simOrders = (
                    from order in _context.SIMOrders
                    join swoder in _context.SIMWithOrders on order.Id equals swoder.OrderId
                    where
                        simInfos.Select(x => x.Id).ToList().Contains(swoder.SimId)
                        && (
                            order.Status != StatusOrder.Cancel
                            && (
                                order.Status == StatusOrder.Order
                                && order.TimeUnlock >= DateTime.Now
                            )
                        )
                    select order
                ).ToList();
                askSimView.priceOrder =
                    simInfos.Sum(x => x.SIMPrice)
                    + simInfos.Sum(x => x.SIMEmbryoFee)
                    + simInfos.Sum(x => x.SIMServiceFee);
                askSimView.simIds = string.Join(",", simInfos.Select(x => x.Id).ToList());
                int idx = 0;
                foreach (var simInfo in simInfos.ToList())
                {
                    idx++;
                    var network = _context
                        .SIMNetworks.FirstOrDefault(x => x.Id == simInfo.SIMNetworkId)
                        ?.NetworkName;
                    var productType = _context
                        .ProductTypes.FirstOrDefault(x => x.Id == simInfo.ProductTypeId)
                        ?.Name;
                    var owner = _context.Users.FirstOrDefault(x => x.Id == simInfo.Owner);
                    var simType = (
                        from t in _context.TypeOfSIMs
                        join st in _context.SIMTypes on t.Id equals st.TypeId
                        where st.SimId == simInfo.Id
                        select t.Name
                    )
                        .Distinct()
                        .ToList();
                    var simInOrder = _context.SIMWithOrders.FirstOrDefault(x =>
                        (x.SimId == simInfo.Id && x.OrderId == orderId && orderId != 0)
                        || (x.SimId == simInfo.Id && orderId == 0)
                    );
                    askSimView.simInfos.Add(
                        new SIMViewModel()
                        {
                            stt = idx,
                            Id = simInfo.Id,
                            Number = simInfo.SIMNumber,
                            Seria = simInfo.SIMSeriaNumber,
                            Price = simInfo.SIMPrice,
                            AgentSIMPrice = simInfo.AgentSIMPrice,
                            CollaboratorsSIMPrice = simInfo.CollaboratorsSIMPrice,
                            Description = simInfo.Description,
                            Network = network,
                            ProductType = productType,
                            Owner = owner?.FullName ?? "",
                            OwnerPhoneNumber = owner?.PhoneNumber ?? "",
                            Position = simInfo.Position,
                            IsMySim = simInfo.IsMySim,
                            SIMType = simType,
                            UsingEsim = simInOrder?.UsingEsim ?? false,
                        }
                    );
                }
            }

            return askSimView;
        }

        public List<int> GetSimIdsRandom(int simNum, int productType)
        {
            var simIdHadOrder = (
                from sworder in _context.SIMWithOrders
                join order in _context.SIMOrders on sworder.OrderId equals order.Id
                where order.Status != StatusOrder.Cancel
                select sworder.SimId
            ).ToList();

            var simLst = _context
                .SIMDetails.Where(x =>
                    x.ProductTypeId == productType
                    && !simIdHadOrder.Contains(x.Id)
                    && x.IsMySim == true
                )
                .Take(simNum)
                .Select(x => x.Id)
                .ToList();
            if (simLst.Count == simNum)
            {
                return simLst;
            }

            var simLst2 = _context
                .SIMDetails.Where(x =>
                    x.ProductTypeId == productType
                    && !simIdHadOrder.Contains(x.Id)
                    && x.IsMySim != true
                )
                .Take(simNum)
                .Select(x => x.Id)
                .ToList();
            return simLst2;
        }

        public string GetSimIdsWithDataInFile(List<ReadSimCSVModel> dataInFiles, string agentId)
        {
            var simIdHadOrder = (
                from sworder in _context.SIMWithOrders
                join order in _context.SIMOrders on sworder.OrderId equals order.Id
                where order.Status != StatusOrder.Cancel
                select sworder.SimId
            ).ToList();
            List<string> simNumbers = new List<string>();
            List<string> simSerias = new List<string>();
            dataInFiles.RemoveAt(0);
            foreach (var data in dataInFiles)
            {
                if (!string.IsNullOrEmpty(data.phoneNumber))
                {
                    var simNumber = "";
                    if (data.phoneNumber?.Substring(0, 1) == "0")
                    {
                        simNumber = data.phoneNumber.Replace(".", "");
                    }
                    else
                    {
                        simNumber = "0" + data.phoneNumber;
                    }
                    simNumbers.Add(simNumber);
                }
                if (!string.IsNullOrEmpty(data.seria))
                {
                    simSerias.Add(data.seria);
                }
            }

            var simLst = _context
                .SIMDetails.Where(x =>
                    (
                        (
                            simNumbers.Contains(x.SIMNumber.Replace(".", ""))
                            || (
                                simSerias.Contains(x.SIMSeriaNumber)
                                && !string.IsNullOrEmpty(x.SIMSeriaNumber)
                            )
                        )
                        && x.Owner.ToString() == agentId
                    ) && !simIdHadOrder.Contains(x.Id)
                )
                .Select(x => x.Id)
                .ToList();

            return string.Join(",", simLst);
        }

        //UpdateSeriaAndFeeOfSim

        public ResponseDataModel<string> UpdateSeriaAndFeeOfSim(UpdateSeriaAndFeeOfSimModel request)
        {
            try
            {
                var dataEntity = _context.SIMDetails.FirstOrDefault(x => x.Id == request.simId);
                if (dataEntity == null)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Số SIM không tồn tại.",
                    };
                }

                dataEntity.SIMSeriaNumber = request.seria;
                dataEntity.SIMEmbryoFee = request.simEmbryoFee;
                dataEntity.SIMServiceFee = request.simServiceFee;
                dataEntity.UpdateTime = DateTime.Now;

                _context.SIMDetails.Update(dataEntity);

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
                    Message = "Có lỗi trong quá trình cập nhật SIM.",
                };
            }
        }

        #region report
        public List<InventoryReportModel> GetInventoryReport(ReportFilterModels request)
        {
            List<InventoryReportModel> reportInventorys = new();
            var productTypes = _context.ProductTypes.ToList();
            List<AppUser>? agents = new();
            if (request.agentId == "0")
            {
                agents = _context.Users.Where(x => x.IsAgent).ToList();
            }
            else
            {
                agents = _context
                    .Users.Where(x => x.IsAgent && x.Id.ToString() == request.agentId)
                    .ToList();
            }
            int idx = 0;
            foreach (var agent in agents)
            {
                foreach (var productType in productTypes)
                {
                    idx++;

                    //Call stored procedure
                    FormattableString stored_procedure_query =
                        $"call CountProductTypeInventoryOfAgent({productType.Id}, {agent.Id})";
                    var simNum = _context.Database.SqlQuery<int>(stored_procedure_query).ToList();

                    reportInventorys.Add(
                        new InventoryReportModel()
                        {
                            stt = idx.ToString(),
                            owner = agent.FullName,
                            productDesc = productType.Description ?? "",
                            productName = productType.Name ?? "",
                            inventoryAmount = simNum[0].ToString(),
                        }
                    );
                }
            }
            return reportInventorys;
        }

        public ResponseDataViewModel<SimInventoryCompanyReportModel> GetSimInventoryCompany(
            SimInventoryCompanyReportRequest request
        )
        {
            try
            {
                List<SimInventoryCompanyReportModel> data = new();
                if (request.ProductTypes?.Count == 0)
                    if (request.IsSimData)
                    {
                        request.ProductTypes = GetSIMDataNTouristForCombo()
                            .Select(x => int.Parse(x.Value))
                            .ToList();
                    }
                    else
                    {
                        request.ProductTypes = GetSIMTypeForCombo()
                            .Select(x => int.Parse(x.Value))
                            .ToList();
                    }

                // Chuẩn bị tên và câu lệnh của stored procedure , "IsMySim": true, "IsConsignment": false
                string storedProcedureName = "GetSimInventoryCompanyReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @ProductTypeIds, @NetworkIds, @OwnerIds, @IsMySim, @IsConsignment, @ApprStatus)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                request.keyword = request.keyword.Replace(".", "");
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@ProductTypeIds", string.Join(",", request.ProductTypes)),
                    new("@NetworkIds", string.Join(",", request.Networks)),
                    new("@OwnerIds", string.Join(",", request.Owners)),
                    new("@IsMySim", request.IsMySim ? 1 : 0),
                    new("@IsConsignment", request.IsConsignment ? 1 : 0),
                    new("@ApprStatus", request.ApprStatus),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimInventoryCompanyReportModel>()
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
                var responseData = new ResponseDataViewModel<SimInventoryCompanyReportModel>()
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
                return new ResponseDataViewModel<SimInventoryCompanyReportModel>();
            }
        }

        public ResponseDataViewModel<WarehouseOutboundReportModel> GetWarehouseOutbound(
            WarehouseOutboundReportRequest request
        )
        {
            try
            {
                List<WarehouseOutboundReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetWarehouseOutboundReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate, @MaterialIds)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                    new("@MaterialIds", string.Join(",", request.materialIds)),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<WarehouseOutboundReportModel>()
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
                var responseData = new ResponseDataViewModel<WarehouseOutboundReportModel>()
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
                return new ResponseDataViewModel<WarehouseOutboundReportModel>();
            }
        }

        public ResponseDataViewModel<SoldSimReportModel> GetSoldSim(SoldSimReportRequest request)
        {
            try
            {
                List<SoldSimReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSoldSimReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @FromDate, @ToDate)";

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
                    .Set<SoldSimReportModel>()
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
                var responseData = new ResponseDataViewModel<SoldSimReportModel>()
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
                return new ResponseDataViewModel<SoldSimReportModel>();
            }
        }

        public ResponseDataViewModel<ProfitSituationReportModel> GetProfitSituation(
            ProfitSituationReportRequest request
        )
        {
            try
            {
                List<ProfitSituationReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetProfitSituationReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @FromDate, @ToDate)";

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
                    .Set<ProfitSituationReportModel>()
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
                var responseData = new ResponseDataViewModel<ProfitSituationReportModel>()
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
                return new ResponseDataViewModel<ProfitSituationReportModel>();
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
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @FromDate, @ToDate)";

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

        public ResponseDataViewModel<BankBalanceReportModel> GetBankBalance(
            BankBalanceReportRequest request
        )
        {
            try
            {
                List<BankBalanceReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetBankBalanceReport";
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
                    .Set<BankBalanceReportModel>()
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
                var responseData = new ResponseDataViewModel<BankBalanceReportModel>()
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
                return new ResponseDataViewModel<BankBalanceReportModel>();
            }
        }

        public ResponseDataViewModel<ProfitStatementReportModel> GetProfitStatement(
            ProfitStatementReportRequest request
        )
        {
            try
            {
                List<ProfitStatementReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetProfitStatementReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<ProfitStatementReportModel>()
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
                var responseData = new ResponseDataViewModel<ProfitStatementReportModel>()
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
                return new ResponseDataViewModel<ProfitStatementReportModel>();
            }
        }

        public ResponseDataViewModel<OrderProfitReportModel> GetOrderProfit(
            OrderProfitReportRequest request
        )
        {
            try
            {
                List<OrderProfitReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetOrderProfitReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate, @Type)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                    new("@Type", request.type),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<OrderProfitReportModel>()
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
                var responseData = new ResponseDataViewModel<OrderProfitReportModel>()
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
                return new ResponseDataViewModel<OrderProfitReportModel>();
            }
        }

        public ResponseDataViewModel<BankTransactionReportModel> GetBankTransaction(
            BankTransactionReportRequest request
        )
        {
            try
            {
                List<BankTransactionReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetBankTransactionReport";
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
                    .Set<BankTransactionReportModel>()
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
                var responseData = new ResponseDataViewModel<BankTransactionReportModel>()
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
                return new ResponseDataViewModel<BankTransactionReportModel>();
            }
        }

        public ResponseDataViewModel<CashFundReportModel> GetCashFund(CashFundReportRequest request)
        {
            try
            {
                List<CashFundReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetCashFundReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<CashFundReportModel>()
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
                var responseData = new ResponseDataViewModel<CashFundReportModel>()
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
                return new ResponseDataViewModel<CashFundReportModel>();
            }
        }

        public ResponseDataViewModel<SimInventoryReportModel> GetSimInventory(
            SimInventoryReportRequest request
        )
        {
            try
            {
                List<SimInventoryReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSimInventoryReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate, @MaterialIds)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                    new("@MaterialIds", string.Join(",", request.materialIds)),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<SimInventoryReportModel>()
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
                var responseData = new ResponseDataViewModel<SimInventoryReportModel>()
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
                return new ResponseDataViewModel<SimInventoryReportModel>();
            }
        }

        public ResponseDataViewModel<OrderImportExportReportModel> GetOrderImportExport(
            OrderImportExportReportRequest request
        )
        {
            try
            {
                List<OrderImportExportReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetOrderImportExportReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate, @Type)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                    new("@Type", request.type),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<OrderImportExportReportModel>()
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
                var responseData = new ResponseDataViewModel<OrderImportExportReportModel>()
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
                return new ResponseDataViewModel<OrderImportExportReportModel>();
            }
        }

        public ResponseDataViewModel<InventoryMovementReportModel> GetInventoryMovement(
            InventoryMovementReportRequest request
        )
        {
            try
            {
                List<InventoryMovementReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetInventoryMovementReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate, @MaterialIds)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                    new("@MaterialIds", string.Join(",", request.materialIds)),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<InventoryMovementReportModel>()
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
                var responseData = new ResponseDataViewModel<InventoryMovementReportModel>()
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
                return new ResponseDataViewModel<InventoryMovementReportModel>();
            }
        }

        public ResponseDataViewModel<CustomerDebtReportModel> GetCustomerDebt(
            CustomerDebtReportRequest request
        )
        {
            try
            {
                List<CustomerDebtReportModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetCustomerDebtReport";
                string query =
                    $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @AgentId, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@AgentId", string.Join(",", request.agentId)),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate),
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context
                    .Set<CustomerDebtReportModel>()
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
                var responseData = new ResponseDataViewModel<CustomerDebtReportModel>()
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
                return new ResponseDataViewModel<CustomerDebtReportModel>();
            }
        }
        #endregion
        //Tìm sim phong thuy hợp mệnh
        public List<SimPhongThuyResultModel> GetSimPTOfMenhChu(
            string amDuong,
            string nguHanh,
            int pageIndex,
            int pageSize
        )
        {
            List<SimPhongThuyResultModel> data = new();
            // Chuẩn bị tên và câu lệnh của stored procedure
            string storedProcedureName = "GetSimPTOfMenhChu";
            string query = $"CALL {storedProcedureName}(@PageIndex, @PageSize, @AmDuong, @NguHanh)";

            // Tạo các đối tượng MySqlParameter từ các giá trị trong request
            var parameters = new List<MySqlParameter>
            {
                new("@PageIndex", pageIndex),
                new("@PageSize", pageSize),
                new("@AmDuong", amDuong),
                new("@NguHanh", nguHanh),
            };

            // Thực hiện truy vấn sử dụng FromSqlRaw
            var dataExec = _context
                .Set<SimPhongThuyResultModel>()
                .FromSqlRaw(query, parameters.ToArray())
                .ToList();

            // Thêm dữ liệu vào danh sách data
            foreach (var item in dataExec)
            {
                SimPhongThuyResultModel sim = new();
                sim.simId = item.simId;
                sim.networkId = item.networkId;
                sim.simNumber = item.simNumber;
                sim.price = item.price;
                sim.point = item.point;
                sim.nguHanhSim = item.nguHanhSim;
                var queBatQuai = SimPhongThuy.GetQueBatQuaiInfo(item.simNumber.Replace(".", ""));
                sim.queKinhDich = queBatQuai.queChu.queName;
                sim.yNghiaQue = queBatQuai.queChu.giaiNghia;
                sim.TotalCount = item.TotalCount;
                data.Add(sim);
            }

            return data;
        }

        public double GetEstimatedPrice(List<string> formatsSim)
        {
            double estimatedPrice = 0;
            var typeOfSims = _context
                .TypeOfSIMs.Where(x => formatsSim.Contains(x.Format))
                .OrderByDescending(x => x.EstimatedPrice)
                .FirstOrDefault();
            if (typeOfSims != null)
            {
                estimatedPrice = typeOfSims.EstimatedPrice;
            }
            return estimatedPrice;
        }

        public ResponseDataModel<string> OnApprovedSimOfAgent(
            UpdateStatusSIMOfAgentRequest request,
            string userId
        )
        {
            try
            {
                var dataEntity = _context.SIMDetails.Where(x =>
                    request.simIds.Contains(x.Id) && x.status == ApprovedStatus.Waiting
                );
                if (dataEntity == null || dataEntity.Count() == 0)
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "0",
                        Message = "Đơn hàng không tồn tại hoặc đã được xử lý.",
                    };
                }
                foreach (var sim in dataEntity)
                {
                    sim.status = request.status;
                    sim.UpdateBy = new Guid(userId);
                    sim.UpdateTime = DateTime.Now;
                }

                _context.SIMDetails.UpdateRange(dataEntity);

                var result = _context.SaveChanges();

                //Ghi log
                LogAction logAction = new LogAction()
                {
                    ActionName = "Duyệt số của đại lý",
                    ControllerName = "",
                    CreateBy = new Guid(userId),
                    CreateTime = DateTime.Now,
                    IpAddressUser = null,
                    NewData = request.simIds + Enum.GetName(typeof(ApprovedStatus), request.status),
                    OldData =
                        request.simIds
                        + Enum.GetName(typeof(ApprovedStatus), ApprovedStatus.Waiting),
                };
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
                        Code = "-1",
                        Message = "Cập nhật thất bại.",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật đơn mua.",
                };
            }
        }

        public SimInfoOfUserModel GetSimInfoOfUser(Guid userId)
        {
            SimInfoOfUserModel simInfoOfUser = new();

            var simInfo = _context.SIMDetails.Where(x => x.Owner == userId).ToList();
            if (simInfo.Count > 0)
            {
                simInfoOfUser.totalPrice = simInfo.Select(x => x.SIMPrice).Sum();
                simInfoOfUser.totalSim = simInfo.Select(x => x.SIMNumber).Count();
            }

            return simInfoOfUser;
        }

        public List<ProductTypeModel> GetProductTypeOfSimData()
        {
            var query = _context.ProductTypes.Where(x => x.IsSimData == true);
            var data = new List<ProductTypeModel>();
            var idx = 0;
            foreach (var item in query.ToList())
            {
                idx++;
                data.Add(
                    new ProductTypeModel()
                    {
                        Id = item.Id,
                        Name = item.Name ?? "",
                        DefaulPrice = item.DefaulPrice,
                        Summary = item.Summary ?? "",
                        Description = item.Description ?? "",
                        IsSimData = item.IsSimData,
                    }
                );
            }

            //
            return data;
        }

        public ResponseDataModel<string> DeleteSimOfAgent(Guid id, string userId)
        {
            try
            {
                var simsOfAgent = _context.SIMDetails.Where(x => x.Owner == id);
                _context.SIMDetails.RemoveRange(simsOfAgent);
                var result = _context.SaveChanges();

                if (result > 0)
                {
                    var agent = _context.Users.FirstOrDefault(x => x.Id == id);
                    //Ghi log
                    LogAction logAction = new LogAction()
                    {
                        ActionName = "Xóa số của đại lý " + agent.UserName,
                        ControllerName = "",
                        CreateBy = new Guid(userId),
                        CreateTime = DateTime.Now,
                        IpAddressUser = null,
                        NewData = "",
                        OldData = "",
                    };
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Xóa sim của đại lý thành công",
                    };
                }
                else
                {
                    return new ResponseDataModel<string>()
                    {
                        Code = "1",
                        Message = "Không có sim để xóa",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDataModel<string>()
                {
                    Code = "-1",
                    Message = "Có lỗi trong quá trình cập nhật đơn mua.",
                };
            }
        }
    }
}
