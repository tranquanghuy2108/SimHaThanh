using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Helper
{
    public static class RestSharpHelper
    {
        public static Task<string> GetAsync(string url, string token)
        {
            try
            {
                string responseBody;
                var client = new RestClient(url);
                // Create a new RestSharp request
                var request = new RestRequest(url, Method.Get);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {token}");

                var response = client.Execute(request);

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static async Task<string> PostAsync<T>(string url, string token, T body, string version = "1.1")
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {token}");
                request.AddHeader("Connection", "keep-alive");
                request.AddBody(body);
                request.Timeout = Timeout.Infinite;
                var response = await client.ExecuteAsync(request);

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
