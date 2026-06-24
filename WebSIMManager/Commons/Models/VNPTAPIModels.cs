using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class VNPTAPIRequest
    {
        public string? ACTION { get; set; }
        public string? VERSION { get; set; }
        public string? PARTNER_ID { get; set; }
        public string? SERVICE_ID { get; set; }
        public string? SERVICE_PROVIDER_ID { get; set; }
        public string? TRANS_REQUEST_ID { get; set; }
        public string? CHANNEL_ID { get; set; }
        public string? DATA_INPUT { get; set; }
        public string? TRANS_DATE_TIME { get; set; }
        public string? SECURE_CODE { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class VNPTAPIPAYMENTRequest
    {
        public string? ACTION { get; set; }
        public string? VERSION { get; set; }
        public string? PARTNER_ID { get; set; }
        public string? SERVICE_ID { get; set; }
        public string? SERVICE_PROVIDER_ID { get; set; }
        public string? PAYMENT_CODE { get; set; }
        public string? CHANNEL_ID { get; set; }
        public string? TRANS_REQUEST_ID { get; set; }
        public string? ADDITIONAL_INFO { get; set; }
        public string? OPTIONS { get; set; }
        public string? BILL_AMOUNT { get; set; }
        public string? BILL_FEE { get; set; }
        public string? BILL_DETAIL { get; set; }
        public string? TRANS_DATE_TIME { get; set; }
        public string? SECURE_CODE { get; set; }
    }
    public class PayBill_OPTIONS
    {
        public int product_id { get; set; }
        public string phone_number { get; set; }
        public string otp { get; set; }
        public string partner_accountID { get; set; }
    }
    public class PayBill_BILL_DETAIL
    {
        public string AMOUNT { get; set; }
        public string MONTH { get; set; }
        public string INFO { get; set; }
    }

    public class getNumberSearchDataInput
    {
        public string? search { get; set; }
        public string? prefix { get; set; }
        public int type { get; set; }
        public int page_number { get; set; }
        public int page_record { get; set; }
        public string? partner_accountID { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class VNPTAPIResponse
    {
        public string? RESPONSE_CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? TRANS_REQUEST_ID { get; set; }
        public string? TRANS_RESPONSE_ID { get; set; }
        public string? DATA_OUTPUT { get; set; }
        public string? SERVICE_ID { get; set; }
        public string? SECURE_CODE { get; set; }
    }    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class VNPTAPIPAYMENTResponse
    {
        public string? RESPONSE_CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? TRANS_DATE_TIME { get; set; }
        public string? TRANS_REQUEST_ID { get; set; }
        public string? TRANS_RESPONSE_ID { get; set; }
        public string? OPTIONS { get; set; }
        public string? SECURE_CODE { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class BookSimDATA_OUTPUT
    {
        public int errorCode { get; set; }
        public string? errorMessage { get; set; }
        public string? mxt { get; set; }
        public string? tran_id { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SearchSim_DATA_OUTPUT<T>
    {
        public int errorCode { get; set; }
        public string? errorMessage { get; set; }
        public List<T>? items { get; set; }
        public string? tran_id { get; set; }
    }
    public class SearchSim_DATA_ITEM
    {
        public string? id { get; set; }
        public string? msisdn { get; set; }
        public string? kieu_so { get; set; }
        public string? cuoc_camket { get; set; }
        public string? thoigian_camket { get; set; }
        public string? matinh { get; set; }
        public string? idKhoSim { get; set; }
        public string? prefix { get; set; }
        public int price { get; set; }
    }
    /// <summary>
    /// GetListInProduct
    /// </summary>
    public class GetListInProduct_DATA_INPUT
    {
        public string partner_accountID { get; set; }
    }   
    public class GetListByCategory_DATA_INPUT
    {
        public string partner_accountID { get; set; }
        public int parent_id { get; set; }
    }     
    public class GetAvailablePersonalizedPackages_DATA_INPUT
    {
        public string msisdn { get; set; }
        public string partner_accountID { get; set; }
    }  
    public class GetProductDetail_DATA_INPUT
    {
        public string partner_accountID { get; set; }
        public string product_id { get; set; }
    }
    public class GetListInProduct_DATA_ITEM
    {
        public int id { get; set; }
        public string display_name { get; set; }
        public int level { get; set; }
        public object parent_id { get; set; }
        public int sell_channel { get; set; }
    }

    public class Filter_DATA_ITEM
    {
        public GiaSim gia_sim { get; set; }
        public List<DataDic> hinh_thuc { get; set; }
        public List<DataDic> loai_goi_cuoc { get; set; }
        public List<DataDic> khoang_gia { get; set; }
        public List<DataDic> data_tra_sau { get; set; }
        public List<DataDic> data_tra_truoc { get; set; }
        public List<DataDic> thoai_noi_mang_tra_sau { get; set; }
        public List<DataDic> thoai_noi_mang_tra_truoc { get; set; }
        public List<DataDic> thoai_ngoai_mang_tra_sau { get; set; }
        public List<DataDic> thoai_ngoai_mang_tra_truoc { get; set; }
    }
    public class DataDic
    {
        public string key { get; set; }
        public string value { get; set; }
    }
    public class GiaSim
    {
        public double gia_sim_vat_ly { get; set; }
        public double gia_e_sim { get; set; }
        public double phi_hoa_mang_tra_truoc { get; set; }
        public double phi_hoa_mang_tra_sau { get; set; }
        public double phi_giao_hang_tai_quay { get; set; }
        public double phi_giao_hang_tai_nha { get; set; }
    }
    public class Filter_DATA_OUTPUT<T>
    {
        public int errorCode { get; set; }
        public string? errorMessage { get; set; }
        public T item { get; set; }
    }
    public class GetAvailablePersonalizedPackages_DATA_ITEM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string summary { get; set; }
        public string link { get; set; }
        public string category_id { get; set; }
        public string sell_channel { get; set; }
    }
    public class RegiterPackages_DATA_INPUT
    {
        public string phone_number { get; set; }
        public string product_id { get; set; }
        public string partner_accountID { get; set; }
        public int type { get; set; }
    }
    public class BuyPackage_DATA_OUTPUT
    {
        public int errorCode { get; set; }
        public string errorMessage { get; set; }
        public string otp { get; set; }
    }

}
