using System;
using System.Net.Http;
using System.Text;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static string Get()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromMinutes(5);
            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36");
            client.DefaultRequestHeaders.Connection.ParseAdd("keep-alive");
            var result = client.GetByteArrayAsync("http://www.nmgp.gov.cn").Result;
            var html = Encoding.UTF8.GetString(result);
            return html;
        }
    }
}
