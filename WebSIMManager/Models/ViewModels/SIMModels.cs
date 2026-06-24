using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Commons.Enums;
using Commons.Models;
using Models.Requests;

namespace Models.ViewModels
{
    public class SIMFilterModel : PagingRequestBase
    {
        public string? SimNumber { get; set; }
        public bool? IsMySim { get; set; }
        public bool? IsSimData { get; set; }
        public List<int>? ProductTypes { get; set; }
        public List<int>? Networks { get; set; }
        public List<Guid?> Owners { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class SIMViewModel
    {
        public int stt { get; set; }
        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Seria { get; set; }
        public string? Network { get; set; }
        public string? ProductType { get; set; }
        public double Price { get; set; }
        public double SIMPriceOfAgent { get; set; }
        public double AgentSIMPrice { get; set; }
        public double CollaboratorsSIMPrice { get; set; }
        public double SIMEmbryoFee { get; set; }
        public double SIMServiceFee { get; set; }
        public string? Owner { get; set; }
        public string? OwnerPhoneNumber { get; set; }
        public List<string>? SIMType { get; set; }
        public string? Status { get; set; }
        public string? SIMImgUrl { get; set; }
        public string? Description { get; set; }
        public string? Position { get; set; }
        public bool IsMySim { get; set; }
        public bool UsingEsim { get; set; }
    }

    public class SIMCreateModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
        public string SIMNumber { get; set; }
        public string? Seria { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập nhà mạng.")]
        public int SIMNetworkId { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập giá số điện thoại.")]
        public double SIMPrice { get; set; }
        public double SIMPriceOfAgent { get; set; }
        public double AgentSIMPrice { get; set; }
        public double CollaboratorsSIMPrice { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập thuê bao.")]
        public int ProductTypeId { get; set; }
        public string? SIMImgUrl { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập người sở hữu sim.")]
        public string? Owner { get; set; }
        public string? Description { get; set; }
        public string? Position { get; set; }
    }

    public class SIMEditModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
        public string SIMNumber { get; set; }
        public string? Seria { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập nhà mạng.")]
        public int SIMNetworkId { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập giá số điện thoại.")]
        public double SIMPrice { get; set; }
        public double OriginalSIMPrice { get; set; }
        public double AgentSIMPrice { get; set; }
        public double CollaboratorsSIMPrice { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập thuê bao.")]
        public int ProductTypeId { get; set; }
        public string? SIMImgUrl { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập người sở hữu sim.")]
        public string? Owner { get; set; }
        public string? Description { get; set; }
        public string? Position { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class SIMNetworkViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa tên nhà mạng.")]
        public string? NetworkName { get; set; }
        public string? NetworkImgUrl { get; set; }

        [Required(ErrorMessage = "Bạn chưa Url.")]
        public string? HtmlId { get; set; }
        public string? PrefixNumber { get; set; }
        public string? Description { get; set; }
    }

    public class SIMNetworkCreateModel
    {
        [Required(ErrorMessage = "Bạn chưa tên nhà mạng.")]
        public string? NetworkName { get; set; }
        public string? NetworkImgUrl { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Url.")]
        public string? HtmlId { get; set; }
        public string? PrefixNumber { get; set; }
        public string? Description { get; set; }
    }

    public class SIMNetworkEditModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa tên nhà mạng.")]
        public string NetworkName { get; set; }
        public string? NetworkImgUrl { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Url.")]
        public string? HtmlId { get; set; }
        public string? PrefixNumber { get; set; }
        public string? Description { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class TypeOfSIMViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Url.")]
        public string Format { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mô tả.")]
        public string Description { get; set; }
        public double EstimatedPrice { get; set; }
    }

    public class TypeOfSimCreateModel
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Url.")]
        public string Format { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mô tả.")]
        public string Description { get; set; }
        public double EstimatedPrice { get; set; }
    }

    public class TypeOfSimEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Url.")]
        public string Format { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mô tả.")]
        public string Description { get; set; }
        public double EstimatedPrice { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class SIMOrderViewModel
    {
        public int Id { get; set; }
        public int SIMId { get; set; }
        public string SIMNumber { get; set; }
        public string seria { get; set; }
        public string priceOrder { get; set; }
        public string priceOfSim { get; set; }
        public string discount { get; set; }
        public string simEmbryoFee { get; set; }
        public string simServiceFee { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string? PIC { get; set; }
        public string? Note { get; set; }
        public string payOrderType { get; set; }
        public string CreateTime { get; set; }
        public string Status { get; set; }
        public string Contact { get; set; }
        public string SimPosition { get; set; }
        public string ProductType { get; set; }
        public bool IsMySim { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class SIMOrderViewAPIModel
    {
        public int Id { get; set; }
        public double priceOrder { get; set; }
        public double priceOfSim { get; set; }
        public int discount { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string payOrderType { get; set; }
        public string CreateTime { get; set; }
        public string Status { get; set; }

        //Handle sim trả góp
        //Thời hạn thanh toán
        public int InstallmentPeriod { get; set; } = 0;

        //NGày thanh toán hàng tháng
        public int DateOfPayment { get; set; } = 0;

        //Ngày hoàn thành thanh toán
        public DateTime InstallmentEndDate { get; set; }

        //Số tiền thanh toán ban đầu
        public double? DownPayment { get; set; } = 0;

        //Số tiền sẽ trả góp
        public double? InstallmentPayment { get; set; } = 0;

        //Tiền góp hàng tháng
        public double? MonthlyInstallmentPayment { get; set; } = 0;

        //Lãi theo ngày
        public double? InterestRate { get; set; } = 0;
        public List<SimInfoInOrderAPIViewModel> SimInfos { get; set; }
    }

    public class SimInfoInOrderAPIViewModel
    {
        public int Id { get; set; }
        public string SimNumber { get; set; }
        public double SimPrice { get; set; }
    }

    public class SIMOrderModel
    {
        public int? Id { get; set; }
        public Guid? UserId { get; set; }

        [Required(ErrorMessage = "Bạn chưa hỏi sim.")]
        public List<SimInOrder> simInOrders { get; set; }

        [Required(ErrorMessage = "Chưa có tổng giá trị đơn.")]
        public double? PriceOrder { get; set; } = 0;
        public double PriceOfSim { get; set; } = 0;
        public TypePriceSimOrder TypePriceSimOrder { get; set; }
        public int? Discount { get; set; } = 0;
        public double SIMEmbryoFee { get; set; } = 0;
        public double SIMServiceFee { get; set; } = 0;
        public string? Name { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
        public string PhoneNum { get; set; }
        public Guid UserBuyId { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ.")]
        public string? Address { get; set; }
        public int? ContactId { get; set; }
        public Guid? PIC { get; set; }
        public string? Note { get; set; }
        public StatusOrder Status { get; set; }
        public PaymentType PaymentType { get; set; }
        public Guid? UpdateBy { get; set; }

        //Handle sim trả góp
        //Thời hạn thanh toán
        public int InstallmentPeriod { get; set; } = 0;

        //NGày thanh toán hàng tháng
        public int DateOfPayment { get; set; } = 0;

        //Ngày hoàn thành thanh toán
        public DateTime InstallmentEndDate { get; set; }

        //Số tiền thanh toán ban đầu
        public double? DownPayment { get; set; } = 0;

        //Số tiền sẽ trả góp
        public double? InstallmentPayment { get; set; } = 0;

        //Tiền góp hàng tháng
        public double? MonthlyInstallmentPayment { get; set; } = 0;

        //Lãi theo ngày
        public double? InterestRate { get; set; } = 0;
    }

    public class SimInOrder
    {
        public int simId { get; set; }
        public bool? usingEsim { get; set; }
        public double simPrice { get; set; }
    }

    public class UpdateOrderStatusModel
    {
        public string orderIds { get; set; }
        public StatusOrder status { get; set; }
    }

    public class SIMViewOnApp
    {
        public int Id { get; set; }
        public int SimNetworkId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? SimType { get; set; }
        public string? Price { get; set; }
        public string? PriceOnSale { get; set; }
    }

    //
    public class ProductTypeViewModel
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CountryName { get; set; }
        public string DefaulPrice { get; set; }
        public bool IsSimData { get; set; }
        public bool IsTouristSim { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
    }

    public class ProductTypeModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa tên loại sim.")]
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public double DefaulPrice { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public bool IsSimData { get; set; }
        public bool IsTouristSim { get; set; }
        public Guid? CreateBy { get; set; }
    }

    public class ImportSIMModel
    {
        public List<ReadSimCSVModel> DataInFile { get; set; }
        public string? Owner { get; set; }
        public string? Description { get; set; }
    }

    public class ImportSIMModel2
    {
        public string? DataInFile { get; set; }
        public string? Owner { get; set; }
        public string? Description { get; set; }
    }

    public class AgentChangeReqModel
    {
        public string agentId { get; set; }
        public int price { get; set; }
    }

    public class AgentChangeResModel
    {
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public int discount { get; set; }
        public double priceWithDiscount { get; set; }
    }

    public class RequestIdsModel
    {
        public List<int> ids { get; set; }
    }

    public class RequestSimNumberModel
    {
        public string simNumber { get; set; }
    }

    //
    public class UpdateStatusOrderRequest
    {
        public string orderIds { get; set; }
        public StatusOrder status { get; set; }
    }

    public class UpdateStatusSIMOfAgentRequest
    {
        public List<int> simIds { get; set; }
        public ApprovedStatus status { get; set; }
    }

    public class RequestGetRandomSimIdsModel
    {
        public int simAmount { get; set; }
        public int productTypeId { get; set; }
    }

    public class RequestGetSimIdsWitFileModel
    {
        public int simNum { get; set; }
        public int productTypeId { get; set; }
    }

    public class UpdateSeriaAndFeeOfSimModel
    {
        public int simId { get; set; }
        public string seria { get; set; }
        public double simEmbryoFee { get; set; }
        public double simServiceFee { get; set; }
    }

    //
    public class RequestGetSimInfoInOrderModel
    {
        public string customerId { get; set; }
        public string simIds { get; set; }
        public string orderIds { get; set; }
    }

    //
    public class ResponseGetSimInfoInOrderModel
    {
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public double totalPrice { get; set; }
        public int discount { get; set; }
        public double totalOrderPrice { get; set; }
        public double totalSimEmbryoFee { get; set; }
        public double totalSimServiceFee { get; set; }
        public List<SimInfoInOrderModel> simInfos { get; set; }
    }

    //
    public class SimInfoInOrderModel
    {
        public int stt { get; set; }
        public int id { get; set; }
        public int orderId { get; set; }
        public string? number { get; set; }
        public string? seria { get; set; }
        public double price { get; set; }
        public double discountOrder { get; set; }
        public double priceDiscountOrder { get; set; }
        public double priceOrder { get; set; }
        public double simEmbryoFee { get; set; }
        public double simServiceFee { get; set; }
        public Guid? ownerId { get; set; }
        public string? owner { get; set; }
        public string? ownerPhoneNumber { get; set; }
        public double SIMPriceOfAgent { get; set; }
        public double discountForMe { get; set; }
        public double priceDiscountForMe { get; set; }
        public double priceForMe { get; set; }
    }

    public class AskSimViewModel
    {
        public string simIds { get; set; }
        public double priceOrder { get; set; }
        public List<SIMViewModel> simInfos { get; set; }
        public List<SIMOrderViewModel> orderCancelInfos { get; set; }
        public List<SIMOrderViewModel> orderInfos { get; set; }
    }

    public class SimInfoOfUserModel
    {
        public double totalPrice { get; set; }
        public double totalSim { get; set; }
    }

    public class SIMTypeModel
    {
        public int SimId { get; set; }
        public int TypeId { get; set; }
    }

    public class OrderSIMOnHomeModel
    {
        public int SimId { get; set; }
        public bool? UsingEsim { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusProvince { get; set; }
        public string CusNote { get; set; }
        public int PaymentMethod { get; set; }
    }

    public class OrderSimInCart
    {
        public List<ItemInCart> ItemInCarts { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusProvince { get; set; }
        public string CusNote { get; set; }
        public int PaymentMethod { get; set; }
    }

    public class ItemInCart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SIMProductType Type { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public bool Esim { get; set; }
    }

    public class OrderSIMDataOnHomeModel
    {
        public string SimIds { get; set; }
        public int ProductTypeId { get; set; }
        public double PriceOrder { get; set; }
        public Guid? UserBuyId { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusProvince { get; set; }
        public int Amount { get; set; }
        public bool BuyEsim { get; set; }
        public string CusNote { get; set; }
        public int PaymentMethod { get; set; }
    }

    public class DebtOfAgentRequest
    {
        public DateTime receiptDate { get; set; }
        public string AgentId { get; set; }
    }

    public class DebtOfAgentResponse
    {
        public double oldDebt { get; set; }
        public double newDebt { get; set; }
    }

    //Order sim data
    public class ProductTypeOfSimData
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public bool IsSimData { get; set; }
        public bool IsTouristSim { get; set; }
        public int? CountryId { get; set; }
        public int Amount { get; set; }
    }
}
