using Commons.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Models;

namespace Commons.CallAPIs
{
    public static class VNPTCallAPI
    {
        private static readonly string _URL = "https://sandboxpay.vnptmedia.vn/rest/collection/v2.0.0/inquire_commom";
        private static readonly string _URL_BILL = "https://sandboxpay.vnptmedia.vn/rest/collection/v2.0.0/inquire_commom";
        private static readonly string _PARTNER_ID = "262897";
        private static readonly string _PRIVATE_KEY = "ed96fee1afdcde6639923d1f07578f8e";
        private static readonly string _BEAR_TOKEN = "2d2b21aa6572d237236e8ca92434224c";
        private static HttpClient client = new HttpClient();
        public static async Task<List<SearchSim_DATA_ITEM>> GetSimAsync(string searchKey = "", string prefix = "", int simType = 21)
        {
            try
            {
                List<SearchSim_DATA_ITEM> simLst = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "get_number_search";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "251";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "20051201a3aa31a2";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new getNumberSearchDataInput();
                dataInput.search = searchKey;
                dataInput.prefix = prefix;
                dataInput.type = simType;
                dataInput.page_number = 1;
                dataInput.page_record = 1;
                dataInput.partner_accountID = _PARTNER_ID;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    simLst = JsonConvert.DeserializeObject<SearchSim_DATA_OUTPUT<SearchSim_DATA_ITEM>>(dataOutput).items;
                }
                return simLst;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new List<SearchSim_DATA_ITEM>();
            }

        }
        public static async Task<List<GetListInProduct_DATA_ITEM>> GetListInProductAsync()
        {
            try
            {
                List<GetListInProduct_DATA_ITEM> result = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "get-list-in-product";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "252";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "200512017771119132";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new GetListInProduct_DATA_INPUT();
                dataInput.partner_accountID = _PARTNER_ID;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<SearchSim_DATA_OUTPUT<GetListInProduct_DATA_ITEM>>(dataOutput).items;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new List<GetListInProduct_DATA_ITEM>();
            }
        }
        public static async Task<List<GetListInProduct_DATA_ITEM>> GetListByCategoryAsync(int parentId)
        {
            try
            {
                List<GetListInProduct_DATA_ITEM> result = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "get-list-by-category";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "252";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "20051201a333611134442";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new GetListByCategory_DATA_INPUT();
                dataInput.partner_accountID = _PARTNER_ID;
                dataInput.parent_id = parentId;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<SearchSim_DATA_OUTPUT<GetListInProduct_DATA_ITEM>>(dataOutput).items;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new List<GetListInProduct_DATA_ITEM>();
            }
        }
        public static async Task<List<GetAvailablePersonalizedPackages_DATA_ITEM>> GetAvailablePersonalizedPackages(string msisdn)
        {
            try
            {
                List<GetAvailablePersonalizedPackages_DATA_ITEM> result = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "get_available_personalized_packages";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "252";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "2005120135311553";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new GetAvailablePersonalizedPackages_DATA_INPUT();
                dataInput.partner_accountID = _PARTNER_ID;
                dataInput.msisdn = msisdn;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<SearchSim_DATA_OUTPUT<GetAvailablePersonalizedPackages_DATA_ITEM>>(dataOutput).items;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new List<GetAvailablePersonalizedPackages_DATA_ITEM>();
            }
        }       
        public static async Task<BuyPackage_DATA_OUTPUT> RegisterPackages(string phoneNumber, string productId)
        {
            try
            {
                BuyPackage_DATA_OUTPUT result = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "buy-product";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "252";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "2005120135311553";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new RegiterPackages_DATA_INPUT();
                dataInput.partner_accountID = _PARTNER_ID;
                dataInput.product_id = productId;
                dataInput.phone_number = phoneNumber;
                dataInput.type = 0;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<BuyPackage_DATA_OUTPUT>(dataOutput);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new BuyPackage_DATA_OUTPUT();
            }
        }      
        public static async Task<BuyPackage_DATA_OUTPUT> PayBill(string phoneNumber, int productId, string otp)
        {
            try
            {

                BuyPackage_DATA_OUTPUT result = new();
                var requestAPI = new VNPTAPIPAYMENTRequest();
                requestAPI.ACTION = "RELIEF_BANGOI";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "252";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.PAYMENT_CODE = "1";
                requestAPI.CHANNEL_ID = "1";
                requestAPI.TRANS_REQUEST_ID = "2019912142554433";
                requestAPI.ADDITIONAL_INFO = "ADDITIONAL_INFO";
                //
                var options = new PayBill_OPTIONS();
                options.partner_accountID = _PARTNER_ID;
                options.product_id = productId;
                options.phone_number = phoneNumber;
                options.otp = otp;
                requestAPI.OPTIONS = JsonConvert.SerializeObject(options);

                requestAPI.BILL_AMOUNT = "0";
                requestAPI.BILL_FEE = "0";
                //
                var billDetail = new PayBill_BILL_DETAIL();
                billDetail.MONTH = "";
                billDetail.AMOUNT = "0";
                billDetail.INFO = "201";
                requestAPI.BILL_DETAIL = "["+JsonConvert.SerializeObject(billDetail)+"]";
                //
                requestAPI.TRANS_DATE_TIME = "20190620101832";

                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.PAYMENT_CODE  + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.TRANS_REQUEST_ID + "|"+ requestAPI.ADDITIONAL_INFO + "|" + requestAPI.OPTIONS
                    + "|" + requestAPI.BILL_AMOUNT + "|" + requestAPI.BILL_FEE + "|" + requestAPI.BILL_DETAIL + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIPAYMENTRequest>(_URL_BILL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIPAYMENTResponse>(response).OPTIONS;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<BuyPackage_DATA_OUTPUT>(dataOutput);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new BuyPackage_DATA_OUTPUT();
            }
        }
        
        public static async Task<Filter_DATA_ITEM> GetFilter()
        {
            try
            {
                Filter_DATA_ITEM result = new();
                var requestAPI = new VNPTAPIRequest();
                requestAPI.ACTION = "filter";
                requestAPI.VERSION = "2.0.0";
                requestAPI.PARTNER_ID = _PARTNER_ID;
                requestAPI.SERVICE_ID = "251";
                requestAPI.SERVICE_PROVIDER_ID = "VNP";
                requestAPI.TRANS_REQUEST_ID = "20051201a3aa31a21";
                requestAPI.CHANNEL_ID = "1";
                //
                var dataInput = new GetListInProduct_DATA_INPUT();
                dataInput.partner_accountID = _PARTNER_ID;
                requestAPI.DATA_INPUT = JsonConvert.SerializeObject(dataInput);

                requestAPI.TRANS_DATE_TIME = "20210915154100";
                requestAPI.SECURE_CODE = Endcode.getHashSha256(requestAPI.ACTION + "|" + requestAPI.VERSION + "|" + requestAPI.PARTNER_ID + "|" + requestAPI.SERVICE_ID + "|" + requestAPI.SERVICE_PROVIDER_ID
                    + "|" + requestAPI.TRANS_REQUEST_ID + "|" + requestAPI.CHANNEL_ID + "|" + requestAPI.DATA_INPUT + "|" + requestAPI.TRANS_DATE_TIME + "|" + _PRIVATE_KEY);

                string response = await HttpClientHelper.HttpPost<VNPTAPIRequest>(_URL, _BEAR_TOKEN, requestAPI);
                var dataOutput = JsonConvert.DeserializeObject<VNPTAPIResponse>(response).DATA_OUTPUT;
                if (dataOutput != null)
                {
                    result = JsonConvert.DeserializeObject<Filter_DATA_OUTPUT<Filter_DATA_ITEM>>(dataOutput).item;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return new Filter_DATA_ITEM();
            }
        }

    }
}
