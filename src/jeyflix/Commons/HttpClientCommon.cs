using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Commons
{
    public static class HttpClientCommon
    {
        public static HttpClient client = new HttpClient();

        public static void SetBaseUrl(string ipOrhost, string port)
        {
            if (client.BaseAddress != null)
                return;

            if (string.IsNullOrEmpty(ipOrhost))
            { 
                throw new ArgumentNullException(nameof(ipOrhost), "Ip or host must be informed.");
            }

            if(string.IsNullOrEmpty(port) )
                client.BaseAddress = new Uri($"http://{ipOrhost}");
            else
                client.BaseAddress = new Uri($"http://{ipOrhost}:{port}");
        }
    }
}
