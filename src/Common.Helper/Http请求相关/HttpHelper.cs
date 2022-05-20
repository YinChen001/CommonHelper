using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class HttpHelper
    {
        static readonly HttpClient client = new();

        #region 模拟GET
        /// <summary>
        /// 一般的GET请求
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <returns></returns>
        public static async Task<string> HttpGetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        #endregion

        #region 模拟POST
        public static async Task<string> HttpPostAsync(string url, string jsonParas)
        {
            var content = new StringContent(jsonParas, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        /// <summary>
        /// Post请求并获取头部特定信息
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParas"></param>
        /// <returns></returns>
        public static async Task<Tuple<string, HttpResponseHeaders>> HttpPostToHeaderAsync(string url, string jsonParas)
        {
            var content = new StringContent(jsonParas, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            HttpResponseHeaders responseHeader = response.Headers;
            return new Tuple<string, HttpResponseHeaders>(responseBody, responseHeader);
        }
        #endregion

        #region 模拟PUT
        public static async Task<string> HttpPutAsync(string url, string jsonParas)
        {
            var content = new StringContent(jsonParas, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        #endregion
    }
}
