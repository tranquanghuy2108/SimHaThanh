using Commons.Helper;
using Commons.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Commons.CallAPIs
{
    public static class SendbirdAPI
    {
        public static async Task<MyGroupChannel> GetMyGroupChannelAsync(string app_id, string user_id, string api_token)
        {
            MyGroupChannel myGroupChannel = new();
            var url = "https://api-" + app_id + ".sendbird.com/v3/users/" + user_id + "/my_group_channels";
            List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
            headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
            headers.Add(new NameValueHeaderValue("Api-Token", api_token));
            string response = await HttpClientHelper.HtmlGet(url, headers);
            var dataOutput = JsonConvert.DeserializeObject<MyGroupChannel>(response);
            if (dataOutput != null)
            {
                myGroupChannel = dataOutput;
            }
            return myGroupChannel;
        }
        public static async Task<ListMessage> GetListMessageAsync(string app_id, string channel_url, string api_token)
        {
            ListMessage myGroupChannel = new();
            var url = "https://api-" + app_id + ".sendbird.com/v3/group_channels/" + channel_url + "/messages?message_ts=15";

            List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
            headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
            headers.Add(new NameValueHeaderValue("Api-Token", api_token));
            string response = await HttpClientHelper.HtmlGet(url, headers);
            var dataOutput = JsonConvert.DeserializeObject<ListMessage>(response);
            if (dataOutput != null)
            {
                myGroupChannel = dataOutput;
            }
            return myGroupChannel;
        }
        public static async Task<SendMesssageResponse> SendMessageAsync(string message, string app_id, string user_id, string channel_url, string api_token)
        {
            SendMesssageResponse mesageResponse = new();
            var url = "https://api-" + app_id + ".sendbird.com/v3/group_channels/" + channel_url + "/messages";
            List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
            headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
            headers.Add(new NameValueHeaderValue("Api-Token", api_token));
            //
            SendMesssageRequest requestBody = new SendMesssageRequest();
            requestBody.message_type = "MESG";
            requestBody.message = message;
            requestBody.custom_type = "vote";
            requestBody.user_id = user_id;
            requestBody.sorted_metaarray = new();
            requestBody.sorted_metaarray.Add(new SortedMetaarray()
            {
                key = "design",
                value = new() { "A", "B", "C" },
            });

            string response = await HttpClientHelper.HttpPost<SendMesssageRequest>(url, headers, requestBody);
            var dataOutput = JsonConvert.DeserializeObject<SendMesssageResponse>(response);
            if (dataOutput != null)
            {
                mesageResponse = dataOutput;
            }
            return mesageResponse;
        }

        public static async Task<string> MaskReadMessageAsync(string app_id, string api_token, string channel_url, string user_id)
        {
            MaskReadRequest request = new MaskReadRequest();
            request.user_id = user_id;
            var url = "https://api-" + app_id + ".sendbird.com/v3/group_channels/" + channel_url + "/messages/mark_as_read";

            List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
            headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
            headers.Add(new NameValueHeaderValue("Api-Token", api_token));
            string response = await HttpClientHelper.HttpPut<MaskReadRequest>(url, headers, request);

            return response;
        }
    }
}
