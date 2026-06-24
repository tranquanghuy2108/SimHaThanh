using Commons.Helper;
using Commons.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Commons.CallAPIs
{
    public static class TelegramAPI
    {
        // TODO: Replace the following with your gateway instance ID, Premium Account client ID and secret:
        private static string INSTANCE_ID = "149.154.167.50:443";
        private static string CLIENT_ID = "25847353";
        private static string CLIENT_SECRET = "a197f669002360e5c8b2777415b2e8dd";

        private static string API_URL = "https://api.whatsmate.net/v3/telegram/single/text/message/" + INSTANCE_ID;


        public static async Task<string> sendMessage(string number, string message)
        {
            try
            {
                List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
                headers.Add(new NameValueHeaderValue("X-WM-CLIENT-ID", CLIENT_ID));
                headers.Add(new NameValueHeaderValue("X-WM-CLIENT-SECRET", CLIENT_SECRET));

                Payload payloadObj = new Payload() { number = number, message = message };
                string response = await HttpClientHelper.HttpPost<Payload>(API_URL, headers, payloadObj);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public class Payload
        {
            public string number { get; set; }
            public string message { get; set; }
        }
    }
}
