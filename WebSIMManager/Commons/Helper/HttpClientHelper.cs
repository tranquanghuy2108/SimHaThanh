using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using System.Net;

namespace Commons.Helper
{
    public static class HttpClientHelper
    {
        public static async Task<string> HtmlGet(string url, string token)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;
                string responseBody;

                request = new HttpRequestMessage(HttpMethod.Get, url);

                List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
                headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
                headers.Add(new NameValueHeaderValue("Authorization", $"Bearer {token}"));

                foreach (var header in headers)
                {
                    request.Headers.Add(header.Name, header.Value);
                }

                client.Timeout = Timeout.InfiniteTimeSpan;

                response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public static async Task<string> HtmlGet(string url, List<NameValueHeaderValue> headers)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;
                string responseBody;

                request = new HttpRequestMessage(HttpMethod.Get, url);

                //List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
                //headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
                //headers.Add(new NameValueHeaderValue("Authorization", $"Bearer {token}"));

                foreach (var header in headers)
                {
                    request.Headers.Add(header.Name, header.Value);
                }

                client.Timeout = Timeout.InfiniteTimeSpan;

                response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public static async Task<string> HttpPost<T>(string url, string token, T body)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;
                string responseBody;

                request = new HttpRequestMessage(HttpMethod.Post, url);
                var stringData = JsonConvert.SerializeObject(body);
                var stringContent = new StringContent(stringData, Encoding.UTF8, "application/json");
                request.Content = stringContent;

                List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
                headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
                headers.Add(new NameValueHeaderValue("Authorization", $"Bearer {token}"));

                foreach (var header in headers)
                {
                    request.Headers.Add(header.Name, header.Value);
                }

                client.Timeout = Timeout.InfiniteTimeSpan;

                using (response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                }

                return responseBody;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public static async Task<string> HttpPost<T>(string url, List<NameValueHeaderValue> headers, T body)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;
                string responseBody;

                request = new HttpRequestMessage(HttpMethod.Post, url);
                var stringData = JsonConvert.SerializeObject(body);
                var stringContent = new StringContent(stringData, Encoding.UTF8, "application/json");
                request.Content = stringContent;

                //List<NameValueHeaderValue> headers = new List<NameValueHeaderValue>();
                //headers.Add(new NameValueHeaderValue("Encoding", "utf-8"));
                //headers.Add(new NameValueHeaderValue("Authorization", $"Bearer {token}"));

                foreach (var header in headers)
                {
                    request.Headers.Add(header.Name, header.Value);
                }

                client.Timeout = Timeout.InfiniteTimeSpan;

                using (response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                }

                return responseBody;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public static async Task<string> HttpPut<T>(string url, List<NameValueHeaderValue> headers, T body)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;
                string responseBody;

                request = new HttpRequestMessage(HttpMethod.Put, url);
                var stringData = JsonConvert.SerializeObject(body);
                var stringContent = new StringContent(stringData, Encoding.UTF8, "application/json");
                request.Content = stringContent;

                foreach (var header in headers)
                {
                    request.Headers.Add(header.Name, header.Value);
                }

                client.Timeout = Timeout.InfiniteTimeSpan;

                using (response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                }

                return responseBody;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
